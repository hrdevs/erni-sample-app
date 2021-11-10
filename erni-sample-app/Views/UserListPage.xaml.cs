using System;
using System.Collections.Generic;
using ernisampleapp.Models;
using ernisampleapp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ernisampleapp.Views
{
    public partial class UserListPage : ContentPage
    {
        UserListViewModel _vm = new UserListViewModel();
        public UserListPage()
        {
            InitializeComponent();
            BindingContext = _vm;

            //For iOS 11 and above
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var user = e.Item as UserModel;

            //Navigate to UserPage
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new UserPage(user.name, user.imageUrl));
        }
    }
}
