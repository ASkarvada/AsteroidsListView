﻿using AsteroidsListView.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AsteroidsListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
