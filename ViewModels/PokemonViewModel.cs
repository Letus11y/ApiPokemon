using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;
using PokeApi.Mappers;
using PokeApi.Extensions;

namespace PokeApi.ViewModels;

public partial class PokemonViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<PokemonModel> _pokemons;

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private PokemonDetailModel _pokemonDetail;

    [ObservableProperty]
    private string _pokemonTypes;

    private readonly IPokemonRepository _pokemonRepository;
    private readonly IPokemonRealmRepository _pokemonRealmRepository;

    public PokemonViewModel()
    {
        _pokemonRepository = Startup.GetService<IPokemonRepository>();
        _pokemonRealmRepository = Startup.GetService<IPokemonRealmRepository>();
    }

    [RelayCommand]
    public async Task LoadDataPokemons()
    {
        IsBusy = true;
        var pokemons = await _pokemonRepository.GetAllPokemonsAsync(1);
        Pokemons = new ObservableCollection<PokemonModel>(pokemons);
        await Task.Delay(500); // Pequeña pausa visual
        IsBusy = false;
    }

    [RelayCommand]
    public async Task NavigateToPokemonDetail(string url)
    {
        if (string.IsNullOrEmpty(url)) return;

        // Navegación hacia la página de detalles, pasando el parámetro por query
      await Shell.Current.GoToAsync($"PokemonDetailPage?url={Uri.EscapeDataString(url)}");
    }
}
