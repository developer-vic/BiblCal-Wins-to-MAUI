# BiblCal MAUI Project

This project is a **migration and modernization** of a Windows Forms application (BiblCal) to a cross-platform .NET MAUI application for macOS and iOS. The original application is a Biblical calendar calculator that performs complex astronomical and calendar calculations.

## Project Purpose

The BiblCal MAUI project migrates the original Windows Forms application to a modern, cross-platform solution using .NET MAUI. The migration follows a clean architecture approach, extracting all business logic into a platform-agnostic Core library while implementing a modern MAUI-based UI.

## Original Application (Windows)

The original application is located in the `BiblCal-master/` folder and was built as a Windows Forms application using:
- VB.NET (upgraded from VB6)
- Windows Forms UI
- Windows-specific libraries (System.Drawing, System.Media, Win32 APIs)
- UpgradeHelpers libraries for VB6 compatibility

### Key Features of Original Windows App:
1. **Holy Days Calculator** - Calculates Biblical holy days for a given year
2. **Local Moon Visibility** - Calculates visible new moons for any location
3. **Hebrew Calendar Functions** - Hebrew calendar date calculations
4. **Flood Calculations** - Biblical flood date analysis
5. **Golgotha Calculations** - Possible crucifixion date calculations
6. **Sunset/Times Calculations** - Astronomical time calculations
7. **Location Management** - Save and manage multiple locations with coordinates

## Migration Strategy

The migration follows a **clean architecture approach**:

### 1. Core Library Extraction (`BiblCalCore/`)
- **Purpose**: Extract all business logic and calculations from Windows-specific code
- **Target**: .NET Standard 2.1 (maximum compatibility)
- **Key Achievement**: Removed ALL Windows dependencies
- **Abstraction**: Created interfaces (`IOutputWriter`, `IUserDataProvider`) to decouple UI from business logic

### 2. MAUI Application (`BiblCalMaui/`)
- **Purpose**: Cross-platform UI using .NET MAUI
- **Target Platforms**: iOS and macOS (Mac Catalyst)
- **Architecture**: Uses the Core library, implements abstraction interfaces
- **Status**: Two main features fully converted (Local Moon Visibility, Holy Days)

## Project Structure

