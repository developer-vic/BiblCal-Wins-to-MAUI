using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Media;
using UpgradeHelpers.Gui;
using UpgradeHelpers.Helpers;
using System.Xml;
using System.Diagnostics;

namespace BiblCal
{
	internal static class modBiblcalFunctions
	{

		//This is the Heart of the program.
		//This calculates the Holy Days and the start of the months.
		//Also computes the local new moons so the user may see for himself how it works.
		 //Make sure all variables are declared
		public static double A = 0;
		public static double B = 0;
		public static double C = 0;
		public static double D = 0;
		public static double E = 0;
		public static double F = 0;
		public static double G = 0;
		public static double H = 0;
		public static double L = 0;
		public static double M = 0; //=Month number 1 is January 12 is December
		public static double S = 0;
		public static double W = 0;
		public static double A4 = 0;
		public static double A5 = 0;
		public static double A6 = 0;
		public static double A7 = 0;
		public static double A9 = 0;
		public static double B3 = 0;
		public static double B4 = 0;
		public static double B6 = 0;
		public static double B9 = 0;
		public static double C9 = 0;
		public static double D7 = 0;
		public static double D8 = 0;
		public static double D9 = 0;
		public static double E9 = 0;
		public static double W1 = 0;
		public static double W2 = 0;
		public static double HO = 0; //=Hour of Moonset
		public static double AZC = 0;
		public static double W3 = 0;
		public static double DNL = 0;
		public static double YearAfterCreation = 0; //= Year after creation
		public static double AD = 0;
		public static double AX = 0;
		public static double AJ = 0; //=Longitude hour adjustment for sunset.
		public static double AN = 0;
		public static double SD = 0;
		public static double HW = 0; //= Hour Angle
		public static double LG = 0; //= Longitude
		public static double EE = 0;
		public static double LT = 0; //= Latitude
		public static double CT = 0;
		public static double H1 = 0;
		public static double HZ = 0;
		public static double CS = 0;
		public static double B2 = 0;
		public static double TL = 0;
		public static double HR = 0; //= Hour location
		public static double DM = 0;
		public static double S5 = 0;
		public static double AZ = 0; //= Azimuth of Moon
		public static double EO = 0;
		public static double FM = 0;
		public static double SJ = 0;
		public static double S1 = 0;
		public static double JD = 0; //= Julian Day number
		public static double DS = 0; //= Declination of Sun
		public static double SA = 0;
		public static double SabbathYear = 0; //= Sabbath Year
		public static double LM = 0;
		public static double DT = 0;
		public static double TRA2 = 0;
		public static double TM = 0;
		public static double AZB = 0;
		public static float IL = 0; //= Illumination of moon
		public static double MA = 0;
		public static double LS = 0;
		public static double MJ = 0;
		public static double IM = 0;
		public static double ML = 0;
		public static double LO1 = 0;
		public static double LB1 = 0;
		public static double LT1 = 0;
		public static double D81 = 0;
		public static double B31 = 0;
		public static double S51 = 0;
		public static double MM1 = 0;
		public static double S11 = 0;
		public static double DI = 0;
		public static double MS = 0;
		public static double MM = 0;
		public static double Daye = 0;
		public static double ET = 0;
		public static double HS = 0;
		public static double HALP = 0;
		public static double HL = 0;
		public static double HT = 0;
		public static double HM = 0;
		public static double KT = 0;
		public static double SF = 0; //= Sabbath fraction
		public static double AZA = 0;
		public static double LB = 0;
		public static double GYear = 0; //= Gregorian Year for printing output
		public static double LO = 0; //= Sun's true geometric Longitude
		public static double LY = 0;
		public static double HA = 0;
		public static double LN = 0; //= Biblical Month number
		public static double JI = 0; //= Integer part of the JD
		public static double VisibilityNumber = 0; //= Visibility Number
		public static double JF = 0;
		public static double YU = 0;
		public static double JT = 0; //= Ephemeris time in centuries taken from 12 noon Jan 1, 1900 at Greenwich
		public static double HAL = 0; //= Altitude of Moon
		public static double SSAM = 0; //= Intermediate Sun's altitude at Moonset
		public static double L1 = 0;
		public static double MC = 0;
		public static double HAS = 0; //= Hour Angle of Sun
		public static double S4 = 0;
		public static double DMT = 0;
		public static double SAM = 0; //= Sun's Altitude at Moonset
		public static double HAD = 0;
		public static double HQ = 0; //= Minutes of Sunrise/set, Moonrise/set
		public static double DNO = 0;
		public static double RAS = 0; //= Right Ascention of Sun in radians
		public static double JubileeYear = 0; //= Jubilee Year
		public static double HP = 0;
		public static double TRA4 = 0;
		public static double E1 = 0;
		public static double HV = 0;
		public static double CAZS = 0;
		public static double AZS = 0;
		public static string JubileeYearString = ""; //= Jubilee year string
		public static string HTString = "";
		public static string DayString = ""; //= String for Gregorian day
		public static string HALString = "";
		public static string AZString = "";
		public static string HMString = "";
		public static string AZSString = ""; //= Azimuth string
		public static string HOString = "";
		public static string ILString = ""; //= Illumination string
		public static string HQString = ""; //= Moonrise/Set string
		public static string SAMString = ""; //= Suns altitude as Moonset string
		public static string VisibilityNumberString = ""; //= Visibility Number string
		public static string EJWString = ""; //= East of Jerusalem (Israel) and west of IDL Flag
		public static string CRLF = ""; //= String for Carriage Return Line Feed
		public static double GregorianYear = 0; //= Second Gregorian Year variable
		public static double DR = 0;
		public static double VS = 0; //= Visibility criteria 1 = prob not, 2 = prob, 3 = vis
		public static double AA = 0; //= Julian Days date
		public static double YRI = 0;
		public static double JDD = 0; //= Vernal Equinox
		public static double JDT = 0; //= Visual New Moon
		public static bool EarlyYear = false; //= Early Year Flag
		public static bool MonthsFlag = false; //= Used to check what to change when CHKEJW is checked.
		public static bool LocalCalcFlag = false; //= Used to determine if coordinates are local
		public static bool ChangeFlag = false; //= If true then location data needs to be saved.
		public static bool FloodFlag = false; //= Initialize for Flood Calculations
		public static bool PrintFlag = false; //= Disable output to the screen while doing Flood tables.
		public static float M0 = 0; //= Number of month to calculate
		public static string[] DayName = new string[]{"", "", "", "", "", "", ""}; //= Array for names of the days of the week
		public static string[] MonthName = ArraysHelper.InitializeArray<string>(13); //= Array for Gregorian month names
		public static string Instructions = ""; //= Holds Documentation
		public static double DateOfFirstMonth = 0; //= Julian date for start first month of year.
		public static bool SunsetFlag = false; //= Tells that 'Sunset' routine is active.
		public static string Mode = ""; //= Indicates the Mode the program is working in.
		public static double DA = 0; //= Gregorian Day
		public static double MH = 0; //= Gregorian Month
		public static string DAString = "";
		public static string MHString = "";
		public static string GregorianYearString = "";
		public static bool CheckGregYearChange = false; //= Indicates if a program MODE changed (Sunset/Times)
		public static int TempYear = 0;
		//************************************
		public static string CurrentLocation = ""; //= Current location name
		public static int NumberOfLocations = 0; //= Number of locations on list starts with 0
		public static string[] LocationName = ArraysHelper.InitializeArray<string>(501); //= Array for the location names
		public static double[] DegLat = new double[501]; //= Array for the location Latitudes
		public static double[] DegLon = new double[501]; //= Array for the location Longitudes
		public static string[] GMTOffset = ArraysHelper.InitializeArray<string>(501); //= Array for the location time offsets
		//Variables used by Times ***********************************
		public static double ZZ = 0;
		public static double IA = 0; //= Intermediate JD used internally while looping
		public static double J2 = 0;
		public static double RH = 0;
		public static double MZ = 0;
		public static double MR = 0;
		public static double TS = 0;
		public static double IB = 0; //= Current Julian Day Count
		public static double HOS = 0;
		public static double HQS = 0;
		public static double RJ = 0;
		public static double HMS = 0;
		public static double HTS = 0;
		//Variables used by frmConversions ******************************************************
		public static bool MayBeEarlyOrLate = false; //First month may be early or late (True = yes)
		public static double MonthNumber = 0; //Number of month
		public static bool ConversionFlag = false; //Indicates Conversions are active
		public static int StoreVS = 0; //Stores the visibility criteria number
		public static int StoreMonthNumber = 0; //Stores the month number for early or late (1 or 2)
		public static double CurrentDate = 0; //Stores the current date
		public static double SecondDate = 0; //Stores the possible second date
		public static double ThirdDate = 0; //Stores the possible third date
		public static double FourthDate = 0; //Stores the possible fourth date
		public static bool CriteriaFlag = false; //Indicates the Criteria Subroutine is running
		public static bool PrintCriteria = false; //Let's the TPrint subroutine know to print or not.
		public static bool ControlFlag = false; //Flag to indicate we wrote this program.
		public static double RabbinicJD = 0; //Actual Rabbinic Julian Day Count
		//Variables used by JulianToBiblical ****************************************************
		public static double BYear = 0; //Biblical Year
		public static int BMonth = 0; //Biblical Month
		public static int BDay = 0; //Biblical Day
		public static bool ThirteenthMonthFlag = false; //Indicates this is a 13th month and may be first month
		//of next year if harvest is early.
		public static bool MoonFlag = false;
		public static string TempMode = "";
		//*********************************************************************************************
		//              Here it is Bruce, a way to adjust the date of Jeshua's long day
		//              Just change the Julian Day number for it here in JDNJLD
		public const double JDNJLD = 1170111.5d; //= Julian Day number of Jeshua's long day
		//Public Const JDNJLD = 1172298.5        '= Alternate Day number if Jeshua's long day is 1 day sooner
		public const double JDNJLDBench = 1170111.5d; //= Benchmark in case JDNJLD is changed (was 1172299 Leave this alone!)
		public const double PI = 3.14159265358979d; //= Constant for PI
		public const double VEQ = 6.79189999999999E-02d; //= Constant for Spring Equinox calculation

		// References to Benchmarks for the Jubilee Calendar
		// http://www.danielrevelation.com/sda/reference/synch.html
		// http://www.wake-up.org/Charts/Jubileev7view.pdf
		// http://www.bibleplus.com/creation/datingcreation.htm
		public static string Copyright = "                                Copyright 1986-2021"; // Copyright year
		public static string Version = "Version " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMajorPart.ToString() + "." + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMinorPart.ToString() + "." + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FilePrivatePart.ToString();

