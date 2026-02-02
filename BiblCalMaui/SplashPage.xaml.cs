namespace BiblCalMaui;

public partial class SplashPage : ContentPage
{
	public SplashPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		// Brief splash display then switch to main app
		await Task.Delay(2000);
		if (Application.Current?.Windows?.FirstOrDefault() is Window window)
		{
			window.Page = new NavigationPage(new MainPage())
			{
				Title = "Bibli_Cal"
			};
		}
	}
}
