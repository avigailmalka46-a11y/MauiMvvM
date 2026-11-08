using MauiMvvM.Servies;
using MauiMvvM.ViewModels;

namespace MauiMvvM.Views;

public partial class LoginPageView : ContentPage
{
    public LoginPageView(LoginPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;


        //BindingContext = new LoginPageViewModel();
    }
}