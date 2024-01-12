using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Question3.Services;
using Question3.ViewModels;

namespace Question3
{
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

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<User>();
            builder.Services.AddSingleton<UserViewModel>();
#endif
            builder.Services.AddSingleton<IUserServices, UserServices>();

            return builder.Build();
        }
    }
}
