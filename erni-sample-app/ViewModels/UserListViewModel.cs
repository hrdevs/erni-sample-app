using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using erni_sample_app;
using ernisampleapp.Models;
using ernisampleapp.Services;
using ernisampleapp.ViewModel;
using Xamarin.Forms;

namespace ernisampleapp.ViewModels
{
    public class UserListViewModel : ViewModelBase
    {
        private readonly UserService _userService;

        //private List<UserModel> _userList;
        //public List<UserModel> UserList
        //{
        //    get { return _userList; }
        //    set { SetProperty(ref _userList, value); }
        //}

        private ObservableCollection<UserModel> _userList;
        public ObservableCollection<UserModel> UserList
        {
            get { return _userList; }
            set { SetProperty(ref _userList, value); }
        }

        public UserListViewModel()
        {
            _userService = new UserService();

            Task.Run(GetUsers);
        }

        public async Task GetUsers()
        {
            var userList = await _userService.GetUsers();

            UserList = userList;

            RemoveDuplicateUsers();
        }

        private void RemoveDuplicateUsers()
        {
            foreach (var user in UserList)
            {
                //remove a duplicate user by id
                if (UserList.Any(p => p.id == user.id))
                {
                    UserList.Remove(user);
                }
            }
        }
    }
}
