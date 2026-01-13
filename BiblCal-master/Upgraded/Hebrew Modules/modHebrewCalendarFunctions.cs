using Microsoft.VisualBasic;
using System;
using UpgradeHelpers.Helpers;

namespace BiblCal
{
	internal static class modHebrewCalendarFunctions
	{


		//*******************************************************************************************
		//*                               HEBREW CALENDAR PROGRAM                                   *
		//*                                      Ver(1.000)                                         *
		//*               Routines used to do Hebrew (Rabbinc) calendar calculations                *
		//*                                          -                                              *
		//*   Written by:         Dale D. Donelson, 22 November 2006                                *
		//*                      10140 E Brooks Rd., Lennon, Michigan                               *
		//*                                Phone 810 496 0384                                       *
		//*                         http://www.vinedresser.org                                      *
		//*                         Email: donelson@vinedresser.org                                 *
		//*                                          -                                              *
		//*   Written for:     CENTRAL HIGHLANDS CHRISTIAN PUBLICATIONS                             *
		//*                    PO Box 236, Creswick, Vic. 3363 Australia                            *
		//*                            Phone (614) 0428 457 363                                     *
		//*                         http://www.chcpublications.net/                                 *
		//*                         Email: info@chcpublications.net                                 *
		//*******************************************************************************************
		public static int[] LOM = new int[14]; //Array for holding length of each Hebrew month
		public static string[] TypeYear = new string[]{"", "", "", "", "", "", ""}; //Array for holding names of types of Hebrew years
		public static string[] HMonthName = ArraysHelper.InitializeArray<string>(14); //Array for holding names of Hebrew months
		public static string[] SHMonthName = ArraysHelper.InitializeArray<string>(14); //Array for holding short names of Gregorian days.
		public static string[] SMonthName = ArraysHelper.InitializeArray<string>(13); //Array for holding names of Gregorian months
		public static string[] SDayName = new string[]{"", "", "", "", "", "", ""}; //Array for holding names of Gregorian days of week
		public static string[] BMonthName = ArraysHelper.InitializeArray<string>(14); //Array for holding names of Biblical months
		public static string[] BDayName = ArraysHelper.InitializeArray<string>(12); //Array for holding names of Biblical days of week
		public static string[] DayName2 = ArraysHelper.InitializeArray<string>(12); //Array for holding names of Gregorian days.
		public static string[] MonthName2 = ArraysHelper.InitializeArray<string>(13); //Array for holding names of Gregorian months.

		//Used by Function MoladOfTishri
		public static double Weeks = 0; //Weeks since creation
		public static double Days = 0; //Days offset from creation
		public static double Hours = 0; //Hours offset from creation
		public static double Parts = 0; //Parts offset from creation
		public static byte[] YR = new byte[20]; //Array containing flags for years being Common or Leap

		//Used by Sub CheckRules to return which Rules were used
		public static bool Rule1 = false; //Molad Zakein
		public static bool Rule2 = false; //Gatarad
		public static bool Rule3 = false; //Betutkafot
		public static bool Rule4 = false; //Dechiyah
		public static int PicMoonVisible = 0;

