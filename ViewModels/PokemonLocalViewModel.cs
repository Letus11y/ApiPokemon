using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeApi.Models;

namespace PokeApi.ViewModels;

public partial class PokemonLocalViewModel : ObservableObject
{
    [ObservableProperty]
     public ObservableCollection<PokemonModel> __pokemons;

     [RelayCommand]
     public async virtual Task LoadDataPokemons()
     {
        
     }

}
