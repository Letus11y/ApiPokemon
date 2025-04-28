using System;

namespace PokeApi.Models;

public class PokemonDetailModel
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string? ImageUrl { get; set; }  // Para la imagen
    public List<string> Types { get; set; }  // Tipos como 'Fire', 'Water', etc.
    public List<string> Abilities { get; set; }  // Habilidades
    
}


