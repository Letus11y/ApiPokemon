using System;
using PokeApi.Entities;

namespace PokeApi.Repositories.Interfaces;

public interface IPokemonRealmRepository
{
    void SavePokemon(PokemonEntity item);

    IQueryable<PokemonEntity> GetAllObjects();

}
