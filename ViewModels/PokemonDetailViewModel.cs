using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;
using PokeApi.Extensions; // <-- Importante para usar la extensión
using System.Threading.Tasks;

namespace PokeApi.ViewModels
{
    // Recibe el parámetro "url" desde Shell
    [QueryProperty(nameof(Url), "url")]
    public partial class PokemonDetailViewModel : ObservableObject
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonDetailViewModel(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        // URL que llega como parámetro desde la navegación
        [ObservableProperty]
        private string url;

        // Modelo con los detalles del Pokémon
        [ObservableProperty]
        private PokemonDetailModel pokemonDetail;

        // Propiedad que contendrá la descripción de los tipos
        [ObservableProperty]
        private string tiposDescripcion;

        // Método disparado automáticamente cuando cambia la URL
        partial void OnUrlChanged(string value)
        {
            _ = LoadPokemonDetailsAsync(value);
        }

        // Llama al repositorio con la URL completa para obtener los detalles
        private async Task LoadPokemonDetailsAsync(string fullUrl)
        {
            if (string.IsNullOrWhiteSpace(fullUrl))
                return;

            var detail = await _pokemonRepository.GetPokemonDetailByUrlAsync(fullUrl);
            if (detail is not null)
            {
                PokemonDetail = detail;
                TiposDescripcion = detail.GetPokemonTypes(); // Actualizamos la propiedad con la extensión
            }
        }

        [RelayCommand]
        public async Task ChangeTheme()
        {
            var currentTheme = Application.Current.RequestedTheme;
            if (currentTheme == AppTheme.Light)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }
    }
}
