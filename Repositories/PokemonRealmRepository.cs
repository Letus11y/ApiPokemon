using System;
using PokeApi.Entities;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.Repositories;

public class PokemonRealmRepository : IPokemonRealmRepository
{
    private readonly IContextDataBase _contextRealm;

    public PokemonRealmRepository()
    {
        _contextRealm = Startup.ServicesProvider.GetService<IContextDataBase>();
    }

    public void SavePokemon(PokemonEntity item)
    {
        var reaml = _contextRealm.GetRealm();
        reaml.Write(()=>
        {
            reaml.Add(item);
        });
    }

    public IQueryable<PokemonEntity> GetAllObjects()
    {
        var reaml = _contextRealm.GetRealm();
        return reaml.All<PokemonEntity>();
    }
}