- **BiblCalCore/** - Shared class library containing non-UI business logic
  - Targets .NET Standard 2.1 for maximum compatibility
  - Contains ALL calculation functions from the original codebase
  - Uses abstraction interfaces to avoid platform-specific dependencies

- **BiblCalMaui/** - .NET MAUI application
  - Targets iOS and macOS (Mac Catalyst)
  - References the BiblCalCore library
  - Contains platform-specific UI implementations

## Implementation Status

### Phase 0: Core Library & Infrastructure ✅

1. **Complete Core Library**
   - Created `BiblCalCore` class library targeting .NET Standard 2.1
   - Migrated ALL modules from the original Windows application:
     - `BiblicalCalendarCalculator` - Core calendar functions
     - `HebrewCalendarFunctions` - Hebrew calendar calculations
     - `FloodCalculations` - Flood date calculations
     - `GolgothaCalculations` - Golgotha/Jordan/Creation calculations
     - `SunsetCalculations` - Sunset time calculations
     - `TimesCalculations` - Sun/Moon rise/set calculations
     - `Documentation` - Help text and documentation
     - `LocalMoonCalculations` - **NEW: Full local moon visibility calculations** (Milestone 1)
   - Removed all Windows-specific dependencies (Win32, System.Drawing, System.Media, Windows.Forms)

2. **Abstraction Interfaces**
   - `IOutputWriter` - Interface for output operations (replaces TPrint)
   - `IUserDataProvider` - Interface for user data operations (replaces file I/O)

3. **MAUI Application**
   - Updated to reference BiblCalCore library
   - Created MAUI implementations of abstraction interfaces
   - UI demonstrating Core library usage
   - Successfully builds for iOS and macOS (Mac Catalyst)

### Phase 0.5: Feature Conversions ✅

#### Local Moon Visibility Page ($350)
   **Work Completed:**
   - **Complete UI Implementation**
     - Location management system with add/edit/delete functionality
     - Location dropdown (CollectionView) with preset cities matching Windows app
     - Manual coordinate inputs (Latitude/Longitude with degrees, minutes, N/S/E/W directions)
     - GMT/UTC offset input field (supports negative offsets, e.g., -5 for Pittsburgh)
     - Year input field (defaults to current year)
     - Image button for calculation (using extracted Windows app icon)
     - Results display with formatted output matching Windows app exactly
     - Persistent location storage (XML-based)
     - Hint text: "To edit, add or delete a location (Press ENTER after the location name)"
   - **Full Calculation Logic**
     - Complete port of all astronomical calculations from Windows app
     - `LocalMoonCalculations` class with full implementation:
       - `FindFirstDay()` - New moon date calculations
       - `FiftyTwoFifty()` - Julian Day to Gregorian conversion (with recursive processing for "Not Visible" days)
       - `FiftyFourHundred()` - Moon visibility calculation loop
       - `PrintSunset()` - Sunset time calculations (with negative UTC offset support)
       - `FindPositionOfMoon()` - Moon position calculations (Formula 30)
       - `NauticalTwilightCalc()` - Twilight calculations
       - `FormatToString()` - Number formatting matching Windows app (removes trailing zeros)
       - `RoundToPrecision()` - Precision matching helper for VB.NET compatibility
     - **Precision Improvements**:
       - Intermediate rounding at each calculation step to match VB.NET behavior
       - Julian century (_jt) calculations with high precision (15 decimal places)
       - Moonset time normalization for negative UTC offsets
       - Visibility number calculation with step-by-step rounding
       - Workaround for visibility numbers near threshold (98-100 range)
     - **UTC/GMT Offset Support**:
       - Full support for negative UTC offsets (e.g., UTC -5 for Pittsburgh)
       - Correct time normalization and wrapping for negative offsets
       - Proper GMT offset display in result headers (shows negative sign correctly)
     - All calculations produce identical results to Windows app, with special handling for edge cases near visibility thresholds
   - **Output Format**
     - Exact header format: `" Date     Sunset Moonset   Illum. Sun's  [Moon's at Sunset]  Sun's    Visib   Visible?"`
     - Exact subheader format: `"(Evening)                    %    Azimuth Azimuth Altitude   Alt(M)   Number"`
     - Location format matches Windows app (includes GMT offset with correct sign)
     - Year formatting with CE/BCE suffix
     - Trailing zeros removed from decimal numbers (e.g., "89.14" instead of "89.140")
     - Proper column alignment and spacing
     - Font size: 14pt for better readability
   - **Icon Integration**
     - Extracted `cmdLocMon` icon from Windows app's resource file
     - Saved as `local_moon.png` in Resources/Images
     - Integrated into Calculate button (ImageButton)
   - **Navigation**
     - Accessible from AppShell navigation menu
     - Removed from MainPage (only available via navigation menu)
   - **Location Management**
     - Add new locations: Type location name and press ENTER
     - Edit existing locations: Select from dropdown, modify coordinates, press ENTER
     - Delete locations: Type existing location name and press ENTER, confirm deletion
     - Persistent storage: Locations saved to `UserData.xml` in app's local data folder
     - Default locations include: Jerusalem, Lennon MI, New York, Pittsburgh PA, Chicago, Houston, Los Angeles, Honolulu

#### Holy Days Page ($400)
   **Work Completed:**
   - Converted Windows Forms UI to MAUI XAML
   - Implemented Jerusalem/Local location mode switching
   - Location management system (same as Moon Visibility)
   - Year input with calculation buttons
   - EJW (East of Jerusalem/West of International Date Line) checkbox
   - Results display with formatted output
   - Full calculation logic port from Windows app
   - Multiple calculation modes (Holy Days, Months)
   - Complete UI/UX matching Windows app behavior

## Current State

### What Exists:
- ✅ Complete Core library with all calculations
- ✅ Local Moon Visibility page (fully functional)
- ✅ Holy Days page (fully functional)
- ✅ Basic navigation structure (AppShell with tabs)
- ✅ Location management system
- ✅ MAUI service implementations

### What's Missing for Phase 1:
- ❌ Home screen (landing page with navigation buttons)
- ❌ Proper navigation flow (Home → Feature screens → Back to Home)
- ❌ UI/UX polish for both feature screens
- ❌ Platform configuration (macOS/iOS app metadata, icons, etc.)
- ❌ Cross-platform testing and optimization

### Available Functionality

The implementation provides complete functionality:

- **Julian Day Number conversions** - Convert between Gregorian dates and Julian Day Numbers
- **Hebrew calendar calculations** - Calculate Hebrew calendar dates (1st of Tishri, year length, leap years)
- **Year calculations** - Calculate "Year After Creation" from Gregorian years
- **Flood calculations** - Calculate 150 days between specific dates for Flood analysis
- **Golgotha calculations** - Calculate possible dates for Jesus' crucifixion
- **Jordan Crossing calculations** - Calculate dates for Jordan crossing
- **Creation date calculations** - Calculate possible Creation dates
- **Sunset calculations** - Calculate sunset times for locations
- **Times calculations** - Calculate sunrise/sunset, moonrise/moonset, moon illumination
- **Local Moon Visibility** - **NEW (Milestone 1)**: Calculate visible new moons for any location with exact Windows app behavior
- **Documentation** - Complete help text for all modules

## Building and Running

### Prerequisites

- .NET 9.0 SDK
- For iOS: Xcode and iOS Simulator
- For macOS: Xcode and Mac development tools

### Build Commands

```bash
# Build Core library
dotnet build BiblCalCore/BiblCalCore.csproj

# Build for iOS
dotnet build BiblCalMaui/BiblCalMaui.csproj -f net9.0-ios

# Build for macOS (Mac Catalyst)
dotnet build BiblCalMaui/BiblCalMaui.csproj -f net9.0-maccatalyst
```

### Running

```bash
# Run on iOS Simulator
dotnet build BiblCalMaui/BiblCalMaui.csproj -f net9.0-ios
# Then run from Xcode or Visual Studio

# Run on macOS
dotnet build BiblCalMaui/BiblCalMaui.csproj -f net9.0-maccatalyst
# Then run from Xcode or Visual Studio
```

## How to Use BiblCalCore Library in Your .NET MAUI App

### Step 1: Add Project Reference

Add a reference to the BiblCalCore project in your MAUI app's `.csproj` file:

```xml
<ItemGroup>
  <ProjectReference Include="..\BiblCalCore\BiblCalCore.csproj" />
</ItemGroup>
```

### Step 2: Implement Required Interfaces

The library requires two interfaces. Create implementations in your MAUI app:

#### IOutputWriter Implementation

```csharp
using BiblCalCore;
using System.Text;

namespace YourApp.Services
{
    public class MauiOutputWriter : IOutputWriter
    {
        private readonly StringBuilder _output = new StringBuilder();

        public void Write(string text)
        {
            _output.Append(text);
        }

        public void WriteLine(string text)
        {
            _output.AppendLine(text);
        }

        public void Clear()
        {
            _output.Clear();
        }

        public string GetOutput()
        {
            return _output.ToString();
        }
    }
}
```

#### IUserDataProvider Implementation

```csharp
using BiblCalCore;

namespace YourApp.Services
{
    public class MauiUserDataProvider : IUserDataProvider
    {
        private string _currentLocation = "Jerusalem, Israel";

        public string GetCurrentLocation() => _currentLocation;
        public void SetCurrentLocation(string location) => _currentLocation = location;
        public int GetNumberOfLocations() => 1;
        public string GetLocationName(int index) => "Jerusalem";
        public double GetLocationLatitude(int index) => 31.78;
        public double GetLocationLongitude(int index) => -35.24;
        public string GetLocationGMTOffset(int index) => "2";
        public void SaveUserData() { /* Implement persistence if needed */ }
    }
}
```

### Step 3: Initialize and Use the Calculator

In your page or view model:

```csharp
using BiblCalCore;
using YourApp.Services;

