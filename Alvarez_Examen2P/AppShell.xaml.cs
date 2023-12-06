namespace Alvarez_Examen2P;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AlvarezViews.AlvarezNotePage), typeof(AlvarezViews.AlvarezNotePage));

	}
}
