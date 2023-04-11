
namespace MauiBlazorForegroundServiceTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();

#if ANDROID
        Android.Content.Intent intent = new Android.Content.Intent(Android.App.Application.Context,typeof(ForegroundServiceDemo));
        Android.App.Application.Context.StartForegroundService(intent);
#endif
	}
}