public partial class YourPage : ContentPage
{
    private readonly BiblicalCalendarCalculator _calculator;
    private readonly MauiOutputWriter _outputWriter;
    private readonly FloodCalculations _floodCalculations;
    private readonly GolgothaCalculations _golgothaCalculations;

    public YourPage()
    {
        InitializeComponent();
        
        // Initialize services
        _outputWriter = new MauiOutputWriter();
        var userDataProvider = new MauiUserDataProvider();
        _calculator = new BiblicalCalendarCalculator(_outputWriter, userDataProvider);
        
        // Initialize calculation modules
        _floodCalculations = new FloodCalculations(_outputWriter, _calculator);
        _golgothaCalculations = new GolgothaCalculations(_outputWriter, _calculator);
        
        // Initialize Hebrew calendar (required once)
        HebrewCalendarFunctions.LoadHebrewVariables();
    }

    private void CalculateButton_Clicked(object sender, EventArgs e)
    {
        _outputWriter.Clear();
        
        // Set the year
        _calculator.GregorianYear = 2024;
        _calculator.InitializeVariables();

        // Calculate year after creation
        double yearAfterCreation = _calculator.CalculateYearAfterCreation(2024);
        string yearString = _calculator.FormatYearString(2024);

        _outputWriter.WriteLine($"Year: {yearString}");
        _outputWriter.WriteLine($"Year After Creation: {yearAfterCreation:F0}");

        // Calculate Hebrew calendar
        int year = 2024;
        double tishriJD = HebrewCalendarFunctions.JD1stOfTishri(year);
        int yearLength = HebrewCalendarFunctions.LengthOfYear(year);
        bool isLeapYear = HebrewCalendarFunctions.HebrewLeapYear(year + 3760);

        _outputWriter.WriteLine($"1st of Tishri Julian Day: {tishriJD:F2}");
        _outputWriter.WriteLine($"Year Length: {yearLength} days");
        _outputWriter.WriteLine($"Is Leap Year: {isLeapYear}");

        // Convert Julian Day to Gregorian
        var (month, day, gregYear) = _calculator.JulianToGregorian(tishriJD);
        _outputWriter.WriteLine($"1st of Tishri (Gregorian): {month}/{day}/{gregYear}");

        // Get results
        string results = _outputWriter.GetOutput();
        // Display results in your UI
    }
}
```

### Step 4: Available Functions

#### BiblicalCalendarCalculator
- `ConvertToJulian(month, day, year)` - Convert Gregorian to Julian Day Number
- `JulianToGregorian(jd)` - Convert Julian Day Number to Gregorian date
- `CalculateYearAfterCreation(year)` - Calculate year after creation
- `FormatYearString(year, includeSuffix)` - Format year with CE/BCE suffix
- `InitializeVariables()` - Initialize calculation variables

#### HebrewCalendarFunctions
- `LoadHebrewVariables()` - Initialize Hebrew calendar data (call once)
- `JD1stOfTishri(year)` - Get Julian Day for 1st of Tishri
- `LengthOfYear(year)` - Get Hebrew year length in days
- `HebrewLeapYear(hebrewYear)` - Check if Hebrew year is a leap year

#### FloodCalculations
- `CalculateFloodDates(startYear, endYear?)` - Calculate flood dates for year range

#### GolgothaCalculations
- `CalculateGolgothaDates(startYear, endYear?)` - Calculate possible crucifixion dates
- `CalculateJordanCrossingDates(startYear, endYear?)` - Calculate Jordan crossing dates
- `CalculateCreationDates(startYear, endYear?)` - Calculate possible Creation dates

#### SunsetCalculations
- `CalculateSunsets(year, longitude, latitude, gmtOffset)` - Calculate sunset times

#### TimesCalculations
- `CalculateTimes(year, longitude, latitude, gmtOffset, useBiblicalYear)` - Calculate sun/moon times

#### LocalMoonCalculations (Milestone 1)
- `CalculateLocalMoons(year, longitude, latitude, hr, locationName, originalGmtOffset)` - Calculate local moon visibility for a location
  - Full astronomical calculations matching Windows app exactly
  - Outputs sunset time, moonset time, illumination %, azimuths, altitudes, visibility number
  - Determines visibility status: "Not Visible", "Prob Not Visible", "Prob Visible", or "Visible"
  - Supports negative UTC/GMT offsets (e.g., UTC -5 for Pittsburgh)
  - Includes precision workarounds for visibility numbers near threshold (98-100 range)
  - Handles all dates in a month, including recursive processing for "Not Visible" days

#### Documentation
- `GetDocumentation(mode)` - Get help text for specific module

### Quick Example

```csharp
// Initialize (do this once)
var outputWriter = new MauiOutputWriter();
var userDataProvider = new MauiUserDataProvider();
var calculator = new BiblicalCalendarCalculator(outputWriter, userDataProvider);
HebrewCalendarFunctions.LoadHebrewVariables();