		internal static void LoadHebrewVariables()
		{
			//Load up the table of month lengths for Common Deficient year and the 13th month
			LOM[1] = 30; //Nisan
			LOM[2] = 29; //Iyar
			LOM[3] = 30; //Sivan
			LOM[4] = 29; //Tammuz
			LOM[5] = 30; //Av
			LOM[6] = 29; //Elul
			LOM[7] = 30; //Tishri
			LOM[8] = 29; //Heshvan
			LOM[9] = 29; //Kislev
			LOM[10] = 29; //Tevet
			LOM[11] = 30; //Shevat
			LOM[12] = 29; //Adar
			LOM[13] = 29; //Vedar
			//Load up table of Hebrew Year types
			TypeYear[1] = "Common Deficient (353 days)";
			TypeYear[2] = "Common Regular (354 days)";
			TypeYear[3] = "Common Complete (355 days)";
			TypeYear[4] = "Embolismic Deficient (383 days)";
			TypeYear[5] = "Embolismic Regular (384 days)";
			TypeYear[6] = "Embolismic Complete (385 days)";
			//Load up table of Hebrew month names
			HMonthName[1] = "Nisan";
			HMonthName[2] = "Iyar";
			HMonthName[3] = "Sivan";
			HMonthName[4] = "Tammuz";
			HMonthName[5] = "AV";
			HMonthName[6] = "Elul";
			HMonthName[7] = "Tishri";
			HMonthName[8] = "Heshvan";
			HMonthName[9] = "Kislev";
			HMonthName[10] = "Tevet";
			HMonthName[11] = "Shevat";
			HMonthName[12] = "Adar";
			HMonthName[13] = "Vedar";
			SHMonthName[1] = "Nisan   ";
			SHMonthName[2] = "Iyar    ";
			SHMonthName[3] = "Sivan   ";
			SHMonthName[4] = "Tammuz  ";
			SHMonthName[5] = "AV      ";
			SHMonthName[6] = "Elul    ";
			SHMonthName[7] = "Tishri  ";
			SHMonthName[8] = "Heshvan ";
			SHMonthName[9] = "Kislev  ";
			SHMonthName[10] = "Tevet   ";
			SHMonthName[11] = "Shevat  ";
			SHMonthName[12] = "Adar    ";
			SHMonthName[13] = "Vedar   ";
			//Load up table of Biblical Month Names
			BMonthName[1] = "Abib";
			BMonthName[2] = "Second";
			BMonthName[3] = "Third";
			BMonthName[4] = "Fourth";
			BMonthName[5] = "Fifth";
			BMonthName[6] = "Sixth";
			BMonthName[7] = "Seventh";
			BMonthName[8] = "Eighth";
			BMonthName[9] = "Ninth";
			BMonthName[10] = "Tenth";
			BMonthName[11] = "Eleventh";
			BMonthName[12] = "Twelfth";
			BMonthName[13] = "Thirteenth";
			BDayName[0] = "First";
			BDayName[1] = "Second";
			BDayName[2] = "Third";
			BDayName[3] = "Fourth";
			BDayName[4] = "Fifth";
			BDayName[5] = "Sixth";
			BDayName[6] = "Sabbath";
			//Load up table of Gregorian Month Names
			MonthName2[1] = "January";
			MonthName2[2] = "February";
			MonthName2[3] = "March";
			MonthName2[4] = "April";
			MonthName2[5] = "May";
			MonthName2[6] = "June";
			MonthName2[7] = "July";
			MonthName2[8] = "August";
			MonthName2[9] = "September";
			MonthName2[10] = "October";
			MonthName2[11] = "November";
			MonthName2[12] = "December";
			SMonthName[1] = "JAN";
			SMonthName[2] = "FEB";
			SMonthName[3] = "MAR";
			SMonthName[4] = "APR";
			SMonthName[5] = "MAY";
			SMonthName[6] = "JUN";
			SMonthName[7] = "JUL";
			SMonthName[8] = "AUG";
			SMonthName[9] = "SEP";
			SMonthName[10] = "OCT";
			SMonthName[11] = "NOV";
			SMonthName[12] = "DEC";
			//Load up table of Day Names
			DayName2[0] = "Sunday";
			DayName2[1] = "Monday";
			DayName2[2] = "Tuesday";
			DayName2[3] = "Wednesday";
			DayName2[4] = "Thursday";
			DayName2[5] = "Friday";
			DayName2[6] = "Saturday";
			SDayName[0] = "SUN";
			SDayName[1] = "MON";
			SDayName[2] = "TUE";
			SDayName[3] = "WED";
			SDayName[4] = "THU";
			SDayName[5] = "FRI";
			SDayName[6] = "SAB";
			//Load up array with flags of what years in the 19 year cycle are leap years.
			//0 = common and 1 = leap year
			YR[1] = 0;
			YR[2] = 0;
			YR[3] = 1; //Leap
			YR[4] = 0;
			YR[5] = 0;
			YR[6] = 1; //Leap
			YR[7] = 0;
			YR[8] = 1; //Leap
			YR[9] = 0;
			YR[10] = 0;
			YR[11] = 1; //Leap
			YR[12] = 0;
			YR[13] = 0;
			YR[14] = 1; //Leap
			YR[15] = 0;
			YR[16] = 0;
			YR[17] = 1; //Leap
			YR[18] = 0;
			YR[19] = 1; //Leap
		}

