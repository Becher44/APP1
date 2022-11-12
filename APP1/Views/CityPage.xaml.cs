using APP1.ViewModel;

namespace APP1.Views;

public partial class CityPage : ContentPage
{
	public CityPage(CityViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}