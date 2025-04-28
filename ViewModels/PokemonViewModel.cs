using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.ViewModels;

public partial class PokemonViewModel : ObservableObject
{
    [ObservableProperty]
    
    public ObservableCollection<PokemonModel> _pokemons;

    [ObservableProperty]
    private bool _isBusy;

    private IPokemonRepository _pokemonRepository;

    public PokemonViewModel()
    {
        _pokemonRepository = Startup.GetService<IPokemonRepository>(); 
    }

    [RelayCommand]
    public async virtual Task LoadDataPokemons()
    {
        IsBusy = true;
        var pokemons = await _pokemonRepository.GetAllPokemonsAsync(1);
        Pokemons = new ObservableCollection<PokemonModel>(pokemons);
        await Task.Delay(TimeSpan.FromSeconds(3));
        IsBusy = false;
    }
}
