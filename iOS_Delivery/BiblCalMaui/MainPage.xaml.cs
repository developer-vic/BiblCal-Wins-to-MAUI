using BiblCalCore;
using BiblCalMaui.Services;

namespace BiblCalMaui;

public partial class MainPage : ContentPage
{
	private readonly BiblicalCalendarCalculator _calculator;
	private readonly MauiOutputWriter _outputWriter;

	public MainPage()
	{
		InitializeComponent();
		
		// Initialize services
		_outputWriter = new MauiOutputWriter();
		var userDataProvider = new MauiUserDataProvider();
		_calculator = new BiblicalCalendarCalculator(_outputWriter, userDataProvider);
		
		// Initialize Hebrew calendar variables
		HebrewCalendarFunctions.LoadHebrewVariables();
		
		// Set initial text to ensure Label is properly initialized
		ResultsLabel.Text = "Enter a year and click Calculate to see results.\n\nTip: Enter 'test' to run library tests.";
	}

	private async void OnCalculateClicked(object? sender, EventArgs e)
	{
		try
		{
			// Clear previous results
			_outputWriter.Clear();
			ResultsLabel.Text = "Calculating...";
			
			// Force UI update
			await Task.Delay(10);
			
			// Check for test command
			if (YearEntry.Text?.ToLower() == "test")
			{
				var testResults = BiblCalCore.BiblCalCoreTests.RunBasicTests();
				ResultsLabel.Text = testResults;
				return;
			}
			
			if (string.IsNullOrWhiteSpace(YearEntry.Text))
			{
				ResultsLabel.Text = "Please enter a year.\n\nTip: Enter 'test' to run library tests.";
				return;
			}

			if (!double.TryParse(YearEntry.Text, out double year))
			{
				ResultsLabel.Text = "Invalid year format. Please enter a number.\n\nTip: Enter 'test' to run library tests.";
				return;
			}

			_calculator.GregorianYear = year;
			_calculator.InitializeVariables();

			// Calculate year after creation
			double yearAfterCreation = _calculator.CalculateYearAfterCreation(year);
			string yearString = _calculator.FormatYearString(year);

			_outputWriter.WriteLine($"Year: {yearString}");
			_outputWriter.WriteLine($"Year After Creation: {yearAfterCreation:F0}");
			_outputWriter.WriteLine("");

			// Calculate Hebrew calendar for this year
			int intYear = (int)year;
			if (intYear != 0) // Avoid year zero
			{
				double tishriJD = HebrewCalendarFunctions.JD1stOfTishri(intYear);
				int yearLength = HebrewCalendarFunctions.LengthOfYear(intYear);
				bool isLeapYear = HebrewCalendarFunctions.HebrewLeapYear(intYear + 3760);

				_outputWriter.WriteLine("Hebrew Calendar Information:");
				_outputWriter.WriteLine($"1st of Tishri Julian Day: {tishriJD:F2}");
				_outputWriter.WriteLine($"Year Length: {yearLength} days");
				_outputWriter.WriteLine($"Is Leap Year: {isLeapYear}");
				_outputWriter.WriteLine("");

				// Convert Julian Day to Gregorian
				var (month, day, gregYear) = _calculator.JulianToGregorian(tishriJD);
				_outputWriter.WriteLine($"1st of Tishri (Gregorian): {month}/{day}/{gregYear}");
			}

			// Display results - force property change for macOS
			var output = _outputWriter.GetOutput();
			if (string.IsNullOrEmpty(output))
			{
				ResultsLabel.Text = "No results generated.";
			}
			else
			{
				// Explicitly set the text property to ensure UI updates on macOS
				ResultsLabel.Text = output;
				// Force layout update
				ResultsLabel.InvalidateMeasure();
			}
		}
		catch (Exception ex)
		{
			ResultsLabel.Text = $"Error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
		}
	}
}
