using System.Linq;
using PokeApi.Models;

namespace PokeApi.Extensions
{
    public static class PokemonExtension
    {
        public static string GetPokemonTypes(this PokemonDetailModel pokemon)
        {
            if (pokemon == null || pokemon.Types == null || !pokemon.Types.Any())
                return "Sin tipos";

            var tipos = pokemon.Types
                .Where(t => t?.Type?.Name != null)
                .Select(t => Capitalizar(t.Type.Name))
                .ToList();

            if (tipos.Count == 1)
                return $"Tipo único: {tipos[0]}";
            else if (tipos.Count == 2)
                return $"Pokémon completo: {string.Join(", ", tipos)}";
            else
                return $"Tipos múltiples: {string.Join(", ", tipos)}"; // Por si en algún caso hay más de 2
        }

        private static string Capitalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
    }
}
