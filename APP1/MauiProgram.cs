using APP1.Services;
using APP1.ViewModel;
using APP1.Views;

namespace APP1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<IHttpsClientHandlerService, HttpsClientHandlerService>();
        builder.Services.AddSingleton<IRestService, RestService>();
        builder.Services.AddSingleton<ISignUpService, SignUpService>();

        builder.Services.AddSingleton<SignUpViewModel>();
        builder.Services.AddSingleton<SignUpPage>();
        
        builder.Services.AddSingleton<SignUpSMSVerifivationViewModel>();
        builder.Services.AddSingleton<SignUpSMSVerifivationPage>();

        builder.Services.AddSingleton<StateViewModel>();
        builder.Services.AddSingleton<StatePage>();

        builder.Services.AddSingleton<CityViewModel>();
        builder.Services.AddSingleton<CityPage>();


        return builder.Build();
	}
}
