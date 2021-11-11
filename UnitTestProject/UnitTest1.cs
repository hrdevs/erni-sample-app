using Microsoft.VisualStudio.TestTools.UnitTesting;
using ernisampleapp;
using ernisampleapp.ViewModels;
using System.Threading.Tasks;
using ernisampleapp.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using ernisampleapp.Services;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserService userService = new UserService();

            ObservableCollection<UserModel> expectedUserList = new ObservableCollection<UserModel>();
            expectedUserList.Add(
                new UserModel 
                { 
                    id = "1", 
                    name = "John", 
                    imageUrl = "https://www.alchinlong.com/wp-content/uploads/2015/09/sample-profile.png" 
                }
            );
            expectedUserList.Add(
                new UserModel
                {
                    id = "1",
                    name = "John",
                    imageUrl = "https://www.alchinlong.com/wp-content/uploads/2015/09/sample-profile.png"
                }
            );
            expectedUserList.Add(
                new UserModel
                {
                    id = "2",
                    name = "Chris",
                    imageUrl = "https://www.alchinlong.com/wp-content/uploads/2015/09/sample-profile.png"
                }
            );
            expectedUserList.Add(
                new UserModel
                {
                    id = "3",
                    name = "Mark",
                    imageUrl = "https://www.alchinlong.com/wp-content/uploads/2015/09/sample-profile.png"
                }
            );
            
            ObservableCollection<UserModel> actualUserList = new ObservableCollection<UserModel>();
            actualUserList = userService.GetUsers().Result;
            
            foreach (var user in expectedUserList)
            {
                Console.WriteLine("Expected: " + user.name);
            }

            foreach (var user in actualUserList)
            {
                Console.WriteLine("Actual: " + user.name);
            }
        }
    }
}
