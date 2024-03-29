﻿using MeteoApp.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MeteoApp
{
    public partial class App : Application
    {
        private static LocationsDatabase database;

        public static LocationsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LocationsDatabase();
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new MeteoListPage())
            {
               // BarBackgroundColor = Color.LightGreen,
              //  BarTextColor = Color.White
            };
            MainPage = nav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
