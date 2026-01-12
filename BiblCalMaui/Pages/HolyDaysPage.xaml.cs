using BiblCalCore;
using BiblCalMaui.Services;

namespace BiblCalMaui.Pages
{
    public partial class HolyDaysPage : ContentPage
    {
        private readonly BiblicalCalendarCalculator _calculator;
        private readonly HolyDaysCalculations _holyDaysCalc;
        private readonly MauiOutputWriter _outputWriter;
        private readonly MauiUserDataProvider _userDataProvider;

        public HolyDaysPage()
        {
            InitializeComponent();

            // Initialize services
            _outputWriter = new MauiOutputWriter();
            _userDataProvider = new MauiUserDataProvider();
            _calculator = new BiblicalCalendarCalculator(_outputWriter, _userDataProvider);
            _holyDaysCalc = new HolyDaysCalculations(_outputWriter, _calculator);

            // Set default year to current year
            YearEntry.Text = DateTime.Now.Year.ToString();

            // Set default EJW checkbox to unchecked
            EJWCheckBox.IsChecked = false;

            // Initialize results display
            ResultsLabel.Text = "Enter a year and click Calculate to see the Holy Days for that year.";
        }

        private void OnYearEntryCompleted(object? sender, EventArgs e)
        {
            OnCalculateHolyDaysClicked(CalculateHolyDaysButton, e);
        }

        private async void OnCalculateHolyDaysClicked(object? sender, EventArgs e)
        {
            ImageButton? calculateButton = sender as ImageButton;
            
            try
            {
                // Disable button during calculation
                if (calculateButton != null)
                {
                    calculateButton.IsEnabled = false;
                }
                if (CalculateMonthsButton != null)
                {
                    CalculateMonthsButton.IsEnabled = false;
                }

                _outputWriter.Clear();
                ResultsLabel.Text = "Calculating... This may take a few seconds.";

                // Allow UI to update
                await Task.Delay(50);

                // Parse year input
                if (!int.TryParse(YearEntry.Text, out int year))
                {
                    ResultsLabel.Text = "Please enter a valid year.";
                    if (calculateButton != null)
                    {
                        calculateButton.IsEnabled = true;
                    }
                    if (CalculateMonthsButton != null)
                    {
                        CalculateMonthsButton.IsEnabled = true;
                    }
                    return;
                }


                // Get EJW checkbox state
                string ejwString = EJWCheckBox.IsChecked ? "Y" : "";

                // Calculate holy days on background thread
                await Task.Run(() =>
                {
                    try
                    {
                        _holyDaysCalc.CalculateHolyDays(year, ejwString);
                    }
                    catch (Exception calcEx)
                    {
                        // Store error for display on UI thread
                        _outputWriter.Clear();
                        _outputWriter.WriteLine($"Calculation Error: {calcEx.Message}");
                        _outputWriter.WriteLine($"\nStack Trace:\n{calcEx.StackTrace}");
                        _outputWriter.WriteLine($"\nInner Exception: {calcEx.InnerException?.Message ?? "None"}");
                    }
                });

                // Display results on UI thread
                var output = _outputWriter.GetOutput();
                if (string.IsNullOrEmpty(output))
                {
                    ResultsLabel.Text = "No results generated.";
                }
                else
                {
                    ResultsLabel.Text = output;
                    ResultsLabel.InvalidateMeasure();
                }
            }
            catch (Exception ex)
            {
                ResultsLabel.Text = $"Error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
            }
            finally
            {
                // Re-enable buttons
                if (calculateButton != null)
                {
                    calculateButton.IsEnabled = true;
                }
                if (CalculateMonthsButton != null)
                {
                    CalculateMonthsButton.IsEnabled = true;
                }
            }
        }

        private async void OnCalculateMonthsClicked(object? sender, EventArgs e)
        {
            ImageButton? calculateButton = sender as ImageButton;
            
            try
            {
                // Disable button during calculation
                if (calculateButton != null)
                {
                    calculateButton.IsEnabled = false;
                }
                if (CalculateHolyDaysButton != null)
                {
                    CalculateHolyDaysButton.IsEnabled = false;
                }

                _outputWriter.Clear();
                ResultsLabel.Text = "Calculating New Moons... This may take a few seconds.";

                // Allow UI to update
                await Task.Delay(50);

                // Parse year input
                if (!int.TryParse(YearEntry.Text, out int year))
                {
                    ResultsLabel.Text = "Please enter a valid year.";
                    if (calculateButton != null)
                    {
                        calculateButton.IsEnabled = true;
                    }
                    if (CalculateHolyDaysButton != null)
                    {
                        CalculateHolyDaysButton.IsEnabled = true;
                    }
                    return;
                }


                // Get EJW checkbox state
                string ejwString = EJWCheckBox.IsChecked ? "Y" : "";

                // Calculate new moons on background thread
                await Task.Run(() =>
                {
                    try
                    {
                        _holyDaysCalc.CalculateNewMoons(year, ejwString);
                    }
                    catch (Exception calcEx)
                    {
                        // Store error for display on UI thread
                        _outputWriter.Clear();
                        _outputWriter.WriteLine($"Calculation Error: {calcEx.Message}");
                        _outputWriter.WriteLine($"\nStack Trace:\n{calcEx.StackTrace}");
                        _outputWriter.WriteLine($"\nInner Exception: {calcEx.InnerException?.Message ?? "None"}");
                    }
                });

                // Display results on UI thread
                var output = _outputWriter.GetOutput();
                if (string.IsNullOrEmpty(output))
                {
                    ResultsLabel.Text = "No results generated.";
                }
                else
                {
                    ResultsLabel.Text = output;
                    ResultsLabel.InvalidateMeasure();
                }
            }
            catch (Exception ex)
            {
                ResultsLabel.Text = $"Error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
            }
            finally
            {
                // Re-enable buttons
                if (calculateButton != null)
                {
                    calculateButton.IsEnabled = true;
                }
                if (CalculateHolyDaysButton != null)
                {
                    CalculateHolyDaysButton.IsEnabled = true;
                }
            }
        }

        private void OnEJWCheckBoxChanged(object? sender, CheckedChangedEventArgs e)
        {
            // Optionally recalculate when checkbox changes
            // For now, user needs to click Calculate button
        }
    }
}