		//This is the 'HolyDays' module
		internal static void CalcHolyDays()
		{
			double CurrentYear = 0;

			InitializeVariables();
			//******************************************************************************
			//       Start of Jubilee Calendar is 49 years before the First Jubilee year

			//FirstJubileeYear = 50          'If the cycle started at Creation 4004 BCE
			double FirstJubileeYear = 2544; //local variables to this Subroutine are //If the cycle started at the Jordan crossing 1510 BCE
			//FirstJubileeYear = 57          'Makes Jubilee years align!
			//FirstJubileeYear = 2557        'If Isaiah 37:30 is 699 BCE and Jordan Crossing is 1497 BCE
			double LastJubileeYear = 10000; //only available to this Subroutine //This is beyond the range of our program so not a problem
			//I left it in case there is a change of mind as to if there
			//is an end date for this calendar.
			//*******************************************************************************
			if (GregorianYear < 0)
			{ // set up the After Creation year
				YearAfterCreation = GregorianYear + 4005; //BCE is 4005
			}
			else
			{
				YearAfterCreation = GregorianYear + 4004; //CE is 4004
			}

			if (EJWString == "Y")
			{ //The use of the TPrint function allows for turning off printing
				TPrint("These Holy Day dates are corrected (delayed one day) for the" + CRLF + "region east of Israel and west of the International Date Line." + CRLF);
			}
			else
			{
				TPrint("These Holy Day dates are for Israel and regions westward to the International Date Line." + CRLF);
			}

			TPrint("This may be Year" + Conversion.Str(YearAfterCreation) + " After Creation. " + CRLF);
			//*******************************************************************************************
			// Start code for Jubilee calendar. (-3955 would be first Jubilee)

			//Only check for Jubilee occurances between the start and end date of calendar.
			if (YearAfterCreation >= (FirstJubileeYear - 48) && YearAfterCreation <= LastJubileeYear)
			{
				JubileeYear = (YearAfterCreation - FirstJubileeYear) / 50d; // find what Jubilee year it is, first starts with 0.
				SabbathYear = (Convert.ToInt32((YearAfterCreation - FirstJubileeYear - 49) - Math.Floor(JubileeYear))) % 7;
				if (JubileeYear - Math.Floor(JubileeYear) == 0)
				{ //Does it come out even?  Yes? then Jubilee
					JubileeYearString = Conversion.Str(JubileeYear + 1);
					TPrint("This may be the" + JubileeYearString);
					if (JubileeYear > 10 && JubileeYear < 20)
					{ //Print the suffix for the number.
						TPrint("th "); // Special case for numbers 11 through 19
					}
					else
					{
						int switchVar = Convert.ToInt32(Conversion.Val(JubileeYearString.Substring(Math.Max(JubileeYearString.Length - 1, 0))));
						if (switchVar == 0)
						{
							TPrint("th ");
						}
						else if (switchVar == 1)
						{ 
							TPrint("st ");
						}
						else if (switchVar == 2)
						{ 
							TPrint("nd ");
						}
						else if (switchVar == 3)
						{ 
							TPrint("rd ");
						}
						else if (switchVar > 3)
						{ 
							TPrint("th ");
						}
					}
					TPrint("Jubilee (Yobel) Year." + CRLF);
				}
				if (SabbathYear == 0 && JubileeYear - Math.Floor(JubileeYear) != 0)
				{
					TPrint("This may be a Sabbatical (Shemittah) Year." + CRLF);
				}
			}
			TPrint(CRLF);
			//End Code for Jubilee calendar**************************************************************

			LY = GregorianYear + 0.256d; //bga- selects which new moon to start testing for year, was 0.277, 0.273, 0.265
			if (LY >= 0)
			{
				LN = Math.Floor((LY - 1900) * 12.368277d);
			}
			if (LY < 0)
			{
				LN = Math.Floor((LY - 1899) * 12.368277d);
			}
			//Line 1760

			do 
			{ //######################## EarlyYear 'Do Loop' Starts ###############################
				FindFirstDay();
				//1762 'spring/vernal equinox calc -EQ. 20
				YRI = Math.Floor(GregorianYear); //Line 1764
				if (YRI < 0)
				{
					YRI++;
				} //Fix for year zero
				//Line 1766
				JDD = 1721139.2855d + 365.2421376d * YRI + VEQ * Math.Pow(YRI / 1000d, 2) - 0.0027879d * Math.Pow(YRI / 1000d, 3d);
				JDT = (AA - 1) + (HS + 0.25d) / 24d + HR / 24d; //Line 1768
				DMT = Math.Abs(JDD - JDT);
				if (DMT < 1)
				{
					JT = (JDD - 2415020) / 36525d;
					if (JDD < 1483746)
					{ //Line 1769
						JT -= 0.00000076d;
						FiftyFourHundred();
					}
					else
					{
						FiftyFourHundred();
					}
					JDD += 58 * Math.Sin(-LO); //Line 1770
					DMT = 0;
				}
				else
				{
					DMT = 0;
				}
				if (JDD > JDT)
				{ //Check for early or late year start.          'Line 1774
					MayBeEarlyOrLate = true; //Used by Sub BiblicalToJulian
					TPrint("If this Spring's barley harvest is/was early, this New Moon will begin the New Year. " + CRLF);
					EarlyYear = true; //Set EarlyYear flag true if it is an early year.
				}
				else
				{
					EarlyYear = false; //Set EarlyYear flag false if it is not an early year.
				}
				if (MonthNumber == 0)
				{
					MonthNumber = LN;
				} //Sub BiblicalToJulian Number of First month
				if (VS == 1)
				{
					TPrint("Abib 1, Passover sacrifice and Feast of Unleavened Bread are possibly one day earlier." + CRLF);
				}
				if (VS == 2)
				{
					TPrint("Abib 1, Passover sacrifice and Feast of Unleavened Bread are possibly one day later." + CRLF);
				}
				TPrint("Abib 1 is"); //Line 1830
				//AA is the Julian Day count
				PrintDayAndDate();
				TPrint("The Passover sacrifice is"); //Line 1850
				AA += 13;
				PrintDayAndDate();
				TPrint("The Feast of Unleavened Bread begins on"); //Line 1870
				AA++;
				PrintDayAndDate();
				TPrint("and ends on"); //Line 1890
				AA += 6;
				PrintDayAndDate();
				//------------------------- EJWString 'If Then' Statement Starts ----------------------
				if (EJWString == "Y")
				{ //Line 1905
					TPrint("The Wave Offering (the First-fruit) is Monday, ");
					D--; //Line 1955
					if (D < 0)
					{
						D = 6;
					}
					D = Convert.ToInt32(D); //Line 1957
					W = 7 - D;
					AA = AA + W - 6;
					PrintDate();
					TPrint("First-fruits (Pentecost) is Monday, "); //Line 1960
					AA += 50;
					PrintDate();

					if (D == 6 && VS == 2)
					{ //Line 1970
						TPrint("If Abib 1 is later then Wave Offering and Pentecost are one week later." + CRLF);
					}
					if (D == 0 && VS == 1)
					{ //Line 1975
						TPrint("If Abib 1 is earlier then Wave Offering and Pentecost are one week earlier." + CRLF);
					}
				}
				else
				{
					//Not correcting for EJW
					TPrint("The Wave Offering (the First-fruit) is Sunday, "); //Line 1910
					W = 7 - D; //Line 1920
					AA = AA + W - 7;
					PrintDate();
					TPrint("First-fruits (Pentecost) is Sunday, "); //Line 1925
					AA += 49;
					PrintDate();
					if (D == 6 && VS == 2)
					{ //Line 1935
						TPrint("If Abib 1 is later then Wave Offering and Pentecost are one week later." + CRLF);
					}
					if (D == 0 && VS == 1)
					{ //Line 1940
						TPrint("If Abib 1 is earlier then Wave Offering and Pentecost are one week earlier." + CRLF);
					}
				}
				//-------------------------- EJWString 'If Then' Statement ends ------------------------
				LN += 6; //LN is month number
				FindFirstDay(); //Gosub 5000
				if (VS == 1)
				{ //Line 2030
					TPrint("The following Holy Days could be one day earlier:" + CRLF);
				}
				if (VS == 2)
				{ //Line 2040
					TPrint("The following Holy Days could be one day later:" + CRLF);
				}
				TPrint("The Day of Trumpets is"); //Line 2090
				PrintDayAndDate();
				TPrint("The Day of Atonement is"); //Line 2110
				AA += 9; //Add nine days
				PrintDayAndDate();
				TPrint("The Feast of Booths (Ingathering) begins on"); //Line 2130
				AA += 5; //Add five days
				PrintDayAndDate();
				TPrint("and ends on"); //Line 2150
				AA += 6; //Add six days
				PrintDayAndDate();
				TPrint("The Last Great Day is"); //Line 2170
				AA++; //Add one day
				PrintDayAndDate();
				if (EarlyYear)
				{ //Line 2190
					TPrint(CRLF);
					TPrint("If this Spring's barley harvest is/was late, God's Holy Days are:" + CRLF);
					LN -= 5;
				}

			}
			while(EarlyYear); //Loops till the Early Year flag is False
			//########################### EarlyYear 'Do Loop' ends #################################
		}

		//Used by both cmdMonths and cmdLocMon to get Jerusalem and Local months
		internal static void CalcNewMoons()
		{
			string GMTOffset = "";


			DateOfFirstMonth = 0;
			InitializeVariables();
			TPrint(StringYear(GregorianYear) + " CALCULATED NEW MOONS");
			if (LocalCalcFlag)
			{
				TPrint(CRLF);
				PrintLocation();
			}
			else
			{
				TPrint("(Jerusalem)" + CRLF);
				if (EJWString == "Y")
				{
					TPrint("The Month Start dates are corrected (delayed one day)" + CRLF + "for the region east of Israel and west of the International Date Line." + CRLF);
				}
				else
				{
					TPrint("These dates are for Israel and regions westward to the International Date Line." + CRLF);
				}
			}
			LY = GregorianYear + 0.256d; //bga- selects which new moon to start testing for year, was 0.277, 0.273, 0.265
			if (LY >= 0)
			{
				LN = Math.Floor((LY - 1900) * 12.368277d);
			}
			else
			{
				LN = Math.Floor((LY - 1899) * 12.368277d);
			}
			while (M0 < 14)
			{
				FindFirstDay();
				//Records the first day of year for 'Sunset'routine.
				if (!LocalCalcFlag)
				{
					if (VS == 2)
					{
						TPrint("First Day of the Month is (possibly one day later)");
					}
					else
					{
						if (VS == 3)
						{
							TPrint("First Day of the Month is");
						}
						else
						{
							TPrint("First Day of the Month is (possibly one day earlier)");
						}
					}
					PrintDayAndDate();
				}
				TPrint(CRLF);
				LN++;
				M0++; //Do all months so it will get to 14 and end "While loop"
			}
			M0 = 0;
		}

