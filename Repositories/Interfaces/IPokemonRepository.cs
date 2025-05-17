using PokeApi.Models;

namespace PokeApi.Repositories.Interfaces;

public interface IPokemonRepository
{
    Task<List<PokemonModel>> GetAllPokemonsAsync(int page);
    Task<PokemonDetailModel> GetPokemonDetailAsync(string url);

    Task<PokemonDetailModel> GetPokemonDetailByUrlAsync(string url);




  

}
