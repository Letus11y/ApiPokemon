using System.Text.Json.Serialization;
using PokeApi.Models;

namespace PokeApi.Responses;

public class PokemonApiResponse
{ 
    [JsonPropertyName("count")]
     public int Count;

    [JsonPropertyName("next")]
   public String? Next;

   [JsonPropertyName("previous")]
    public String? Previous;

    [JsonPropertyName("results")]
        public List<PokemonModel>? Results { get; set ;}

}