		internal static void FindFirstDay()
		{ //Line 5000
			//Finds the first day of the month, on entry LN = the month number.

			TPrint(" Date     Sunset Moonset   Illum. Sun's  [Moon's at Sunset]  Sun's    Visib   Visible?" + CRLF);
			TPrint("(Evening)                    %    Azimuth Azimuth Altitude   Alt(M)   Number" + CRLF);
			CT = LN / 1236.85d;
			S = 166.56d + 132.87d * CT - 0.009173d * Math.Pow(CT, 2);
			S -= (Math.Floor(S / 360d)) * 360;
			//This section calculates the day to begin looking for the visible new moon
			JD = 2415020.75933d + 29.53058868d * LN + 0.0001178d * Math.Pow(CT, 2); //Line 5050
			JD = JD - 0.000000155d * Math.Pow(CT, 3) + 0.00033d * Math.Sin(S * DR);
			SA = 359.2242d + 29.10535608d * LN - 0.0000333d * Math.Pow(CT, 2) - 0.00000347d * Math.Pow(CT, 3);
			SA = (SA - (Math.Floor(SA / 360d)) * 360) * DR;
			MA = 306.0253d + 385.816918d * LN + 0.0107306d * Math.Pow(CT, 2) + 0.00001236d * Math.Pow(CT, 3);
			MA = (MA - (Math.Floor(MA / 360d)) * 360) * DR;
			ML = 21.2964d + 390.6705065d * LN - 0.0016528d * Math.Pow(CT, 2) - 0.00000239d * Math.Pow(CT, 3);
			ML = (ML - (Math.Floor(ML / 360d)) * 360) * DR;
			AD = (0.1734d - 0.000393d * CT) * Math.Sin(SA) + 0.0021d * Math.Sin(2 * SA) - 0.4068d * Math.Sin(MA);
			AD = AD + 0.0161d * Math.Sin(2 * MA) - 0.0004d * Math.Sin(3 * MA) + 0.0104d * Math.Sin(2 * ML);
			AD = AD - 0.0051d * Math.Sin(SA + MA) - 0.0074d * Math.Sin(SA - MA) + 0.0004d * Math.Sin(2 * ML + SA);
			AD = AD - 0.0004d * Math.Sin(2 * ML - SA) - 0.0006d * Math.Sin(2 * ML + MA);
			AD = AD + 0.001d * Math.Sin(2 * ML - MA) + 0.0005d * Math.Sin(SA + 2 * MA);
			JD += AD;
			if (JD < 1483746)
			{
				JD -= 0.02778d;
			}
			DT = (0.41d + 1.2053d * CT + 0.4992d * Math.Pow(CT, 2)) / 1440d;
			JI = JD - DT;
			JF = JI - Math.Floor(JI);
			JI = Math.Floor(JI);
			if (JF > 0.7d)
			{
				JI++;
			}
			FiftyTwoFifty();
		}

		private static void FiftyTwoFifty()
		{ //Line 5250, converts JDN to Calendar Date, AFC3-Chap 3
			H = Math.Floor((JI - 1867216.25d) / 36524.25d);
			H = JI + 1 + H - Math.Floor(H / 4d);
			B = H + 1524;
			C = Math.Floor((B - 122.1d) / 365.25d);
			G = Math.Floor(365.25d * C);
			E = Math.Floor((B - G) / 30.6001d);
			Daye = B - G - Math.Floor(30.6001d * E) + F;
			if (E < 13.5d)
			{
				M = E - 1;
			}
			else
			{
				M = E - 13;
			}
			if (M > 2.5d)
			{
				GYear = C - 4716;
			}
			else
			{
				GYear = C - 4715;
			}
			if (GYear < 1)
			{
				GYear--;
			}
			DayString = Conversion.Str(Daye);
			DayString = DayString.Substring(1);
			if (Strings.Len(DayString) < 2)
			{
				DayString = DayString + " ";
			}
			TPrint(DayString + " " + MonthName[Convert.ToInt32(M)]);
			//This section calculates the sunset time
			if (JI < 1483746)
			{
				JT = (JI + LG + 0.2222d + DT - 2415020) / 36525d;
			}
			else
			{
				JT = (JI + LG + 0.25d + DT - 2415020) / 36525d;
			}
			FiftyFourHundred();
		}

		internal static void FiftyFourHundred()
		{
			bool MoonsetFound = false; // Used to terminate Moonset Loop
			PrintSunset();
			if (DMT == 0)
			{ //Added to fix the premature return from 'PrintSunset'
				CAZS = -(Math.Sin(DS) / Math.Cos(LT));
				AZS = (-Math.Atan(CAZS / Math.Sqrt((-CAZS) * CAZS + 1)) + 1.570796326795d);
				AZS /= DR;
				AZSString = FormatToString(AZS, 5); //Azimuth of the sun

				//This if statement makes an adjustment for Hezekiah's long day, ref 2 Kings 20:10.

				if (JI < 1483746)
				{ // 5 Apr 651 BCE Was changed to 1458600 - 29 May 720 BCE                  Line 5610
					JT = (JI + HS / 24d + DT + LG - 2415020.0278d) / 36525d; //.0278 gives about 40 minutes.
				}
				else
				{
					JT = (JI + HS / 24d + DT + LG - 2415020) / 36525d;
				}

				//This section runs in a loop. First it calculates an approximate moonset time
				//based on the sunset time. Then it loops back to FiftySixSixty and calculates an
				//accurate moonset time using the approximate moonset time.
				do 
				{ //Keep looking for moonset.  Line 5660
					FindPositionOfMoon();
					if (MC != 0)
					{ //Line 6720
						MoonsetFound = true;
						HOString = Conversion.Str(HO); //Moonset hours string.
						HQString = Conversion.Str(HQ);
						HQString = HQString.Substring(1); //Moonset minutes string.
					}
					else
					{
						MoonsetFound = false;
						L1 = L;
						LO1 = LO;
						LB1 = LB;
						LT1 = LT;
						D81 = D8;
						B31 = B3;
						S51 = S5;
						MM1 = MM;
						S11 = S1;
						MC = HW / 24d;
						if (JI < 1483746)
						{ // 5 Apr 651 BCE Was changed to 1458600 - 29 May 720 BCE                  Line 5610
							JT = (JI + MC + DT + LG - 2415020.0278d) / 36525d; //.0278 is about 40 minutes
						}
						else
						{
							JT = (JI + MC + DT + LG - 2415020) / 36525d;
						}
					}
				}
				while(!MoonsetFound);

				if (HO > 9)
				{
					HOString = HOString.Substring(Math.Max(HOString.Length - 2, 0));
				} //Correct for extra space
				if (HQ < 10)
				{ //Print Moonset time       Line 6740 #0#0#0#0#0#0#0#0#0#0
					TPrint("  " + HOString + ":0" + HQString);
				}
				else
				{
					TPrint("  " + HOString + ":" + HQString);
				}
				TL = (HO * 60 + HQ) - (HT * 60 + HM);
				DI = Math.Cos(L1 - LO1) * Math.Cos(LB1);
				DI = -Math.Atan(DI / Math.Sqrt((-DI) * DI + 1)) + PI / 2d;
				IM = PI - DI - (0.1468d * ((1 - 0.0549d * Math.Sin(MM1)) / (1 - 0.0167d * Math.Sin(S11))) * DR) * Math.Sin(DI);
				IL = (float) ((1 + Math.Cos(IM)) / 2d);
				IL = (float) (Convert.ToInt32(IL * 10000) / 100d);
				ILString = FormatToString(IL, 4);
				TPrint("    " + ILString); //Print Illumination #0#0#0#0#0#0#0#0
				TPrint("  " + AZSString); //Print Sun's Azimuth #0#0#0#0#0#0#0#
				//Azimuth of sun *****************************
				HAD = (S51 + (HL + 12) * 1.002737908d - AJ - B31);
				HA = HAD / 3.8197186342055d;
				//converts Hour Angle (HW) back to radians ***********************************
				AZA = Math.Sin(HA);
				AZB = Math.Cos(HA) * Math.Sin(LT1) - Math.Tan(D81) * Math.Cos(LT1);
				AZ = Math.Atan(AZA / AZB);
				AZC = AZ / DR;
				HALP = Math.Sin(LT1) * Math.Sin(D81) + Math.Cos(LT1) * Math.Cos(D81) * Math.Cos(HA);
				HAL = (Math.Atan(HALP / Math.Sqrt((-HALP) * HALP + 1))) / DR;
				HAL = Math.Floor(HAL * 10000) / 10000d;
				HALString = FormatToString(HAL, 4); //Format (HAL) Altitude of moon for printing
				if (AZA > 0 && AZB < 0)
				{
					AZ += PI;
				}
				if (AZA < 0 && AZB < 0)
				{
					AZ += PI;
				}
				if (AZA < 0 && AZB > 0)
				{
					AZ += 2 * PI;
				}
				AZ /= DR;
				AZString = FormatToString(AZ, 5); //Format Moon's azimuth for printing
				//AZ = azimuth of moon; HAL = Altitude of moon ********************************
				//Print Moon's azimuth #0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#
				TPrint("  " + AZString); //Line 6828 Moon's azimuth
				//Print Altitude of Moon #0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#
				TPrint("   " + HALString); //Line 6835 Altitude of Moon
				NauticalTwilightCalc();
				VisibilityNumber = (TL + IL * 27 + HAL * 5.5d - SAM * 5) / 1.7d;
				VisibilityNumberString = FormatToString(VisibilityNumber, 5);
				//Print Visibility Number #0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#0#
				TPrint("    " + VisibilityNumberString); //Visibility number
				if (VisibilityNumber <= 88)
				{ //Line 6846
					JI++;
					MC = 0;
					TPrint("  Not Visible" + CRLF); //#0#0#0#0#0#0#0#0#0#0#0#0#0#
					FiftyTwoFifty(); // Find a day that is not 'not Visible'
					return;
				}
				if (VisibilityNumber > 88 && VisibilityNumber <= 100)
				{ //Line 6847
					VS = 1;
					AA = JI + 2;
					MC = 0;
					if (DateOfFirstMonth == 0)
					{
						DateOfFirstMonth = AA;
					} //Record start date of first month
					TPrint("  Prob Not Visible" + CRLF); //#0#0#0#0#0#0#0#0#0#0#0#0#0#
					if (!FloodFlag)
					{ //Don't want to find total visibility for 'Flood'
						JI++;
						if (Mode == "HolyDays" && !LocalCalcFlag)
						{ //Find total visible day and probability.
							FiftyTwoFifty();
							VS = 1;
							AA = JI + 1;
							MC = 0;
						}
						return;
					}
				}
				else
				{
					if (VisibilityNumber > 100 && VisibilityNumber <= 112)
					{ //Line 6848
						VS = 2;
						AA = JI + 1;
						MC = 0;
						if (DateOfFirstMonth == 0)
						{
							DateOfFirstMonth = AA;
						} //Record start date of first month
						TPrint("  Prob Visible" + CRLF); //#0#0#0#0#0#0#0#0#0#0#0#0#0#
						if (!FloodFlag)
						{ //Don't want to find total visibility for 'Flood'
							JI++;
							if (Mode == "HolyDays" && !LocalCalcFlag)
							{ //Find total visible day and probability.
								FiftyTwoFifty();
								VS = 2;
								AA = JI;
								MC = 0;
							}
							return;
						}
					}
					else
					{
						VS = 3; //Line 6849
						AA = JI + 1;
						MC = 0;
						TPrint("  Visible" + CRLF); //#0#0#0#0#0#0#0#0#0#0#0#0#0#
					}
				}
			}
			if (DateOfFirstMonth == 0)
			{
				DateOfFirstMonth = AA;
			} //Record start date of first month
		}

