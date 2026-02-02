namespace BiblCalMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		// Force light mode on all platforms
		UserAppTheme = AppTheme.Light;
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		// Android uses native splash; iOS/Mac Catalyst show custom splash page then main
		ContentPage rootPage = DeviceInfo.Platform == DevicePlatform.Android
			? new MainPage()
			: new SplashPage();

		var navigationPage = new NavigationPage(rootPage)
		{
			Title = "Bibli_Cal"
		};

		var window = new Window(navigationPage);

		// Ensure light mode is applied to the window
		UserAppTheme = AppTheme.Light;

		return window;
	}
}