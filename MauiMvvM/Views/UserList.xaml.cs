using MauiMvvM.ViewModels;

namespace MauiMvvM.Views;

public partial class UserList : ContentPage
{
    public UserList(UserListViewModel vm)

    { 

    
        InitializeComponent();
        BindingContext = vm;


    }

}