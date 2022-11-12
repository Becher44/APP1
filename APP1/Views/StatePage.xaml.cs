using APP1.ViewModel;

namespace APP1.Views;

public partial class StatePage : ContentPage
{
	public StatePage(StateViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}