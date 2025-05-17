using System.Text.Json.Serialization;

namespace PokeApi.Models
{
    public class PokemonDetailModel 
    {
     
        public int Id { get; set; }

        public string? Name { get; set; }

      
         public int Base_Experience { get; set; }

       
        public int Height { get; set; }

     
        public List<PokemonAbilityInfo>? Abilities { get; set; }

    
        public PokemonSpriteInfo? Sprites { get; set; }

        public List<PokemonType>? Types { get; set; } // Corregimos la referencia
    }

   

    // public class BasicInfo
    // {
     
    //     public string? Name { get; set; }

       
    //     public string? Url { get; set; }
    // }

   
     
       

   
}
