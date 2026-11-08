using MauiMvvM.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MauiMvvM.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        DBdemo db;
        private string name;
        public string password;
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

        private bool messageVisible;

        public bool MessageVisible
        {
            get { return messageVisible; }
            set
            {
                if (messageVisible != value)
                {
                    messageVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        private string messageError;

        public string MessageError
        {
            get { return messageError; }
            set
            {
                if (messageError != value)
                {
                    messageError = value;
                    OnPropertyChanged();
                }
            }
        }

        private Color messageColor;

        public Color MessageColor
        {
            get { return messageColor; }
            set
            {
                if (messageColor != value)
                {
                    messageColor = value;
                    OnPropertyChanged();
                }
            }
        }

        private void Login()
        {
            MessageVisible = true;
            if (db.Login(Name, Password) == true)
            {
                MessageError = "you are in";
                //errorLabel.Text = "you are in";
                //errorLabel.TextColor = Colors.Green;
                MessageColor = Colors.Green;
            }
            else
            {
                messageError = "login fail";
                //errorLabel.Text = "login fail";
                //errorLabel.TextColor = Colorsx.Red;
                messageColor = Colors.Red;

            }
        } 
        public ICommand  LoginCommand
        {
            get;
        }

        public LoginPageViewModel()
        {
            db  = new DBdemo();
            LoginCommand = new Command(Login);
        }
    }
}
