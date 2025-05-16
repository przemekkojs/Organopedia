using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Organopedia3.Services;
using CommunityToolkit.Maui.Markup;

namespace Organopedia3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services.AddSingleton(LocalizationResourceManager.Instance);

            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .UseMauiCommunityToolkitMarkup()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
