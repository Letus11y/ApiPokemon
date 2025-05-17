using System;
using Realms;

namespace PokeApi.Repositories.Interfaces;

public interface IContextDataBase
{
    Realms.Realm GetRealm();

}
