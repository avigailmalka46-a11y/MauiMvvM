using MauiMvvM.ViewModels;

namespace MauiMvvM.Views;

public partial class AddUserPage1 : ContentPage
{
	public AddUserPage1(AddUserViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}