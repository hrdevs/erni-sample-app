using ernisampleapp.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ernisampleapp.Views
{
    public partial class UserPage : ContentPage
    {
        UserViewModel _vm = new UserViewModel();
        public UserPage(string name, string imageUrl)
        {
            InitializeComponent();
            BindingContext = _vm;

            //Bind values
            _vm.Name = name;
            _vm.ImageUrl = imageUrl;
        }

        private void GoBackBtn_Clicked(object sender, EventArgs e)
        {
            //Pop this page to return to UserList Page
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
