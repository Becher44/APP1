using APP1.Views;

namespace APP1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
        Routing.RegisterRoute(nameof(SignUpSMSVerifivationPage), typeof(SignUpSMSVerifivationPage));
        Routing.RegisterRoute(nameof(StatePage), typeof(StatePage));
        Routing.RegisterRoute(nameof(CityPage), typeof(CityPage));
    }
}
