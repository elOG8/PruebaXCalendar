using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PruebaXCal.ViewModels;

namespace PruebaXCal;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
			builder
			.UseMauiCommunityToolkit()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddTransient<CalendarViewModel>();
		builder.Services.AddTransient<MainPage>();


		return builder.Build();
	}
}
