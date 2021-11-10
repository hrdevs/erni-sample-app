using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ernisampleapp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace ernisampleapp.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _getUsersAPI = "https://gist.githubusercontent.com/erni-ph-mobile-team/c5b401c4fad718da9038669250baff06/raw/7e390e8aa3f7da4c35b65b493fcbfea3da55eac9/test.json";
        //private List<UserModel> _userModels;
        private ObservableCollection<UserModel> _userList;

        public UserService()
        {
            _httpClient = new HttpClient();
            //_userModels = new List<UserModel>();
            _userList = new ObservableCollection<UserModel>();
        }

        //public async Task<List<UserModel>> GetUsers()
        //{
        //    var request = await _httpClient.GetAsync(_getUsersAPI);

        //    try
        //    {
        //        if (request.IsSuccessStatusCode)
        //        {
        //            Console.WriteLine("Get users successful");

        //            string response = await request.Content.ReadAsStringAsync();

        //            _userList = JsonConvert.DeserializeObject<List<UserModel>>(response.ToString());
        //        }
        //        else
        //        {
        //            Console.WriteLine("Get users failed");
        //            await Application.Current.MainPage.DisplayAlert("Get users", "Failed to get users.", "OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Get users exception");
        //        await Application.Current.MainPage.DisplayAlert("Get users exception", ex.Message, "OK");
        //    }

        //    return _userModels;
        //}


        public async Task<ObservableCollection<UserModel>> GetUsers()
        {
            var request = await _httpClient.GetAsync(_getUsersAPI);

            try
            {
                if (request.IsSuccessStatusCode)
                {
                    Console.WriteLine("Get users successful");

                    string response = await request.Content.ReadAsStringAsync();

                    _userList = JsonConvert.DeserializeObject<ObservableCollection<UserModel>>(response.ToString());
                }
                else
                {
                    Console.WriteLine("Get users failed");
                    await Application.Current.MainPage.DisplayAlert("Get users", "Failed to get users.", "OK");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Get users exception");
                await Application.Current.MainPage.DisplayAlert("Get users exception", ex.Message, "OK");
            }

            return _userList;
        }
    }
}
