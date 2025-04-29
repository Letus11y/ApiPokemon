using System.Text.Json.Serialization;
using PokeApi.Models;

namespace PokeApi.Responses;

public class PokemonApiResponse
{ 

    [JsonPropertyName("results")]
        public List<PokemonModel>? Results { get; set ;}

}


