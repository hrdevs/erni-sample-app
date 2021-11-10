﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
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
            _userList = new ObservableCollection<UserModel>();
            _userService = new UserService();

            Task.Run(GetUsers);
        }

        private async Task GetUsers()
        {
            var userList = await _userService.GetUsers();

            UserList.Clear();

            foreach(var user in userList)
            {
                //don't add into list if it already exists
                if(!UserList.Any(p => p.id == user.id))
                {
                    UserList.Add(user);
                }
            }            
        }

        public ICommand GetUsersCommand { get; set; }
    }
}