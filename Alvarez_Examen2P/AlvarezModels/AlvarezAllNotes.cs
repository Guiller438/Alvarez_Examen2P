using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvarez_Examen2P.AlvarezModels
{
	internal class AlvarezAllNotes
	{
		public ObservableCollection<AlvarezNotas> AlvarezNotes { get; set; } = new ObservableCollection<AlvarezNotas>();


		public AlvarezAllNotes() =>
			LoadNotes();

		public void LoadNotes()
		{
			AlvarezNotes.Clear();

			// Get the folder where the notes are stored.
			string appDataPath = FileSystem.AppDataDirectory;

			// Use Linq extensions to load the *.notes.txt files.
			IEnumerable<AlvarezNotas> notes = Directory

										// Select the file names from the directory
										.EnumerateFiles(appDataPath, "*.notes.txt")

										// Each file name is used to create a new Note
										.Select(filename => new AlvarezNotas()
										{
											Filename = filename,
											Text = File.ReadAllText(filename),
											Date = File.GetCreationTime(filename)
										})

										// With the final collection of notes, order them by date
										.OrderBy(note => note.Date);

			// Add each note into the ObservableCollection
			foreach (AlvarezNotas note in notes)
				AlvarezNotes.Add(note);
		}
			
	}
}
