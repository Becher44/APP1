using APP1.ViewModel;

namespace APP1.Views;

public partial class SignUpSMSVerifivationPage : ContentPage
{
	public SignUpSMSVerifivationPage(SignUpSMSVerifivationViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

    }
}