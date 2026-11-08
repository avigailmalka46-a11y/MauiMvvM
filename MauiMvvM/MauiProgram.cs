using MauiMvvM.Servies;
using MauiMvvM.ViewModels;
using MauiMvvM.Views;
using Microsoft.Extensions.Logging;

namespace MauiMvvM
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.AddPages().AddVmPages().AddServices();
            return builder.Build();
        }

        public static MauiAppBuilder AddPages(this MauiAppBuilder builder) 
        {
            builder.Services.AddTransient<LoginPageView>();
            builder.Services.AddTransient<AddUserPage1>();
            builder.Services.AddTransient<UserList>();
            return builder;
        }

        public static MauiAppBuilder AddVmPages(this MauiAppBuilder builder) 
        {
            builder.Services.AddTransient<LoginPageViewModel>();
            builder.Services.AddTransient<AddUserViewModel>();
            builder.Services.AddTransient<UserListViewModel>();
            return builder;
        }

        public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDataService,DBdemo>();
            return builder;
        }

    }
}
