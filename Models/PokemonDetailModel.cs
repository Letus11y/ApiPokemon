using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class PokemonDetailModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("abilities")]
        public List<AbilityInfo>? Abilities { get; set; }

        [JsonPropertyName("sprites")]
        public SpriteInfo? Sprites { get; set; }
    }

    public class AbilityInfo
    {
        [JsonPropertyName("ability")]
        public BasicInfo? Ability { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
    }

    public class BasicInfo
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class SpriteInfo
    {
        [JsonPropertyName("front_default")]
        public string? FrontDefault { get; set; }

        [JsonPropertyName("back_default")]
        public string? BackDefault { get; set; }

        [JsonPropertyName("front_shiny")]
        public string? FrontShiny { get; set; }

        [JsonPropertyName("back_shiny")]
        public string? BackShiny { get; set; }
    }
}
