using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ernisampleapp.Utils
{
    public class CheckConnectivity
    {
        public CheckConnectivity()
        {          
            // Register for connectivity changes            
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var access = e.NetworkAccess;

            if(access == NetworkAccess.None)
            {
                DisplayDisconnectedMsg();
            }
            else if(access == NetworkAccess.Internet)
            {
                DisplayReconnectedMsg();
            }
        }
        public bool CheckNetworkAccess()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.None)
            {
                return false;
            }

            return true;
        }

        public void DisplayReconnectedMsg()
        {
            Application.Current.MainPage.DisplayAlert("Connectivity", "You are reconnected to the internet.", "OK");
        }

        public void DisplayDisconnectedMsg()
        {
            Application.Current.MainPage.DisplayAlert("Connectivity", "You got disconnected from the internet.\nTurn on Wifi/Mobile data and restart the app.", "OK");
        }

        public void DisplayNoInternetMsg()
        {
            Application.Current.MainPage.DisplayAlert("Connectivity", "You are not connected in the internet.\nTurn on Wifi/Mobile data and restart the app.", "OK");
        }

        public void DisplayConnectedToInternetMsg()
        {
            Application.Current.MainPage.DisplayAlert("Connectivity", "You are connected in the internet.", "OK");
        }
    }
}