		private static void FindPositionOfMoon()
		{
			//Formula 30, Position of the Moon
			A4 = 51.2d + 20.2d * JT;
			A4 = (A4 - Math.Floor(A4 / 360d) * 360) * DR;
			A5 = 346.56d + 132.87d * JT - 0.0091731d * Math.Pow(JT, 2);
			A5 = (A5 - Math.Floor(A5 / 360d) * 360) * DR;
			A6 = 0.003964d * Math.Sin(A5);
			AX = 259.183275d - 1934.142d * JT + 0.002078d * Math.Pow(JT, 2) + 0.0000022d * Math.Pow(JT, 3);
			AN = (AX - Math.Floor(AX / 360d) * 360) * DR;
			A7 = AX + 275.05d - 2.3d * JT;
			A7 = (A7 - Math.Floor(A7 / 360d) * 360) * DR;
			MM = 296.104608d + 477198.8491d * JT + 0.009192d * Math.Pow(JT, 2);
			MM = MM + 0.0000144d * Math.Pow(JT, 3) + 0.000817d * Math.Sin(A4);
			MM = MM + A6 + 0.002541d * Math.Sin(AN);
			MM = (MM - Math.Floor(MM / 360d) * 360) * DR;
			LM = 270.434164d + 481267.8831d * JT - 0.001133d * Math.Pow(JT, 2) + 0.0000019d * Math.Pow(JT, 3);
			LM = LM + 0.000233d * Math.Sin(A4) + A6 + 0.001964d * Math.Sin(AN);
			LM = (LM - Math.Floor(LM / 360d) * 360);
			DNL = (-(17.2327d + 0.01737d * JT)) * Math.Sin(AN) - (1.2729d + 0.00013d * JT) * Math.Sin(2 * LS) + 0.2088d * Math.Sin(2 * AN) - 0.2037d * Math.Sin(2 * LM) + (0.1261d - 0.00031d * JT) * Math.Sin(MS) + 0.0675d * Math.Sin(MM);
			DNL = DNL - (0.0497d - 0.00012d * JT) * Math.Sin(2 * LS + MS) - 0.0342d * Math.Sin(2 * LM - AN) - 0.0261d * Math.Sin(2 * LM + MM) + 0.0214d * Math.Sin(2 * LS - MS) - 0.0149d * Math.Sin(2 * LS - 2 * LM + MM);
			DNL = DNL + 0.0124d * Math.Sin(2 * LS - AN) + 0.114d * Math.Sin(2 * LM - MM);
			DNO += 0.0183d * Math.Cos(2 * LM - AN);
			S1 = 358.475833d + 35999.0498d * JT - 0.00015d * Math.Pow(JT, 2) - 0.0000033d * Math.Pow(JT, 3);
			S1 -= 0.001778d * Math.Sin(A4);
			S1 = (S1 - Math.Floor(S1 / 360d) * 360) * DR;
			DM = 350.737486d + 445267.1142d * JT - 0.001436d * Math.Pow(JT, 2) + 0.0000019d * Math.Pow(JT, 3);
			DM = DM + 0.002011d * Math.Sin(A4) + A6 + 0.001964d * Math.Sin(AN);
			DM = (DM - Math.Floor(DM / 360d) * 360) * DR;
			FM = 11.250889d + 483202.0251d * JT - 0.003211d * Math.Pow(JT, 2) - 0.0000003d * Math.Pow(JT, 3);
			FM = FM + A6 - 0.024691d * Math.Sin(AN) - 0.004328d * Math.Sin(A7);
			FM = (FM - Math.Floor(FM / 360d) * 360) * DR;
			E1 = 1 - 0.002495d * JT - 0.00000752d * Math.Pow(JT, 2);
			L = LM + 6.28875d * Math.Sin(MM) + 1.274018d * Math.Sin(2 * DM - MM) + 0.658309d * Math.Sin(2 * DM);
			L = L + 0.213616d * Math.Sin(2 * MM) - (0.185596d * Math.Sin(S1)) * E1 - 0.114336d * Math.Sin(2 * FM);
			L = L + 0.058793d * Math.Sin(2 * DM - 2 * MM) + (0.057212d * Math.Sin(2 * DM - S1 - MM)) * E1;
			L = L + 0.05332d * Math.Sin(2 * DM + MM) + (0.045874d * Math.Sin(2 * DM - S1)) * E1;
			L = L + (0.041024d * Math.Sin(MM - S1)) * E1 - 0.034718d * Math.Sin(DM);
			L = L - E1 * 0.030465d * Math.Sin(S1 + MM) + 0.015326d * Math.Sin(2 * DM - 2 * FM);
			L = L - 0.012528d * Math.Sin(2 * FM + MM) - 0.01098d * Math.Sin(2 * FM - MM) + 0.010674d * Math.Sin(4 * DM - MM);
			L = L + 0.010034d * Math.Sin(3 * MM) + 0.008548d * Math.Sin(4 * DM - 2 * MM);
			L = L - 0.00791d * Math.Sin(S1 - MM + 2 * DM) * E1 - E1 * 0.006783d * Math.Sin(2 * DM + S1);
			L = L + 0.005162d * Math.Sin(MM - DM) + E1 * 0.005d * Math.Sin(S1 + DM);
			L = L + E1 * 0.004049d * Math.Sin(MM - S1 + 2 * DM) + 0.003996d * Math.Sin(2 * MM + 2 * DM);
			L = L + 0.003862d * Math.Sin(4 * DM) + 0.003665d * Math.Sin(2 * DM - 3 * MM);
			L = L + E1 * 0.002695d * Math.Sin(2 * MM - S1) + 0.002602d * Math.Sin(MM - 2 * FM - 2 * DM);
			L = L + E1 * 0.002396d * Math.Sin(2 * DM - S1 - 2 * MM) - 0.002349d * Math.Sin(MM + DM);
			L = L + Math.Pow(E1, 2) * 0.002249d * Math.Sin(2 * DM - 2 * S1) - E1 * 0.002125d * Math.Sin(2 * MM + S1);
			L = L - Math.Pow(E1, 2) * 0.002079d * Math.Sin(2 * S1) + Math.Pow(E1, 2) * 0.002059d * Math.Sin(2 * DM - MM - 2 * S1);
			L = L - 0.001773d * Math.Sin(MM + 2 * DM - 2 * FM) - 0.001595d * Math.Sin(2 * FM + 2 * DM);
			L = L + E1 * 0.00122d * Math.Sin(4 * DM - S1 - MM) - 0.00111d * Math.Sin(2 * MM + 2 * FM);
			L = L + 0.000892d * Math.Sin(MM - 3 * DM) - E1 * 0.000811d * Math.Sin(S1 + MM + 2 * DM);
			L = L + E1 * 0.000761d * Math.Sin(4 * DM - S1 - 2 * MM) + Math.Pow(E1, 2) * 0.000717d * Math.Sin(MM - 2 * S1);
			L = L + Math.Pow(E1, 2) * 0.000704d * Math.Sin(MM - 2 * S1 - 2 * DM) + E1 * 0.000693d * Math.Sin(S1 - 2 * MM + 2 * DM);
			L += E1 * 0.000598d * Math.Sin(2 * DM - S1 - 2 * FM);
			L = L + 0.00055d * Math.Sin(MM + 4 * DM) + 0.000538d * Math.Sin(4 * MM);
			L = L + E1 * 0.000521d * Math.Sin(4 * DM - S1) + 0.000486d * Math.Sin(2 * MM - DM);
			LB = 5.128189d * Math.Sin(FM) + 0.280606d * Math.Sin(MM + FM) + 0.277693d * Math.Sin(MM - FM);
			LB = LB + 0.173238d * Math.Sin(2 * DM - FM) + 0.055413d * Math.Sin(2 * DM + FM - MM);
			LB = LB + 0.046272d * Math.Sin(2 * DM - FM - MM) + 0.032573d * Math.Sin(2 * DM + FM);
			LB = LB + 0.017198d * Math.Sin(2 * MM + FM) + 0.009267d * Math.Sin(2 * DM + MM - FM);
			LB = LB + 0.008823d * Math.Sin(2 * MM - FM) + E1 * 0.008247d * Math.Sin(2 * DM - S1 - FM);
			LB = LB + 0.004323d * Math.Sin(2 * DM - FM - 2 * MM) + 0.0042d * Math.Sin(2 * DM + FM + MM);
			LB = LB + E1 * 0.003372d * Math.Sin(FM - S1 - 2 * DM) + E1 * 0.002472d * Math.Sin(2 * DM + FM - S1 - MM);
			LB = LB + E1 * 0.002222d * Math.Sin(2 * DM + FM - S1) + E1 * 0.002072d * Math.Sin(2 * DM - FM - S1 - MM);
			LB = LB + E1 * 0.001877d * Math.Sin(FM - S1 + MM) + 0.001828d * Math.Sin(4 * DM - FM - MM);
			LB = LB - E1 * 0.001803d * Math.Sin(FM + S1) - 0.00175d * Math.Sin(3 * FM) + E1 * 0.00157d * Math.Sin(MM - S1 - FM);
			LB = LB - 0.001487d * Math.Sin(FM + DM) - E1 * 0.001481d * Math.Sin(FM + S1 + MM);
			LB = LB + E1 * 0.001417d * Math.Sin(FM - S1 - MM) + E1 * 0.00135d * Math.Sin(FM - S1) + 0.00133d * Math.Sin(FM - DM);
			LB = LB + 0.001106d * Math.Sin(FM + 3 * MM) + 0.00102d * Math.Sin(4 * DM - FM);
			LB = LB + 0.000833d * Math.Sin(FM + 4 * DM - MM) + 0.000781d * Math.Sin(MM - 3 * FM);
			LB = LB + 0.00067d * Math.Sin(FM + 4 * DM - 2 * MM) + 0.000606d * Math.Sin(2 * DM - 3 * FM);
			LB = LB + 0.000597d * Math.Sin(2 * DM + 2 * MM - FM) + E1 * 0.000492d * Math.Sin(2 * DM + MM - S1 - FM);
			LB = LB + 0.00045d * Math.Sin(2 * MM - FM - 2 * DM) + 0.000439d * Math.Sin(3 * MM - FM);
			LB = LB + 0.000423d * Math.Sin(FM + 2 * DM + 2 * MM) + 0.000422d * Math.Sin(2 * DM - FM - 3 * MM);
			LB = LB - E1 * 0.000367d * Math.Sin(S1 + FM + 2 * DM - MM) - E1 * 0.000353d * Math.Sin(S1 + FM + 2 * DM);
			LB = LB + 0.000331d * Math.Sin(FM + 4 * DM) + E1 * 0.000317d * Math.Sin(2 * DM + FM - S1 + MM);
			LB = LB + Math.Pow(E1, 2) * 0.000306d * Math.Sin(2 * DM - 2 * S1 - FM) - 0.000283d * Math.Sin(MM + 3 * FM);
			HP = 0.950724d + 0.051818d * Math.Cos(MM) + 0.009531d * Math.Cos(2 * DM - MM);
			HP = HP + 0.007843d * Math.Cos(2 * DM) + 0.002824d * Math.Cos(2 * MM);
			HP = HP + 0.000857d * Math.Cos(2 * DM + MM) + E1 * (0.000533d * Math.Cos(2 * DM - S1));
			HP = HP + E1 * (0.000401d * Math.Cos(2 * DM - S1 - MM)) + E1 * (0.00032d * Math.Cos(MM - S1));
			HP = HP - 0.000271d * Math.Cos(DM) - E1 * (0.000264d * Math.Cos(S1 + MM));
			HP = HP - 0.000198d * Math.Cos(2 * FM - MM) + 0.000173d * Math.Cos(3 * MM);
			HP = HP + 0.000167d * Math.Cos(4 * DM - MM) - E1 * (0.000111d * Math.Cos(S1));
			HP = HP + 0.000103d * Math.Cos(4 * DM - 2 * MM) - 0.000084d * Math.Cos(2 * MM - 2 * DM);
			HP = HP - E1 * (0.000083d * Math.Cos(2 * DM + S1)) + 0.000079d * Math.Cos(2 * DM + 2 * MM);
			HP = HP + 0.000072d * Math.Cos(4 * DM) + E1 * (0.000064d * Math.Cos(2 * DM - S1 + MM));
			HP = HP - E1 * (0.000063d * Math.Cos(2 * DM + S1 - MM)) + E1 * (0.000041d * Math.Cos(S1 + DM));
			HP = HP + E1 * (0.000035d * Math.Cos(2 * MM - S1)) - 0.000033d * Math.Cos(3 * MM - 2 * DM);
			HP = HP - 0.00003d * Math.Cos(MM + DM) - 0.000029d * Math.Cos(2 * FM - 2 * DM);
			HP = HP - E1 * (0.000029d * Math.Cos(2 * MM + S1)) + Math.Pow(E1, 2) * (0.000026d * Math.Cos(2 * DM - 2 * S1));
			HP = HP - 0.000023d * Math.Cos(2 * FM - 2 * DM + MM) + E1 * (0.000019d * Math.Cos(4 * DM - S1 - MM));
			W1 = 0.0004664d * Math.Cos(AN);
			W3 = (275.05d - 2.3d * JT) * DR;
			W2 = 0.0000754d * Math.Cos(AN + W3);
			LB *= (1 - W1 - W2);
			L *= DR;
			LB *= DR;
			D7 = Math.Sin(LB) * Math.Cos(EO) + Math.Cos(LB) * Math.Sin(EO) * Math.Sin(L);
			D8 = Math.Atan(D7 / Math.Sqrt((-D7) * D7 + 1));
			HZ = (((0.7275d * HP - 0.5666667d) * DR) - Math.Sin(LT) * Math.Sin(D8)) / (Math.Cos(LT) * Math.Cos(D8));
			HW = ((-Math.Atan(HZ / Math.Sqrt((-HZ) * HZ + 1)) + 1.570796326795d) * 3.8197186342055d);
			B2 = (Math.Sin(L) * Math.Cos(EO) - Math.Tan(LB) * Math.Sin(EO));
			B4 = Math.Cos(L);
			B6 = Math.Atan(B2 / B4);
			if (B2 > 0 && B4 < 0)
			{
				B6 += PI;
			}
			if (B2 < 0 && B4 < 0)
			{
				B6 += PI;
			}
			if (B2 < 0 && B4 > 0)
			{
				B6 += 2 * PI;
			}
			B3 = B6 * 3.8197186342055d;
			KT = (JI - 2415019.5d) / 36525d;
			S4 = 6.6460656d + 2400.051262d * KT + 0.00002581d * Math.Pow(KT, 2);
			S5 = S4 - Math.Floor(S4 / 24d) * 24;
			TM = 12 + S5 - B3 - 0.065712d * DT;
			if (TM > 0)
			{
				TM = 24 - TM;
			}
			else
			{
				TM = -TM;
			}
			HW = HW + TM + MJ + 0.0241666666d; //Line 6690     0.024166 USED TO ADJUST MOONSET TIME.
			if (HW > 24)
			{
				HW -= 24;
			}
			HV = HW + AJ;
			if (HV > 24)
			{
				HV -= 24;
			} //This does not match the 'Times' module
			HQ = Math.Floor((HV - Math.Floor(HV)) * 60);
			HO = Math.Floor(HV);
		}

