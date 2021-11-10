using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ernisampleapp.Views
{
    public partial class UserPage : ContentPage
    {
        public UserPage(string name, string imageUrl)
        {
            InitializeComponent();

            Username.Text = name;

            UserImage.Source = new UriImageSource
            {
                Uri = new Uri(imageUrl)
            };
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
