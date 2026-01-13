using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.Helpers;

namespace BiblCal
{
	internal static class modFlood
	{

		internal static void DoFlood()
		{
			object txtWorking = null;
			//Calclates the number of days between 17th of 2nd Month and the 17th of the 7th month
			//to see if there are 150 days as per the flood scriptures.
			int TT = 0; //+1 or -1 Offset from 150 day may be in 2nd month
			int TU = 0; //+1 or -1 Offset from 150 day may be in 7th month
			double ZA = 0; //First date = 17th of second month
			double ZW = 0; //Number of days between dates
			double ZX = 0; //Possible early or late date of first month
			double ZY = 0; //Possible early or late date of second month
			float Year2 = 0; //Year to end with
			string Year1String = ""; //String containing year to start with
			string Year2String = ""; //String containing year to end with
			float[] OneFifty = new float[401]; //Array containing years with exactly 150
			float[] PlusOne = new float[401]; //Array containing years with 149 + 1
			float[] PlusTwo = new float[41]; //Array containing years with 148 + 2
			int MaxResults = 0; //Maximum number in the three arrays.
			int ArrayIndex = 0; //Index pointer for 'For Next' statement
			int WorkingCount = 0; //Count to make 'WORKING' indicator flash
			//---------------------------------------------------------------------------------------
			modBiblcalFunctions.FloodFlag = true; //Tell other subroutines this is a Flood run.
			frmHolyDays.DefInstance.chkEJW.CheckState = CheckState.Unchecked;
			frmHolyDays.DefInstance.txtOut.Text = "";
			float IndexOneFifty = 0; //Index for array containing exactly 150
			float IndexPlusOne = 0; //Index for array containing 149 + 1
			float IndexPlusTwo = 0; //Index for array containing 148 + 2
			modBiblcalFunctions.RangeCheckGregorianYear();
			float Year1 = (float) modBiblcalFunctions.GregorianYear; //Year to start with
			if (frmHolyDays.DefInstance.txtYear2.Text == "")
			{ //If there is no second year, just do one pass.
				Year2 = Year1;
			}
			else
			{
				//else make a table.
				Year2 = (float) Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text);
				if (Year2 < -4004)
				{ //Correct for Year entries less than -4004
					Year2 = -4004;
					frmHolyDays.DefInstance.txtYear2.Text = "-4004";
				}
				if (Year2 == 0)
				{ //Correct for there being no year Zero
					Year2 = -1;
					frmHolyDays.DefInstance.txtYear2.Text = "-1";
				}
				if (Year2 > 9999)
				{ //Correct for too big of a year
					Year2 = 9999;
					frmHolyDays.DefInstance.txtYear2.Text = "9999";
				}
			}
			if (Year2 < ((float) modBiblcalFunctions.GregorianYear))
			{ //Swap years if they are reversed.
				frmHolyDays.DefInstance.txtYear.Text = Year2.ToString();
				frmHolyDays.DefInstance.txtYear2.Text = Year1.ToString();
				Year1 = (float) Conversion.Val(frmHolyDays.DefInstance.txtYear.Text);
				Year2 = (float) Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text);
			}
			//If printing a table, we don't want to print all the years so we turn off the PrintFlag
			if (Year2 > Year1)
			{
				modBiblcalFunctions.PrintFlag = false; //Disable printing for Table
				frmHolyDays.DefInstance.txtWorking.Visible = true;
				frmHolyDays.DefInstance.cmdFlood.Enabled = false;
				Application.DoEvents(); //Allow processing while in the Loop
			}
			else
			{
				modBiblcalFunctions.PrintFlag = true; //One pass only print intermediate results.
			}
			float tempForEndVar = Year2;
			for (modBiblcalFunctions.GregorianYear = Year1; ((float) modBiblcalFunctions.GregorianYear) <= tempForEndVar; modBiblcalFunctions.GregorianYear++)
			{ //Check from the first year to the last year
				if (modBiblcalFunctions.GregorianYear == 0)
				{
					modBiblcalFunctions.GregorianYear = 1;
				}
				modBiblcalFunctions.LG = -44.32d;
				modBiblcalFunctions.LT = 39.69d;
				modBiblcalFunctions.HR = 14; //Location of Mount Ararat
				modBiblcalFunctions.InitializeVariables();
				modBiblcalFunctions.LY = modBiblcalFunctions.GregorianYear + 0.265d; //bga- selects which new moon to start testing for year, was 0.277, 0.273
				if (modBiblcalFunctions.LY >= 0)
				{ //Line 1527
					modBiblcalFunctions.LN = Math.Floor((modBiblcalFunctions.LY - 1900) * 12.368277d);
				}
				else
				{
					modBiblcalFunctions.LN = Math.Floor((modBiblcalFunctions.LY - 1899) * 12.368277d);
				}
				modBiblcalFunctions.FindFirstDay(); //Gosub 5000
				//1550  'spring equinox calc -EQ. 20
				modBiblcalFunctions.YRI = Math.Floor(modBiblcalFunctions.GregorianYear);
				if (modBiblcalFunctions.YRI < 0)
				{
					modBiblcalFunctions.YRI++;
				}
				modBiblcalFunctions.JDD = 1721139.2855d + 365.2421376d * modBiblcalFunctions.YRI + modBiblcalFunctions.VEQ * Math.Pow(modBiblcalFunctions.YRI / 1000d, 2) - 0.0027879d * Math.Pow(modBiblcalFunctions.YRI / 1000d, 3d);
				if (modBiblcalFunctions.VS == 1)
				{ //Line 1555
					modBiblcalFunctions.JDT = modBiblcalFunctions.JI + 1 + (modBiblcalFunctions.HS + 0.25d) / 24d + modBiblcalFunctions.HR / 24d;
				}
				else
				{
					modBiblcalFunctions.JDT = modBiblcalFunctions.JI + (modBiblcalFunctions.HS + 0.25d) / 24d + modBiblcalFunctions.HR / 24d;
				}
				modBiblcalFunctions.DMT = Math.Abs(modBiblcalFunctions.JDD - modBiblcalFunctions.JDT); //Line 1556
				if (modBiblcalFunctions.DMT < 1)
				{
					modBiblcalFunctions.JT = (modBiblcalFunctions.JDD - 2415020) / 36525d;
					if (modBiblcalFunctions.JDD < 1483746)
					{ //Line 1558
						modBiblcalFunctions.JT -= 0.00000076d;
						modBiblcalFunctions.FiftyFourHundred();
					}
					else
					{
						modBiblcalFunctions.FiftyFourHundred();
					}
					modBiblcalFunctions.JDD += 58 * Math.Sin(-modBiblcalFunctions.LO); //Line 1560
					modBiblcalFunctions.DMT = 0;
				}
				else
				{
					modBiblcalFunctions.DMT = 0;
				}
				//Line 1562
				modBiblcalFunctions.TPrint("Vernal Equinox JD: " + (Math.Floor(modBiblcalFunctions.JDD * 1000) / 1000d).ToString());
				modBiblcalFunctions.TPrint("    Visible New Moon JD: " + (Math.Floor(modBiblcalFunctions.JDT * 1000) / 1000d).ToString() + modBiblcalFunctions.CRLF);
				if (modBiblcalFunctions.JDD > modBiblcalFunctions.JDT)
				{ //Line 1566
					modBiblcalFunctions.TPrint("Visible New Moon seen before vernal Equinox. Next month begins New Year." + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
					modBiblcalFunctions.LN++;
				}
				modBiblcalFunctions.LN++;
				modBiblcalFunctions.FindFirstDay(); //Gosub 5000          Line 1569
				modBiblcalFunctions.AA += 16; //Locate the 17th day of the month
				ZA = modBiblcalFunctions.AA; //Keep track of the date to subtract from the second
				if (modBiblcalFunctions.VS == 1)
				{ //Line 1570
					modBiblcalFunctions.TPrint("17th of 2nd Month is (possibly one day earlier)");
					TT = 1;
					modBiblcalFunctions.PrintDayAndDate(); //Gosub 6870
				}
				else
				{
					if (modBiblcalFunctions.VS == 2)
					{
						modBiblcalFunctions.TPrint("17th of 2nd Month is (possibly one day later)");
						TT = -1;
						modBiblcalFunctions.PrintDayAndDate();
					}
					else
					{
						modBiblcalFunctions.TPrint("17th of 2nd Month is"); //Line 1610
						TT = 0;
						modBiblcalFunctions.PrintDayAndDate();
					}
				}
				modBiblcalFunctions.LN += 5; //Go to the 7th month.  2+5=7
				modBiblcalFunctions.FindFirstDay();
				modBiblcalFunctions.AA += 16; //Locate the 17th day of the month
				if (modBiblcalFunctions.VS == 1)
				{
					modBiblcalFunctions.TPrint("17th of 7th Month is (possibly one day earlier)");
					TU = -1;
					modBiblcalFunctions.PrintDayAndDate(); //GoSub 6870          Line 1650
				}
				else
				{
					if (modBiblcalFunctions.VS == 2)
					{
						modBiblcalFunctions.TPrint("17th of 7th Month is (possibly one day later)");
						TU = 1;
						modBiblcalFunctions.PrintDayAndDate(); //GoSub 6870
					}
					else
					{
						modBiblcalFunctions.TPrint("17th of 7th Month is");
						TU = 0;
						modBiblcalFunctions.PrintDayAndDate(); //GoSub 6870
					}
				}
				ZW = modBiblcalFunctions.AA - ZA; //Find how many days between dates.
				if (ZW == 150)
				{
					OneFifty[Convert.ToInt32(IndexOneFifty)] = (float) modBiblcalFunctions.GregorianYear;
					IndexOneFifty++;
				}
				if (ZW == 150)
				{
					modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "******* ");
				}
				modBiblcalFunctions.TPrint("There are " + ZW.ToString() + " days between these dates. ");
				if (ZW == 150)
				{
					modBiblcalFunctions.TPrint(" ******* ");
				}
				if (TT == 1 && TU == -1)
				{ //Line 1770
					ZY = ZW + 1;
					ZX = ZW - 1;
					if (ZY == 150)
					{
						modBiblcalFunctions.TPrint("******** ");
						PlusOne[Convert.ToInt32(IndexPlusOne)] = (float) modBiblcalFunctions.GregorianYear;
						IndexPlusOne++;
					}
					modBiblcalFunctions.TPrint("Possibly " + ZX.ToString() + " or " + ZY.ToString() + " days.");
					if (ZY == 150)
					{
						modBiblcalFunctions.TPrint(" **********");
					}
				}
				if (TT == 1 && TU == 1)
				{ //Line 1780
					ZX = ZW + 1;
					ZY = ZW + 2;
					if (ZY == 150)
					{
						PlusTwo[Convert.ToInt32(IndexPlusTwo)] = (float) modBiblcalFunctions.GregorianYear;
						IndexPlusTwo++;
						modBiblcalFunctions.TPrint("********** ");
					}
					else
					{
						if (ZX == 150)
						{
							PlusOne[Convert.ToInt32(IndexPlusOne)] = (float) modBiblcalFunctions.GregorianYear;
							IndexPlusOne++;
							modBiblcalFunctions.TPrint("********** ");
						}
					}
					modBiblcalFunctions.TPrint("Possibly " + ZX.ToString() + " or " + ZY.ToString() + " days.");
					if ((ZX == 150) || (ZY == 150))
					{
						modBiblcalFunctions.TPrint(" ***********");
					}
				}
				if (TT == 1 && TU == 0)
				{ //Line 1790
					ZY = ZW + 1;
					if (ZY == 150)
					{
						PlusOne[Convert.ToInt32(IndexPlusOne)] = (float) modBiblcalFunctions.GregorianYear;
						IndexPlusOne++;
						modBiblcalFunctions.TPrint("********** ");
					}
					modBiblcalFunctions.TPrint("Possibly " + ZY.ToString() + " days.");
					if (ZY == 150)
					{
						modBiblcalFunctions.TPrint(" **********");
					}
				}
				if (TT == -1 && TU == -1)
				{ //Line 1800
					ZY = ZW - 1;
					ZX = ZW - 2;
					modBiblcalFunctions.TPrint("Possibly " + ZX.ToString() + " or " + ZY.ToString() + " days.");
				}
				if (TT == -1 && TU == 1)
				{ //Line 1810
					ZY = ZW + 1;
					ZX = ZW - 1;
					if (ZY == 150)
					{
						PlusOne[Convert.ToInt32(IndexPlusOne)] = (float) modBiblcalFunctions.GregorianYear;
						IndexPlusOne++;
						modBiblcalFunctions.TPrint("********** ");
					}
					modBiblcalFunctions.TPrint("Possibly " + ZX.ToString() + " or " + ZY.ToString() + " days.");
					if (ZY == 150)
					{
						modBiblcalFunctions.TPrint(" **********");
					}
				}
				if (TT == -1 && TU == 0)
				{ //Line 1820
					ZY = ZW - 1;
					modBiblcalFunctions.TPrint("Possibly " + ZY.ToString() + " days.");
				}
				if (TT == 0 && TU == -1)
				{ //Line 1830
					ZY = ZW - 1;
					modBiblcalFunctions.TPrint("Possibly " + ZY.ToString() + " days.");
				}
				if (TT == 0 && TU == 1)
				{ //Line 1840
					ZY = ZW + 1;
					if (ZY == 150)
					{
						PlusOne[Convert.ToInt32(IndexPlusOne)] = (float) modBiblcalFunctions.GregorianYear;
						IndexPlusOne++;
						modBiblcalFunctions.TPrint("********** ");
					}
					modBiblcalFunctions.TPrint("Possibly " + ZY.ToString() + " days.");
					if (ZY == 150)
					{
						modBiblcalFunctions.TPrint(" **********");
					}
				}
				modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
				WorkingCount++;
				if (WorkingCount > 500)
				{ //Make the WORKING sign flash so user knows
					WorkingCount = 0; //the system is not locked up.
					if (ReflectionHelper.GetMember<bool>(txtWorking, "Visible"))
					{
						ReflectionHelper.LetMember(txtWorking, "Visible", false);
					}
					else
					{
						ReflectionHelper.LetMember(txtWorking, "Visible", true);
					}
					Application.DoEvents();
				}
			}
			//PrintFlag indicates if there just one year detail printed or a table of many years.
			if (!modBiblcalFunctions.PrintFlag)
			{ //Print a table of many years.
				//Find out which array has the most items.
				MaxResults = Convert.ToInt32(IndexOneFifty);
				if (MaxResults < IndexPlusOne)
				{
					MaxResults = Convert.ToInt32(IndexPlusOne);
				}
				if (MaxResults < IndexPlusTwo)
				{
					MaxResults = Convert.ToInt32(IndexPlusTwo);
				}
				MaxResults--;
				modBiblcalFunctions.PrintFlag = true; //Print the table
				modBiblcalFunctions.TPrint(" First year of run is" + modBiblcalFunctions.StringYear(Year1) + "          Last year of run is" + modBiblcalFunctions.StringYear(Year2) + modBiblcalFunctions.CRLF);
				modBiblcalFunctions.TPrint(" 150 days           149(+1)             148(+2)" + modBiblcalFunctions.CRLF);
				modBiblcalFunctions.TPrint(" ===================================================================" + modBiblcalFunctions.CRLF);
				if (MaxResults < 0)
				{
					MaxResults = 0;
				}
				int tempForEndVar2 = MaxResults;
				for (ArrayIndex = 0; ArrayIndex <= tempForEndVar2; ArrayIndex++)
				{
					if (ArrayIndex < IndexOneFifty)
					{
						modBiblcalFunctions.TPrint(modBiblcalFunctions.StringYear(OneFifty[ArrayIndex]) + "          ");
					}
					else
					{
						modBiblcalFunctions.TPrint("                   ");
					}
					if (ArrayIndex < IndexPlusOne)
					{
						modBiblcalFunctions.TPrint(modBiblcalFunctions.StringYear(PlusOne[ArrayIndex]) + "           ");
					}
					else
					{
						modBiblcalFunctions.TPrint("               ");
					}
					if (ArrayIndex < IndexPlusTwo)
					{
						modBiblcalFunctions.TPrint(modBiblcalFunctions.StringYear(PlusTwo[ArrayIndex]) + modBiblcalFunctions.CRLF);
					}
					else
					{
						modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF);
					}
					frmHolyDays.DefInstance.txtWorking.Visible = false;
					frmHolyDays.DefInstance.cmdFlood.Enabled = true;
				}
			}
			modBiblcalFunctions.FloodFlag = false;
		}
	}
}