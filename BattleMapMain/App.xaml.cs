﻿using BattleMapMain.Models;
using BattleMapMain.Services;
using BattleMapMain.Views;

namespace BattleMapMain
{
    public partial class App : Application
    {
        //Application level variables
        public User? LoggedInUser { get; set; }
        private BattleMapWebAPIProxy proxy;
        public bool NotInSession;
        public App(IServiceProvider serviceProvider, BattleMapWebAPIProxy proxy)
        {
            this.proxy = proxy;
            InitializeComponent();
            LoggedInUser = null;
            NotInSession = true;
            //Start with the Login View
            MainPage = new NavigationPage(serviceProvider.GetService<LoginView>());
        }     
    }
}