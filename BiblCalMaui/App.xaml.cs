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
		// Use NavigationPage with MainPage as root instead of AppShell
		var navigationPage = new NavigationPage(new MainPage())
		{
			Title = "Biblical Calendar Calculator"
		};
		
		var window = new Window(navigationPage);
		
		// Ensure light mode is applied to the window
		UserAppTheme = AppTheme.Light;
		
		return window;
	}
}