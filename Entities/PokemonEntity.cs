using MongoDB.Bson;
using Realms;

namespace PokeApi.Entities;

public class PokemonEntity : RealmObject
{
    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId? Id { get; set; }

    [MapTo("poke_id")]
    public int PokeId { get; set; }

    [MapTo("name")]
    public string? Name { get; set; }

    [MapTo("base_experience")]
    public int BaseExperience { get; set; }

    [MapTo("height")]
    public int Height { get; set; }

    [MapTo("sprites")]
    public PokemonSpriteEntity? Sprites { get; set; }

    [MapTo("abilities")]
    public IList<PokemonAbilityEntity> Abilities { get; } 

    [MapTo("types")]
    public IList<PokemonTypeEntity> Types { get; } 
}
