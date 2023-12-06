namespace Alvarez_Examen2P.AlvarezViews;

public partial class AlvarezAboutPage : ContentPage
{
	public AlvarezAboutPage()
	{
		InitializeComponent();
	}
	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is AlvarezModels.AlvarezAbout about)
		{
			// Navigate to the specified URL in the system browser.
			await Launcher.Default.OpenAsync(about.MoreInfoUrl);
		}
	}
}