		internal static double JD1stOfTishri(int YearNum)
		{
			//Finds the Julian Day count for the 1st of Tishri for the given Gregorian Year Number.
			//Algorithm is found in Astronomical Algorithms Second Edition by Jean Meeus pages 71 and 72.

			double B = 0; //= B in book
			int MonthNum = 3; //= Number of Month //Start with March
			double x = YearNum; //= X in book
			//*******************************************************************************
			if (x <= 0)
			{
				x++;
			} //fix for year zero
			//*******************************************************************************
			double C = Math.Floor(x / 100d); //= C in book
			double S = Math.Floor(((3 * C) - 5) / 4d); //= S in book
			double A = x + 3760; //= A in book
			//lca = a, lcb = b  can't have A and a in the same program so I had to make new variable names.
			double lca = Convert.ToInt32(Math.Floor((12 * x) + 12)) % 19; //= a in book is the lower case a //a = [12X + 12]sub 19 (leap, before or after a leap year?)
			if (lca < 0)
			{
				lca += 19;
			} //Fix up for mod of negative numbers
			//*******************************************************************************
			double lcb = Convert.ToInt32(x) % 4; //= b in book is the lower case b //b = [X]sub 4
			if (lcb < 0)
			{
				lcb += 4;
			} //Fix up for mod of negative numbers
			//*******************************************************************************
			//Continue on page 72 from here.
			// If X < 1583 Then S = 0        'Makes the program run incorrectly on negative years.
			double Q = -1.904412361576d + (1.554241796621d * lca) + (0.25d * lcb) - (0.003177794022d * x) + S; //= Q in book
			double j = Convert.ToInt32(Math.Floor(Math.Floor(Q) + (3 * x) + (5 * lcb) + 2 - S)) % 7; //= j in book
			if (j < 0)
			{
				j += 7;
			} //Fix up for mod of negative numbers
			//*******************************************************************************
			double r = Q - Math.Floor(Q); //= r in book

			//Do the postponement rules
			//1. Postpone Rosh HaShanah to the next allowable weekday if the molad of Tishrei is on
			//   or after noon.
			//2. Postpone Rosh HaShanah to the next day if the molad of Tishrei is on Sunday,
			//   Wednesday or Friday.
			//3. Postpone Rosh Hashanah to Thursday when the molad of Tishrei for a non-leap year
			//   (12 months) is on Tuesday on or after 9 hours and 204 parts.
			//4. Postpone Rosh Hashanah to Tuesday when the molad of Tishrei for a leap year
			//   (13 months) is on Monday on or after 15 hours and 589 parts.

			//When lca < 7 the year can be either 2, 5, 7, 10, 13, 16 or 18 in the 19 year cycle, common.
			//When lca > 11 the Hebrew year is leap, and molad >= (21h + 589p)/24h (15 hours and 589p)
			//The 0.63287037 is equivalent to (15h + 204p)/24h. (9 hours and 204 parts)
			//Similarly, the 0.897723765 = (21h + 589p)/24h     (15 hours and 589 parts)

			//j = Day of Molad
			//0 = Monday
			//1 = Tuesday
			//2 = Wednesday
			//3 = Thursday
			//4 = Friday
			//5 = Saturday
			//6 = Sunday

			double D = Math.Floor(Q) + 22; //= D in book
			if (j == 2 || j == 4 || j == 6)
			{
				D = Math.Floor(Q) + 23;
			} //2 Wed or Fri or Sun
			if (j == 1 && lca > 6 && r >= 0.63287037d)
			{
				D = Math.Floor(Q) + 24;
			} //3 Tues, common, >= 9H 204P
			if (j == 0 && lca > 11 && r >= 0.897723765d)
			{
				D = Math.Floor(Q) + 23;
			} //4 Mon, leap, >= 15H 589P

			//Check to see if month is still March if not then advance month and continue
			if (D > 31)
			{ //If day is greater than length of month of March then month is April.
				D -= 31; //Take off days for March
				MonthNum++; //Advance from March to April
				//Had to add this to make program work farther into the future.
				if (D > 30)
				{ //If day is greater than length of month of April then month is May.
					D -= 30; //Take off days for April
					MonthNum++; //Advance from April to May
				}
			}
			modBiblcalFunctions.JD = ConvertToJulian2(MonthNum, D, YearNum); //Get the Julian day count for 15 Nisan.
			modBiblcalFunctions.JD += 163; //Get Julian day count for 1st of Tishri
			return modBiblcalFunctions.JD; //Return the result
		}

		internal static int LengthOfYear(int YearNum)
		{
			//Returns the length of the Hebrew year given Gregorian Year Number for a Hebrew year.


			double ThisYear = JD1stOfTishri(YearNum); //Julian Day count for start of this year //Julian Day count for the 1st of Tishri this year
			double NextYear = JD1stOfTishri(YearNum + 1); //Julian Day count for start of next year //Julian Day count for the 1st of Tishri next year
			return Convert.ToInt32(NextYear - ThisYear); //Difference is number of days
		}

		internal static int TypeOfYear(int YearNum)
		{
			//Gives the type of Hebrew Year for a given Gregorian Year number
			//returns integer for the type.
			//Also loads up the proper number of days in the three changed months for each type.
			//Type 1 is Common Deficient
			//Type 2 is Common Regular
			//Type 3 is Common Complete
			//Type 4 is Embolismic Deficient
			//Type 5 is Embolismic Regular
			//Type 6 is Embolismic Complete


			int result = 0;
			int DaysInYear = LengthOfYear(YearNum); //Number of days in Hebrew year
			if (DaysInYear == 353)
			{
				result = 1; //Common Deficient (353 days)
				LOM[8] = 29; //Heshvan
				LOM[9] = 29; //Kislev
				LOM[12] = 29; //Adar
			}
			else if (DaysInYear == 354)
			{ 
				result = 2; //Common Regular (354 days)
				LOM[8] = 29; //Heshvan
				LOM[9] = 30; //Kislev
				LOM[12] = 29; //Adar
			}
			else if (DaysInYear == 355)
			{ 
				result = 3; //Common Complete (355 days)
				LOM[8] = 30; //Heshvan
				LOM[9] = 30; //Kislev
				LOM[12] = 29; //Adar
			}
			else if (DaysInYear == 383)
			{ 
				result = 4; //Embolismic Deficient (383 days)
				LOM[8] = 29; //Heshvan
				LOM[9] = 29; //Kislev
				LOM[12] = 30; //Adar
			}
			else if (DaysInYear == 384)
			{ 
				result = 5; //Embolismic Regular (384 days)
				LOM[8] = 29; //Heshvan
				LOM[9] = 30; //Kislev
				LOM[12] = 30; //Adar
			}
			else if (DaysInYear == 385)
			{ 
				result = 6; //Embolismic Complete (385 days)
				LOM[8] = 30; //Heshvan
				LOM[9] = 30; //Kislev
				LOM[12] = 30; //Adar
			}

			return result;
		}

