using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;
using PokeApi.Repositories.Interfaces;

namespace PokeApi.ViewModels;

public partial class PokemonLocalViewModel : ObservableObject
{
    [ObservableProperty]
     public ObservableCollection<PokemonModel> __pokemons;

     private IPokemonRealmRepository _pokemonRealmRepository;

     [RelayCommand]
     public async virtual Task LoadDataPokemons()
     {
        var list = _pokemonRealmRepository.GetAllObjects();
        
     }

}