		private static void NauticalTwilightCalc()
		{ //Line 5400
			//Nautical twilight calc*******************************
			AN = (259.18d - 1934.142d * JT) * DR;
			EO = (23.452294d - 0.0130125d * JT - 0.00000164d * Math.Pow(JT, 2) + 0.000000503d * Math.Pow(JT, 3) + 0.00256d * Math.Cos(AN)) * DR;
			A9 = 153.23d + 22518.7541d * JT;
			A9 = (A9 - (Math.Floor(A9 / 360d)) * 360) * DR;
			B9 = 216.57d + 45037.5082d * JT;
			B9 = (B9 - (Math.Floor(B9 / 360d)) * 360) * DR;
			C9 = 312.69d + 32964.3577d * JT;
			C9 = (C9 - (Math.Floor(C9 / 360d)) * 360) * DR;
			D9 = 350.74d + 445267.1142d * JT - 0.00144d * Math.Pow(JT, 2);
			D9 = (D9 - (Math.Floor(D9 / 360d)) * 360) * DR;
			E9 = 231.19d + 20.2d * JT;
			E9 = (E9 - (Math.Floor(E9 / 360d)) * 360) * DR;
			LS = 279.69668d + 36000.76892d * JT + 0.0003025d * Math.Pow(JT, 2);
			LS = (LS - (Math.Floor(LS / 360d)) * 360) * DR;
			MS = 358.47583d + 35999.04975d * JT - 0.00015d * Math.Pow(JT, 2) - 0.0000033d * Math.Pow(JT, 3);
			MS = (MS - (Math.Floor(MS / 360d)) * 360) * DR;
			EE = 0.01675104d - 0.0000418d * JT - 0.000000126d * Math.Pow(JT, 2);
			YU = Math.Pow(Math.Tan(EO / 2d), 2);
			ET = YU * Math.Sin(2 * LS) - 2 * EE * Math.Sin(MS) + 4 * EE * YU * Math.Sin(MS) * Math.Cos(2 * LS);
			ET = (ET - 1 / 2d * Math.Pow(YU, 2) * Math.Sin(4 * LS) - 5 / 4d * Math.Pow(EE, 2) * Math.Sin(2 * MS)) * 3.819718634d;
			CS = (1.91946d - 0.004789d * JT - 0.000014d * Math.Pow(JT, 2)) * Math.Sin(MS);
			CS = (CS + (0.020094d - 0.0001d * JT) * Math.Sin(2 * MS) + 0.000293d * Math.Sin(3 * MS)) * DR;
			//LO = sun's true geometric longitude *************************************
			LO = LS + CS + (0.00134d * Math.Cos(A9) + 0.00154d * Math.Cos(B9) + 0.002d * Math.Cos(C9) + 0.00179d * Math.Sin(D9) + 0.00178d * Math.Sin(E9) - 0.00569d - 0.00479d * Math.Sin(AN)) * DR;
			SD = Math.Sin(EO) * Math.Sin(LO);
			DS = Math.Atan(SD / Math.Sqrt((-SD) * SD + 1));
			//DS= declination of sun **************************
			TRA2 = Math.Cos(EO) * Math.Sin(LO);
			TRA4 = Math.Cos(LO);
			RAS = Math.Atan(TRA2 / TRA4);
			//RAS = RIGHT ASCENSION OF SUN IN RADIANS *********************
			if (TRA2 > 0 && TRA4 < 0)
			{
				RAS += PI;
			}
			if (TRA2 < 0 && TRA4 < 0)
			{
				RAS += PI;
			}
			if (TRA2 < 0 && TRA4 > 0)
			{
				RAS += 2 * PI;
			}
			RAS *= 3.8197186342055d; // converts RAS to hours from radians**********************
			HAS = (S5 + (HV + 12) * 1.002737908d - AJ - RAS);
			HAS /= 3.8197186342055d;
			//-converts Hour Angle of sun (HAS) back to radians ***********************************
			//SAM = Sun's altitude at Moonset ***************************************
			SSAM = Math.Sin(LT) * Math.Sin(DS) + Math.Cos(LT) * Math.Cos(DS) * Math.Cos(HAS);
			SAM = (Math.Atan(SSAM / Math.Sqrt((-SSAM) * SSAM + 1))) / DR;
			SAM += 1.75d; // - ADJUSTMENT NEEDED TO MAKE SAM MORE ACCURATE.*******************
			SAM = Math.Floor(SAM * 10000) / 10000d;
			SAMString = FormatToString(SAM, 4); //Sun's Altitude at moonset
			TPrint("      " + SAMString); //Sun's Altitude at Moonset           #0#0#0#0#0#0#0#0#0#0#0
		}

		//Function to convert numeric years to printable strings with CE or BCE instead of + or -
		//
		internal static string StringYear(double GYear)
		{
			string IntStringYear = Conversion.Str(Math.Abs(GYear));
			if (!SunsetFlag)
			{
				if (GYear < 0)
				{
					IntStringYear = IntStringYear + " BCE";
				}
				else
				{
					IntStringYear = IntStringYear + " CE";
				}
				while (Strings.Len(IntStringYear) < 9)
				{ //If string is short then pad it with spaces
					IntStringYear = IntStringYear + " ";
				}
			}
			return IntStringYear;
		}

