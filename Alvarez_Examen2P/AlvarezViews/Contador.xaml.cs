using Alvarez_Examen2P.AlvarezModels;

namespace Alvarez_Examen2P.AlvarezViews;

public partial class Contador : ContentPage
{
	private Contadores Alvarezcontadores = new Contadores();

	public Contador()
	{
		InitializeComponent();
	}

	private void Contar(object sender, EventArgs e)
	{
		// Obtén la cadena de entrada del Entry
		string input = inputEntry.Text;

		// Lógica de análisis
		Alvarezcontadores.Texto = input;
		Alvarezcontadores.ContadorNumeros = CountNumbers(input);
		Alvarezcontadores.ContadorLetras = CountLetters(input);
		Alvarezcontadores.ContadorVocales = CountVowels(input);
		Alvarezcontadores.ContadorMayusculas = CountUppercase(input);
		Alvarezcontadores.ContadorMinusculas = CountLowercase(input);
		Alvarezcontadores.TotalCount = input.Length;

		// Actualiza la etiqueta de resultados
		resultLabel.Text = $"Números: {Alvarezcontadores.ContadorNumeros}, " +
						   $"Letras: {Alvarezcontadores.ContadorLetras}, " +
						   $"Vocales: {Alvarezcontadores.ContadorVocales}, " +
						   $"Mayúsculas: {Alvarezcontadores.ContadorMayusculas}, " +
						   $"Minúsculas: {Alvarezcontadores.ContadorMinusculas}, " +
						   $"Total: {Alvarezcontadores.TotalCount}";
	}

	private void OnClearClicked(object sender, EventArgs e)
	{
		// Limpia la pantalla
		inputEntry.Text = string.Empty;
		resultLabel.Text = string.Empty;
	}
	private int CountNumbers(string input)
	{
		return input.Count(char.IsDigit);
	}

	private int CountLetters(string input)
	{
		return input.Count(char.IsLetter);
	}

	private int CountVowels(string input)
	{
		return input.Count(c => "aeiouAEIOU".Contains(c));
	}

	private int CountUppercase(string input)
	{
		return input.Count(char.IsUpper);
	}

	private int CountLowercase(string input)
	{
		return input.Count(char.IsLower);
	}
}

