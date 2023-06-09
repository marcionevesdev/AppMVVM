﻿using AppMVVM.Services;
using AppMVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AppMVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<CarService>();
		builder.Services.AddSingleton<CarListViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