		internal static double StartOfMonth(int Month, int YearNum)
		{
			//Finds the Julian day for the start of a given Hebrew Month and Gregorian Year Number.
			//Months start with Nisan = 1
			double result = 0;
			int Index = 0; //Index to go through the months

			result = JD1stOfTishri(YearNum) - 177; //Get JD for start of Nisan
			int TOY = TypeOfYear(YearNum); //Only used to run the function //Set up month lengths and get type of year
			int tempForEndVar = Month - 1;
			for (Index = 1; Index <= tempForEndVar; Index++)
			{ //Add lengths of each month together
				result += LOM[Index]; //LOM(Index) is the length of that month
			}
			return result;
		}

		internal static int NumberOfMonths(int YearNum)
		{
			//Returns the number of months in a Hebrew year, given it's Gregorian year number.


			int TOY = TypeOfYear(YearNum); //Type of Hebrew year 1, 2 and 3 are Common, 4, 5 and 6 are Leap
			if (TOY == 1 || TOY == 2 || TOY == 3)
			{ //If Common year then 12 months
				return 12;
			}
			else
			{
				return 13; //else 13 months
			}
		}

		//The Jean Meeus formula 7.1 pages 60 - 61 of Astronomical Algorithms Second Edition
		//Convert from Gregorian date to Julian day number.
		internal static double ConvertToJulian2(int MonthNum, double DayNum, double YearNum)
		{
			double result = 0;
			double C = 0; //In the book
			double E = 0; //In the book
			double F = 0; //In the book

			int TempYear = Convert.ToInt32(YearNum); //Temporary storage for Gregorian Year number
			//*********************************************************************************
			//Fix for year zero added by DDD to make it work for this program
			if (YearNum <= 0)
			{
				YearNum++;
			}
			//*********************************************************************************
			if (MonthNum < 3)
			{
				YearNum--;
				MonthNum += 12;
			}
			//The following 'If - Then' statement is not used with our type of Gregorian calendar
			//If YearNum + (MonthNum / 100) + (DayNum / 10000) >= 1582.1015 Then 'In the Gregorian calendar!
			double A = Math.Floor(YearNum / 100d); //In the book
			double B = Math.Floor(2 - A + Math.Floor(A / 4d)); //In the book
			//Else
			// B = 0                                                     'Not in the Gregorian Calendar
			//End If
			result = Math.Floor(365.25d * (YearNum + 4716)) + Math.Floor(30.6001d * (MonthNum + 1)) + DayNum + B - 1524.5d;
			YearNum = TempYear;
			return result;
		}