// Use
calculator.GregorianYear = 2024;
double jd = calculator.ConvertToJulian(1, 1, 2024);
var (month, day, year) = calculator.JulianToGregorian(jd);
double yearAfterCreation = calculator.CalculateYearAfterCreation(2024);
```

## Key Technical Challenges Overcome

1. **Precision Matching**: VB.NET and C# handle floating-point differently. Implemented intermediate rounding to match Windows app results exactly.

2. **Windows Dependencies**: Removed all Windows-specific code (Win32, System.Drawing, Windows.Forms) while preserving functionality.

3. **UI Framework Migration**: Converted Windows Forms to MAUI XAML while maintaining exact functionality and user experience.

4. **Location Management**: Implemented persistent storage system matching Windows app behavior.

5. **UTC/GMT Offset Handling**: Properly implemented negative UTC offsets (e.g., UTC -5 for Pittsburgh) with correct time normalization.

## Notes

- **Platform Agnostic**: The Core library works on iOS, Android, macOS, Windows, and any .NET platform
- **No Windows Dependencies**: All Windows-specific code has been removed
- **Thread Safety**: The calculator is not thread-safe; use on UI thread or add synchronization
- **Initialization**: Call `HebrewCalendarFunctions.LoadHebrewVariables()` once before using Hebrew calendar functions
- **Floating-Point Precision**: The library includes precision matching mechanisms to minimize differences between C# and VB.NET calculations. Intermediate rounding is applied at key calculation steps to match VB.NET behavior.
- **UTC/GMT Offsets**: Full support for both positive and negative UTC/GMT offsets. Negative offsets (e.g., UTC -5 for locations west of Greenwich) are properly handled with time normalization.
- **Visibility Calculations**: Special handling for visibility numbers near the 100 threshold to ensure correct classification matching Windows app behavior.
- The original codebase used `Microsoft.VisualBasic` and `UpgradeHelpers` libraries which are Windows-specific. These have been replaced with standard .NET equivalents.
- The Core library is designed to be platform-agnostic and can be used by any .NET platform that supports .NET Standard 2.1.
- The abstraction interfaces allow the Core library to remain independent of UI frameworks.

## Troubleshooting

**Build Error: "Cannot find BiblCalCore"**
- Verify the project reference path is correct
- Ensure BiblCalCore builds successfully: `dotnet build BiblCalCore/BiblCalCore.csproj`

**Runtime Error: "Interface not implemented"**
- Ensure you've implemented both `IOutputWriter` and `IUserDataProvider`
- Check that implementations are in the correct namespace

**Hebrew Calendar Functions Not Working**
- Ensure you've called `HebrewCalendarFunctions.LoadHebrewVariables()` before using Hebrew functions

## Technical Architecture

### Core Library (`BiblCalCore/`)
```
BiblCalCore/
├── BiblicalCalendarCalculator.cs    # Core calendar functions
├── HebrewCalendarFunctions.cs        # Hebrew calendar calculations
├── LocalMoonCalculations.cs         # Moon visibility calculations
├── HolyDaysCalculations.cs          # Holy days calculations
├── FloodCalculations.cs             # Flood date calculations
├── GolgothaCalculations.cs          # Crucifixion date calculations
├── SunsetCalculations.cs            # Sunset time calculations
├── TimesCalculations.cs             # Sun/Moon rise/set calculations
├── Documentation.cs                 # Help text
├── IOutputWriter.cs                 # Abstraction interface
└── IUserDataProvider.cs             # Abstraction interface
```

### MAUI Application (`BiblCalMaui/`)
```
BiblCalMaui/
├── Pages/
│   ├── LocalMoonVisibilityPage.xaml      # Moon visibility UI
│   ├── LocalMoonVisibilityPage.xaml.cs   # Moon visibility logic
│   ├── HolyDaysPage.xaml                 # Holy days UI
│   └── HolyDaysPage.xaml.cs              # Holy days logic
├── Services/
│   ├── MauiOutputWriter.cs               # Core interface implementation
│   └── MauiUserDataProvider.cs           # Core interface implementation
├── MainPage.xaml                         # Currently a test page (needs replacement)
├── AppShell.xaml                         # Navigation structure
└── Platforms/                            # Platform-specific configurations
    ├── iOS/
    ├── MacCatalyst/
    └── ...
```

## Original Codebase

The original BiblCal codebase is located in the `BiblCal-master/` folder and remains unchanged as requested. This MAUI implementation uses a copy/adaptation of the non-UI logic.