		//Prints the sunset time, on entry AA = julian date
		internal static void PrintSunset()
		{
			AN = (259.18d - 1934.142d * JT) * DR; //Solar Coordinates page 69
			EO = (23.452294d - 0.0130125d * JT - 0.00000164d * Math.Pow(JT, 2) + 0.000000503d * Math.Pow(JT, 3) + 0.00256d * Math.Cos(AN)) * DR;
			A9 = 153.23d + 22518.7541d * JT;
			A9 = (A9 - (Math.Floor(A9 / 360d)) * 360) * DR;
			B9 = 216.57d + 45037.5082d * JT;
			B9 = (B9 - (Math.Floor(B9 / 360d)) * 360) * DR;
			C9 = 312.69d + 32964.3577d * JT;
			C9 = (C9 - (Math.Floor(C9 / 360d)) * 360) * DR;
			D9 = 350.74d + 445267.1142d * JT - 0.00144d * Math.Pow(JT, 2);
			D9 = (D9 - (Math.Floor(D9 / 360d)) * 360) * DR;
			E9 = 231.19d + 20.2d * JT;
			E9 = (E9 - (Math.Floor(E9 / 360d)) * 360) * DR;
			LS = 279.69668d + 36000.76892d * JT + 0.0003025d * Math.Pow(JT, 2);
			LS = (LS - (Math.Floor(LS / 360d)) * 360) * DR;
			MS = 358.47583d + 35999.04975d * JT - 0.00015d * Math.Pow(JT, 2) - 0.0000033d * Math.Pow(JT, 3);
			MS = (MS - (Math.Floor(MS / 360d)) * 360) * DR;
			EE = 0.01675104d - 0.0000418d * JT - 0.000000126d * Math.Pow(JT, 2);
			YU = Math.Pow(Math.Tan(EO / 2d), 2);
			ET = YU * Math.Sin(2 * LS) - 2 * EE * Math.Sin(MS) + 4 * EE * YU * Math.Sin(MS) * Math.Cos(2 * LS);
			ET = (ET - 1 / 2d * Math.Pow(YU, 2) * Math.Sin(4 * LS) - 5 / 4d * Math.Pow(EE, 2) * Math.Sin(2 * MS)) * 3.819718634d;
			CS = (1.91946d - 0.004789d * JT - 0.000014d * Math.Pow(JT, 2)) * Math.Sin(MS);
			CS = (CS + (0.020094d - 0.0001d * JT) * Math.Sin(2 * MS) + 0.000293d * Math.Sin(3 * MS)) * DR;
			LO = LS + CS + (0.00134d * Math.Cos(A9) + 0.00154d * Math.Cos(B9) + 0.002d * Math.Cos(C9) + 0.00179d * Math.Sin(D9) + 0.00178d * Math.Sin(E9) - 0.00569d - 0.00479d * Math.Sin(AN)) * DR;
			SD = Math.Sin(EO) * Math.Sin(LO); // Sun's Declination
			if (DMT == 0)
			{ //Premature return from sub reflected in FiftyFourHundred
				DS = Math.Atan(SD / Math.Sqrt((-SD) * SD + 1)); // Transformation of Coordinates: Setting of a body chapter 8 (AFC-3rd ed)
				H1 = (-0.01454d - Math.Sin(LT) * Math.Sin(DS)) / (Math.Cos(LT) * Math.Cos(DS));
				HS = ((-Math.Atan(H1 / Math.Sqrt((-H1) * H1 + 1)) + 1.570796326795d) * 3.8197186342055d) - ET;
				HL = HS + AJ + SJ + 0.00833333333d; // .008333 USED TO ADJUST BASE SUNSET TIME (IN HOURS)
				HM = Math.Floor((HL - Math.Floor(HL)) * 60);
				HT = Math.Floor(HL);
				HTString = Conversion.Str(HT);
				HMString = Conversion.Str(HM);
				HMString = HMString.Substring(1);
				if (!SunsetFlag)
				{
					TPrint("   ");
				}
				if (HT < 10)
				{
					HTString = " " + HTString;
				}
				if (HM < 10)
				{ //Print Sunset time    Line 5590 #0#0#0#0#0#0#0#0#0
					TPrint(HTString + ":0" + HMString);
				}
				else
				{
					TPrint(HTString + ":" + HMString);
				}
			}
		}

		//*****************************************************************
		// Prints the Day and date, on entry AA = Julian date
		//*****************************************************************
		internal static void PrintDayAndDate()
		{

			if (EJWString == "Y")
			{
				AA++;
			} //Add day for east of Israel and west of IDL
			A = (AA + 1) / 7d;
			//Set up date and day of the week accounting for the long day

			if ((AA <= JDNJLD + 0.5d) || Mode == "Jordan")
			{
				D = (A - Math.Floor(A)) * 7 + 1;
			}
			else
			{
				D = (A - Math.Floor(A)) * 7;
			}
			D = Convert.ToInt32(D);
			if (D > 6)
			{
				D -= 7;
				D = Convert.ToInt32(D);
			}
			TPrint(DayName[Convert.ToInt32(D)]);
			PrintDate();
		}

		//*******************************************************************
		//* Prints the date, on entry AA = Julian date
		//*******************************************************************
		internal static void PrintDate()
		{
			H = Math.Floor((AA - 1867216.25d) / 36524.25d);
			H = AA + 1 + H - Math.Floor(H / 4d);
			B = H + 1524;
			C = Math.Floor((B - 122.1d) / 365.25d);
			G = Math.Floor(365.25d * C);
			E = Math.Floor((B - G) / 30.6001d);
			Daye = B - G - Math.Floor(30.6001d * E) + F;
			if (E < 13.5d)
			{
				M = E - 1;
			}
			else
			{
				M = E - 13;
			}
			if (M > 2.5d)
			{
				GYear = C - 4716;
			}
			else
			{
				GYear = C - 4715;
			}
			if (GYear < 1)
			{
				GYear--;
			}
			DayString = Conversion.Str(Daye);
			DayString = DayString.Substring(1);
			while (Strings.Len(DayString) < 2)
			{
				DayString = " " + DayString;
			}
			TPrint(DayString + " " + MonthName[Convert.ToInt32(M)] + StringYear(GYear));
			if (!SunsetFlag)
			{
				TPrint(CRLF);
			}
			if (EJWString == "Y")
			{
				AA--;
			}
		}

		//Function to print to the text box txtOut.  This allows us to turn off printing as needed.
		//Called as TPrint("What you want printed in the Text Box")
		//PrintFlag indicates if printing will be allowed. If TRUE then Print else No Print.
		internal static object TPrint(string Words)
		{
			if (CriteriaFlag && PrintCriteria)
			{
				frmCriteria.DefInstance.txtCriteria.Text = frmCriteria.DefInstance.txtCriteria.Text + Words;
			}

			if (PrintFlag)
			{ //Allow turning off printing
				frmHolyDays.DefInstance.txtOut.Text = frmHolyDays.DefInstance.txtOut.Text + Words;
			}
			return null;
		}

		//Function to format numbers into numeric strings of a predetermined length.
		//Length includes the decimal point. "99.99" would have a length of 5.
		//Length does not include the - sign or the space in front of a numeric string.
		internal static string FormatToString(double Number, int Length)
		{
			string result = "";
			string TempString = "";
			int IntegerLength = 0;
			double TempNumber = 0;
			bool LongInteger = false;
			int TempLength = 0;
			if ((PrintFlag || CriteriaFlag) || MoonFlag)
			{ //Don't waste time if not printing
				if (Length < 2)
				{
					Length = 2;
				} //Don't allow a Length of < 2.
				TempNumber = Number;
				while (Math.Abs(TempNumber) > 1)
				{ //Find number of digits in integer part.
					TempNumber /= 10d;
					IntegerLength++;
				}
				if (IntegerLength >= Length)
				{ //Print the entire integer.
					LongInteger = true;
					TempLength = Length;
					Length = IntegerLength + 1; //Can't round to less than integer.
				}
				if (Math.Abs(Number) < 1)
				{ //Round to the required number of decimal places
					Number = Math.Round((double) Number, Length - IntegerLength - 2); //Take in for the leading zero
				}
				else
				{
					Number = Math.Round((double) Number, Length - IntegerLength - 1); //Don't take in for the leading zero
				}
				if (LongInteger)
				{
					Length = TempLength;
				}
				TempString = Conversion.Str(Number);
				if (Math.Abs(Number) < 1 && Number != 0)
				{ //Take care of purely decimal numbers
					if (Number < 0)
					{
						TempString = "-0" + TempString.Substring(Math.Max(TempString.Length - (Strings.Len(TempString) - 1), 0));
					}
					else
					{
						TempString = " 0" + TempString.Substring(Math.Max(TempString.Length - (Strings.Len(TempString) - 1), 0));
					}
				}
				if (Math.Floor(Number) == Number && Strings.Len(TempString) + 2 <= Length + 1)
				{
					TempString = TempString + ".0"; //Add decimal place to lonely integers
				}
				if (Math.Floor(Number) == Number && TempString.Substring(Math.Max(TempString.Length - 2, 0)) != ".0")
				{
					while (Strings.Len(TempString) < Length + 1)
					{
						TempString = TempString + " "; //Pad with spaces for length
					}
				}
				while (Strings.Len(TempString) < Length + 1)
				{ //Pad with zeros for length
					TempString = TempString + "0";
				}
				result = TempString;
			}
			return result;
		}

		//Prints the Location data to the Text Box.
		internal static void PrintLocation()
		{
			TPrint("(" + CurrentLocation + ", " + frmHolyDays.DefInstance.txtLatDeg.Text + "�" + frmHolyDays.DefInstance.txtLatMin.Text);
			TPrint("'" + frmHolyDays.DefInstance.txtLatDir.Text + " ");
			TPrint(frmHolyDays.DefInstance.txtLongDeg.Text + "�" + frmHolyDays.DefInstance.txtLongMin.Text);
			TPrint("'" + frmHolyDays.DefInstance.txtLonDir.Text + " GMT ");
			string GMTOffset = Conversion.Str(Conversion.Val(frmHolyDays.DefInstance.txtGMT.Text));
			if (frmHolyDays.DefInstance.txtLonDir.Text == "W")
			{
				GMTOffset = "-" + GMTOffset.Substring(Math.Max(GMTOffset.Length - (Strings.Len(GMTOffset) - 1), 0));
			}
			else
			{
				GMTOffset = "+" + GMTOffset.Substring(Math.Max(GMTOffset.Length - (Strings.Len(GMTOffset) - 1), 0));
			}
			TPrint(GMTOffset + ")" + CRLF);
		}

		//Initializes variables before computation is started
		internal static void InitializeVariables()
		{
			MM = 0;
			LM = 0;
			S1 = 0;
			DM = 0;
			FM = 0;
			L = 0;
			LB = 0;
			MC = 0;
			DR = 0.01745329251993d;
			if ((!FloodFlag) && (!ConversionFlag))
			{
				RangeCheckGregorianYear();
			}
			if (!LocalCalcFlag && !FloodFlag)
			{ //Skip if Local New Moons or Flood is selected
				LG = -35.244d; //Longitude of Jerusalem
				LT = 31.78d; //Latitude of Jerusalem
				HR = 14; //Hour location of Jerusalem GMT + 2
				//LG = -42: LT = 38.5: HR = 14               'Location of Garden of Eden
				//LG = 83.965: LT = 42.96278: HR = 8         'Location of 'My Home' GMT - 4
				//LG = -143.9167: LT = -37.4167: HR = 22     'Location of Creswick Aus. 37�25'S 143�55'E GMT +10
				//LG = -44.32: LT = 39.69: HR = 14           'Location of Mount Ararat
				//LG = 84.22424: LT =42.93381: HR = 8        'Location of Spring Vale Academy
				if (PrintFlag)
				{
					frmHolyDays.DefInstance.txtOut.Text = ""; //Clear the output text box for new data
				}
			}
			SJ = 0;
			MJ = 0;
			HR = 12 - HR; //Get International Date Line hour
			AJ = (LG - HR * 15) * 0.066667d; //Calculate longitude hour adjustment for sunset.
			LG /= 360d;
			LT *= DR;
			SJ /= 60d; //Set up Sunset adjustment
			MJ /= 60d; //Set up Moonset adjustment
		}

