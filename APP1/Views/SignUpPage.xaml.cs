using APP1.Models;
using APP1.Services;
using APP1.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace APP1.Views;

public partial class SignUpPage : ContentPage
{

    public SignUpPage(SignUpViewModel vm )
	{
		InitializeComponent();

        BindingContext = vm;
        

    }



}