using System;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.Repositories;

public class ContexDataBase : IContextDataBase
{
    public Realms.Realm GetRealm()
    {
        return Realms.Realm.GetInstance();
    }

}
