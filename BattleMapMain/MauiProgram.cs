﻿using BattleMapMain.Services;
using BattleMapMain.ViewModels;
using BattleMapMain.Views;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;

namespace BattleMapMain
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
                })
                .RegisterDataServices()
                .RegisterPages()
                .RegisterViewModels();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<RegisterView>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<GameStartView>();
            builder.Services.AddTransient<ProfileView>();
            builder.Services.AddTransient<AddFriendView>();
            builder.Services.AddTransient<AllMonstersView>();
            builder.Services.AddTransient<BattleMapView>();
            builder.Services.AddTransient<CalculatorView>();
            builder.Services.AddTransient<CharacterSheetsView>();
            builder.Services.AddTransient<DieRollerView>();
            builder.Services.AddTransient<FriendListView>();
            builder.Services.AddTransient<FriendProfileView>();
            builder.Services.AddTransient<PasswordResetView>();
            builder.Services.AddTransient<PlacedMinisView>();
            builder.Services.AddTransient<SavedMonstersView>();
            builder.Services.AddTransient<SessionView>();
            builder.Services.AddTransient<StatBlockView>();
            builder.Services.AddTransient<UserMonstersView>();


            return builder;
        }

        public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<BattleMapWebAPIProxy>();
            return builder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<RegisterViewModel>();
            builder.Services.AddTransient<GameStartViewModel>();
            builder.Services.AddTransient<AppShellViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<AddFriendViewModel>();
            builder.Services.AddTransient<AllMonstersViewModel>();
            builder.Services.AddTransient<BattleMapViewModel>();
            builder.Services.AddTransient<CalculatorViewModel>();
            builder.Services.AddTransient<CharacterSheetsViewModel>();
            builder.Services.AddTransient<DieRollerViewModel>();
            builder.Services.AddTransient<FriendListViewModel>();
            builder.Services.AddTransient<FriendProfileViewModel>();
            builder.Services.AddTransient<PasswordResetViewModel>();
            builder.Services.AddTransient<PlacedMinisViewModel>();
            builder.Services.AddTransient<SavedMonstersViewModel>();
            builder.Services.AddTransient<SessionViewModel>();
            builder.Services.AddTransient<StatBlockViewModel>();
            builder.Services.AddTransient<UserMonstersViewModel>();


            return builder;
        }
    }
}
