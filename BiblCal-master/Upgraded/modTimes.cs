using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BiblCal
{
	internal static class modTimes
	{

		public static string ILSString = ""; //Moonset Illumination
		public static int LineCount = 0;
		public static string Header = "";
		public static double XL = 0;
		public static string HMSString = "";
		public static string HTSString = "";
		public static string HOSString = "";
		public static string HQSString = "";
		public static double A1 = 0;
		public static double B0 = 0;

		//This is the 'Times' module
		internal static void DoTimes()
		{
			int DayToCalc = 0;
			int DaysToPrint = 0;
			modBiblcalFunctions.TempYear = Convert.ToInt32(Conversion.Val(frmHolyDays.DefInstance.txtYear.Text));
			//HR = 12# - HR
			//AJ = (LG - HR * 15#) * 0.066667
			//LG = LG / 360#
			//LT = LT * DR
			//SJ = SJ / 60#
			//MJ = MJ / 60#
			//RJ = RJ / 60#
			//XL = 2
			modBiblcalFunctions.SJ = 0;
			modBiblcalFunctions.MJ = 0;
			modBiblcalFunctions.RH = 0;
			modBiblcalFunctions.MR = 0;
			Header = "  DATE    JULIAN DAY #  SUNRISE   SUNSET   MOONRISE  % ILLUM.  MOONSET  % ILLUM" + modBiblcalFunctions.CRLF;
			if (modBiblcalFunctions.ChangeFlag)
			{
				modBiblcalFunctions.WriteUserDataXML();
			}
			modBiblcalFunctions.SunsetFlag = true; //Tell other routines 'Sunset' is active
			modBiblcalFunctions.InitializeVariables();
			if (frmHolyDays.DefInstance.chkGregYear.CheckState == CheckState.Unchecked)
			{
				modBiblcalFunctions.PrintFlag = false; //Don't print results while looking up
				frmHolyDays.DefInstance.cmdLocMon_Click(frmHolyDays.DefInstance.cmdLocMon, new EventArgs()); //the first month date.
				modBiblcalFunctions.PrintFlag = true;
				DaysToPrint = 400;
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
				DaysToPrint = 366;
				frmHolyDays.DefInstance.txtOut.Text = "";
			}
			modBiblcalFunctions.LocalCalcFlag = true; //Set up to do local calculations
			modBiblcalFunctions.GetLocation(); //Read in the location from the textboxes
			modBiblcalFunctions.InitializeVariables();
			frmHolyDays.DefInstance.txtOut.Text = "";
			modBiblcalFunctions.PrintLocation();
			modBiblcalFunctions.TPrint("Times are not corrected for changes in Daylight Saving." + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.TPrint("Dates are shown in Month/Day/Year format." + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.TPrint("_______________________________________________________________________________" + modBiblcalFunctions.CRLF);
			modBiblcalFunctions.TPrint(Header);
			modBiblcalFunctions.JI = modBiblcalFunctions.DateOfFirstMonth - 1;
			modBiblcalFunctions.IA = modBiblcalFunctions.JI;
			modBiblcalFunctions.JulianToMDY(); //Get the current date to print
			LineCount = -1; //Account for the first printed header
			modBiblcalFunctions.LN = Math.Floor((modBiblcalFunctions.IA - 2415021d) / 29.530589d);
			frmHolyDays.DefInstance.cmdTimes.Enabled = false; //Don't show button while in loop.
			//****************************************************************************************

			int tempForEndVar = DaysToPrint;
			for (DayToCalc = 1; DayToCalc <= tempForEndVar; DayToCalc++)
			{ //Number of days to calculate
				Times(modBiblcalFunctions.IA);
				modBiblcalFunctions.IA = modBiblcalFunctions.IB + 1d;
				modBiblcalFunctions.JulianToMDY(); //Get the current date to print
			} //Do the next day

			frmHolyDays.DefInstance.cmdTimes.Enabled = true; //Show the button again
			modBiblcalFunctions.SunsetFlag = false;
			modBiblcalFunctions.LocalCalcFlag = false;
		}

		internal static void Times(double IA)
		{
			//Does one days worth of Times.
			//***************************** Set up variables *********************************
			modBiblcalFunctions.MZ = 0;
			modBiblcalFunctions.HV = 0;
			modBiblcalFunctions.TS = 0;
			modBiblcalFunctions.HW = 0;
			modBiblcalFunctions.RH = 0;
			XL = 2;
			modBiblcalFunctions.MR = 0;
			modBiblcalFunctions.SJ = 0;
			modBiblcalFunctions.MJ = 0;
			//********************************************************************************
			//RJ = -0.018 '= some other kind of adjustment not used here.
			//SJ = Sunset adjustment
			//MJ = Moonset adjustment
			LineCount++;
			if (LineCount == 30)
			{
				LineCount = 0;
				modBiblcalFunctions.TPrint(Header);
			}
			modBiblcalFunctions.TPrint(modBiblcalFunctions.MHString + "/" + modBiblcalFunctions.DAString + "/" + modBiblcalFunctions.GregorianYearString + "   " + IA.ToString() + "     ");
			modBiblcalFunctions.IB = IA;
			modBiblcalFunctions.ZZ = 1;
			FiveThousand();
			modBiblcalFunctions.J2 = (IA - modBiblcalFunctions.JI) * 0.0339d;
			if (modBiblcalFunctions.J2 > 0.96d)
			{
				modBiblcalFunctions.LN += 1d;
				modBiblcalFunctions.ZZ = 1;
				FiveThousand();
			}
			if (modBiblcalFunctions.JI <= IA)
			{
				modBiblcalFunctions.J2 = (IA - modBiblcalFunctions.JI) * 0.0339d;
			}
			if (modBiblcalFunctions.J2 > 0.25d)
			{
				modBiblcalFunctions.J2 -= 1d;
			}
			modBiblcalFunctions.JT = (IA + 0.25d + modBiblcalFunctions.LG + modBiblcalFunctions.DT - 2415020d) / 36525d;
			modBiblcalFunctions.DT = (0.41d + 1.2053d * modBiblcalFunctions.JT + 0.4992d * Math.Pow(modBiblcalFunctions.JT, 2)) / 1440d;
			modBiblcalFunctions.JT = (IA + 0.25d + modBiblcalFunctions.LG + modBiblcalFunctions.DT - 2415020d) / 36525d;
			do 
			{
				//FiftyTwoSixty:                        'Calculate Sunset
				modBiblcalFunctions.EO = (23.452294d - 0.0130125d * modBiblcalFunctions.JT - 0.00000164d * Math.Pow(modBiblcalFunctions.JT, 2) + 0.000000503d * Math.Pow(modBiblcalFunctions.JT, 3)) * modBiblcalFunctions.DR;
				modBiblcalFunctions.A9 = 153.23d + 22518.7541d * modBiblcalFunctions.JT;
				modBiblcalFunctions.A9 = (modBiblcalFunctions.A9 - (Math.Floor(modBiblcalFunctions.A9 / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.B9 = 216.57d + 45037.5082d * modBiblcalFunctions.JT;
				modBiblcalFunctions.B9 = (modBiblcalFunctions.B9 - (Math.Floor(modBiblcalFunctions.B9 / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.C9 = 312.69d + 32964.3577d * modBiblcalFunctions.JT;
				modBiblcalFunctions.C9 = (modBiblcalFunctions.C9 - (Math.Floor(modBiblcalFunctions.C9 / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.D9 = 350.74d + 445267.1142d * modBiblcalFunctions.JT - 0.00144d * Math.Pow(modBiblcalFunctions.JT, 2);
				modBiblcalFunctions.D9 = (modBiblcalFunctions.D9 - (Math.Floor(modBiblcalFunctions.D9 / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.E9 = 231.19d + 20.2d * modBiblcalFunctions.JT;
				modBiblcalFunctions.E9 = (modBiblcalFunctions.E9 - (Math.Floor(modBiblcalFunctions.E9 / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.LS = 279.69668d + 36000.76892d * modBiblcalFunctions.JT + 0.0003025d * Math.Pow(modBiblcalFunctions.JT, 2);
				modBiblcalFunctions.LS = (modBiblcalFunctions.LS - (Math.Floor(modBiblcalFunctions.LS / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.MS = 358.47583d + 35999.04975d * modBiblcalFunctions.JT - 0.00015d * Math.Pow(modBiblcalFunctions.JT, 2) - 0.0000033d * Math.Pow(modBiblcalFunctions.JT, 3);
				modBiblcalFunctions.MS = (modBiblcalFunctions.MS - (Math.Floor(modBiblcalFunctions.MS / 360d)) * 360d) * modBiblcalFunctions.DR;
				modBiblcalFunctions.EE = 0.01675104d - 0.0000418d * modBiblcalFunctions.JT - 0.000000126d * Math.Pow(modBiblcalFunctions.JT, 2);
				modBiblcalFunctions.YU = Math.Pow(Math.Tan(modBiblcalFunctions.EO / 2d), 2);
				modBiblcalFunctions.ET = modBiblcalFunctions.YU * Math.Sin(2d * modBiblcalFunctions.LS) - 2d * modBiblcalFunctions.EE * Math.Sin(modBiblcalFunctions.MS) + 4d * modBiblcalFunctions.EE * modBiblcalFunctions.YU * Math.Sin(modBiblcalFunctions.MS) * Math.Cos(2d * modBiblcalFunctions.LS);
				modBiblcalFunctions.ET = (modBiblcalFunctions.ET - 1d / 2d * Math.Pow(modBiblcalFunctions.YU, 2) * Math.Sin(4d * modBiblcalFunctions.LS) - 5d / 4d * Math.Pow(modBiblcalFunctions.EE, 2) * Math.Sin(2d * modBiblcalFunctions.MS)) * 3.819718634d;
				modBiblcalFunctions.CS = (1.91946d - 0.004789d * modBiblcalFunctions.JT - 0.000014d * Math.Pow(modBiblcalFunctions.JT, 2)) * Math.Sin(modBiblcalFunctions.MS);
				modBiblcalFunctions.CS = (modBiblcalFunctions.CS + (0.020094d - 0.0001d * modBiblcalFunctions.JT) * Math.Sin(2d * modBiblcalFunctions.MS) + 0.000293d * Math.Sin(3d * modBiblcalFunctions.MS)) * modBiblcalFunctions.DR;
				modBiblcalFunctions.LO = modBiblcalFunctions.LS + modBiblcalFunctions.CS + (0.00134d * Math.Cos(modBiblcalFunctions.A9) + 0.00154d * Math.Cos(modBiblcalFunctions.B9) + 0.002d * Math.Cos(modBiblcalFunctions.C9) + 0.00179d * Math.Sin(modBiblcalFunctions.D9) + 0.00178d * Math.Sin(modBiblcalFunctions.E9)) * modBiblcalFunctions.DR;
				modBiblcalFunctions.SD = Math.Sin(modBiblcalFunctions.EO) * Math.Sin(modBiblcalFunctions.LO);
				modBiblcalFunctions.DS = Math.Atan(modBiblcalFunctions.SD / Math.Sqrt((-modBiblcalFunctions.SD) * modBiblcalFunctions.SD + 1d));
				modBiblcalFunctions.H1 = (-0.01454d - Math.Sin(modBiblcalFunctions.LT) * Math.Sin(modBiblcalFunctions.DS)) / (Math.Cos(modBiblcalFunctions.LT) * Math.Cos(modBiblcalFunctions.DS));
				if (modBiblcalFunctions.RH != 1)
				{
					modBiblcalFunctions.HS = ((-Math.Atan(modBiblcalFunctions.H1 / Math.Sqrt((-modBiblcalFunctions.H1) * modBiblcalFunctions.H1 + 1d)) + 1.570796326795d) * 3.8197186342055d) - modBiblcalFunctions.ET;
					modBiblcalFunctions.HL = modBiblcalFunctions.HS + modBiblcalFunctions.AJ + modBiblcalFunctions.SJ + 0.008333333d + 12; //Rem .008333 USED TO ADJUST BASE SUNSET TIME (IN HOURS)
					modBiblcalFunctions.HMS = Math.Floor((modBiblcalFunctions.HL - Math.Floor(modBiblcalFunctions.HL)) * 60d);
					modBiblcalFunctions.HTS = Math.Floor(modBiblcalFunctions.HL);
					modBiblcalFunctions.RH = 1;
					modBiblcalFunctions.JT -= 2d * modBiblcalFunctions.HS / 876600d;
				}
			}
			while(modBiblcalFunctions.RH != 1);

			modBiblcalFunctions.RH = ((-Math.Atan(modBiblcalFunctions.H1 / Math.Sqrt((-modBiblcalFunctions.H1) * modBiblcalFunctions.H1 + 1d)) + 1.570796326795d) * 3.8197186342055d) + modBiblcalFunctions.ET;
			modBiblcalFunctions.HL = -modBiblcalFunctions.RH + modBiblcalFunctions.AJ + modBiblcalFunctions.SJ + 0.0083333333d + 12d;
			modBiblcalFunctions.HM = Math.Floor((modBiblcalFunctions.HL - Math.Floor(modBiblcalFunctions.HL)) * 60d);
			modBiblcalFunctions.HT = Math.Floor(modBiblcalFunctions.HL);
			modBiblcalFunctions.RH = 0;
			//
			//HT = Hour of Sunrise
			//HM = Minute Sunrise
			//HTS = Hour of Sunset
			//HMS = Minute of Sunset
			//
			//Print Sunrise time #0#0#0#0#0#0#0#0#0#0#0#0
			modBiblcalFunctions.HMString = Conversion.Str(modBiblcalFunctions.HM); //Line 5470
			modBiblcalFunctions.HMString = modBiblcalFunctions.HMString.Substring(1);
			modBiblcalFunctions.HTString = Conversion.Str(modBiblcalFunctions.HT);
			modBiblcalFunctions.HTString = modBiblcalFunctions.HTString.Substring(1);
			if (modBiblcalFunctions.HM < 10)
			{ //Line 5480
				modBiblcalFunctions.TPrint(modBiblcalFunctions.HTString + ":0" + modBiblcalFunctions.HMString + "      "); //Sunrise ************************
			}
			else
			{
				modBiblcalFunctions.TPrint(modBiblcalFunctions.HTString + ":" + modBiblcalFunctions.HMString + "      "); //Sunrise ************************
			}
			//5490
			//
			//Print Sunset time #0#0#0#0#0#0#0#0#0#0#0#0
			HMSString = Conversion.Str(modBiblcalFunctions.HMS); //Line 5500
			HMSString = HMSString.Substring(1);
			HTSString = Conversion.Str(modBiblcalFunctions.HTS);
			HTSString = HTSString.Substring(1);
			if (modBiblcalFunctions.HMS < 10)
			{ //Line 5510
				modBiblcalFunctions.TPrint(HTSString + ":0" + HMSString + "    "); //Sunset *************************
			}
			else
			{
				modBiblcalFunctions.TPrint(HTSString + ":" + HMSString + "    "); //Sunset *************************
			}
			//5520
			modBiblcalFunctions.MZ = 0; //Line 5530
			modBiblcalFunctions.JT = (IA + modBiblcalFunctions.HS / 24d + modBiblcalFunctions.DT + modBiblcalFunctions.LG + modBiblcalFunctions.J2 - 2415020d) / 36525d;
			goto FiftyFiveFifty;

			//Loops back to here from Line 6620
			FiftyFiveForty:
			modBiblcalFunctions.JT = (IA + modBiblcalFunctions.MC + modBiblcalFunctions.DT + modBiblcalFunctions.LG - 2415020d) / 36525d; //Line 5540

			FiftyFiveFifty://Loops back from next line after 6690
			modBiblcalFunctions.A4 = 51.2d + 20.2d * modBiblcalFunctions.JT; //Line 5550
			modBiblcalFunctions.A4 = (modBiblcalFunctions.A4 - Math.Floor(modBiblcalFunctions.A4 / 360d) * 360d) * modBiblcalFunctions.DR;
			modBiblcalFunctions.A5 = 346.56d + 132.87d * modBiblcalFunctions.JT - 0.0091731d * Math.Pow(modBiblcalFunctions.JT, 2); //Line 5560
			modBiblcalFunctions.A5 = (modBiblcalFunctions.A5 - Math.Floor(modBiblcalFunctions.A5 / 360d) * 360d) * modBiblcalFunctions.DR;
			modBiblcalFunctions.A6 = 0.003964d * Math.Sin(modBiblcalFunctions.A5); //Line 5570
			//Line 5580
			modBiblcalFunctions.AX = 259.183275d - 1934.142d * modBiblcalFunctions.JT + 0.002078d * Math.Pow(modBiblcalFunctions.JT, 2) + 0.0000022d * Math.Pow(modBiblcalFunctions.JT, 3);
			modBiblcalFunctions.AN = (modBiblcalFunctions.AX - Math.Floor(modBiblcalFunctions.AX / 360d) * 360d) * modBiblcalFunctions.DR; //Line 5590
			modBiblcalFunctions.A7 = modBiblcalFunctions.AX + 275.05d - 2.3d * modBiblcalFunctions.JT; //Line 5600
			modBiblcalFunctions.A7 = (modBiblcalFunctions.A7 - Math.Floor(modBiblcalFunctions.A7 / 360d) * 360d) * modBiblcalFunctions.DR;
			//Line 5610
			modBiblcalFunctions.MM = 296.104608d + 477198.8491d * modBiblcalFunctions.JT + 0.009192d * Math.Pow(modBiblcalFunctions.JT, 2);
			modBiblcalFunctions.MM = modBiblcalFunctions.MM + 0.0000144d * Math.Pow(modBiblcalFunctions.JT, 3) + 0.000817d * Math.Sin(modBiblcalFunctions.A4);
			modBiblcalFunctions.MM = modBiblcalFunctions.MM + modBiblcalFunctions.A6 + 0.002541d * Math.Sin(modBiblcalFunctions.AN); //Line 5630
			modBiblcalFunctions.MM = (modBiblcalFunctions.MM - Math.Floor(modBiblcalFunctions.MM / 360d) * 360d) * modBiblcalFunctions.DR;
			//Line 5640
			modBiblcalFunctions.LM = 270.434164d + 481267.8831d * modBiblcalFunctions.JT - 0.001133d * Math.Pow(modBiblcalFunctions.JT, 2) + 0.0000019d * Math.Pow(modBiblcalFunctions.JT, 3);
			//Line 5650
			modBiblcalFunctions.LM = modBiblcalFunctions.LM + 0.000233d * Math.Sin(modBiblcalFunctions.A4) + modBiblcalFunctions.A6 + 0.001964d * Math.Sin(modBiblcalFunctions.AN);
			modBiblcalFunctions.LM = (modBiblcalFunctions.LM - Math.Floor(modBiblcalFunctions.LM / 360d) * 360d);
			//Line 5660
			modBiblcalFunctions.S1 = 358.475833d + 35999.0498d * modBiblcalFunctions.JT - 0.00015d * Math.Pow(modBiblcalFunctions.JT, 2) - 0.0000033d * Math.Pow(modBiblcalFunctions.JT, 3);
			modBiblcalFunctions.S1 -= 0.001778d * Math.Sin(modBiblcalFunctions.A4); //Line 5670
			modBiblcalFunctions.S1 = (modBiblcalFunctions.S1 - Math.Floor(modBiblcalFunctions.S1 / 360d) * 360d) * modBiblcalFunctions.DR;
			//Line 5680
			modBiblcalFunctions.DM = 350.737486d + 445267.1142d * modBiblcalFunctions.JT - 0.001436d * Math.Pow(modBiblcalFunctions.JT, 2) + 0.0000019d * Math.Pow(modBiblcalFunctions.JT, 3);
			//Line 5690
			modBiblcalFunctions.DM = modBiblcalFunctions.DM + 0.002011d * Math.Sin(modBiblcalFunctions.A4) + modBiblcalFunctions.A6 + 0.001964d * Math.Sin(modBiblcalFunctions.AN);
			modBiblcalFunctions.DM = (modBiblcalFunctions.DM - Math.Floor(modBiblcalFunctions.DM / 360d) * 360d) * modBiblcalFunctions.DR; //Line 5700
			//Line 5710
			modBiblcalFunctions.FM = 11.250889d + 483202.0251d * modBiblcalFunctions.JT - 0.003211d * Math.Pow(modBiblcalFunctions.JT, 2) - 0.0000003d * Math.Pow(modBiblcalFunctions.JT, 3);
			//Line 5720
			modBiblcalFunctions.FM = modBiblcalFunctions.FM + modBiblcalFunctions.A6 - 0.024691d * Math.Sin(modBiblcalFunctions.AN) - 0.004328d * Math.Sin(modBiblcalFunctions.A7);
			modBiblcalFunctions.FM = (modBiblcalFunctions.FM - Math.Floor(modBiblcalFunctions.FM / 360d) * 360d) * modBiblcalFunctions.DR; //Line 5730
			modBiblcalFunctions.E1 = 1d - 0.002495d * modBiblcalFunctions.JT - 0.00000752d * Math.Pow(modBiblcalFunctions.JT, 2); //Line 5740
			//Line 5750
			modBiblcalFunctions.L = modBiblcalFunctions.LM + 6.28875d * Math.Sin(modBiblcalFunctions.MM) + 1.274018d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.MM) + 0.658309d * Math.Sin(2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.213616d * Math.Sin(2d * modBiblcalFunctions.MM) - (0.185596d * Math.Sin(modBiblcalFunctions.S1)) * modBiblcalFunctions.E1 - 0.114336d * Math.Sin(2d * modBiblcalFunctions.FM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.058793d * Math.Sin(2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.MM) + (0.057212d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM)) * modBiblcalFunctions.E1;
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.05332d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.MM) + (0.045874d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1)) * modBiblcalFunctions.E1;
			modBiblcalFunctions.L = modBiblcalFunctions.L + (0.041024d * Math.Sin(modBiblcalFunctions.MM - modBiblcalFunctions.S1)) * modBiblcalFunctions.E1 - 0.034718d * Math.Sin(modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L - modBiblcalFunctions.E1 * 0.030465d * Math.Sin(modBiblcalFunctions.S1 + modBiblcalFunctions.MM) + 0.015326d * Math.Sin(2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.FM);
			modBiblcalFunctions.L = modBiblcalFunctions.L - 0.012528d * Math.Sin(2d * modBiblcalFunctions.FM + modBiblcalFunctions.MM) - 0.01098d * Math.Sin(2d * modBiblcalFunctions.FM - modBiblcalFunctions.MM) + 0.010674d * Math.Sin(4d * modBiblcalFunctions.DM - modBiblcalFunctions.MM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.010034d * Math.Sin(3d * modBiblcalFunctions.MM) + 0.008548d * Math.Sin(4d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.MM);
			modBiblcalFunctions.L = modBiblcalFunctions.L - 0.00791d * Math.Sin(modBiblcalFunctions.S1 - modBiblcalFunctions.MM + 2d * modBiblcalFunctions.DM) * modBiblcalFunctions.E1 - modBiblcalFunctions.E1 * 0.006783d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.S1);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.005162d * Math.Sin(modBiblcalFunctions.MM - modBiblcalFunctions.DM) + modBiblcalFunctions.E1 * 0.005d * Math.Sin(modBiblcalFunctions.S1 + modBiblcalFunctions.DM);
			// If MZ <> 0 Then            '5850 IF MZ = 0 THEN GOTO 6000
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.004049d * Math.Sin(modBiblcalFunctions.MM - modBiblcalFunctions.S1 + 2d * modBiblcalFunctions.DM) + 0.003996d * Math.Sin(2d * modBiblcalFunctions.MM + 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.003862d * Math.Sin(4d * modBiblcalFunctions.DM) + 0.003665d * Math.Sin(2d * modBiblcalFunctions.DM - 3d * modBiblcalFunctions.MM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.002695d * Math.Sin(2d * modBiblcalFunctions.MM - modBiblcalFunctions.S1) + 0.002602d * Math.Sin(modBiblcalFunctions.MM - 2d * modBiblcalFunctions.FM - 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.002396d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.MM) - 0.002349d * Math.Sin(modBiblcalFunctions.MM + modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + Math.Pow(modBiblcalFunctions.E1, 2) * 0.002249d * Math.Sin(2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.S1) - modBiblcalFunctions.E1 * 0.002125d * Math.Sin(2d * modBiblcalFunctions.MM + modBiblcalFunctions.S1);
			modBiblcalFunctions.L = modBiblcalFunctions.L - Math.Pow(modBiblcalFunctions.E1, 2) * 0.002079d * Math.Sin(2d * modBiblcalFunctions.S1) + Math.Pow(modBiblcalFunctions.E1, 2) * 0.002059d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.MM - 2d * modBiblcalFunctions.S1);
			modBiblcalFunctions.L = modBiblcalFunctions.L - 0.001773d * Math.Sin(modBiblcalFunctions.MM + 2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.FM) - 0.001595d * Math.Sin(2d * modBiblcalFunctions.FM + 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.00122d * Math.Sin(4d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM) - 0.00111d * Math.Sin(2d * modBiblcalFunctions.MM + 2d * modBiblcalFunctions.FM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.000892d * Math.Sin(modBiblcalFunctions.MM - 3d * modBiblcalFunctions.DM) - modBiblcalFunctions.E1 * 0.000811d * Math.Sin(modBiblcalFunctions.S1 + modBiblcalFunctions.MM + 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.000761d * Math.Sin(4d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.MM) + Math.Pow(modBiblcalFunctions.E1, 2) * 0.000717d * Math.Sin(modBiblcalFunctions.MM - 2d * modBiblcalFunctions.S1);
			modBiblcalFunctions.L = modBiblcalFunctions.L + Math.Pow(modBiblcalFunctions.E1, 2) * 0.000704d * Math.Sin(modBiblcalFunctions.MM - 2d * modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.DM) + modBiblcalFunctions.E1 * 0.000693d * Math.Sin(modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.MM + 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.L += modBiblcalFunctions.E1 * 0.000598d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.FM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + 0.00055d * Math.Sin(modBiblcalFunctions.MM + 4d * modBiblcalFunctions.DM) + 0.000538d * Math.Sin(4d * modBiblcalFunctions.MM);
			modBiblcalFunctions.L = modBiblcalFunctions.L + modBiblcalFunctions.E1 * 0.000521d * Math.Sin(4 * modBiblcalFunctions.DM - modBiblcalFunctions.S1) + 0.000486d * Math.Sin(2d * modBiblcalFunctions.MM - modBiblcalFunctions.DM);
			// End If
			//Line 6000
			modBiblcalFunctions.LB = 5.128189d * Math.Sin(modBiblcalFunctions.FM) + 0.280606d * Math.Sin(modBiblcalFunctions.MM + modBiblcalFunctions.FM) + 0.277693d * Math.Sin(modBiblcalFunctions.MM - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.173238d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.FM) + 0.055413d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM - modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.046272d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.FM - modBiblcalFunctions.MM) + 0.032573d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.017198d * Math.Sin(2d * modBiblcalFunctions.MM + modBiblcalFunctions.FM) + 0.009267d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.MM - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.008823d * Math.Sin(2d * modBiblcalFunctions.MM - modBiblcalFunctions.FM) + modBiblcalFunctions.E1 * 0.008247d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.004323d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.FM - 2d * modBiblcalFunctions.MM) + 0.0042d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM + modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + modBiblcalFunctions.E1 * 0.003372d * Math.Sin(modBiblcalFunctions.FM - modBiblcalFunctions.S1 - 2d * modBiblcalFunctions.DM) + modBiblcalFunctions.E1 * 0.002472d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM);
			// If MZ <> 0 Then              'IF MZ = 0 THEN GOTO 6220
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + modBiblcalFunctions.E1 * 0.002222d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM - modBiblcalFunctions.S1) + modBiblcalFunctions.E1 * 0.002072d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.FM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + modBiblcalFunctions.E1 * 0.001877d * Math.Sin(modBiblcalFunctions.FM - modBiblcalFunctions.S1 + modBiblcalFunctions.MM) + 0.001828d * Math.Sin(4d * modBiblcalFunctions.DM - modBiblcalFunctions.FM - modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB - modBiblcalFunctions.E1 * 0.001803d * Math.Sin(modBiblcalFunctions.FM + modBiblcalFunctions.S1) - 0.00175d * Math.Sin(3d * modBiblcalFunctions.FM) + modBiblcalFunctions.E1 * 0.00157d * Math.Sin(modBiblcalFunctions.MM - modBiblcalFunctions.S1 - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB - 0.001487d * Math.Sin(modBiblcalFunctions.FM + modBiblcalFunctions.DM) - modBiblcalFunctions.E1 * 0.001481d * Math.Sin(modBiblcalFunctions.FM + modBiblcalFunctions.S1 + modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + modBiblcalFunctions.E1 * 0.001417d * Math.Sin(modBiblcalFunctions.FM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM) + modBiblcalFunctions.E1 * 0.00135d * Math.Sin(modBiblcalFunctions.FM - modBiblcalFunctions.S1) + 0.00133d * Math.Sin(modBiblcalFunctions.FM - modBiblcalFunctions.DM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.001106d * Math.Sin(modBiblcalFunctions.FM + 3d * modBiblcalFunctions.MM) + 0.00102d * Math.Sin(4d * modBiblcalFunctions.DM - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.000833d * Math.Sin(modBiblcalFunctions.FM + 4d * modBiblcalFunctions.DM - modBiblcalFunctions.MM) + 0.000781d * Math.Sin(modBiblcalFunctions.MM - 3d * modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.00067d * Math.Sin(modBiblcalFunctions.FM + 4d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.MM) + 0.000606d * Math.Sin(2d * modBiblcalFunctions.DM - 3d * modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.000597d * Math.Sin(2d * modBiblcalFunctions.DM + 2d * modBiblcalFunctions.MM - modBiblcalFunctions.FM) + modBiblcalFunctions.E1 * 0.000492d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.MM - modBiblcalFunctions.S1 - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.00045d * Math.Sin(2d * modBiblcalFunctions.MM - modBiblcalFunctions.FM - 2d * modBiblcalFunctions.DM) + 0.000439d * Math.Sin(3d * modBiblcalFunctions.MM - modBiblcalFunctions.FM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.000423d * Math.Sin(modBiblcalFunctions.FM + 2d * modBiblcalFunctions.DM + 2d * modBiblcalFunctions.MM) + 0.000422d * Math.Sin(2d * modBiblcalFunctions.DM - modBiblcalFunctions.FM - 3d * modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB - modBiblcalFunctions.E1 * 0.000367d * Math.Sin(modBiblcalFunctions.S1 + modBiblcalFunctions.FM + 2d * modBiblcalFunctions.DM - modBiblcalFunctions.MM) - modBiblcalFunctions.E1 * 0.000353d * Math.Sin(modBiblcalFunctions.S1 + modBiblcalFunctions.FM + 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + 0.000331d * Math.Sin(modBiblcalFunctions.FM + 4d * modBiblcalFunctions.DM) + modBiblcalFunctions.E1 * 0.000317d * Math.Sin(2d * modBiblcalFunctions.DM + modBiblcalFunctions.FM - modBiblcalFunctions.S1 + modBiblcalFunctions.MM);
			modBiblcalFunctions.LB = modBiblcalFunctions.LB + Math.Pow(modBiblcalFunctions.E1, 2) * 0.000306d * Math.Sin(2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.S1 - modBiblcalFunctions.FM) - 0.000283d * Math.Sin(modBiblcalFunctions.MM + 3d * modBiblcalFunctions.FM);
			// End If
			//Line 6220
			modBiblcalFunctions.HP = 0.950724d + 0.051818d * Math.Cos(modBiblcalFunctions.MM) + 0.009531d * Math.Cos(2d * modBiblcalFunctions.DM - modBiblcalFunctions.MM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + 0.007843d * Math.Cos(2d * modBiblcalFunctions.DM) + 0.002824d * Math.Cos(2d * modBiblcalFunctions.MM);
			// If MZ <> 0 Then     'IF MZ = 0 THEN GOTO 6380
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + 0.000857d * Math.Cos(2d * modBiblcalFunctions.DM + modBiblcalFunctions.MM) + modBiblcalFunctions.E1 * (0.000533d * Math.Cos(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + modBiblcalFunctions.E1 * (0.000401d * Math.Cos(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM)) + modBiblcalFunctions.E1 * (0.00032d * Math.Cos(modBiblcalFunctions.MM - modBiblcalFunctions.S1));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - 0.000271d * Math.Cos(modBiblcalFunctions.DM) - modBiblcalFunctions.E1 * (0.000264d * Math.Cos(modBiblcalFunctions.S1 + modBiblcalFunctions.MM));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - 0.000198d * Math.Cos(2d * modBiblcalFunctions.FM - modBiblcalFunctions.MM) + 0.000173d * Math.Cos(3d * modBiblcalFunctions.MM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + 0.000167d * Math.Cos(4d * modBiblcalFunctions.DM - modBiblcalFunctions.MM) - modBiblcalFunctions.E1 * (0.000111d * Math.Cos(modBiblcalFunctions.S1));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + 0.000103d * Math.Cos(4d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.MM) - 0.000084d * Math.Cos(2d * modBiblcalFunctions.MM - 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - modBiblcalFunctions.E1 * (0.000083d * Math.Cos(2d * modBiblcalFunctions.DM + modBiblcalFunctions.S1)) + 0.000079d * Math.Cos(2d * modBiblcalFunctions.DM + 2d * modBiblcalFunctions.MM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + 0.000072d * Math.Cos(4d * modBiblcalFunctions.DM) + modBiblcalFunctions.E1 * (0.000064d * Math.Cos(2d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 + modBiblcalFunctions.MM));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - modBiblcalFunctions.E1 * (0.000063d * Math.Cos(2d * modBiblcalFunctions.DM + modBiblcalFunctions.S1 - modBiblcalFunctions.MM)) + modBiblcalFunctions.E1 * (0.000041d * Math.Cos(modBiblcalFunctions.S1 + modBiblcalFunctions.DM));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP + modBiblcalFunctions.E1 * (0.000035d * Math.Cos(2d * modBiblcalFunctions.MM - modBiblcalFunctions.S1)) - 0.000033d * Math.Cos(3d * modBiblcalFunctions.MM - 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - 0.00003d * Math.Cos(modBiblcalFunctions.MM + modBiblcalFunctions.DM) - 0.000029d * Math.Cos(2d * modBiblcalFunctions.FM - 2d * modBiblcalFunctions.DM);
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - modBiblcalFunctions.E1 * (0.000029d * Math.Cos(2d * modBiblcalFunctions.MM + modBiblcalFunctions.S1)) + Math.Pow(modBiblcalFunctions.E1, 2) * (0.000026d * Math.Cos(2d * modBiblcalFunctions.DM - 2d * modBiblcalFunctions.S1));
			modBiblcalFunctions.HP = modBiblcalFunctions.HP - 0.000023d * Math.Cos(2d * modBiblcalFunctions.FM - 2d * modBiblcalFunctions.DM + modBiblcalFunctions.MM) + modBiblcalFunctions.E1 * (0.000019d * Math.Cos(4d * modBiblcalFunctions.DM - modBiblcalFunctions.S1 - modBiblcalFunctions.MM));
			// End If
			//Line 6380
			modBiblcalFunctions.W1 = 0.0004664d * Math.Cos(modBiblcalFunctions.AN);
			modBiblcalFunctions.W3 = (275.05d - 2.3d * modBiblcalFunctions.JT) * modBiblcalFunctions.DR;
			modBiblcalFunctions.W2 = 0.0000754d * Math.Cos(modBiblcalFunctions.AN + modBiblcalFunctions.W3);
			modBiblcalFunctions.LB *= (1d - modBiblcalFunctions.W1 - modBiblcalFunctions.W2);
			modBiblcalFunctions.L *= modBiblcalFunctions.DR; // Geocentric longitude of the moon, converted to Radians
			modBiblcalFunctions.LB *= modBiblcalFunctions.DR; // Geocentric latitude of the moon, converted to Radians
			modBiblcalFunctions.D7 = Math.Sin(modBiblcalFunctions.LB) * Math.Cos(modBiblcalFunctions.EO) + Math.Cos(modBiblcalFunctions.LB) * Math.Sin(modBiblcalFunctions.EO) * Math.Sin(modBiblcalFunctions.L);
			modBiblcalFunctions.D8 = Math.Atan(modBiblcalFunctions.D7 / Math.Sqrt((-modBiblcalFunctions.D7) * modBiblcalFunctions.D7 + 1d)); // converts equatorial to ecliptical (declination)
			// was: HZ = (((0.7275 * HP - 0.5666667) * DR) - Sin(LT) * Sin(D8)) / (Cos(LT) * Cos(D8)) ' Moon Rise/Set Time Calc.
			modBiblcalFunctions.HZ = (Math.Sin((0.7275d * modBiblcalFunctions.HP - 0.5666667d) * modBiblcalFunctions.DR) - Math.Sin(modBiblcalFunctions.LT) * Math.Sin(modBiblcalFunctions.D8)) / (Math.Cos(modBiblcalFunctions.LT) * Math.Cos(modBiblcalFunctions.D8)); // Moon Rise/Set Time Calc.
			modBiblcalFunctions.HW = ((-Math.Atan(modBiblcalFunctions.HZ / Math.Sqrt((-modBiblcalFunctions.HZ) * modBiblcalFunctions.HZ + 1d)) + 1.570796326795d) * 3.8197186342055d); // Moon Rise/Set Time Calc.
			modBiblcalFunctions.B2 = (Math.Sin(modBiblcalFunctions.L) * Math.Cos(modBiblcalFunctions.EO) - Math.Tan(modBiblcalFunctions.LB) * Math.Sin(modBiblcalFunctions.EO));
			modBiblcalFunctions.B4 = Math.Cos(modBiblcalFunctions.L);
			modBiblcalFunctions.B6 = Math.Atan(modBiblcalFunctions.B2 / modBiblcalFunctions.B4);
			if (modBiblcalFunctions.B2 > 0d && modBiblcalFunctions.B4 < 0d)
			{
				modBiblcalFunctions.B6 += modBiblcalFunctions.PI;
			}
			if (modBiblcalFunctions.B2 < 0d && modBiblcalFunctions.B4 < 0d)
			{
				modBiblcalFunctions.B6 += modBiblcalFunctions.PI;
			}
			if (modBiblcalFunctions.B2 < 0d && modBiblcalFunctions.B4 > 0d)
			{
				modBiblcalFunctions.B6 += 2d * modBiblcalFunctions.PI;
			}
			modBiblcalFunctions.B3 = modBiblcalFunctions.B6 * 3.8197186342055d; // B3 is the right ascension of the moon
			modBiblcalFunctions.KT = (IA - 2415019.5d) / 36525d;
			modBiblcalFunctions.S4 = 6.6460656d + 2400.051262d * modBiblcalFunctions.KT + 0.00002581d * Math.Pow(modBiblcalFunctions.KT, 2);
			modBiblcalFunctions.S5 = modBiblcalFunctions.S4 - Math.Floor(modBiblcalFunctions.S4 / 24d) * 24d; //Correction to Sidereal Time
			//TM = 12# + S5 - B3 - 24# * DT ' NEW DT TEST ######################################
			modBiblcalFunctions.TM = 12d + modBiblcalFunctions.S5 - modBiblcalFunctions.B3 - 0.065712d * modBiblcalFunctions.DT; // WHY THIS coeff ON DT?
			if (modBiblcalFunctions.TM > 24d)
			{
				modBiblcalFunctions.TM -= 24d;
			}
			if (modBiblcalFunctions.TM < 0d)
			{
				modBiblcalFunctions.TM = -modBiblcalFunctions.TM;
			}
			else
			{
				modBiblcalFunctions.TM = 24d - modBiblcalFunctions.TM;
			}
			//
			//********************************** Rem Moonset calc: *************************************
			//******************************************************************************************
			if (modBiblcalFunctions.MR == 1)
			{
				goto SixtySevenTen;
			} //Line 6590
			modBiblcalFunctions.HW = modBiblcalFunctions.HW + modBiblcalFunctions.TM + modBiblcalFunctions.MJ + 0.0121d; // do we need this final part of the adjustment?                                    'MJ = Moonset adjustment
			modBiblcalFunctions.MZ++;
			// 0.024166 USED TO ADJUST MOONSET TIME UNTIL Ver 9.6.
			if (modBiblcalFunctions.HW < 0d)
			{
				modBiblcalFunctions.HW += 24d;
			} //Line 6605
			if (modBiblcalFunctions.HW > 24d)
			{
				modBiblcalFunctions.HW -= 24d;
			} // NEW LINE ADDED BGA #################################
			modBiblcalFunctions.HV = modBiblcalFunctions.HW + modBiblcalFunctions.AJ; //Line 6610
			if (modBiblcalFunctions.TS == 0 && modBiblcalFunctions.HV > 12d)
			{ //Line 6620
				modBiblcalFunctions.TS = 1;
				modBiblcalFunctions.MZ = 0;
				IA -= 1d;
				modBiblcalFunctions.MC = (modBiblcalFunctions.HW - 0.81d) / 24d;
				goto FiftyFiveForty;
			}
			modBiblcalFunctions.HV += 12d; //Line 6630
			if (modBiblcalFunctions.HV >= 24d)
			{
				modBiblcalFunctions.HV -= 24d;
			} //Line 6640
			if (modBiblcalFunctions.MZ >= 2d)
			{ //Line 6650
				SixtyEightEighty();
				ILSString = modBiblcalFunctions.FormatToString(Conversion.Val(modBiblcalFunctions.ILString), 4); //First Illuminition
			}
			if (modBiblcalFunctions.IB > IA && modBiblcalFunctions.MZ >= 2 && modBiblcalFunctions.HV >= 22.6d)
			{ //Line 6660
				HQSString = "--";
				HOSString = "--";
				// GoTo SixtySixNinty
			}
			else
			{
				if (modBiblcalFunctions.MZ < 2)
				{ //Line 6670
					modBiblcalFunctions.MC = modBiblcalFunctions.HW / 24d;
					goto FiftyFiveForty;
				}
				else
				{
					modBiblcalFunctions.HQS = Math.Floor((modBiblcalFunctions.HV - Math.Floor(modBiblcalFunctions.HV)) * 60d);
					modBiblcalFunctions.HOS = Math.Floor(modBiblcalFunctions.HV);
				}
				//                         Setting up Moonset time
				HQSString = Conversion.Str(modBiblcalFunctions.HQS); //Minutes               'Line 6680
				HQSString = HQSString.Substring(1);
				HOSString = Conversion.Str(modBiblcalFunctions.HOS); //Hours
				HOSString = HOSString.Substring(1);
			}

			modBiblcalFunctions.MR = 1; //Line 6690
			modBiblcalFunctions.TS = 0;
			modBiblcalFunctions.MZ = 0;
			modBiblcalFunctions.MC = 0;
			IA = modBiblcalFunctions.IB;
			if (modBiblcalFunctions.HV <= 12.04d || HQSString == "--")
			{
				modBiblcalFunctions.JT += 0.000014d;
			}
			else
			{
				modBiblcalFunctions.JT -= 0.000014d;
			}

			goto FiftyFiveFifty; //Line 6700
			//******************************* Rem: Moonrise Calc:*******************************************
			//**********************************************************************************************
			SixtySevenTen:
			modBiblcalFunctions.HW = -modBiblcalFunctions.HW + modBiblcalFunctions.TM + modBiblcalFunctions.RJ; //Line 6710        RJ is Moonrise adj.
			modBiblcalFunctions.MZ++;

			if (modBiblcalFunctions.HW < 0d)
			{
				modBiblcalFunctions.HW += 24d;
			} //Line 6705 bad numbering
			if (modBiblcalFunctions.HW > 24d)
			{
				modBiblcalFunctions.HW -= 24d;
			} // New line check BGA
			modBiblcalFunctions.HV = modBiblcalFunctions.HW + modBiblcalFunctions.AJ; //Line 6720
			if (modBiblcalFunctions.TS == 0 && modBiblcalFunctions.HV > 12d)
			{ //Line 6730
				modBiblcalFunctions.TS = 1;
				modBiblcalFunctions.MZ = 0;
				IA -= 1d;
				modBiblcalFunctions.MC = (modBiblcalFunctions.HW - 0.81d) / 24d;
				goto FiftyFiveForty; //********************
			}
			//
			modBiblcalFunctions.HV += 12d; //Line 6740
			if (modBiblcalFunctions.HV >= 24d)
			{
				modBiblcalFunctions.HV -= 24d;
			} //Line 6750
			if (modBiblcalFunctions.MZ < 2)
			{ //Line 6760
				modBiblcalFunctions.MC = modBiblcalFunctions.HW / 24d;
				goto FiftyFiveForty;
			}
			else
			{
				modBiblcalFunctions.HQ = Math.Floor((modBiblcalFunctions.HV - Math.Floor(modBiblcalFunctions.HV)) * 60d);
				modBiblcalFunctions.HO = Math.Floor(modBiblcalFunctions.HV);
			}

			if (modBiblcalFunctions.IB > IA && modBiblcalFunctions.MZ >= 2 && modBiblcalFunctions.HV >= 22.6d)
			{ //Line 6770
				modBiblcalFunctions.HQString = "--";
				modBiblcalFunctions.HOString = "--";
				goto SixtyEightHundred;
			}
			//                       Setting up Moonrise string
			modBiblcalFunctions.HQString = Conversion.Str(modBiblcalFunctions.HQ); //Minutes             'Line 6780
			modBiblcalFunctions.HQString = modBiblcalFunctions.HQString.Substring(1);
			modBiblcalFunctions.HOString = Conversion.Str(modBiblcalFunctions.HO); //Hours
			modBiblcalFunctions.HOString = modBiblcalFunctions.HOString.Substring(1);
			if (modBiblcalFunctions.HO < 10)
			{
				modBiblcalFunctions.HOString = "0" + modBiblcalFunctions.HOString;
			}
			if (modBiblcalFunctions.HQ < 10)
			{ //Line 6790
				modBiblcalFunctions.TPrint(modBiblcalFunctions.HOString + ":0" + modBiblcalFunctions.HQString); //*************************************************
				goto SixtyEightTen;
			}

			SixtyEightHundred:
			modBiblcalFunctions.TPrint(modBiblcalFunctions.HOString + ":" + modBiblcalFunctions.HQString); //Line 6800  ***********************

			SixtyEightTen:
			modBiblcalFunctions.TS = 0; //Line 6810
			SixtyEightEighty();
			if (modBiblcalFunctions.HOString == "--")
			{
				modBiblcalFunctions.ILString = " ----";
			}
			if (modBiblcalFunctions.ILString != " ----")
			{
				modBiblcalFunctions.ILString = modBiblcalFunctions.FormatToString(modBiblcalFunctions.IL, 4);
			}
			modBiblcalFunctions.TPrint("      " + modBiblcalFunctions.ILString); //Line 6820  First Illumination *********
			if (HQSString == "--")
			{
				goto SixtyEightFifty;
			} //Line 6830
			if (modBiblcalFunctions.HOS < 10)
			{
				HOSString = "0" + HOSString;
			}
			if (modBiblcalFunctions.HQS < 10)
			{ //Line 6840
				modBiblcalFunctions.TPrint("    " + HOSString + ":0" + HQSString); //          ***********************
				goto SixtyEightSixty;
			}

			SixtyEightFifty://Line 6850
			modBiblcalFunctions.TPrint("    " + HOSString + ":" + HQSString); //Moonset        *************************

			//
			SixtyEightSixty:
			if (HOSString == "--")
			{
				ILSString = " ----";
			}
			//
			//Print Moonset Illumination           ***************************************************

			modBiblcalFunctions.TPrint("     " + ILSString + modBiblcalFunctions.CRLF); //  Moonset Illumination    *************************
		}

		//Called by 'Times'
		private static void SixtyEightEighty()
		{
			modBiblcalFunctions.DI = Math.Cos(modBiblcalFunctions.L - modBiblcalFunctions.LO) * Math.Cos(modBiblcalFunctions.LB);
			modBiblcalFunctions.DI = -Math.Atan(modBiblcalFunctions.DI / Math.Sqrt((-modBiblcalFunctions.DI) * modBiblcalFunctions.DI + 1d)) + modBiblcalFunctions.PI / 2d;
			modBiblcalFunctions.IM = modBiblcalFunctions.PI - modBiblcalFunctions.DI - (0.1468d * ((1d - 0.0549d * Math.Sin(modBiblcalFunctions.MM)) / (1d - 0.0167d * Math.Sin(modBiblcalFunctions.S1))) * modBiblcalFunctions.DR) * Math.Sin(modBiblcalFunctions.DI);
			modBiblcalFunctions.IL = (float) ((1d + Math.Cos(modBiblcalFunctions.IM)) / 2d);
			modBiblcalFunctions.IL = (float) (Math.Floor(modBiblcalFunctions.IL * 1000 + 0.5d) / 10d);
			modBiblcalFunctions.ILString = Conversion.Str(modBiblcalFunctions.IL);
		}

		//Called by 'Times'
		private static void FiveThousand()
		{
			modBiblcalFunctions.CT = modBiblcalFunctions.LN / 1236.85d;
			modBiblcalFunctions.S = 166.56d + 132.87d * modBiblcalFunctions.CT - 0.009173d * Math.Pow(modBiblcalFunctions.CT, 2);
			modBiblcalFunctions.S -= (Math.Floor(modBiblcalFunctions.S / 360d)) * 360d;
			modBiblcalFunctions.JD = 2415020.75933d + 29.53058868d * modBiblcalFunctions.LN + 0.0001178d * Math.Pow(modBiblcalFunctions.CT, 2);
			modBiblcalFunctions.JD = modBiblcalFunctions.JD - 0.000000155d * Math.Pow(modBiblcalFunctions.CT, 3) + 0.00033d * Math.Sin(modBiblcalFunctions.S * modBiblcalFunctions.DR);
			modBiblcalFunctions.SA = 359.2242d + 29.10535608d * modBiblcalFunctions.LN - 0.0000333d * Math.Pow(modBiblcalFunctions.CT, 2) - 0.00000347d * Math.Pow(modBiblcalFunctions.CT, 3);
			modBiblcalFunctions.SA = (modBiblcalFunctions.SA - (Math.Floor(modBiblcalFunctions.SA / 360d)) * 360d) * modBiblcalFunctions.DR;
			modBiblcalFunctions.MA = 306.0253d + 385.816918d * modBiblcalFunctions.LN + 0.0107306d * Math.Pow(modBiblcalFunctions.CT, 2) + 0.00001236d * Math.Pow(modBiblcalFunctions.CT, 3);
			modBiblcalFunctions.MA = (modBiblcalFunctions.MA - (Math.Floor(modBiblcalFunctions.MA / 360d)) * 360d) * modBiblcalFunctions.DR;
			modBiblcalFunctions.ML = 21.2964d + 390.6705065d * modBiblcalFunctions.LN - 0.0016528d * Math.Pow(modBiblcalFunctions.CT, 2) - 0.00000239d * Math.Pow(modBiblcalFunctions.CT, 3);
			modBiblcalFunctions.ML = (modBiblcalFunctions.ML - (Math.Floor(modBiblcalFunctions.ML / 360d)) * 360d) * modBiblcalFunctions.DR;
			modBiblcalFunctions.AD = (0.1734d - 0.000393d * modBiblcalFunctions.CT) * Math.Sin(modBiblcalFunctions.SA) + 0.0021d * Math.Sin(2d * modBiblcalFunctions.SA) - 0.4068d * Math.Sin(modBiblcalFunctions.MA);
			modBiblcalFunctions.AD = modBiblcalFunctions.AD + 0.0161d * Math.Sin(2d * modBiblcalFunctions.MA) - 0.0004d * Math.Sin(3d * modBiblcalFunctions.MA) + 0.0104d * Math.Sin(2d * modBiblcalFunctions.ML);
			modBiblcalFunctions.AD = modBiblcalFunctions.AD - 0.0051d * Math.Sin(modBiblcalFunctions.SA + modBiblcalFunctions.MA) - 0.0074d * Math.Sin(modBiblcalFunctions.SA - modBiblcalFunctions.MA) + 0.0004d * Math.Sin(2d * modBiblcalFunctions.ML + modBiblcalFunctions.SA);
			modBiblcalFunctions.AD = modBiblcalFunctions.AD - 0.0004d * Math.Sin(2d * modBiblcalFunctions.ML - modBiblcalFunctions.SA) - 0.0006d * Math.Sin(2d * modBiblcalFunctions.ML + modBiblcalFunctions.MA);
			modBiblcalFunctions.AD = modBiblcalFunctions.AD + 0.001d * Math.Sin(2d * modBiblcalFunctions.ML - modBiblcalFunctions.MA) + 0.0005d * Math.Sin(modBiblcalFunctions.SA + 2d * modBiblcalFunctions.MA);
			modBiblcalFunctions.JD += modBiblcalFunctions.AD;
			if (modBiblcalFunctions.JD < 1483746d)
			{
				modBiblcalFunctions.JD -= 0.02778d;
			}
			modBiblcalFunctions.DT = (0.41d + 1.2053d * modBiblcalFunctions.CT + 0.4992d * Math.Pow(modBiblcalFunctions.CT, 2)) / 1440d;
			modBiblcalFunctions.JI = modBiblcalFunctions.JD - modBiblcalFunctions.DT;
			modBiblcalFunctions.JF = modBiblcalFunctions.JI - Math.Floor(modBiblcalFunctions.JI);
			modBiblcalFunctions.JI = Math.Floor(modBiblcalFunctions.JI);
			if (modBiblcalFunctions.JF > 0.7d)
			{
				modBiblcalFunctions.JI += 1d;
			}
			if (modBiblcalFunctions.ZZ == 1)
			{
				modBiblcalFunctions.ZZ = 0;
			}
		}
		//**************************** End of Times Module ******************************************
	}
}