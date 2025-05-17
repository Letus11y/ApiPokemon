using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PokeApi.Repositories;
using PokeApi.Repositories.Interfaces;
using PokeApi.Services;
using PokeApi.Services.Interfaces;
using PokeApi.ViewModels;

namespace PokeApi;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
		    
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
			builder.Services.AddSingleton<IPokemonRepository, PokemonRepository>();
			builder.Services.AddSingleton<IPokemonRealmRepository, PokemonRealmRepository>();
			builder.Services.AddSingleton<IResponseService, ResponseService>();
			builder.Services.AddSingleton<IContextDataBase, ContexDataBase>();
			
			builder.Services.AddTransient<PokemonViewModel>();
			builder.Services.AddTransient<PokemonLocalViewModel>();
			builder.Services.AddTransient<PokemonDetailViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif 
      var app = builder.Build();

		Startup.ServicesProvider = app.Services;
		return app; // Devuelves el app ya construido, no lo construyes dos veces

	}
}
