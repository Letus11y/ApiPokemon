﻿namespace PokeApi.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(PokemonDetailPage), typeof(PokemonDetailPage));
	
	}
}
