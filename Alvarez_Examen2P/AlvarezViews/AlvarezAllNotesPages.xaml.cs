namespace Alvarez_Examen2P.AlvarezViews;

public partial class AlvarezAllNotesPages : ContentPage
{
	public AlvarezAllNotesPages()
	{
		InitializeComponent();
		BindingContext = new AlvarezModels.AlvarezAllNotes();
	}
	protected override void OnAppearing()
	{
		((AlvarezModels.AlvarezAllNotes)BindingContext).LoadNotes();
	}

	private async void Add_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(AlvarezNotePage));
	}

	private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count != 0)
		{
			// Get the note model
			var note = (AlvarezModels.AlvarezNotas)e.CurrentSelection[0];

			// Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
			await Shell.Current.GoToAsync($"{nameof(AlvarezNotePage)}?{nameof(AlvarezNotePage.ItemId)}={note.Filename}");

			// Unselect the UI
			notesCollection.SelectedItem = null;
		}
	}
}