		//The Jean Meeus page 63 of Astronomical Algorithms Second Edition
		//Converts Julian day number to Gregorian Month, Day and Year
		//On entry JD = Julian Date.
		//On exit MHString = month, DAString = day, GregorianYearString = year
		internal static void JulianToMDY2()
		{
			double MonthNum = 0; //Number of Month of year
			int LengthNumber = 0; //Length of Gregorian Year String
			double GregorianYear = 0; //Number of Gregorian Year

			double TempJD = modBiblcalFunctions.JD; //Temporary storage for Julian Day Count //Save the value of JD
			modBiblcalFunctions.JD += 0.5d;
			double Z = Math.Floor(modBiblcalFunctions.JD); //In the book
			double F = modBiblcalFunctions.JD - Z; //In the book
			//If Z < 2299161 Then    'Correction for Gregorian calendar inception date not used here.
			// A = Z
			//Else
			double Alpha = Math.Floor((Z - 1867216.25d) / 36524.25d); //In the book but printed in Greek
			double A = Z + 1 + Alpha - Math.Floor(Alpha / 4d); //In the book
			//End If
			double B = A + 1524; //In the book
			double C = Math.Floor((B - 122.1d) / 365.25d); //In the book
			double D = Math.Floor(365.25d * C); //In the book
			double E = Math.Floor((B - D) / 30.6001d); //In the book
			double DayNum = Math.Round((double) (B - D - Math.Floor(30.6001d * E) + F), 2); //Number of Day of month //Correct for fractional error
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
			DayNum = Math.Floor(DayNum);
			modBiblcalFunctions.DAString = Conversion.Str(DayNum);
			modBiblcalFunctions.MHString = Conversion.Str(MonthNum);
			//*********************************************************************************
			//Fix for year zero added to make this program work correctly
			if (GregorianYear <= 0)
			{
				GregorianYear--;
			}
			//*********************************************************************************
			modBiblcalFunctions.GregorianYearString = GregorianYear.ToString();
			if (Conversion.Val(modBiblcalFunctions.MHString) < 10)
			{
				modBiblcalFunctions.MHString = "0" + modBiblcalFunctions.MHString.Substring(Math.Max(modBiblcalFunctions.MHString.Length - (Strings.Len(modBiblcalFunctions.MHString) - 1), 0));
			}
			if (Conversion.Val(modBiblcalFunctions.DAString) < 10)
			{
				modBiblcalFunctions.DAString = "0" + modBiblcalFunctions.DAString.Substring(Math.Max(modBiblcalFunctions.DAString.Length - (Strings.Len(modBiblcalFunctions.DAString) - 1), 0));
			}
			if (Strings.Len(modBiblcalFunctions.DAString) > 2)
			{
				modBiblcalFunctions.DAString = modBiblcalFunctions.DAString.Substring(Math.Max(modBiblcalFunctions.DAString.Length - (Strings.Len(modBiblcalFunctions.DAString) - 1), 0));
			}
			if (Strings.Len(modBiblcalFunctions.MHString) > 2)
			{
				modBiblcalFunctions.MHString = modBiblcalFunctions.MHString.Substring(Math.Max(modBiblcalFunctions.MHString.Length - (Strings.Len(modBiblcalFunctions.MHString) - 1), 0));
			}
			modBiblcalFunctions.GregorianYearString = Conversion.Val(GregorianYear.ToString()).ToString();
			if (GregorianYear < 0)
			{ //Determine what padding is needed for 'Year' number
				LengthNumber = 5;
			}
			else
			{
				LengthNumber = 4;
			}
			while (Strings.Len(modBiblcalFunctions.GregorianYearString) < LengthNumber)
			{ //Pad the 'Year' so it is always the same length.
				if (GregorianYear >= 0)
				{
					modBiblcalFunctions.GregorianYearString = "0" + modBiblcalFunctions.GregorianYearString;
				}
				else
				{
					modBiblcalFunctions.GregorianYearString = "-0" + modBiblcalFunctions.GregorianYearString.Substring(Math.Max(modBiblcalFunctions.GregorianYearString.Length - (Strings.Len(modBiblcalFunctions.GregorianYearString) - 1), 0));
				}
			}
			modBiblcalFunctions.JD = TempJD; //Restore value for JD
		}

		internal static void Jd_To_Julian(double JD, ref int Year, ref int Month, ref int Day)
		{

			//Converts Julian Day Count to Julian Calendar Date.


			JD += 0.5d;
			double Z = Math.Floor(JD);
			double A = Z;
			double B = A + 1524;
			modBiblcalFunctions.C = Math.Floor((B - 122.1d) / 365.25d);
			modBiblcalFunctions.D = Math.Floor(365.25d * modBiblcalFunctions.C);
			double E = Math.Floor((B - modBiblcalFunctions.D) / 30.6001d);
			Day = Convert.ToInt32(Math.Round((double) (B - modBiblcalFunctions.D - Math.Floor(30.6001d * E)), 2)); //Correct for fractional error
			if (Math.Floor(E) < 14)
			{
				E--;
			}
			else
			{
				E -= 13;
			}
			Month = Convert.ToInt32(Math.Floor(E));
			if (((((double) Month) > 0) ? Math.Floor((double) Month) : Math.Ceiling((double) Month)) > 2)
			{
				modBiblcalFunctions.C -= 4716;
			}
			else
			{
				modBiblcalFunctions.C -= 4715;
			}
			Year = Convert.ToInt32(Math.Floor(modBiblcalFunctions.C));

			if (Year < 1)
			{
				Year--;
			} //Fix up for having no year zero

		}

		internal static double Julian_To_Jd(int Year, int Month, int Day)
		{

			//Converts Julian Date to Julian Day Number

			if (Year < 1)
			{
				Year++;
			} //Fix up negative years for non zero notation

			// Algorithm found in Meeus, Astronomical Algorithms, Chapter 7, page 61

			if (Month <= 2)
			{
				Year--;
				Month += 12;
			}

			return Math.Floor(365.25d * (Year + 4716)) + Math.Floor((30.6001d * (Month + 1)) + Day) - 1524.5d;
		}


		internal static bool GregorianLeapYear(ref int YearNum)
		{
			//Determines if it is a Gregorian Leap Year, returns True if so and False if not

			bool result = false;
			int TempYear = YearNum; //Temporary storage for Gregorian Year
			if (YearNum < 0)
			{
				YearNum++;
			} //Fix for year zero
			int Remainder = YearNum % 4; //Remainder of Mod function //Is the year divisible by 4 evenly?
			if (Remainder < 0)
			{
				Remainder += 4;
			} //Fix for negative Mod problem
			result = Remainder == 0;
			if (Conversion.Val(Conversion.Str(YearNum).Substring(Math.Max(Conversion.Str(YearNum).Length - 2, 0))) == 0)
			{ //Is it a century year?
				Remainder = YearNum % 400; //Is the year divisible by 400 evenly?
				if (Remainder < 0)
				{
					Remainder += 400;
				} //Fix for negative Mod problem
				result = Remainder == 0;
			}
			YearNum = TempYear;
			return result;
		}