		//Makes sure GregorianYear in txtYear is valid
		internal static void RangeCheckGregorianYear()
		{
			GregorianYear = Conversion.Val(frmHolyDays.DefInstance.txtYear.Text);
			if (GregorianYear < -4004)
			{ //Correct for Year entries less than -4004
				GregorianYear = -4004;
				frmHolyDays.DefInstance.txtYear.Text = "-4004";
				SystemSounds.Beep.Play();
			}
			if (GregorianYear == 0)
			{ //Correct for there being no Year Zero
				GregorianYear = -1;
				frmHolyDays.DefInstance.txtYear.Text = "-1";
			}
			if (GregorianYear > 9999)
			{ //Correct for too big of a year number
				GregorianYear = 9999;
				frmHolyDays.DefInstance.txtYear.Text = "9999";
				SystemSounds.Beep.Play();
			}
			GregorianYear = Conversion.Val(frmHolyDays.DefInstance.txtYear.Text);
			TempYear = Convert.ToInt32(GregorianYear);
		}

		//The Jean Meeus formula 7.1 pages 60 - 61 of Astronomical Algorithms Second Edition
		internal static double ConvertToJulian(double MonthNum, double DayNum, double YearNum)
		{
			double result = 0;
			double C = 0;
			double E = 0;
			double F = 0;

			//*********************************************************************************
			//Fix for year zero
			//If YearNum <= 0 Then YearNum = YearNum + 1
			//*********************************************************************************

			if (MonthNum < 3)
			{
				YearNum--;
				MonthNum += 12;
			}
			//If YearNum + (MonthNum / 100) + (DayNum / 10000) >= 1582.1015 Then 'In the Gregorian calendar?
			double A = Math.Floor(YearNum / 100d);
			double B = Math.Floor(2 - A + Math.Floor(A / 4d));
			//Else
			// B = 0
			//End If
			result = Math.Floor(365.25d * (YearNum + 4716)) + Math.Floor(30.6001d * (MonthNum + 1)) + DayNum + B - 1524.5d;
			return Math.Floor(result) + 1;
		}

		//Converts Julian date to Month, Day and Year
		//On entry IA = Julian Date.
		//On exit MHString = month, DAString = day, GregorianYearString = year

		//The Jean Meeus formula  3 pages 26 - 27 of Astronomical Formulae for Calculators Fourth Edition
		//Converts Julian day to Month, Day and Year
		//On entry JD = Julian Date.
		//On exit MHString = month, DAString = day, GregorianYearString = year

		internal static void JulianToMDY()
		{
			double MonthNum = 0;
			int LengthNumber = 0;
			double GregorianYear = 0;

			JD = IA;
			double TempJD = JD; //Save the value of JD
			//JD = JD + 0.5
			double Z = Math.Floor(JD);
			double F = JD - Z;
			//If Z < 2299161 Then
			// A = Z
			//Else
			double Alpha = Math.Floor((Z - 1867216.25d) / 36524.25d);
			double A = Z + 1 + Alpha - Math.Floor(Alpha / 4d);
			//End If
			double B = A + 1524;
			double C = Math.Floor((B - 122.1d) / 365.25d);
			double D = Math.Floor(365.25d * C);
			double E = Math.Floor((B - D) / 30.6001d);
			double DayNum = Math.Round((double) (B - D - Math.Floor(30.6001d * E) + F), 2);
			if (E < 14)
			{
				MonthNum = E - 1;
			}
			if (E == 14 || E == 15)
			{
				MonthNum = E - 13;
			}
			if (MonthNum > 2)
			{
				GregorianYear = C - 4716;
			}
			if (MonthNum == 1 || MonthNum == 2)
			{
				GregorianYear = C - 4715;
			}
			DAString = Conversion.Str(DayNum);
			MHString = Conversion.Str(MonthNum);
			//*********************************************************************************
			//Fix for year zero
			if (GregorianYear <= 0)
			{
				GregorianYear--;
			}
			//*********************************************************************************
			GregorianYearString = GregorianYear.ToString();
			if (Conversion.Val(MHString) < 10)
			{
				MHString = "0" + MHString.Substring(Math.Max(MHString.Length - (Strings.Len(MHString) - 1), 0));
			}
			if (Conversion.Val(DAString) < 10)
			{
				DAString = "0" + DAString.Substring(Math.Max(DAString.Length - (Strings.Len(DAString) - 1), 0));
			}
			if (Strings.Len(DAString) > 2)
			{
				DAString = DAString.Substring(Math.Max(DAString.Length - (Strings.Len(DAString) - 1), 0));
			}
			if (Strings.Len(MHString) > 2)
			{
				MHString = MHString.Substring(Math.Max(MHString.Length - (Strings.Len(MHString) - 1), 0));
			}
			GregorianYearString = Conversion.Val(GregorianYear.ToString()).ToString();
			if (GregorianYear < 0)
			{ //Determine what padding is needed for 'Year'
				LengthNumber = 5;
			}
			else
			{
				LengthNumber = 4;
			}
			while (Strings.Len(GregorianYearString) < LengthNumber)
			{ //Pad the 'Year' so it is always the same length.
				if (GregorianYear >= 0)
				{
					GregorianYearString = "0" + GregorianYearString;
				}
				else
				{
					GregorianYearString = "-0" + GregorianYearString.Substring(Math.Max(GregorianYearString.Length - (Strings.Len(GregorianYearString) - 1), 0));
				}
			}
			JD = TempJD; //Restore value for JD
		}

		internal static void BiblicalToJulian(int BMonth, int BDay, double BYear, ref double JD)
		{

			// Dim MayBeEarlyOrLate As Boolean      'First month may be early or late (True = yes)
			//Month may be day early or late VS indicates (1 = early 2 = late 3 = visible)

			//DateOfFirstMonth = JD for first Month
			//MayBeEarlyOrLate = Month early or not, True if so
			//MonthNumber = The Early Month

			string TempEJWString = EJWString;
			string TempMode = Mode;
			ConversionFlag = true;
			MayBeEarlyOrLate = false; //Clear the early or late flag
			MonthNumber = 0; //Clear the MonthNumber to collect first month
			GregorianYear = BYear - 4004; //Determine the Gregorian year of Biblical Year
			if (GregorianYear <= 0)
			{
				GregorianYear--;
			} //Fix for year zero
			PrintFlag = false; //Keep from printing the look up results
			PrintCriteria = false;
			Mode = "HolyDays"; //Do a Holy Days look up.
			CalcHolyDays(); //Sets MayBeEarlyOrLate flag True if it may be.
			PrintCriteria = true; //Also sets up the location to Jerusalem
			Mode = "LocalMoons"; //Set up so we know visibility criteria
			LN = MonthNumber + BMonth - 1; //The Month Number for the month
			DateOfFirstMonth = 0; //Clear Date of first month so we can capture it.
			//******************************************************************************************
			//New moon seen before Vernal equinox, next month starts the new year
			if (MayBeEarlyOrLate)
			{
				LN++; //Take the late month as the default
			}
			//******************************************************************************************
			FindFirstDay(); //Find JD for possible first day
			JD = DateOfFirstMonth + BDay - 1.5d; //Julian Day Number for possible day
			PrintFlag = true; //Turn on printing
			ConversionFlag = false; //Turn off Conversion flag
			Mode = TempMode; //Restore original Mode
			EJWString = TempEJWString; //Restore East of Jerusalem and West of IDL indicator
			//********************************************************
			//Rest of month when the earth stood still for one day starting on
			//Thursday, 18 July 1504 BCE and going through Saturday, 3 August 1504 BCE
			if (JD >= JDNJLD + 1 && JD <= JDNJLDBench + 19)
			{
				JD++;
			} //JDNJLD is date of long day
			//********************************************************
			//Fix for short month because earth stopped for a day in it.
			//Lets us go back to it from the month after it.
			if (BDay == 0 && JD == JDNJLDBench + 20)
			{
				JD--;
			} //JDNJLDBench is a Benchmark
		}

		internal static void JulianToBiblical(double JD, ref int BMonth, ref int BDay, ref double BYear)
		{

			int Index = 0;
			int MonthsInYear = 0;

			double TempJD = JD; //Save Julian Day Count
			//********************************************************
			//Rest of month when the earth stood still for one day starting on
			//Thursday, 18 July 1504 BCE and going through Saturday, 3 August 1504 BCE
			if (JD >= JDNJLD + 1 && JD <= JDNJLDBench + 19)
			{
				JD--;
			} //JDNJLD is date of long day
			//********************************************************           'JDNJLDBench is a benchmark
			double OriginalJulianCount = JD;
			IA = JD;
			JulianToMDY(); //Find a year that is close

			GregorianYear = Conversion.Val(GregorianYearString);
			if (Conversion.Val(MHString) < 3)
			{
				GregorianYear--;
			} //See if it's the year before
			if (GregorianYear > 0)
			{ //Fix for year zero
				BYear = GregorianYear + 4004;
			}
			else
			{
				BYear = GregorianYear + 4003;
			}
			JD = OriginalJulianCount - 1000; //Find a year that fits start 10000 days before
			BYear -= 2; //Take two years back
			while (JD <= OriginalJulianCount)
			{ //Find the correct year
				BYear++; //by stepping through the years
				BiblicalToJulian(1, 1, BYear, ref JD); //Get Julian Day count for 1st month of that year
			}
			BYear--; //Take back the extra year
			JD = 0;
			BMonth = 0; //Find a Month that fits
			while (JD <= OriginalJulianCount)
			{
				BMonth++;
				BiblicalToJulian(BMonth, 1, BYear, ref JD); //Get the Julian Day count for each month
			}
			BMonth--; //Take back the extra month
			BiblicalToJulian(BMonth, 1, BYear, ref JD); //Get the Julian Day Count for that Month and year
			BDay = Convert.ToInt32(OriginalJulianCount - JD + 1); //Get the exact Julian Day Count
			ThirteenthMonthFlag = false; //Clear the Thirteenth Month Flag
			//*****************************************************************************************
			if (BMonth == 13)
			{ //Check to see if this may be first month of next year
				BiblicalToJulian(1, 1, BYear + 1, ref JD);
				if (MayBeEarlyOrLate)
				{
					ThirteenthMonthFlag = true;
				} //This month may be the 1st month of next year.
			}
			//*****************************************************************************************
			JD = TempJD; //Restore messed up Julian Day Count
		}

		internal static void LoadBiblicalVariables()
		{
			DayName[0] = " Sunday, "; //Load Arrays with day names and month names.
			DayName[1] = " Monday, ";
			DayName[2] = " Tuesday, ";
			DayName[3] = " Wednesday, ";
			DayName[4] = " Thursday, ";
			DayName[5] = " Friday, ";
			DayName[6] = " Saturday, ";
			MonthName[1] = "Jan";
			MonthName[2] = "Feb";
			MonthName[3] = "Mar";
			MonthName[4] = "Apr";
			MonthName[5] = "May";
			MonthName[6] = "Jun";
			MonthName[7] = "Jul";
			MonthName[8] = "Aug";
			MonthName[9] = "Sep";
			MonthName[10] = "Oct";
			MonthName[11] = "Nov";
			MonthName[12] = "Dec";
		}

