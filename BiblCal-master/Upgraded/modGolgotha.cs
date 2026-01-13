using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BiblCal
{
	internal static class modGolgotha
	{

		//************************************************************************************************
		//           This module is shared by modes 'Golgotha', 'Jordan' and 'Creation'
		//************************************************************************************************
		static double WaveOffering = 0;
		static int High = 0;
		static int Low = 0;
		static int Row = 0;

		internal static void DoGolgotha()
		{
			double Year2 = 0;
			Row = 0;
			modBiblcalFunctions.FloodFlag = true; //Tell other subroutines this is a Flood run.
			frmHolyDays.DefInstance.chkEJW.CheckState = CheckState.Unchecked;
			frmHolyDays.DefInstance.txtOut.Text = "";
			modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
			if (modBiblcalFunctions.Mode == "Golgotha")
			{
				High = 9999;
				Low = -4004;
			}
			else if (modBiblcalFunctions.Mode == "Jordan")
			{ 
				High = 9999;
				Low = -4004;
			}
			else if (modBiblcalFunctions.Mode == "Creation")
			{ 
				High = 9999;
				Low = -6000;
			}
			if (frmHolyDays.DefInstance.txtYear.Text == "")
			{
				frmHolyDays.DefInstance.txtYear.Text = frmHolyDays.DefInstance.txtYear2.Text;
				frmHolyDays.DefInstance.txtYear2.Text = "";
			}
			if (Conversion.Val(frmHolyDays.DefInstance.txtYear.Text) < Low || frmHolyDays.DefInstance.txtYear.Text == "")
			{
				frmHolyDays.DefInstance.txtYear.Text = Low.ToString();
			}
			if (Conversion.Val(frmHolyDays.DefInstance.txtYear.Text) > High)
			{
				frmHolyDays.DefInstance.txtYear.Text = High.ToString();
			}
			if (Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text) < Low && frmHolyDays.DefInstance.txtYear2.Text != "")
			{
				frmHolyDays.DefInstance.txtYear2.Text = Low.ToString();
			}
			if (Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text) > High && frmHolyDays.DefInstance.txtYear2.Text != "")
			{
				frmHolyDays.DefInstance.txtYear2.Text = High.ToString();
			}
			//If there is no second year, just do one pass.
			double Year1 = Conversion.Val(frmHolyDays.DefInstance.txtYear.Text);
			if (frmHolyDays.DefInstance.txtYear2.Text == "")
			{
				Year2 = Year1;
			}
			else
			{
				//else make a table.
				Year2 = Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text);
			}
			if (Year2 < Year1)
			{ //Swap years if they are reversed.
				frmHolyDays.DefInstance.txtYear.Text = Year2.ToString();
				frmHolyDays.DefInstance.txtYear2.Text = Year1.ToString();
				Year1 = Conversion.Val(frmHolyDays.DefInstance.txtYear.Text);
				Year2 = Conversion.Val(frmHolyDays.DefInstance.txtYear2.Text);
			}
			//If printing a table, we don't want to print all the years so we turn off the PrintFlag
			if (Year2 > Year1)
			{
				if (modBiblcalFunctions.Mode == "Golgotha")
				{
					modBiblcalFunctions.TPrint("The following years may have the Passover sacrifice on Wednesday." + modBiblcalFunctions.CRLF);
				}
				else if (modBiblcalFunctions.Mode == "Jordan")
				{ 
					modBiblcalFunctions.TPrint("The following years may have the Passover sacrifice on the Sabbath." + modBiblcalFunctions.CRLF);
				}
				else if (modBiblcalFunctions.Mode == "Creation")
				{ 
					modBiblcalFunctions.TPrint("The following years may have Abib 1 on Sunday." + modBiblcalFunctions.CRLF);
				}
				modBiblcalFunctions.TPrint("First year of run is" + modBiblcalFunctions.StringYear(Year1) + modBiblcalFunctions.CRLF + "Last year of run is" + modBiblcalFunctions.StringYear(Year2) + modBiblcalFunctions.CRLF);
				modBiblcalFunctions.TPrint("==============================" + modBiblcalFunctions.CRLF);
				modBiblcalFunctions.PrintFlag = false; //Disable printing for Table
			}
			else
			{
				modBiblcalFunctions.PrintFlag = true; //One pass only print intermediate results.
			}
			if (modBiblcalFunctions.Mode == "Golgotha")
			{
				modBiblcalFunctions.TPrint("Possible Dates for Jesus' Crucifixion, Resurrection and Pentecost in" + modBiblcalFunctions.StringYear(Year1) + modBiblcalFunctions.CRLF);
			}
			else if (modBiblcalFunctions.Mode == "Jordan")
			{ 
				modBiblcalFunctions.TPrint("Possible Dates for the Jordan Crossing in" + modBiblcalFunctions.StringYear(Year1) + modBiblcalFunctions.CRLF);
			}
			else if (modBiblcalFunctions.Mode == "Creation")
			{ 
				modBiblcalFunctions.TPrint("Possible Dates for Creation in" + modBiblcalFunctions.StringYear(Year1) + modBiblcalFunctions.CRLF);
			}
			double tempForEndVar = Year2;
			for (modBiblcalFunctions.GregorianYear = Year1; modBiblcalFunctions.GregorianYear <= tempForEndVar; modBiblcalFunctions.GregorianYear++)
			{ //Check from the first year to the last year
				if (modBiblcalFunctions.GregorianYear == 0)
				{
					modBiblcalFunctions.GregorianYear = 1;
				}
				if (modBiblcalFunctions.Mode != "Creation")
				{
					modBiblcalFunctions.LG = -35.244d;
					modBiblcalFunctions.LT = 31.78d;
					modBiblcalFunctions.HR = 14; //Location of Jerusalem
				}
				else
				{
					modBiblcalFunctions.LG = -42;
					modBiblcalFunctions.LT = 38.5d;
					modBiblcalFunctions.HR = 14; //Location of Garden of Eden
				}
				modBiblcalFunctions.InitializeVariables();
				modBiblcalFunctions.LY = modBiblcalFunctions.GregorianYear + 0.265d; //bga- selects which new moon to start testing for year, was 0.282, 0.277, 0.273
				if (modBiblcalFunctions.LY >= 0)
				{
					modBiblcalFunctions.LN = Math.Floor((modBiblcalFunctions.LY - 1900) * 12.368277d);
				}
				else
				{
					modBiblcalFunctions.LN = Math.Floor((modBiblcalFunctions.LY - 1899) * 12.368277d);
				}
				modBiblcalFunctions.FloodFlag = false;
				modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
				modBiblcalFunctions.Mode = "HolyDays";
				modBiblcalFunctions.FindFirstDay();
				modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
				modBiblcalFunctions.FloodFlag = true;
				//1550  'spring equinox calc -EQ. 20
				modBiblcalFunctions.YRI = Math.Floor(modBiblcalFunctions.GregorianYear);
				if (modBiblcalFunctions.YRI < 0)
				{
					modBiblcalFunctions.YRI++;
				}
				modBiblcalFunctions.JDD = 1721139.2855d + 365.2421376d * modBiblcalFunctions.YRI + modBiblcalFunctions.VEQ * Math.Pow(modBiblcalFunctions.YRI / 1000d, 2) - 0.0027879d * Math.Pow(modBiblcalFunctions.YRI / 1000d, 3d);
				if (modBiblcalFunctions.VS == 1)
				{
					modBiblcalFunctions.JDT = modBiblcalFunctions.JI + 1 + (modBiblcalFunctions.HS + 0.25d) / 24d + modBiblcalFunctions.HR / 24d;
				}
				else
				{
					modBiblcalFunctions.JDT = modBiblcalFunctions.JI + (modBiblcalFunctions.HS + 0.25d) / 24d + modBiblcalFunctions.HR / 24d;
				}
				modBiblcalFunctions.DMT = Math.Abs(modBiblcalFunctions.JDD - modBiblcalFunctions.JDT);
				if (modBiblcalFunctions.DMT < 1)
				{
					modBiblcalFunctions.JT = (modBiblcalFunctions.JDD - 2415020) / 36525d;
					if (modBiblcalFunctions.JDD < 1483746)
					{
						modBiblcalFunctions.JT -= 0.00000076d;
						modBiblcalFunctions.FiftyFourHundred();
					}
					else
					{
						modBiblcalFunctions.FiftyFourHundred();
					}
					modBiblcalFunctions.JDD += 58 * Math.Sin(-modBiblcalFunctions.LO);
					modBiblcalFunctions.DMT = 0;
				}
				else
				{
					modBiblcalFunctions.DMT = 0;
				}
				modBiblcalFunctions.TPrint("Vernal Equinox JD: " + (Math.Floor(modBiblcalFunctions.JDD * 1000) / 1000d).ToString());
				modBiblcalFunctions.TPrint("    Visible New Moon JD: " + (Math.Floor(modBiblcalFunctions.JDT * 1000) / 1000d).ToString() + modBiblcalFunctions.CRLF);
				if (modBiblcalFunctions.JDD > modBiblcalFunctions.JDT)
				{
					modBiblcalFunctions.TPrint("Visible New Moon seen before vernal Equinox. Next month begins New Year." + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
					modBiblcalFunctions.LN++;
					modBiblcalFunctions.FloodFlag = false;
					modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
					modBiblcalFunctions.Mode = "HolyDays";
					modBiblcalFunctions.FindFirstDay();
					modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
					modBiblcalFunctions.FloodFlag = true;
				}

				switch(modBiblcalFunctions.Mode)
				{
					//************************************************************************************************
					case "Golgotha" :  //***** GOLGOTHA ***** 
						 
						if (modBiblcalFunctions.VS == 1)
						{
							modBiblcalFunctions.TPrint("Abib 1, Passover sacrifice and Feast of Unleavened Bread are possibly one day earlier." + modBiblcalFunctions.CRLF);
						}
						else
						{
							if (modBiblcalFunctions.VS == 2)
							{
								modBiblcalFunctions.TPrint("Abib 1, Passover sacrifice and Feast of Unleavened Bread are possibly one day later." + modBiblcalFunctions.CRLF);
							}
						} 
						modBiblcalFunctions.TPrint("Abib 1 is"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						modBiblcalFunctions.AA += 13;  //Get Passover sacrifice date 
						modBiblcalFunctions.TPrint("Passover sacrifice is"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						if (modBiblcalFunctions.D == 3)
						{ //Falls on a Wednesday?
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year has the proper day of the week for Christ's death. **********" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 4 && modBiblcalFunctions.VS == 1)
						{ //Falls on Thursday and is possibly one day earlier.
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year has the proper day of the week for Christ's death. **********" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 2 && modBiblcalFunctions.VS == 2)
						{ //Falls on a Tuesday and is possibly one day later.
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year has the proper day of the week for Christ's death. **********" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						modBiblcalFunctions.AA++;  //Get start of Feast of Unleavened Bread 
						modBiblcalFunctions.TPrint("Feast of Unleavened Bread runs from"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						WaveOffering = 7 - modBiblcalFunctions.D + modBiblcalFunctions.AA; 
						modBiblcalFunctions.AA += 6; 
						modBiblcalFunctions.TPrint("to"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						modBiblcalFunctions.TPrint("The Wave Offering (the First-Fruit) is"); 
						modBiblcalFunctions.AA = WaveOffering; 
						modBiblcalFunctions.PrintDayAndDate(); 
						modBiblcalFunctions.TPrint("First-Fruits (Pentecost) is"); 
						modBiblcalFunctions.AA = WaveOffering + 49; 
						modBiblcalFunctions.PrintDayAndDate(); 
						//************************************************************************************************ 
						break;
					case "Jordan" :  //***** JORDAN ***** 
						modBiblcalFunctions.AA += 13;  //Get Passover sacrifice date 
						modBiblcalFunctions.TPrint("Passover sacrifice is"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						if (modBiblcalFunctions.D == 6)
						{ //Falls on a Sabbath?
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** The wave offering is the next day. **********" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 0 && modBiblcalFunctions.VS == 1)
						{ //Falls on a Sunday and is possibly one day earlier.
							modBiblcalFunctions.TPrint("The Passover sacrifice may be one day earlier." + modBiblcalFunctions.CRLF);
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + " ***** The Wave Offering would be the next day if it is. *****" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 5 && modBiblcalFunctions.VS == 2)
						{ //Falls on a Friday and is possibly one day later.
							modBiblcalFunctions.TPrint("The Passover sacrifice may be one day later." + modBiblcalFunctions.CRLF);
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "***** The Wave Offering would be the next day if it is. *****" + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						modBiblcalFunctions.AA++;  //Get the start of the Feast of Unleavened Bread 
						modBiblcalFunctions.TPrint("Feast of Unleavened Bread runs from"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						if (modBiblcalFunctions.D == 0)
						{
							modBiblcalFunctions.D = 7;
						}  //Don't skip a week for the Wave Offering (0 = Sunday) 
						WaveOffering = 7 - modBiblcalFunctions.D + modBiblcalFunctions.AA;  //Subtracting 0 from 7 would leave 7 and advance a week. 
						modBiblcalFunctions.AA += 6;  //Get the last day of the Feast of Unleavened Bread 
						modBiblcalFunctions.TPrint("to"); 
						modBiblcalFunctions.PrintDayAndDate(); 
						modBiblcalFunctions.TPrint("The Wave Offering (the First-Fruit) is"); 
						modBiblcalFunctions.AA = WaveOffering; 
						modBiblcalFunctions.PrintDayAndDate(); 
						modBiblcalFunctions.TPrint("First-Fruits (Pentecost) is"); 
						modBiblcalFunctions.AA = WaveOffering + 49; 
						modBiblcalFunctions.PrintDayAndDate(); 
						//*********************************************************************************************** 
						break;
					case "Creation" :  //***** CREATION ***** 
						if (modBiblcalFunctions.VS == 1)
						{
							modBiblcalFunctions.TPrint("Abib 1 is (though possibly one day earlier)");
						} 
						if (modBiblcalFunctions.VS == 2)
						{
							modBiblcalFunctions.TPrint("Abib 1 is (though possibly one day later)");
						}
						else
						{
							if (modBiblcalFunctions.VS == 3)
							{
								modBiblcalFunctions.TPrint("Abib 1 is");
							}
						} 
						modBiblcalFunctions.PrintDayAndDate(); 
						if (modBiblcalFunctions.D == 0)
						{ //Falls on a Sunday?
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year begins on the correct day of the week for the year of Creation. **********" + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 1 && modBiblcalFunctions.VS == 1)
						{ //Falls on a Monday and is possibly one day earlier.
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year begins on the correct day of the week for the year of Creation. **********" + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						if (modBiblcalFunctions.D == 6 && modBiblcalFunctions.VS == 2)
						{ //Falls on a Sabbath and is possibly one day later.
							modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF + "********** This year begins on the correct day of the week for the year of Creation. **********" + modBiblcalFunctions.CRLF);
							YPrint(Convert.ToInt32(modBiblcalFunctions.GregorianYear));
						} 
						break;
				}
			}
			modBiblcalFunctions.PrintFlag = true;
			modBiblcalFunctions.FloodFlag = false;
		}

		//Prints the rows of possible years
		private static void YPrint(int Year)
		{
			if (!modBiblcalFunctions.PrintFlag)
			{
				modBiblcalFunctions.PrintFlag = true;
				modBiblcalFunctions.TPrint(modBiblcalFunctions.StringYear(Year) + "  ");
				Row++;
				if (Row > 7)
				{
					Row = 0;
					modBiblcalFunctions.TPrint(modBiblcalFunctions.CRLF);
				}
				modBiblcalFunctions.PrintFlag = false;
			}
		}
	}
}