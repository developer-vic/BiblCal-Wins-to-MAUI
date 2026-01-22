using BiblCalCore;
using BiblCalMaui.Services;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace BiblCalMaui.Pages
{
    public partial class HolyDaysPage : ContentPage
    {
        private readonly BiblicalCalendarCalculator _calculator;
        private readonly HolyDaysCalculations _holyDaysCalc;
        private readonly MauiOutputWriter _outputWriter;
        private readonly MauiUserDataProvider _userDataProvider;
        private readonly ObservableCollection<LocationItem> _locations;
        private bool _isSelectingFromDropdown = false;
        private string _lastLocationName = "";

        public class LocationItem
        {
            public string Name { get; set; } = string.Empty;
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string GMTOffset { get; set; } = "0";
        }

        public HolyDaysPage()
        {
            InitializeComponent();

            // Initialize services
            _outputWriter = new MauiOutputWriter();
            _userDataProvider = new MauiUserDataProvider();
            _calculator = new BiblicalCalendarCalculator(_outputWriter, _userDataProvider);
            _holyDaysCalc = new HolyDaysCalculations(_outputWriter, _calculator);

            // Initialize locations
            _locations = new ObservableCollection<LocationItem>();
            LoadLocations();
            
            if (LocationDropdownList != null)
            {
                LocationDropdownList.ItemsSource = _locations;
            }

            // Set default picker selections
            LatDirPicker.SelectedIndex = 0; // Default to N
            LongDirPicker.SelectedIndex = 0; // Default to E

            // Set default year to current year
            YearEntry.Text = DateTime.Now.Year.ToString();

            // Set default EJW checkbox to unchecked
            EJWCheckBox.IsChecked = false;

            // Set default location to Jerusalem
            JerusalemRadioButton.IsChecked = true;
            CustomLocationGrid.IsVisible = false;

            // Initialize results display with copyright text (matches Windows app)
            ResultsLabel.Text = BiblCalCore.Documentation.GetDocumentation("HolyDays");
        }

        private void LoadLocations()
        {
            _locations.Clear();

            int numLocations = _userDataProvider.GetNumberOfLocations();
            for (int i = 0; i < numLocations; i++)
            {
                string name = _userDataProvider.GetLocationName(i);
                if (!string.IsNullOrEmpty(name))
                {
                    _locations.Add(new LocationItem
                    {
                        Name = name,
                        Latitude = _userDataProvider.GetLocationLatitude(i),
                        Longitude = _userDataProvider.GetLocationLongitude(i),
                        GMTOffset = _userDataProvider.GetLocationGMTOffset(i)
                    });
                }
            }
            
            if (LocationDropdownList != null && LocationDropdownList.ItemsSource != _locations)
            {
                LocationDropdownList.ItemsSource = _locations;
            }
        }

        private void OnYearEntryCompleted(object? sender, EventArgs e)
        {
            OnCalculateHolyDaysClicked(CalculateHolyDaysButton, e);
        }

        private void OnLocationRadioButtonChanged(object? sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                if (sender == JerusalemRadioButton)
                {
                    CustomLocationGrid.IsVisible = false;
                }
                else if (sender == CustomLocationRadioButton)
                {
                    CustomLocationGrid.IsVisible = true;
                    // Ensure pickers have default selections when grid becomes visible
                    if (LatDirPicker.SelectedIndex == -1)
                    {
                        LatDirPicker.SelectedIndex = 0; // Default to N
                    }
                    if (LongDirPicker.SelectedIndex == -1)
                    {
                        LongDirPicker.SelectedIndex = 0; // Default to E
                    }
                }
            }
        }

        private (int degrees, int minutes) ConvertToDegreesMinutes(double decimalDegrees)
        {
            int degrees = (int)Math.Floor(Math.Abs(decimalDegrees));
            double minutesDecimal = (Math.Abs(decimalDegrees) - degrees) * 60;
            int minutes = (int)Math.Round(minutesDecimal, MidpointRounding.AwayFromZero);
            return (degrees, minutes);
        }

        private double ConvertFromDegreesMinutes(int degrees, int minutes, string direction)
        {
            return Math.Abs(degrees) + (Math.Abs(minutes) / 60.0);
        }

        private void SetupLocation(LocationItem selectedLocation)
        {
            var (latDeg, latMin) = ConvertToDegreesMinutes(Math.Abs(selectedLocation.Latitude));
            var (longDeg, longMin) = ConvertToDegreesMinutes(Math.Abs(selectedLocation.Longitude));

            LatDegEntry.Text = latDeg.ToString();
            LatMinEntry.Text = latMin.ToString();
            LatDirPicker.SelectedIndex = selectedLocation.Latitude >= 0 ? 0 : 1; // 0 = N, 1 = S

            LongDegEntry.Text = longDeg.ToString();
            LongMinEntry.Text = longMin.ToString();
            LongDirPicker.SelectedIndex = selectedLocation.Longitude < 0 ? 0 : 1; // 0 = E, 1 = W

            GMTOffsetEntry.Text = selectedLocation.GMTOffset;
        }

        private void OnLocationEntryTextChanged(object? sender, TextChangedEventArgs e)
        {
            if (_isSelectingFromDropdown)
            {
                return;
            }

            if (e.NewTextValue != null && e.NewTextValue.Length > 40)
            {
                LocationEntry.Text = e.NewTextValue.Substring(0, 40);
            }
        }

        private void OnLocationEntryFocused(object? sender, FocusEventArgs e)
        {
            try
            {
                // Show dropdown with all locations when entry is focused
                if (LocationEntry != null && LocationDropdown != null && LocationDropdownList != null)
                {
                    // Ensure ItemsSource is set to show all locations
                    if (LocationDropdownList.ItemsSource == null)
                    {
                        LocationDropdownList.ItemsSource = _locations;
                    }
                    else if (LocationDropdownList.ItemsSource != _locations)
                    {
                        LocationDropdownList.ItemsSource = _locations;
                    }
                    
                    // Position dropdown to match entry width and align with it
                    if (LocationEntry != null && LocationDropdown != null)
                    {
                        // Use a small delay to ensure layout is complete
                        Task.Delay(50).ContinueWith(_ =>
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                try
                                {
                                    if (LocationEntry != null && LocationDropdown != null)
                                    {
                                        // Match the entry's width
                                        if (LocationEntry.Width > 0)
                                        {
                                            LocationDropdown.WidthRequest = LocationEntry.Width;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Silently handle errors
                                }
                            });
                        });
                    }
                    
                    // Show the dropdown
                    LocationDropdown.IsVisible = _locations.Count > 0;
                }
            }
            catch (Exception ex)
            {
                // Silently handle errors
            }
        }

        private void OnLocationEntryUnfocused(object? sender, FocusEventArgs e)
        {
            if (LocationEntry != null && LocationDropdown != null)
            {
                Task.Delay(200).ContinueWith(_ =>
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        if (LocationEntry != null && LocationDropdown != null && !LocationEntry.IsFocused)
                        {
                            LocationDropdown.IsVisible = false;
                        }
                    });
                });
            }
        }

        private void OnLocationDropdownItemSelected(object? sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (e.CurrentSelection != null && e.CurrentSelection.Count > 0 && e.CurrentSelection[0] is LocationItem selectedLocation)
                {
                    _isSelectingFromDropdown = true;
                    
                    if (LocationEntry != null)
                    {
                        LocationEntry.Text = selectedLocation.Name;
                    }
                    _lastLocationName = selectedLocation.Name;
                    
                    SetupLocation(selectedLocation);
                    
                    if (LocationDropdown != null)
                    {
                        LocationDropdown.IsVisible = false;
                    }
                    if (LocationEntry != null)
                    {
                        LocationEntry.Unfocus();
                    }
                    
                    _isSelectingFromDropdown = false;
                    
                    if (LocationDropdownList != null)
                    {
                        LocationDropdownList.SelectedItem = null;
                    }
                }
            }
            catch (Exception ex)
            {
                _isSelectingFromDropdown = false;
            }
        }

        private async void OnLocationEntryCompleted(object? sender, EventArgs e)
        {
            if (LocationDropdown != null)
            {
                LocationDropdown.IsVisible = false;
            }
            await AddEditDeleteLocation();
        }

        private async Task AddEditDeleteLocation()
        {
            string locationName = LocationEntry.Text?.Trim() ?? "";
            if (string.IsNullOrEmpty(locationName))
            {
                return;
            }

            if (locationName.Length > 40)
            {
                locationName = locationName.Substring(0, 40);
                LocationEntry.Text = locationName;
            }

            int index = _userDataProvider.FindLocationIndex(locationName);
            bool found = index >= 0;

            if (!found)
            {
                bool add = await DisplayAlert("Add Location", 
                    "Do you wish to add this location?\nSelecting [Yes] will add the location to the list.", 
                    "Yes", "No");
                
                if (add)
                {
                    try
                    {
                        if (!int.TryParse(LatDegEntry.Text, out int latDeg) ||
                            !int.TryParse(LatMinEntry.Text, out int latMin) ||
                            !int.TryParse(LongDegEntry.Text, out int longDeg) ||
                            !int.TryParse(LongMinEntry.Text, out int longMin))
                        {
                            await DisplayAlert("Error", "Please enter valid coordinates.", "OK");
                            return;
                        }

                        string latDir = LatDirPicker.SelectedItem?.ToString() ?? "N";
                        string longDir = LongDirPicker.SelectedItem?.ToString() ?? "E";

                        double lg = ConvertFromDegreesMinutes(longDeg, longMin, longDir);
                        double lt = ConvertFromDegreesMinutes(latDeg, latMin, latDir);

                        if (longDir == "E")
                        {
                            lg = -lg;
                        }
                        if (latDir == "S")
                        {
                            lt = -lt;
                        }

                        string gmtOffset = GMTOffsetEntry.Text?.Trim() ?? "0";

                        _userDataProvider.AddLocation(locationName, lt, lg, gmtOffset);
                        LoadLocations();
                        _lastLocationName = locationName;
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("Error", $"Failed to add location: {ex.Message}", "OK");
                    }
                }
            }
            else
            {
                bool edit = await DisplayAlert("Edit Location", 
                    "Do you wish to edit this location?\nSelecting [Yes] will update the location with the current coordinates.", 
                    "Yes", "No");
                
                if (edit)
                {
                    try
                    {
                        if (!int.TryParse(LatDegEntry.Text, out int latDeg) ||
                            !int.TryParse(LatMinEntry.Text, out int latMin) ||
                            !int.TryParse(LongDegEntry.Text, out int longDeg) ||
                            !int.TryParse(LongMinEntry.Text, out int longMin))
                        {
                            await DisplayAlert("Error", "Please enter valid coordinates.", "OK");
                            return;
                        }

                        string latDir = LatDirPicker.SelectedItem?.ToString() ?? "N";
                        string longDir = LongDirPicker.SelectedItem?.ToString() ?? "E";

                        double lg = ConvertFromDegreesMinutes(longDeg, longMin, longDir);
                        double lt = ConvertFromDegreesMinutes(latDeg, latMin, latDir);

                        if (longDir == "E")
                        {
                            lg = -lg;
                        }
                        if (latDir == "S")
                        {
                            lt = -lt;
                        }

                        string gmtOffset = GMTOffsetEntry.Text?.Trim() ?? "0";

                        _userDataProvider.UpdateLocation(index, locationName, lt, lg, gmtOffset);
                        LoadLocations();
                        _lastLocationName = locationName;
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("Error", $"Failed to update location: {ex.Message}", "OK");
                    }
                }
                else
                {
                    bool delete = await DisplayAlert("Delete Location", 
                        "Do you wish to delete this location?", 
                        "Yes", "No");
                    
                    if (delete)
                    {
                        try
                        {
                            _userDataProvider.DeleteLocation(index);
                            LoadLocations();
                            LocationEntry.Text = "";
                            _lastLocationName = "";
                        }
                        catch (Exception ex)
                        {
                            await DisplayAlert("Error", $"Failed to delete location: {ex.Message}", "OK");
                        }
                    }
                }
            }
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

                // Get location coordinates if custom location is selected
                double? latitude = null;
                double? longitude = null;
                double? utcOffset = null;
                string locationName = "";

                if (CustomLocationRadioButton.IsChecked == true)
                {
                    if (!int.TryParse(LatDegEntry.Text, out int latDeg) ||
                        !int.TryParse(LatMinEntry.Text, out int latMin) ||
                        !int.TryParse(LongDegEntry.Text, out int longDeg) ||
                        !int.TryParse(LongMinEntry.Text, out int longMin))
                    {
                        ResultsLabel.Text = "Please enter valid latitude and longitude coordinates.";
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

                    string latDir = LatDirPicker.SelectedItem?.ToString() ?? "N";
                    string longDir = LongDirPicker.SelectedItem?.ToString() ?? "E";

                    double lg = ConvertFromDegreesMinutes(longDeg, longMin, longDir);
                    double lt = ConvertFromDegreesMinutes(latDeg, latMin, latDir);

                    if (longDir == "E")
                    {
                        lg = -lg;
                    }
                    if (latDir == "S")
                    {
                        lt = -lt;
                    }

                    longitude = lg;
                    latitude = lt;

                    if (!double.TryParse(GMTOffsetEntry.Text, out double gmtOffset))
                    {
                        gmtOffset = 0;
                    }
                    utcOffset = gmtOffset;

                    locationName = LocationEntry.Text?.Trim() ?? "Custom Location";
                }

                // Calculate holy days on background thread
                await Task.Run(() =>
                {
                    try
                    {
                        _holyDaysCalc.CalculateHolyDays(year, ejwString, latitude, longitude, utcOffset, locationName);
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

                // Get location coordinates if custom location is selected
                double? latitude = null;
                double? longitude = null;
                double? utcOffset = null;
                string locationName = "";

                if (CustomLocationRadioButton.IsChecked == true)
                {
                    if (!int.TryParse(LatDegEntry.Text, out int latDeg) ||
                        !int.TryParse(LatMinEntry.Text, out int latMin) ||
                        !int.TryParse(LongDegEntry.Text, out int longDeg) ||
                        !int.TryParse(LongMinEntry.Text, out int longMin))
                    {
                        ResultsLabel.Text = "Please enter valid latitude and longitude coordinates.";
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

                    string latDir = LatDirPicker.SelectedItem?.ToString() ?? "N";
                    string longDir = LongDirPicker.SelectedItem?.ToString() ?? "E";

                    double lg = ConvertFromDegreesMinutes(longDeg, longMin, longDir);
                    double lt = ConvertFromDegreesMinutes(latDeg, latMin, latDir);

                    if (longDir == "E")
                    {
                        lg = -lg;
                    }
                    if (latDir == "S")
                    {
                        lt = -lt;
                    }

                    longitude = lg;
                    latitude = lt;

                    if (!double.TryParse(GMTOffsetEntry.Text, out double gmtOffset))
                    {
                        gmtOffset = 0;
                    }
                    utcOffset = gmtOffset;

                    locationName = LocationEntry.Text?.Trim() ?? "Custom Location";
                }

                // Calculate new moons on background thread
                await Task.Run(() =>
                {
                    try
                    {
                        _holyDaysCalc.CalculateNewMoons(year, ejwString, latitude, longitude, utcOffset, locationName);
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
