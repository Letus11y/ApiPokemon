using PokeApi.Models;
using PokeApi.Repositories.Interfaces;
using PokeApi.Responses;
using PokeApi.Services.Interfaces;
using RestSharp;

namespace PokeApi.Repositories;

public class PokemonRepository : IPokemonRepository
{
  private readonly IResponseService _apiResponseService;

  public PokemonRepository()
  {
    _apiResponseService = Startup.GetService<IResponseService>();
  }

  public async Task<List<PokemonModel>> GetAllPokemonsAsync(int page)
  {
    var PokemonClient = _apiResponseService.GetClient<PokemonApiResponse>();

    // Calculamos el offset para paginación (page inicia desde 1)
    var offset = (page - 1) * 10;

    var response = await PokemonClient.GetAsync<PokemonApiResponse>(
  resource: $"pokemon?offset={offset}&limit=30");

    if (response != null)
    {
      return response.Results ?? new List<PokemonModel>();
    }
    else
    {
      throw new Exception("Error fetching Pokemon");
    }

  }
  public async Task<PokemonDetailModel> GetPokemonDetailAsync(string name)
  {
    var url = $"pokemon/{name.ToLower()}";
    return await _apiResponseService.GetClient<PokemonDetailModel>().GetAsync<PokemonDetailModel>(url);
  }
      public async Task<PokemonDetailModel> GetPokemonDetailByUrlAsync(string url)
{
    var client = new RestClient();
    var request = new RestRequest(url, Method.Get);
    var response = await client.ExecuteAsync<PokemonDetailModel>(request);

    return response.Data;
}



}
