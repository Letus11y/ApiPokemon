using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.ViewModels;

public partial class PokemonDetailViewModel : ObservableObject
{   
    
    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private PokemonDetailModel _pokemonDetails;

    private IPokemonRepository _pokemonRepository;

   public PokemonDetailViewModel()
{
    _pokemonRepository = Startup.GetService<IPokemonRepository>();
    PokemonDetails = new PokemonDetailModel(); // Aquí inicializas para evitar el warning
}


    [RelayCommand]
    public async Task LoadPokemonDetails(int pokemonId)
    {
        IsBusy = true;
        var details = await _pokemonRepository.GetPokemonDetailAsync(pokemonId);  // Método que agregamos para obtener detalles
        PokemonDetails = details;
        IsBusy = false;
    }
}

