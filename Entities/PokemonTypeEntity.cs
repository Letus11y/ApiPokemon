using Realms;

namespace PokeApi.Entities;

public class PokemonTypeEntity : RealmObject
{
    [MapTo("slot")]
    public int Slot { get; set; }

    [MapTo("type_name")]
    public string? TypeName { get; set; }
}
