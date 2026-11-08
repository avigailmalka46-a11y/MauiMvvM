using MauiMvvM.Models;
using MauiMvvM.Servies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MauiMvvM.ViewModels
{
     public class UserListViewModel : ViewModelBase
    {
        
            IDataService data;
            private string name;
            private string password;
            List<User> userslist;//רשימה של כל המשתמשים
            ObservableCollection<User> users;//לתצוגה
            private User user;

            private string displayUser;
            private string displayUser2;//
            public User User
            {
                get { return user; }
                set
                {
                    user = value;
                    OnPropertyChanged();
                    ShowUserData();
                }
            }
            private void ShowUserData()
            {
                DisplayUser = User.Name + " - " + User.Password;
            }
            public ObservableCollection<User> Users
            {
                get; set;
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
            public string DisplayUser
            {
                get { return displayUser; }
                set
                {
                    if (displayUser != value)
                    {
                        displayUser = value;
                        OnPropertyChanged();
                    }
                }
            }
            public string DisplayUser2
            {
                get { return displayUser2; }
                set
                {
                    if (displayUser2 != value)
                    {
                        displayUser2 = value;
                        OnPropertyChanged();
                    }
                }
            }
        private string messageList;

        public string MessageList
        {
            get { return messageList; }
            set
            {
                if (messageList != value)
                {
                    messageList = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ShowUserCommand
            {
                get;
            }
            //public ICommand DeleteUserCommand
            //{
            //    get;
            //}
            public ICommand ShowListCommand
            {
                get;
            }

            //not yet
            //public ICommand DeleteUserCommand => new Command<User>((item) =>
            //{
            //    if (item != null && Users.Contains(item))
            //    {
            //        Users.Remove(item); // המחקיפה מכאן מעדכנת את המסך אוטומטית
            //    }
            //});

            public UserListViewModel(IDataService db)
            {
                data = db;
                userslist = data.GetUsers();
                Users = new ObservableCollection<User>(userslist);
                User = Users[1];
                // User p;
                ShowUserCommand = new Command<User>(async p => ShowUser(p));
                // DeleteUserCommand= new Command<User>( p => ShowUser(p));
                // DeleteUserCommand = new Command<User>(async p => ShowUser(p));
                ShowListCommand = new Command(ShowList);
            }
        private void ShowList()
        {
            MessageList = data.GetAllUsers();
        }

        //ny
        private async Task ShowUser(User p)
            {
            //await Application.Current.Windows[0].Page.DisplayAlertAsync("user details:", p.Name + "-" + p.Password, "ok");
            // await Shell.Current.GoToAsync($"UserData?name={p.Name}&password={p.Password}");//neuto!!!
            //await Shell.Current.GoToAsync($"UserData?name={p.Name}&password={p.Password}");
            // await Shell.Current.DisplayAlertAsync("user details:", p.Name + "-" + p.Password, "OK");
            // await Shell.Current.GoToAsync("UserData");

            Dictionary<string, object> data2 = new Dictionary<string, object>();
            data2.Add("user", p);
            await Shell.Current.GoToAsync("UserData", data2); // route!!!
            DisplayUser2 = p.Name + " - " + p.Password;
        }
    }
}
