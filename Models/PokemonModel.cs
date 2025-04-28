using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class PokemonModel
    {
       
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]

         public string Url { get; set; }
    }
}