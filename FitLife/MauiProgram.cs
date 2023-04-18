using FitLife.ViewModel;
using FitLife.Views;
using Microsoft.Extensions.Logging;

namespace FitLife;

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
        builder.Services.AddSingleton<IMap>(Map.Default);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<ExerciseViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<WorkoutViewModel>();
        builder.Services.AddSingleton<WorkoutPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
