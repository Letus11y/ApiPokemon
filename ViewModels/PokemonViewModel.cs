using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.ViewModels;

public partial class PokemonViewModel : ObservableObject
{
    // Propiedades para la lista de Pokémon y estado ocupado
    [ObservableProperty]
    public ObservableCollection<PokemonModel> _pokemons;

    [ObservableProperty]
    private bool _isBusy;
    [ObservableProperty]
private bool _isPopupVisible;


    // Propiedad para los detalles del Pokémon seleccionado
    [ObservableProperty]
    private PokemonDetailModel _pokemonDetail;

    // Repositorio de datos
    private readonly IPokemonRepository _pokemonRepository;

    // Constructor
    public PokemonViewModel()
    {
        // Se inicializa el repositorio desde el contenedor de dependencias
        _pokemonRepository = Startup.GetService<IPokemonRepository>();
    }

    // Comando para cargar la lista de Pokémon
    [RelayCommand]
    public async Task LoadDataPokemons()
    {
        IsBusy = true; // Mostrar el estado de carga
        var pokemons = await _pokemonRepository.GetAllPokemonsAsync(1); // Obtener los datos
        Pokemons = new ObservableCollection<PokemonModel>(pokemons); // Asignarlos a la colección observable
        await Task.Delay(TimeSpan.FromSeconds(3)); // Simulación de carga
        IsBusy = false; // Ocultar el estado de carga
    }

  [RelayCommand]
public async Task LoadPokemonDetails(string url)
{
    IsBusy = true; // Mostrar el estado de carga antes de iniciar la tarea

    // Obtener los detalles del Pokémon
    PokemonDetail = await _pokemonRepository.GetPokemonDetailAsync(url);
    await Task.Delay(TimeSpan.FromSeconds(10));
    IsBusy = false; // Ocultar el estado de carga
    IsPopupVisible = true; // Activar el popup con los detalles cargados
}


}