		internal static bool HebrewLeapYear(double iYear)
		{
			//Determines if it is a Hebrew Leap Year, returns True of so and False if not
			//Input is a Hebrew year number

			int ModResult = Convert.ToInt32((Convert.ToInt32((7 * iYear) + 1)) % 19);
			if (ModResult < 0)
			{
				ModResult += 19;
			} //Fix up for negative mod problem
			return ModResult < 7;
		}

		internal static object JDToHebrew(double JD, ref int hMonth, ref int hDay, ref double HYear)
		{
			//Converts from Julian Day count to Hebrew Date

			double TempJD = JD; //Temporary storage for Julian Day Count //Save value of Julian Day Count
			JulianToMDY2(); //Get the Gregorian Year
			int GYear = Convert.ToInt32(Conversion.Val(modBiblcalFunctions.GregorianYearString)); //Gregorian Year
			JD = StartOfMonth(1, GYear); //Get start of month of Nisan using the Gauss algorithm
			while (JD > TempJD)
			{ //If past the year, go back a year till it is before
				GYear--;
				JD = StartOfMonth(1, GYear);
			}
			int Index = 1; //Index to step through Hebrew month lengths
			while (JD < TempJD)
			{ //Count months till past date
				JD += LOM[Index]; //Add month lengths till past Julian Day count
				Index++; //Advance to next month
			}
			if (JD > TempJD)
			{ //If this was not the first of the month then
				hMonth = Index - 1;
				JD -= LOM[hMonth]; //Take the length of this month away
			}
			else
			{
				hMonth = Index; //Must be the 1st of this month
			}
			if (GYear <= 0)
			{
				GYear++;
			} //Fix for Gregorian year zero
			if (hMonth < 7)
			{ //If before Tishri then this year
				HYear = GYear + 3760; //Calculate the Hebrew month year
			}
			else
			{
				HYear = GYear + 3761; //It's in the next Hebrew month year.
			}
			hDay = Convert.ToInt32(TempJD - JD + 1); //Take away the difference to get date and add 1 to get in the month.
			JD = TempJD; //Restore value for Julian Day Count
			return null;
		}

		internal static double HebrewToJD(int hMonth, int hDay, int HYear)
		{
			//Computes the Julian Day count for a Hebrew date.
			//hMonth, hDay and hYear are Hebrew dates
			int GYear = 0; //Gregorian Year

			if (hMonth > 6)
			{ //Adjust Gregorian year for Hebrew month
				GYear = HYear - 3761;
			}
			else
			{
				GYear = HYear - 3760; //Get Gregorian year
			}
			if (GYear <= 0)
			{
				GYear--;
			} //Adjust Gregorian year for zero or negative
			modBiblcalFunctions.JD = StartOfMonth(hMonth, GYear); //Get Start of that month
			modBiblcalFunctions.JD = modBiblcalFunctions.JD + hDay - 1; //Add the remaining days less the first day of month
			return modBiblcalFunctions.JD; //Return the Julian Day number
		}

