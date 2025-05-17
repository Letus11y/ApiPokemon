using System;

namespace PokeApi.Models;

public class PokemonType
{
    
    
        public int Slot { get; set; }

   
        public TypeInfo Type { get; set; } // Ahora "type" apunta a "TypeInfo"
    

    public class TypeInfo
    {
        
        public string Name { get; set; }

        public string Url { get; set; }
    }

}
