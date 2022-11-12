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
    public partial class SignUpSMSVerifivationViewModel :ObservableObject
    {

        [RelayCommand]
        async Task GoToSatate ()
        {
            await Shell.Current.GoToAsync(nameof(StatePage));
        }

    }
}
