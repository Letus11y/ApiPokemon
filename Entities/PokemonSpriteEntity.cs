using Realms;

namespace PokeApi.Entities;

public class PokemonSpriteEntity : RealmObject
{
    [MapTo("front_default")]
    public string? FrontDefault { get; set; }

    [MapTo("back_default")]
    public string? BackDefault { get; set; }

    [MapTo("front_shiny")]
    public string? FrontShiny { get; set; }

    [MapTo("back_shiny")]
    public string? BackShiny { get; set; }
}
