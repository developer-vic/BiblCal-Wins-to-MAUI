namespace BiblCalMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnMoonVisibilityClicked(object? sender, EventArgs e)
	{
		var moonPage = new Pages.LocalMoonVisibilityPage();
		await Navigation.PushAsync(moonPage);
	}

	private async void OnHolyDaysClicked(object? sender, EventArgs e)
	{
		var holyDaysPage = new Pages.HolyDaysPage();
		await Navigation.PushAsync(holyDaysPage);
	}
}
