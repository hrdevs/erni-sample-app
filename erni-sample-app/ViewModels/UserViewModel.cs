using ernisampleapp.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ernisampleapp.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get { return _imageUrl; }
            set { SetProperty(ref _imageUrl, value); }
        }
    }
}
