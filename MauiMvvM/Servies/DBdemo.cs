using MauiMvvM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MauiMvvM.Servies
{
    public class DBdemo:IDataService
    {
     //   List<Models.User> users = new List<Models.User>();
        List<User> users = new List<User>();

        public DBdemo()
        {
            users.Add(new Models.User{Name = "nehoray", Password = "admin"} );
            users.Add(new Models.User { Name = "shira", Password = "123456" });
            users.Add(new Models.User { Name = "avigail", Password = "654321" });


        }

        public void AddUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
         var user = users.FirstOrDefault(u => u.Name == username && u.Password == password);
            return user != null;
        }
    }
}
