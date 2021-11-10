using System;
using ernisampleapp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace erni_sample_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UserListPage();
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
