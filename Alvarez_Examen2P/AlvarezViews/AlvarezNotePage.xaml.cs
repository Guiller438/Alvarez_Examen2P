namespace Alvarez_Examen2P.AlvarezViews;

[QueryProperty(nameof(ItemId), nameof(ItemId))]

public partial class AlvarezNotePage : ContentPage
{

	//string _fileName = Path.Combine(FileSystem.AppDataDirectory, "GuillermoAlvarez.txt");
	public string ItemId
	{
		set { LoadNote(value); }
	}
	private void LoadNote(string fileName)
	{
		AlvarezModels.AlvarezNotas noteModel = new AlvarezModels.AlvarezNotas();
		noteModel.Filename = fileName;

		if (File.Exists(fileName))
		{
			noteModel.Date = File.GetCreationTime(fileName);
			noteModel.Text = File.ReadAllText(fileName);
		}

		BindingContext = noteModel;
	}

	public AlvarezNotePage()
	{
			InitializeComponent();

		string appDataPath = FileSystem.AppDataDirectory;
		string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

		LoadNote(Path.Combine(appDataPath, randomFileName));

	}

		private async void SaveButton_Clicked(object sender, EventArgs e)
		{
			if (BindingContext is AlvarezModels.AlvarezNotas note)
				File.WriteAllText(note.Filename, TextEditor.Text);

			await Shell.Current.GoToAsync("..");
		}

		private async void DeleteButton_Clicked(object sender, EventArgs e)
		{
			if (BindingContext is AlvarezModels.AlvarezNotas note)
			{
				// Delete the file.
				if (File.Exists(note.Filename))
					File.Delete(note.Filename);
			}

			await Shell.Current.GoToAsync("..");
	}

	


}