		internal static double MoladOfTishri(int GYear, ref double Weeks, ref double Days, ref double Hours, ref double Parts)
		{
			//Calculates the Molad of the first of Tishri for a given Gregorian Year
			//answer is placed in Global Variables, (Weeks, Days, Hours and Parts)

			double result = 0;
			int Index = 0; //Index to point at array of leap year flags
			double Common = 0; //Number of Common years left over
			double Leap = 0; //Number of Leap years left over

			double TempJD = modBiblcalFunctions.JD; //Temporary storage for Julian Count Number //Save the Julian Count Number
			//Hebrew year 3760 = 0 if not using Gregorian Calendar
			int HYear = GYear + 3760; //The Year Number for Hebrew Year //Calculate the Hebrew year

			//Calculate parts of a cycle
			double Remainder = HYear % 19; //Number of years left over from 19 year cycles //Get the odd number of years from the 19 year cycles
			if (Remainder < 0)
			{
				Remainder += 19;
			} //Fix for negative MOD problem

			//Calculate how many cycles
			double Cycles = Math.Floor(HYear / 19d); //Number of whole Cycles since creation //Get the number of whole cycles since creation

			//Get 235 months for each cycle, cycles have (991W 2D 16H 595P)
			Weeks = Cycles * 991;
			Days = Cycles * 2;
			Hours = Cycles * 16;
			Parts = Cycles * 595;

			//Find out how many common and leap years are left from the left over years from cycles
			double tempForEndVar = Remainder;
			for (Index = 1; Index <= tempForEndVar; Index++)
			{
				if (YR[Index] == 0)
				{
					Common++; //Get the number of Common years
				}
				else
				{
					Leap++; //Get the number of Leap years
				}
			}

			//********** Add the Common years, Common years have (50W 4D 8H 876P)difference
			Weeks += (Common * 50);
			Days += (Common * 4);
			Hours += (Common * 8);
			Parts += (Common * 876);

			//********** Add the Leap years, Leap years have (54W 5D 21H 589P)difference
			Weeks += (Leap * 54);
			Days += (Leap * 5);
			Hours += (Leap * 21);
			Parts += (Leap * 589);
			//*********************************************************************

			//********** Add Molad for year of creation   (2D 5H 204P) = Monday at 5 hours and 204 parts
			Days += 2;
			Hours += 5;
			Parts += 204;
			//*********************************************************************

			//Reduce to lowest terms
			Remainder = Convert.ToInt32(Parts) % 1080; //Do the parts, 1080 parts per hour
			if (Remainder < 0)
			{
				Remainder += 1080;
			} //Fix for negative MOD
			Parts = Math.Floor(Parts / 1080d); //Get the whole hours
			Hours += Parts; //Add them to the hours
			Parts = Remainder; //Keep Remainder as parts

			Remainder = Convert.ToInt32(Hours) % 24; //Do the Hours, 24 hours per day
			if (Remainder < 0)
			{
				Remainder += 24;
			} //Fix for negative MOD
			Hours = Math.Floor(Hours / 24d); //Get the whole days
			Days += Hours; //Add them to the days
			Hours = Remainder; //Keep the Remainder as Hours

			Remainder = Convert.ToInt32(Days) % 7; //Do the Days, 7 days per week
			if (Remainder < 0)
			{
				Remainder += 7;
			} //Fix for negative MOD
			Days = Math.Floor(Days / 7d); //Get the Whole weeks
			Weeks += Days; //Add them to the weeks
			Days = Remainder; //Keep the Remainder as Days
			//Here ends the finding of the Molad
			//****************************************************************************************
			//The following is just for information and not part of this program
			//To find the Julian Day Count for this Molad you multiply the Molad Weeks by 7 to get
			//the number of days then add the Molad Days and then add 347995.5
			//347995.5 is The actual Julian Day count for two days before the 1st of Tishri Hebrew Year 1
			modBiblcalFunctions.RabbinicJD = (((Weeks * 7) + Days) + 347995.5d) + (Hours / 24d) + (Parts / 25920d);
			result = modBiblcalFunctions.RabbinicJD;
			//This gives the actual Julian Day count for the Molad  You then need to add the postponement
			//days if there are any to get the actual Julian Count for the computed 1st of Tishri.
			//*******************************************************************************************
			//This will convert that Julian Day count back to Weeks, Days, Hours and Parts
			//Dim W As Double
			//Dim D As Double
			//Dim H As Double
			//Dim P As Double
			//W = Fix((JD - 347995.5) / 7)
			//D = (JD - 347995.5) - (W * 7)
			//H = Fix(((JD - 347995.5) - Fix(JD - 347995.5)) * 24)
			//P = Round(((((JD - 347995.5) - Fix(JD - 347995.5)) * 24) - Fix(((JD - 347995.5) _
			//'              - Fix(JD - 347995.5)) * 24)) * 1080, 0)
			modBiblcalFunctions.JD = TempJD; //Restore the Julian Day Number
			return result;
		}

		//This subroutine checks the postponement rules from the Molad of Tishri

		//To further understand these rules see Example 2 on this web site:
		//http://www.shirhadash.org/calendar/abouthcal.html

		//These rules were copied from this web site:
		//http://www.jewfaq.org/calendr2.htm

		//Example: Gregorian Year 2000 = Hebrew 5761
		//         The Molad of Tishri = 5D 19H 310P  this would be 5D and fall on a Thursday
		//         Rule 1 shows how 19H is > 18 hours, so day is postponed to Friday
		//         Rule 2 does not apply because Molad fell on Thursday not Tuesday
		//         Rule 3 does not apply because Molad did not fall on a Monday
		//         Rule 5 shows how Friday can't work so day is postponed to Sabbath
		//
		//Example: Gregorian Year 30 = Hebrew Year 3791
		//         The Molad of Tishri = 0D 8H 352P this would be 0D and fall on a Sabbath
		//         Rule 1 does not apply because 8H is not greater than 18H
		//         Rule 2 does not apply because it does not fall on a Tuesday
		//         Rule 3 does not apply because it does not fall on a Monday
		//         Rule 4 does not apply because it does not fall on Sunday, Wednesday or Friday
		//
		//Example: Gregorian Year 31 = Hebrew Year 3792
		//        The Molad of Tishri = 4D 17H 148P this would be 4D and fall on a Wednesday
		//        Rule 1 does not apply because Hours are less than noon
		//        Rule 2 does not apply because it does not fall on a Tuesday
		//        Rule 3 does not apply because it did not fall on a Monday
		//        Rule 4 applies because it fell on a Wednesday so day is postponed to Thursday
		//
		//Molad day number corresponds with these days of the week
		//0 = Sabbath
		//1 = Sunday
		//2 = Monday
		//3 = Tuesday
		//4 = Wednesday
		//5 = Thursday
		//6 = Friday

