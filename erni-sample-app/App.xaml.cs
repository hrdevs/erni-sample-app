using System;
using ernisampleapp.Utils;
using ernisampleapp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace erni_sample_app
{
    public partial class App : Application
    {
        public static CheckConnectivity checkConnectivity = new CheckConnectivity();
        public App()
        {
            InitializeComponent();

            MainPage = new UserListPage();
        }

        protected override void OnStart()
        {
            if(!checkConnectivity.CheckNetworkAccess())
            {
                checkConnectivity.DisplayNoInternetMsg();
            }
            else
            {
                checkConnectivity.DisplayConnectedToInternetMsg();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
