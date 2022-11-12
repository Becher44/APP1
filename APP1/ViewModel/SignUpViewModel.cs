using APP1.Models;
using APP1.Services;
using APP1.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1.ViewModel
{
    public partial class SignUpViewModel : ObservableObject
    {

        ISignUpService _SignUpService;
        ToSignUp _toSignUpItem;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        string mobile;

        [ObservableProperty]
        string address;

        public SignUpViewModel(ISignUpService service)
        {
            _SignUpService = service;
        }

        [RelayCommand]
        async Task Add()
        {
            
            ToSignUp toSignUp = new ToSignUp();
            toSignUp.Address = Address;
            toSignUp.Mobile = Mobile;
            toSignUp.Name = Name;

            //await _SignUpService.SaveTaskAsync(toSignUp);


            await Shell.Current.GoToAsync(nameof( SignUpSMSVerifivationPage));
        }

        //    async void OnSaveButtonClicked(object sender, EventArgs e)
        //{
        //    await _SignUpService.SaveTaskAsync(TodoItem);
        //    await Shell.Current.GoToAsync("..");
        //}


    }
}
