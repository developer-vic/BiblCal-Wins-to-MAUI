using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BiblCal
{
	internal static class modSunsets
	{

		internal static void DoSunsets()
		{
			//Computes the Sunsets for the Users location
			//Dim ColumnCount As Integer                        'Counter for columns
			double TempAA = 0;
			double TempJI = 0;
			int Column = 0;
			int DaysToPrint = 0;
			int SkipDays = 0;

			modBiblcalFunctions.TempYear = Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtYear.Text));
			if (modBiblcalFunctions.ChangeFlag)
			{
				modBiblcalFunctions.WriteUserDataXML();
			}
			modBiblcalFunctions.SunsetFlag = true; //Tell other routines 'Sunset' is active
			modBiblcalFunctions.LocalCalcFlag = true; //Set up to do local calculations
			modBiblcalFunctions.GetLocation(); //Read in the location from the textboxes
			modBiblcalFunctions.InitializeVariables();
			if (frmHolyDays.DefInstance.chkGregYear.CheckState == CheckState.Unchecked)
			{
				modBiblcalFunctions.PrintFlag = false; //Don't print results while looking up
				frmHolyDays.DefInstance.cmdLocMon_Click(frmHolyDays.DefInstance.cmdLocMon, new EventArgs()); //the first month date.
				modBiblcalFunctions.PrintFlag = true;
				DaysToPrint = 107;
				SkipDays = 108;
			}
			else
			{
				if (modBiblcalFunctions.GregorianYear <= 0)
				{
					modBiblcalFunctions.GregorianYear++;
				}
				modBiblcalFunctions.DateOfFirstMonth = modBiblcalFunctions.ConvertToJulian(1, 1, modBiblcalFunctions.GregorianYear) + 1;
				if (modBiblcalFunctions.GregorianYear >= 0)
				{
					modBiblcalFunctions.GregorianYear++;
				}
				DaysToPrint = 91;
				SkipDays = 92;
				frmHolyDays.DefInstance.txtOut.Text = "";
			}
			modBiblcalFunctions.LocalCalcFlag = true;
			modBiblcalFunctions.SunsetFlag = false; //Make function StringYear print the 'CE'
			modBiblcalFunctions.TPrint(modBiblcalFunctions.StringYear(modBiblcalFunctions.GregorianYear) + " CALCULATED SUNSETS" + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.SunsetFlag = true;
			modBiblcalFunctions.PrintLocation();
			modBiblcalFunctions.TPrint("Times do not reflect changes in 'Daylight Saving Time'" + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.TPrint("________________________________________________________________________________________" + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.JI = modBiblcalFunctions.DateOfFirstMonth - 1; //Take 1 back to get evening of first month.
			double StartRun = modBiblcalFunctions.JI; //Value for start of run.
			frmHolyDays.DefInstance.cmdSunset.Enabled = false; //Don't allow the user to press the button again.
			double tempForEndVar = StartRun + DaysToPrint;
			for (modBiblcalFunctions.AA = StartRun; modBiblcalFunctions.AA <= tempForEndVar; modBiblcalFunctions.AA++)
			{ //Print 427 dates and times.
				TempAA = modBiblcalFunctions.AA;
				TempJI = modBiblcalFunctions.JI;
				for (Column = 1; Column <= 4; Column++)
				{
					if (modBiblcalFunctions.JI < 1483746)
					{
						modBiblcalFunctions.JT = (modBiblcalFunctions.JI + modBiblcalFunctions.LG + 0.2222d + modBiblcalFunctions.DT - 2415020) / 36525d;
					}
					else
					{
						modBiblcalFunctions.JT = (modBiblcalFunctions.JI + modBiblcalFunctions.LG + 0.25d + modBiblcalFunctions.DT - 2415020) / 36525d;
					}
					modBiblcalFunctions.PrintDate();
					modBiblcalFunctions.PrintSunset();
					modBiblcalFunctions.TPrint("PM" + "    ");
					modBiblcalFunctions.AA += SkipDays;
					modBiblcalFunctions.JI += SkipDays;
				}
				modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF);
				modBiblcalFunctions.AA = TempAA;
				modBiblcalFunctions.JI = TempJI + 1;
			}
			frmHolyDays.DefInstance.cmdSunset.Enabled = true; //Allow use of the button again
			modBiblcalFunctions.SunsetFlag = false;
			modBiblcalFunctions.LocalCalcFlag = false;
		}
	}
}