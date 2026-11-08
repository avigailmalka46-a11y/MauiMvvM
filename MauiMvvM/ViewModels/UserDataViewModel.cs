using MauiMvvM.Models;
using MauiMvvM.Servies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MauiMvvM.ViewModels
{
    public class UserDataViewModel:ViewModelBase
    {

        IDataService data;
        private string name;
        private string password;
    
        private User user;

       
        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
               
            }
        }
       
     
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public UserDataViewModel(IDataService db)
        {
            data = db;
        }
    }
}
