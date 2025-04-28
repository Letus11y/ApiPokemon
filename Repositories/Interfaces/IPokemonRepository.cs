using PokeApi.Models;

namespace PokeApi.Repositories.Interfaces;

public interface IPokemonRepository
{
    Task<List<PokemonModel>> GetAllPokemonsAsync(int page);
    Task<PokemonDetailModel> GetPokemonDetailAsync(int Id);

}