		//Postponement Rules
		//Rule 1)- Dechiyah 1: (Molad Zakein)
		//First, if the time of the Molad Tishrei is later than 18 hours from the beginning of the day,
		//Rosh HaShanah (Feast Of Trumpets) is postponed to the next day. This probably accounts for the fact that the
		//young moon could not have been observed until the next day.

		//Rule 2) - Dechiyah 3: (Gatarad) (Is not combined with Rule 1)
		//Second, for common years only, if the Molad Tishrei falls on a Tuesday, and is later than
		//9 hours and 204 halakhim from the start of the day, Rosh HaShanah (Feast of Trumpets) is
		//postponed to the next day. This rule prevents a situation in which the postponements for
		//the next year would require the year to be 356 days long.

		//Rule 3)- Dechiyah 4: (Betutkafot) (Is not combined with Rule 1)
		//Third, for years following leap years only, if the Molad Tishrei falls on a Monday,
		//and is later than 15 hours and 589 halakhim from the start of the day, Rosh HaShanah
		//(Feast Of Trumpets) is postponed to Tuesday. This rule prevents a situation that would
		//require the previous year to be only 382 days long.

		//Rule 4)- Dechiyah 2: (Lo A"DU Rosh) (Is combined with Rule1 or Rule2, Rule3 does not apply)
		//Finally, if Rosh HaShanah (Feast Of Trumpets) would fall on Sunday, Wednesday, or Friday, it
		//is postponed to the next day. In combination with one of the above postponements
		//(Rule 1 or Rule 2), Rosh HaShanah (Feast Of Trumpets) could be postponed by as much as two
		// days. This postponement prevents certain holidays from falling on the Sabbath.

		internal static void CheckRules(int HYear, int MoladDays, int MoladHours, int MoladParts, ref bool Rule1, ref bool Rule2, ref bool Rule3, ref bool Rule4)
		{

			//Checks the rules and adds the appropriate days to the Julian Day count.
			//Also sets the Rule flags and finds the day of the week.
			//To check these rules and how they work look at Example 2 of this web site:
			//http://www.shirhadash.org/calendar/abouthcal.html


			double TempJD = modBiblcalFunctions.JD; //Temporary storage for the Julian Day Count //Store the Julian Day Count
			Rule1 = false;
			Rule2 = false;
			Rule3 = false;
			Rule4 = false;
			int DOW = MoladDays; //Day of week //Make Day of week start out on the Molad day

			//Rule 1 is (Molad Zakein)
			if (MoladHours >= 18)
			{ //Check Rule 1 - (Molad Zakein)
				if (MoladHours == 18 && MoladParts > 0)
				{
					Rule1 = true;
				}
				if (MoladHours > 18)
				{
					Rule1 = true;
				}
			}
			if (Rule1)
			{
				DOW++; //Advance the Day of Week if Rule1 was used
				modBiblcalFunctions.RabbinicJD++; //Advance the Julian Day Count
			}

			//Rule 2 is (Gatarad)
			if (!Rule1)
			{ //Rules 2 and 3 are not combined with Rule 1
				if (!HebrewLeapYear(HYear))
				{ //Check Rule 2 - (Gatarad) (Tuesday to Wednesday)
					if (MoladDays == 3)
					{ //If Tuesday
						if (MoladHours == 9)
						{ //if Hour is 9
							if (MoladParts > 204)
							{
								Rule2 = true;
							} //and Parts are greater than 204
						}
						if (MoladHours > 9)
						{
							Rule2 = true;
						} //or Hour is greater than 9
					}
				}

				//Rule 3 Is (Betutkafot)
				if (HebrewLeapYear(HYear - 1))
				{ //Check Rule 3 - (Betutkafot)
					if (MoladDays == 2)
					{ //If Monday
						if (MoladHours == 15)
						{ //and Hour is 15
							if (MoladParts > 589)
							{
								Rule3 = true;
							} //and Parts are greater than 589
						}
						if (MoladHours > 15)
						{
							Rule3 = true;
						} //or Hour is greater than 15
					}
				}
			}

			if (Rule2)
			{
				DOW++; //If Rule 2 then add one day to make it Wednesday
				modBiblcalFunctions.RabbinicJD++; //Advance the Julian Day Count
			}

			if (Rule3)
			{
				DOW++; //If Rule 3 then add one day to make it Tuesday
				modBiblcalFunctions.RabbinicJD++; //Advance the Julian Day Count
			}

			//Rule 4 is (Lo A"DU Rosh)
			if (DOW == 1 || DOW == 4 || DOW == 6)
			{ //Check Rule 4 - (Lo A"DU Rosh) (Sun, Wed or Fri)
				Rule4 = true;
				DOW++; //Advance the Day of Week if Rule 4 was used
				modBiblcalFunctions.RabbinicJD++; //Advance the Julian Day Count
			}

			modBiblcalFunctions.JD = Math.Round((double) modBiblcalFunctions.RabbinicJD, 1); //Give the final Julian Day Count
			modBiblcalFunctions.JD = TempJD; //Restore Julian Day Count because we don't use
			//the one calculated here.
		}
	}
}