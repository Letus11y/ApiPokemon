using Realms;

namespace PokeApi.Entities;

public class PokemonAbilityEntity : RealmObject
{
    [MapTo("ability_name")]
    public string? AbilityName { get; set; }

    [MapTo("is_hidden")]
    public bool IsHidden { get; set; }
}
