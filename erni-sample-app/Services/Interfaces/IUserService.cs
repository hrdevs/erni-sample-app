using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ernisampleapp.Models;

namespace ernisampleapp.Services
{
    internal interface IUserService
    {
        //Task<List<UserModel>> GetUsers();
        Task<ObservableCollection<UserModel>> GetUsers();
    }
}
