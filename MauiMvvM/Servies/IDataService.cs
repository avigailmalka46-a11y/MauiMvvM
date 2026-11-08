using System;
using System.Collections.Generic;
using System.Text;

namespace MauiMvvM.Servies
{
    public interface IDataService
    {
        public bool Login(string username, string password);

        public void AddUser(string username, string password);

        public List<Models.User> GetUsers();

        public string GetAllUsers();
    }
}
