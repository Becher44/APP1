using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class CityViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

    }
}
