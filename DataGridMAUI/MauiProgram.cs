using Syncfusion.Maui.Core.Hosting;

namespace DataGridMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Lobster-Regular.ttf", "LobsterRegular");
                fonts.AddFont("Satisfy-Regular.ttf", "SatisfyRegular");
            });
        builder.ConfigureSyncfusionCore();
        return builder.Build();
	}
}
