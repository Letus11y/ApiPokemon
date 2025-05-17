using PokeApi.ViewModels;

namespace PokeApi.Pages;

public partial class PokemonDetailPage : ContentPage
{
	 public PokemonDetailPage(PokemonDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}