		//Read the user data from the disk
		internal static void ReadUserData()
		{
			int Count = 0; //Error count
			int Index = 0; //Index pointer for arrays
			try
			{
				FileSystem.FileOpen(1, "UserData.Dat", OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1); //Open the disk file for reading
				CurrentLocation = FileSystem.LineInput(1); //Get the Current location selected
				FileSystem.Input(1, ref NumberOfLocations); //How many locations are available starts at 0
				if (NumberOfLocations == -1)
				{ //There are no saved locations?
					CurrentLocation = "Jerusalem, Israel"; //Make one!
					NumberOfLocations = 0;
					LocationName[0] = "Jerusalem , Israel";
					DegLon[0] = -35.2166666666667d;
					DegLat[0] = 31.7833333333333d;
					GMTOffset[0] = "2";
					ChangeFlag = true; //Have location saved on [EXIT]
					frmHolyDays.DefInstance.lblChange.Visible = true;
				}
				else
				{
					int tempForEndVar = NumberOfLocations;
					for (Index = 0; Index <= tempForEndVar; Index++)
					{ //Get all locations from file
						LocationName[Index] = FileSystem.LineInput(1); //Get location name
						FileSystem.Input(1, ref DegLon[Index]); //Get Longitude
						FileSystem.Input(1, ref DegLat[Index]); //Get Latitude
						FileSystem.Input(1, ref GMTOffset[Index]); //Get GMT offset
						ChangeFlag = true;
						frmHolyDays.DefInstance.lblChange.Visible = true;
					}
				}
				int tempForEndVar2 = NumberOfLocations;
				for (Index = 0; Index <= tempForEndVar2; Index++)
				{ //Build the locations drop down combo box
					frmHolyDays.DefInstance.cboLocation.AddItem(LocationName[Index]);
				}
				frmHolyDays.DefInstance.cboLocation.Text = CurrentLocation; //Select location to set up
				SetupLocation(); //Set up location into the text boxes.
			}
			catch
			{
				FileSystem.FileClose(1);
				Count++;
				if (Count == 2)
				{
					return;
				} //Prevent major error in event of drive malfunction.
				WriteUserData();
				return;
			}
		}

		//Write the user data to the disk
		internal static void WriteUserData()
		{
			int Index = 0; //Index pointer for arrays
			NumberOfLocations = frmHolyDays.DefInstance.cboLocation.Items.Count - 1; //Get number of locations starts with zero
			FileSystem.FileOpen(1, "UserData.Dat", OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1); //Open the output file
			FileSystem.PrintLine(1, CurrentLocation); //Send the Current Location selected to disk
			FileSystem.PrintLine(1, NumberOfLocations.ToString()); //Send the number of locations in list to disk
			int tempForEndVar = NumberOfLocations;
			for (Index = 0; Index <= tempForEndVar; Index++)
			{ //Send out all locations to disk
				FileSystem.PrintLine(1, LocationName[Index]); //Send out the Location Name
				FileSystem.PrintLine(1, DegLon[Index].ToString()); //Send out the longitude to disk
				FileSystem.PrintLine(1, DegLat[Index].ToString()); //Send out the Latitude to disk
				FileSystem.PrintLine(1, GMTOffset[Index]); //Send out the GMT offset to disk
			}
			FileSystem.FileClose(1); //Close the output file
			ChangeFlag = false;
			frmHolyDays.DefInstance.lblChange.Visible = false;
		}

		//Read the user data from the disk
		internal static void ReadUserDataXML()
		{
			int Count = 0; //Error count
			int Index = 0; //Index pointer for arrays
			try
			{
				XmlTextReader reader = new XmlTextReader("UserData.xml");

				while (reader.Read() && Index < 500)
				{
					// Do some work here on the data.
					var name = reader.Name;

					if (reader.NodeType == XmlNodeType.Element & "Location".Equals(name))
					{
						reader.MoveToAttribute("name");
						LocationName[Index] = reader.Value;
						reader.MoveToAttribute("lat");
						DegLat[Index] = Double.Parse(reader.Value);
						reader.MoveToAttribute("long");
						DegLon[Index] = Double.Parse(reader.Value);
						reader.MoveToAttribute("gmt");
						GMTOffset[Index] = reader.Value;
						reader.MoveToAttribute("selected");
						var isSelected = Boolean.Parse(reader.Value);

						if (isSelected)
						{
							CurrentLocation = LocationName[Index];
						}
						Index++;
					}
				}
				NumberOfLocations = Index;

				if (CurrentLocation.Length == 0)
                {
					CurrentLocation = LocationName[0];
                }

				reader.Close();
				ChangeFlag = true;
				frmHolyDays.DefInstance.lblChange.Visible = true;

				int tempForEndVar2 = Index-1;
				for (Index = 0; Index <= tempForEndVar2; Index++)
				{ //Build the locations drop down combo box
					frmHolyDays.DefInstance.cboLocation.AddItem(LocationName[Index]);
				}
				frmHolyDays.DefInstance.cboLocation.Text = CurrentLocation; //Select location to set up
				SetupLocation(); //Set up location into the text boxes.
			}
			catch
			{
				Count++;
				if (Count == 2)
				{
					return;
				} //Prevent major error in event of drive malfunction.
				WriteUserDataXML();
				return;
			}
		}

		//Write the user data to the disk
		internal static void WriteUserDataXML()
		{
			bool Done = false;
			int Index = 0; //Index pointer for arrays
			NumberOfLocations = frmHolyDays.DefInstance.cboLocation.Items.Count - 1; //Get number of locations zero indexed

			try
			{
				XmlWriter writer = XmlTextWriter.Create("UserData.xml");
				while (!Done)
				{
					writer.WriteStartDocument();
					writer.WriteStartElement("configuration");
					writer.WriteStartElement("Locations");
					writer.WriteWhitespace(CRLF);
					for (Index = 0; Index <= NumberOfLocations; Index++)
                    {
						bool isSelected = false;
						string locName = LocationName[Index];
						if (locName.Equals(CurrentLocation))
                        {
							isSelected = true;
                        }
						writer.WriteStartElement("Location");
						writer.WriteAttributeString("name", locName);
						writer.WriteAttributeString("lat", DegLat[Index].ToString());
						writer.WriteAttributeString("long", DegLon[Index].ToString());
						writer.WriteAttributeString("gmt", GMTOffset[Index]);
						writer.WriteAttributeString("selected", isSelected ? "true" : "false");
						writer.WriteEndElement();
						writer.WriteWhitespace(CRLF);
                    }
//					writer.WriteEndElement();
					writer.WriteEndDocument();
					Done = true;
                }
				writer.Close();
			}
			catch
			{
				return;
			}
			
			ChangeFlag = false;
			frmHolyDays.DefInstance.lblChange.Visible = false;
		}

		//***************************************************************************************
		// This subroutine finds the location data in the arrays matching the location name and
		// puts it in the text boxes on the form.
		//***************************************************************************************
		internal static void SetupLocation()
		{
			int Index = -1;
			do 
			{
				Index++;
				if (LocationName[Index] == CurrentLocation)
				{ //Find the location information
					frmHolyDays.DefInstance.txtLatDeg.Text = GetDegrees(DegLat[Index]).ToString(); //Convert from decimal degrees
					frmHolyDays.DefInstance.txtLatMin.Text = GetMinutes(DegLat[Index]).ToString(); //to degrees and minutes
					frmHolyDays.DefInstance.txtLongDeg.Text = GetDegrees(DegLon[Index]).ToString();
					frmHolyDays.DefInstance.txtLongMin.Text = GetMinutes(DegLon[Index]).ToString();
					frmHolyDays.DefInstance.txtGMT.Text = GMTOffset[Index];
					if (DegLat[Index] < 0)
					{ //Set up directions N/S
						frmHolyDays.DefInstance.txtLatDir.Text = "S";
					}
					else
					{
						frmHolyDays.DefInstance.txtLatDir.Text = "N";
					}
					if (DegLon[Index] < 0)
					{ //Set up directions E/W
						frmHolyDays.DefInstance.txtLonDir.Text = "E";
					}
					else
					{
						frmHolyDays.DefInstance.txtLonDir.Text = "W";
					}
				}
			}
			while(CurrentLocation != LocationName[Index] && Index <= NumberOfLocations);
			GetLocation(); //Put the information into the program
			ChangeFlag = false;
			frmHolyDays.DefInstance.lblChange.Visible = false;
		}

		//Function to convert from Degrees and Minutes to Degrees with decimals
		//Called as ReturnValue = Degrees(Degree,Min)
		internal static double Degrees(int Degree, int Min)
		{
			Degree = Convert.ToInt32(Math.Abs(Degree));
			double TempMin = Min / 60d;
			return Degree + TempMin;
		}

		//Gets the Degrees part of fractional degrees
		private static int GetDegrees(double Degrees)
		{
			double TempDegrees = Math.Floor(Math.Abs(Degrees));
			return Convert.ToInt32(TempDegrees);
		}

		//Gets the Minutes part of fractional degrees
		private static int GetMinutes(double Degrees)
		{
			double TempDegrees = Math.Abs(Degrees) - Math.Floor(Math.Abs(Degrees));
			TempDegrees *= 60;
			return Convert.ToInt32(Math.Floor(TempDegrees));
		}

		//Checks the values in the 'Latitude and Longitude' text boxes.
		//Then sets up the program variables with the proper values for LT,LG and HR.
		internal static void GetLocation()
		{
			bool TempChangeFlag = ChangeFlag;
			LG = Degrees(Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtLongDeg.Text)), Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtLongMin.Text)));
			LT = Degrees(Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtLatDeg.Text)), Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtLatMin.Text)));
			if (LG > 180)
			{
				LG = 180;
			} //Don't let minutes put it out of range.

			//Change here to check why values greater than 60 don't work
			if (LT > 60.99d)
			{
				LT = 60.99d;
			} //Don't allow Latitude greater than 60.99

			if (frmHolyDays.DefInstance.txtLonDir.Text == "E")
			{
				LG = -LG;
			}
			if (frmHolyDays.DefInstance.txtLatDir.Text == "S")
			{
				LT = -LT;
			}
			HR = 12 + Conversion.Val(frmHolyDays.DefInstance.txtGMT.Text);
			if (frmHolyDays.DefInstance.txtLonDir.Text == "W")
			{ //Figure out + or - offset from W or E
				HR = 12 - Conversion.Val(frmHolyDays.DefInstance.txtGMT.Text);
			}
			else
			{
				HR = 12 + Conversion.Val(frmHolyDays.DefInstance.txtGMT.Text);
			}
			ChangeFlag = TempChangeFlag;
		}
	}
}