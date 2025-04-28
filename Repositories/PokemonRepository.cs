using PokeApi.Models;
using PokeApi.Repositories.Interfaces;
using PokeApi.Responses;
using PokeApi.Services.Interfaces;

namespace PokeApi.Repositories;

public class PokemonRepository : IPokemonRepository
{
     private readonly IResponseService _apiResponseService ;

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
        resource: $"pokemon?offset={offset}&limit=10");

            if (response != null)
           {
             return response.Results ?? new List<PokemonModel>();
           }
          else
           {
             throw new Exception("Error fetching Pokemon");
           }

      }


      public async Task<PokemonDetailModel> GetPokemonDetailAsync(int Id)
{
    var PokemonClient = _apiResponseService.GetClient<PokemonDetailModel>();

    var response = await PokemonClient.GetAsync<PokemonModel>(
        resource: $"pokemon/{Id}");

    if (response != null)
    {
        return response;
    }
    else
    {
        throw new Exception("Error fetching Pokemon details");
    }
}



}
