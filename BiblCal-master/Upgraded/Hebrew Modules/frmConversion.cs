using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Windows.Forms;
using UpgradeHelpers.Gui;
using UpgradeHelpers.Helpers;

namespace BiblCal
{
	internal partial class frmConversion
		: System.Windows.Forms.Form
	{

		public frmConversion()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			isInitializingComponent = true;
			InitializeComponent();
			isInitializingComponent = false;
			ReLoadForm(false);
		}


		private void frmConversion_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		//*******************************************************************************************
		//*                            CALENDAR CONVERSION PROGRAM                                  *
		//*                                       Ver 11.0                                         *
		//*     Converts between Gregorian date, Hebrew date Biblical date and Julian Day Count     *
		//*                                          -                                              *
		//*   Written by:         Dale D. Donelson, 22 November 2006                                *
		//*                      10140 E Brooks Rd., Lennon, Michigan                               *
		//*                                Phone 810 621 3163                                       *
		//*                         Email: donelson@vinedresser.org                                 *
		//*                                          -                                              *
		//*   Written for:     CENTRAL HIGHLANDS CHRISTIAN PUBLICATIONS                             *
		//*                    PO Box 236, Creswick, Vic. 3363 Australia                            *
		//*                            Phone (614) 0428 457 363                                     *
		//*                         http://www.chcpublications.net/                                 *
		//*                         Email: info@chcpublications.net                                 *
		//*******************************************************************************************
		//Form Conversion

		double CurrentDateMonth = 0; //Month number of each of the possible dates.
		double SecondDateMonth = 0;
		double ThirdDateMonth = 0;
		double FourthDateMonth = 0;
		float[] MoonKey = new float[59]; //Array with key for moon phase pictures


		//******************************************************************************************
		//*                               Form routines follow                                     *
		//******************************************************************************************
		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			MoonKey[0] = 3; //Percent illumination for moon pictures.
			MoonKey[1] = 3.7f; //Not to be confused with Monkey. (beats chest) ;-)
			MoonKey[2] = 9; //Program looks up what picture to show from this array.
			MoonKey[3] = 11;
			MoonKey[4] = 13;
			MoonKey[5] = 15;
			MoonKey[6] = 18;
			MoonKey[7] = 20;
			MoonKey[8] = 23;
			MoonKey[9] = 26;
			MoonKey[10] = 29;
			MoonKey[11] = 33;
			MoonKey[12] = 36;
			MoonKey[13] = 40;
			MoonKey[14] = 43;
			MoonKey[15] = 47;
			MoonKey[16] = 51;
			MoonKey[17] = 53;
			MoonKey[18] = 57;
			MoonKey[19] = 61;
			MoonKey[20] = 64;
			MoonKey[21] = 67.5f;
			MoonKey[22] = 71;
			MoonKey[23] = 73;
			MoonKey[24] = 77;
			MoonKey[25] = 79;
			MoonKey[26] = 83;
			MoonKey[27] = 84.5f;
			MoonKey[28] = 87;
			MoonKey[29] = 89.5f;
			MoonKey[30] = 91;
			MoonKey[31] = 88.5f;
			MoonKey[32] = 86;
			MoonKey[33] = 84;
			MoonKey[34] = 80.5f;
			MoonKey[35] = 78;
			MoonKey[36] = 74;
			MoonKey[37] = 73;
			MoonKey[38] = 68.5f;
			MoonKey[39] = 65.5f;
			MoonKey[40] = 62.5f;
			MoonKey[41] = 59;
			MoonKey[42] = 55.5f;
			MoonKey[43] = 52;
			MoonKey[44] = 48;
			MoonKey[45] = 45;
			MoonKey[46] = 41.5f;
			MoonKey[47] = 37.5f;
			MoonKey[48] = 34.5f;
			MoonKey[49] = 31.5f;
			MoonKey[50] = 28;
			MoonKey[51] = 25;
			MoonKey[52] = 22.5f;
			MoonKey[53] = 19;
			MoonKey[54] = 17;
			MoonKey[55] = 14;
			MoonKey[56] = 12;
			MoonKey[57] = 9.5f;
			MoonKey[58] = 7.5f;
			modHebrewCalendarFunctions.LoadHebrewVariables();
			BuildGMonthList(); //Put the Gregorian Month names in list
			BuildJCMonthList(); //Put the Julian Calendar Month names in list
			BuildHMonthList(); //Put the Hebrew Month names in list
			BuildBMonthList(); //Put the Biblical Month names in list
			txtGYear.Text = DateTime.Today.Year.ToString(); //Get the current year from computer
			txtGMonth.Text = lstGMonth.GetListItem(DateTime.Today.Month - 1); //Get the current month name from list
			ListBoxHelper.SetSelected(lstGMonth, DateTime.Today.Month - 1, true); //Make it show Selected in the list
			txtGDay.Text = DateAndTime.Day(DateTime.Today).ToString(); //Get the current day from computer
			cmdGCompute_Click(cmdGCompute, new EventArgs()); //Press the Gregorian Compute button
		}

		private void BuildHMonthList()
		{
			//Builds the Hebrew month selection list
			int Index = 0; //Index for going through the table

			for (Index = 1; Index <= 13; Index++)
			{ //Get the Month Names and put them in the list box
				lstHMonth.AddItem(modHebrewCalendarFunctions.HMonthName[Index], Index - 1);
			}
		}

		private void BuildGMonthList()
		{
			//Builds the Gregorian month selection list
			int Index = 0; //Index for going through the Month Name table

			for (Index = 1; Index <= 12; Index++)
			{ //Get the Month Names and put them in the list box
				lstGMonth.AddItem(modHebrewCalendarFunctions.MonthName2[Index], Index - 1);
			}
		}

		private void BuildJCMonthList()
		{
			//Builds the Julian Calendar month selection list
			int Index = 0; //Index for going through the Month Name table

			for (Index = 1; Index <= 12; Index++)
			{ //Get the Month Names and put them in the list box
				lstJCMonth.AddItem(modHebrewCalendarFunctions.MonthName2[Index], Index - 1);
			}
		}

		private void BuildBMonthList()
		{
			//Builds the Biblical month selection list
			int Index = 0;

			for (Index = 1; Index <= 13; Index++)
			{
				lstBMonth.AddItem(modHebrewCalendarFunctions.BMonthName[Index], Index - 1);
			}
		}
		//******************************************************************************************
		//*                         Form Button routines follow                                    *
		//******************************************************************************************
		private void cmdGCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			//Button to convert to Hebrew and Biblical month day, year and Julian day count.

			//Steps in this subroutine.

			//1)Check input in text boxes for limits.
			//2)Get the Julian Day Count for date and put it in the JDCount text box
			//3)Take the Julian Day Count and convert to Gregorian date and place results in text boxes
			//4)Compute the Biblical date and put results in the text boxes
			//5)Compute the Hebrew date and put results in the text boxes
			//6)Compute the Julian date and put results in the text boxes
			//7)Compute moon phase and show it in the picture.

			//1)Check input in text boxes for limits.

			if (Conversion.Val(txtGYear.Text) > 29000)
			{
				txtGYear.Text = "29000"; //Set the high limit
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGYear.Text) < -4500)
			{
				txtGYear.Text = "-4500"; //Set the low limit
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGDay.Text) > 1000)
			{
				txtGDay.Text = "1000"; //Limit days to keep from failure
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGDay.Text) < -1000)
			{
				txtGDay.Text = "-1000"; //Low limit for Gregorian day
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGYear.Text) == 0)
			{
				txtGYear.Text = "-1";
			} //Fix for no year zero

			//2)Get the Julian Day Count for date
			int GYear = Convert.ToInt32(Conversion.Val(txtGYear.Text)); //Gregorian Year number //Get the Gregorian year from the text box
			int GMonth = (ListBoxHelper.GetSelectedIndex(lstGMonth)) + 1; //Gregorian Month number //Get the Gregorian month number from the list box
			int GDay = Convert.ToInt32(Conversion.Val(txtGDay.Text)); //Gregorian Day number //Get the Gregorian day number from the text box
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.ConvertToJulian2(GMonth, GDay, GYear); //Get the Julian Day count for that date
			txtJDCount.Text = modBiblcalFunctions.JD.ToString(); //Put the result in the Julian day count text box

			//3)Take the Julian Day Count and convert to Gregorian date and place results in text boxes
			UpDateGregorian(); //Update the Gregorian Calendar variables
			//4) Compute the Biblical dates and put results in the text boxes
			UpDateBiblical(); //Update the Calculated Biblical Calendar variables
			//5) Compute the Hebrew dates and put results in the text boxes
			UpDateHebrew(); //Update the Hebrew Calendar variables
			UpDateJulianCalendar(); //Update the Julian Calendar variables
			ComputeBiblical(); //Calculate the Biblical date
			if (frmCriteria.DefInstance.Visible)
			{ //If the 'Criteria' form is showing then
				optDate1.Checked = false;
				optDate1.Checked = true;
			}
			ShowMoon(); //Show moon phase picture
		}

		private void UpDateGregorian()
		{
			//UpDates the Gregorian area from the Julian Day Count in JDCount text box
			int GYear = 0; //Gregorian Year number
			double TempJD = 0; //Temporary storeage for Julian Day Count


			//3)Take the Julian Day Count and convert to Gregorian date.
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text); //Get the value of Julian count from text box
			modHebrewCalendarFunctions.JulianToMDY2(); //Get the Gregorian day, month and year numbers

			//Put Gregorian Date in it's text boxes.
			txtGDay.Text = Conversion.Val(modBiblcalFunctions.DAString).ToString(); //Put the Gregorian day number in it's box
			txtGYear.Text = Conversion.Val(modBiblcalFunctions.GregorianYearString).ToString(); //Put the Gregorian year number in it's box
			txtGMonth.Text = lstGMonth.GetListItem(Convert.ToInt32((Conversion.Val(modBiblcalFunctions.MHString)) - 1)); //Get the Gregorian Month name and put in text box
			ListBoxHelper.SetSelected(lstGMonth, Convert.ToInt32(Conversion.Val(modBiblcalFunctions.MHString) - 1), true); //Make it show selected in the list
			modBiblcalFunctions.PrintFlag = false; //Get the proper day of the week
			modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "Conversions";
			modBiblcalFunctions.AA = modBiblcalFunctions.JD + 0.5d; //possibly having to be corrected
			modBiblcalFunctions.PrintDayAndDate(); //for the 48 hour day occuring
			modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
			modBiblcalFunctions.PrintFlag = true; //18 & 19 July 1504 BCE
			if (Conversion.Val(txtJDCount.Text) <= modBiblcalFunctions.JDNJLD)
			{
				fraGregorian.Text = "Modified Gregorian";
			}
			else
			{
				fraGregorian.Text = "Gregorian";
			}
			lblGDayOfWeek.Text = modHebrewCalendarFunctions.DayName2[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
			int tempRefParam = Convert.ToInt32(Conversion.Val(txtGYear.Text));
			if (modHebrewCalendarFunctions.GregorianLeapYear(ref tempRefParam))
			{ //Put Greg year type in label caption
				lblGYearType.Text = "Leap Year (366 days)";
			}
			else
			{
				lblGYearType.Text = "Normal Year (365 days)";
			}
			//Limit Input to keep from Overflow failure
			if (Conversion.Val(txtGYear.Text) > 29000)
			{
				txtGYear.Text = "29000"; //Set the high limit
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGYear.Text) < -4500)
			{
				txtGYear.Text = "-4500"; //Set the low limit
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGDay.Text) > 1000)
			{
				txtGDay.Text = "1000"; //Limit days to keep from failure
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGDay.Text) < -1000)
			{
				txtGDay.Text = "-1000"; //Low limit for Gregorian day
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtGYear.Text) == 0)
			{
				txtGYear.Text = "-1";
			}
			//*********** Done with Gregorian variables
		}

		private void UpDateJulianCalendar()
		{
			//Updates the Julian Calenar area from the Julian Day count text box
			int Year = 0;
			int Day = 0;
			int Month = 0;

			double TempJD = Conversion.Val(txtJDCount.Text);
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text);
			modHebrewCalendarFunctions.Jd_To_Julian(modBiblcalFunctions.JD, ref Year, ref Month, ref Day);
			txtJCDay.Text = Day.ToString();
			txtJCYear.Text = Year.ToString();
			txtJCMonth.Text = lstJCMonth.GetListItem(Month - 1);
			ListBoxHelper.SetSelected(lstJCMonth, Month - 1, true);
		}

		private void UpDateBiblical()
		{
			//Updates the Biblical area from the Julian Day count text box

			//4)Compute the Biblical date and put results in the text boxes
			double TempJD = Conversion.Val(txtJDCount.Text); //Temporary storage for Julian Day Count //Save the Julian day count
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text); //Get the Julian day count
			modBiblcalFunctions.JulianToBiblical(modBiblcalFunctions.JD, ref modBiblcalFunctions.BMonth, ref modBiblcalFunctions.BDay, ref modBiblcalFunctions.BYear); //Compute the Biblical M/D/Y
			txtBDay.Text = modBiblcalFunctions.BDay.ToString(); //Put the Biblical day where it belongs
			txtBYear.Text = modBiblcalFunctions.BYear.ToString(); //Put the Biblical year where it belongs
			txtBMonth.Text = lstBMonth.GetListItem(modBiblcalFunctions.BMonth - 1); //Put the name of the Biblical month in
			ListBoxHelper.SetSelected(lstBMonth, modBiblcalFunctions.BMonth - 1, true); //Make is show selected on list
			modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "Conversions";
			modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
			modBiblcalFunctions.PrintFlag = false; //Don't print when geting day number
			modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
			modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
			modBiblcalFunctions.PrintFlag = true; //Enable printing
			lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
			txtJDCount.Text = TempJD.ToString(); //Restore the Julian Day cou
			//************ Done with Biblical variables
			//Call ShowMoon
		}

		private void UpDateHebrew()
		{
			//Updates the Hebrew area from the Julian day count text box
			double iYear = 0; //Hebrew Year number
			int iDay = 0; //Hebrew Day number
			int iMonth = 0; //Hebrew Month number
			int NumberOfRules = 0; //Number of postponement rules applied

			//5)Compute the Hebrew date and put results in the text boxes
			double TempJD = Conversion.Val(txtJDCount.Text); //Temporary storage for Julian Day Count
			int GYear = Convert.ToInt32(Conversion.Val(txtGYear.Text)); //Gregorian Year number //Get the Gregorian year from text box

			//Now put the Hebrew Rabbinic variables in
			double jdn = Conversion.Val(txtJDCount.Text); //Set up for the call
			modHebrewCalendarFunctions.JDToHebrew(jdn, ref iMonth, ref iDay, ref iYear); //Get the Hebrew Month, Day and year
			txtHYear.Text = iYear.ToString(); //Put the Hebrew Year in the year text box
			txtHMonth.Text = lstHMonth.GetListItem(iMonth - 1); //Get the month name from the list and put in text box
			ListBoxHelper.SetSelected(lstHMonth, iMonth - 1, true); //Make it show selected in the list
			txtHDay.Text = iDay.ToString(); //Put the Hebrew day number in the text box
			txtHMonth.Text = lstHMonth.GetListItem(iMonth - 1); //Put the Hebrew month name in the text box
			GYear = Convert.ToInt32(iYear - 3761);
			if (GYear < 1)
			{
				GYear--;
			}
			lblHYearType.Text = modHebrewCalendarFunctions.TypeYear[modHebrewCalendarFunctions.TypeOfYear(GYear)]; //Put Heb year type in label caption
			lblHDay.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(Conversion.Val(((Convert.ToInt32((Double.Parse(txtJDCount.Text)) + 1.5d)) % 7).ToString()))];
			//Compute the Molad of Tishri
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.MoladOfTishri(Convert.ToInt32(Conversion.Val(txtHYear.Text) - 3761), ref modHebrewCalendarFunctions.Weeks, ref modHebrewCalendarFunctions.Days, ref modHebrewCalendarFunctions.Hours, ref modHebrewCalendarFunctions.Parts);
			modBiblcalFunctions.JD = TempJD;
			lblMolad1.Text = modHebrewCalendarFunctions.Days.ToString() + "D " + modHebrewCalendarFunctions.Hours.ToString() + "H " + modHebrewCalendarFunctions.Parts.ToString() + "P "; //Fill in molad text
			//Check the postponement rules
			modHebrewCalendarFunctions.CheckRules(Convert.ToInt32(iYear), Convert.ToInt32(modHebrewCalendarFunctions.Days), Convert.ToInt32(modHebrewCalendarFunctions.Hours), Convert.ToInt32(modHebrewCalendarFunctions.Parts), ref modHebrewCalendarFunctions.Rule1, ref modHebrewCalendarFunctions.Rule2, ref modHebrewCalendarFunctions.Rule3, ref modHebrewCalendarFunctions.Rule4); //Check postponement
			if (!modHebrewCalendarFunctions.Rule1 && !modHebrewCalendarFunctions.Rule2 && !modHebrewCalendarFunctions.Rule3 && !modHebrewCalendarFunctions.Rule4)
			{ //Tell postponements
				lblRules.Font = lblRules.Font.Change(size:10); //Make 'No Postponements' fit in text box
				lblRules.Text = "No Postponements";
			}
			else
			{
				lblRules.Font = lblRules.Font.Change(size:12); //Restore FontSize for Rules
				if (modHebrewCalendarFunctions.Rule1)
				{
					NumberOfRules = 1;
				} //Count how many rules were used
				if (modHebrewCalendarFunctions.Rule2)
				{
					NumberOfRules++;
				}
				if (modHebrewCalendarFunctions.Rule3)
				{
					NumberOfRules++;
				}
				if (modHebrewCalendarFunctions.Rule4)
				{
					NumberOfRules++;
				}
				if (NumberOfRules < 2 && NumberOfRules > 0)
				{ //Say either 'Rule' or 'Rules'
					lblRules.Text = "Rule ";
				}
				else
				{
					lblRules.Text = "Rules ";
				}
				if (modHebrewCalendarFunctions.Rule1)
				{
					lblRules.Text = lblRules.Text + "1 ";
				} //Print postponement rules
				if (modHebrewCalendarFunctions.Rule2 && modHebrewCalendarFunctions.Rule1)
				{
					lblRules.Text = lblRules.Text + "and ";
				}
				if (modHebrewCalendarFunctions.Rule2)
				{
					lblRules.Text = lblRules.Text + "2 ";
				}
				if (modHebrewCalendarFunctions.Rule3 && (modHebrewCalendarFunctions.Rule1 || modHebrewCalendarFunctions.Rule2))
				{
					lblRules.Text = lblRules.Text + "and ";
				}
				if (modHebrewCalendarFunctions.Rule3)
				{
					lblRules.Text = lblRules.Text + "3 ";
				}
				if (modHebrewCalendarFunctions.Rule4 && (modHebrewCalendarFunctions.Rule1 || modHebrewCalendarFunctions.Rule2 || modHebrewCalendarFunctions.Rule3))
				{
					lblRules.Text = lblRules.Text + "and ";
				}
				if (modHebrewCalendarFunctions.Rule4)
				{
					lblRules.Text = lblRules.Text + "4 ";
				}
			}
			//Done with Hebrew variables
			//Call ShowMoon
		}

		private void cmdJCCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			JCCompute();
			UpDateGregorian();
			UpDateBiblical();
			UpDateHebrew();
			UpDateJulianCalendar();
			ComputeBiblical();
			if (frmCriteria.DefInstance.Visible)
			{ //Check to see if Criteria needs update
				optDate1.Checked = false;
				optDate1.Checked = true;
			}
			ShowMoon();
		}

		private void JCCompute()
		{

			int Year = Convert.ToInt32(Conversion.Val(txtJCYear.Text));
			int Day = Convert.ToInt32(Conversion.Val(txtJCDay.Text));
			int Month = (ListBoxHelper.GetSelectedIndex(lstJCMonth)) + 1; //Get the Julian Calendar month number from the list box
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.Julian_To_Jd(Year, Month, Day);
			txtJDCount.Text = modBiblcalFunctions.JD.ToString();
		}

		private void cmdBCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			txtJDCount.Text = "0"; //Clear Julian Day Count so we know this is a compute
			ComputeBiblical(); //Compute the Biblical Dates and Julian Day count
			UpDateGregorian(); //Update all Gregorian area
			UpDateJulianCalendar();
			UpDateHebrew(); //Update the Hebrew area
			UpDateBiblical(); //Update in the event values in date changed
			ComputeBiblical();
			if (frmCriteria.DefInstance.Visible)
			{ //Check to see if Criteria needs update
				optDate1.Checked = false;
				optDate1.Checked = true;
			}
			ShowMoon();
		}

		private void ComputeBiblical()
		{
			//Computes from the Biblical date
			//And places it in Julian Count
			//5886 (1882 Gregorian)Fifth Month is a good year to test this with

			int GYear = 0;
			int GMonth = 0;
			int GDay = 0;
			double TempDate = 0;
			int TempDateMonth = 0;

			optDate1.Checked = true;
			optDate1.Enabled = true;
			optDate2.Enabled = true;
			optDate3.Enabled = true;
			optDate4.Enabled = true;
			modBiblcalFunctions.CurrentDate = 0; //Clear the possible dates
			modBiblcalFunctions.SecondDate = 0;
			modBiblcalFunctions.ThirdDate = 0;
			modBiblcalFunctions.FourthDate = 0;
			string TempEJWString = modBiblcalFunctions.EJWString;
			modBiblcalFunctions.EJWString = "N";
			modBiblcalFunctions.PrintFlag = false;
			string TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "";

			//Limit Input to keep from overflow failure
			if (StringsHelper.ToDoubleSafe(txtBYear.Text) > 33004)
			{
				txtBYear.Text = "33004";
				SystemSounds.Beep.Play();
			}
			if (StringsHelper.ToDoubleSafe(txtBYear.Text) < -496)
			{
				txtBYear.Text = "-496";
				SystemSounds.Beep.Play();
			}
			if (StringsHelper.ToDoubleSafe(txtBDay.Text) > 1000)
			{
				txtBDay.Text = "1000";
				SystemSounds.Beep.Play();
			}
			if (StringsHelper.ToDoubleSafe(txtBDay.Text) < -1000)
			{
				txtBDay.Text = "-1000";
				SystemSounds.Beep.Play();
			}
			modBiblcalFunctions.BYear = Conversion.Val(txtBYear.Text); //Get the Biblical Year number from the text box
			int BDay = Convert.ToInt32(Conversion.Val(txtBDay.Text)); //Get the Biblical Day number from the text box
			int BMonth = (ListBoxHelper.GetSelectedIndex(lstBMonth)) + 1; //Get the Biblical month number from the list box
			int DateCount = 1; //We know there will be at least one date
			modBiblcalFunctions.BiblicalToJulian(BMonth, BDay, modBiblcalFunctions.BYear, ref modBiblcalFunctions.JD); //Get the Julian Count for that Biblical date
			modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
			TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "Conversions";
			modBiblcalFunctions.PrintFlag = false; //Don't print when getting day number
			modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
			modBiblcalFunctions.Mode = TempMode;
			modBiblcalFunctions.PrintFlag = true; //Enable printing
			lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
			//******************************************************************
			if (StringsHelper.ToDoubleSafe(txtJDCount.Text) != modBiblcalFunctions.JDNJLD + 1)
			{
				txtJDCount.Text = modBiblcalFunctions.JD.ToString();
			} //Skip second day of long day
			//******************************************************************
			//Truth table

			//(Date 1)              (1st month)
			//(Date 1 & 2)          (1st month) & (1st month vis)
			//(Date 1 & 2)          (1st month) & (2nd month)
			//(Date 1 & 2 & 3)      (1st month) & (1st month vis) & (2nd month)
			//(Date 1 & 2 & 3)      (1st month) & (2nd month) & (2nd month vis)
			//(Date 1 & 2 & 3 & 4)  (1st month) & (1st month vis) & (2nd month) & (2nd month vis)

			//Date 1  (1st month)
			modBiblcalFunctions.CurrentDate = modBiblcalFunctions.JD; //Store the current date for future reference
			CurrentDateMonth = BMonth; //May be the late or regular month

			//Date 2  (1st month) & (1st month vis)
			if (modBiblcalFunctions.VS == 1)
			{ //If Visibility for that date is (Probably not visible)
				modBiblcalFunctions.SecondDate = modBiblcalFunctions.JD - 1; //May be a day earlier
				SecondDateMonth = BMonth;
				DateCount++; //Count how many dates there are
			}
			if (modBiblcalFunctions.VS == 2)
			{ //If Visiblilty for that date is (Probably visible)
				modBiblcalFunctions.SecondDate = modBiblcalFunctions.JD + 1; //May be a day later
				SecondDateMonth = BMonth;
				DateCount++; //Count how many dates there are
			}

			//DO THE EARLY HARVEST MONTH
			if (modBiblcalFunctions.MayBeEarlyOrLate)
			{ //If harvest may be a month earlier
				//Harvest will probably be late
				BMonth--;
				modBiblcalFunctions.BiblicalToJulian(BMonth, BDay, modBiblcalFunctions.BYear, ref modBiblcalFunctions.JD); //Get the previous months information

				//Date 2          (1st month) & (2nd month)
				if (modBiblcalFunctions.SecondDate == 0)
				{ //If there was only one date for first month
					modBiblcalFunctions.SecondDate = modBiblcalFunctions.JD; //then use this variable for the second date
					SecondDateMonth = BMonth;
					DateCount++;

					//Date 3         (1st month) & (2nd month) & (2nd month vis)
					if (modBiblcalFunctions.VS == 1)
					{ //(Probably not visible)
						modBiblcalFunctions.ThirdDate = modBiblcalFunctions.JD - 1; //May be a day earlier
						ThirdDateMonth = BMonth;
						DateCount++;
					}
					if (modBiblcalFunctions.VS == 2)
					{ //(Probably visible)
						modBiblcalFunctions.ThirdDate = modBiblcalFunctions.JD + 1; //May be a day later
						ThirdDateMonth = BMonth;
						DateCount++;
					}
				}
				else
				{
					//Second date was used

					//Date 3         (1st month) & (1st month vis) & (2nd month)
					modBiblcalFunctions.ThirdDate = modBiblcalFunctions.JD;
					ThirdDateMonth = BMonth;
					DateCount++; //Count how many dates there are

					//Date 4         (1st month) & (1st month vis) & (2nd month) & (2nd month vis)
					if (modBiblcalFunctions.VS == 1)
					{ //(Probably not visible)
						modBiblcalFunctions.FourthDate = modBiblcalFunctions.JD - 1; //May be a day earlier
						FourthDateMonth = BMonth;
						DateCount++; //Count how many dates there are
					}
					if (modBiblcalFunctions.VS == 2)
					{ //(Probably visible)
						modBiblcalFunctions.FourthDate = modBiblcalFunctions.JD + 1; //May be a day later
						FourthDateMonth = BMonth;
						DateCount++;
					}
				}
			}

			optDate1.Visible = false; //Make none of the buttons show
			optDate2.Visible = false;
			optDate3.Visible = false;
			optDate4.Visible = false;

			if (DateCount >= 2)
			{
				optDate1.Visible = true; //Show the Current Date button
				optDate2.Visible = true; //Show the Second Date button
			}
			if (DateCount >= 3)
			{
				optDate3.Visible = true;
			} //Show the third Date button
			if (DateCount == 4)
			{
				optDate4.Visible = true;
			} //Show the fourth date button
			modBiblcalFunctions.PrintFlag = true;
			modBiblcalFunctions.Mode = TempMode;
			modBiblcalFunctions.EJWString = TempEJWString;
		}

		private void cmdCriteria_Click(Object eventSender, EventArgs eventArgs)
		{
			//Opens and closes the Criteria form and displays the data.
			if (frmCriteria.DefInstance.Visible)
			{
				frmCriteria.DefInstance.Visible = false; //If Criteria form is showing then make it now show
			}
			else
			{
				frmCriteria.DefInstance.Visible = true; //else if not showing then get things ready for it to show
				ComputeBiblical(); //Make sure all the dates are right for it to show
				UpDateGregorian(); //Put the Gregorian dates where they belong
				UpDateHebrew(); //Make sure the Rabbinic calendar is updated
				ComputeCriteria(); //then do the criteria.
			}
			optDate1.Checked = false;
			optDate1.Checked = true;
			ShowMoon();
		}

		private void ComputeCriteria()
		{
			string GYearTypeString = ""; //BCE or CE
			string BYearTypeString = ""; //Before Creation

			double TempJD = modBiblcalFunctions.JD; //Temporary storage for Julan Day Count
			if (modBiblcalFunctions.CurrentDate < 77833.5d)
			{ //Make sure we didn't get out of bounds.
				UpDateGregorian(); //With the inputed dates.
				ComputeBiblical(); //Makes things work incorrectly
			}

			//More bounds checking for the other date variables.
			if ((modBiblcalFunctions.SecondDate != 0 && modBiblcalFunctions.SecondDate < 77833.5d) || (modBiblcalFunctions.ThirdDate != 0 && modBiblcalFunctions.ThirdDate < 77833.5d) || (modBiblcalFunctions.FourthDate != 0 && modBiblcalFunctions.FourthDate < 77833.5d))
			{
				UpDateGregorian(); //Fix if any are out of range
				ComputeBiblical(); //Update the date variables
			}

			//**********************************************
			//Call UpDateGregorian
			//**********************************************

			UpDateHebrew(); //Make the Hebrew area show as the Gregorian
			string TempEJWString = modBiblcalFunctions.EJWString; //Temporary storage for EJWString //Save the status of East of Jerusalem West IDL
			modBiblcalFunctions.EJWString = "N"; //Make dates actual for Jerusalem
			frmCriteria.DefInstance.Show(); //Show the Criteria form
			modBiblcalFunctions.CriteriaFlag = true; //Let other modules know this is a criteria run
			modBiblcalFunctions.PrintCriteria = true; //Print the criteria to criteria text box
			string TempMode = modBiblcalFunctions.Mode; //Temporary storage for Mode //Save the current mode
			modBiblcalFunctions.PrintFlag = false; //Don't print to main form text box
			modBiblcalFunctions.Mode = "Conversions"; //Make mode conversions for now
			frmCriteria.DefInstance.txtCriteria.Text = ""; //Clear the criteria text box
			if (modBiblcalFunctions.MayBeEarlyOrLate)
			{ //Check if early or late harvest
				modBiblcalFunctions.TPrint("This year the barley harvest may be early or late." + Environment.NewLine);
			}
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text);
			//********************************************************
			if (modBiblcalFunctions.JD == modBiblcalFunctions.JDNJLD + 1)
			{
				modBiblcalFunctions.JD--;
			} //Fix for missing Julian Day count. (JDNJLD is long day)
			//*********************************************************
			double BYear = Conversion.Val(txtBYear.Text); //Look up criteria for date
			if (modBiblcalFunctions.JD == modBiblcalFunctions.CurrentDate)
			{ //Is current date button selected?
				if (modBiblcalFunctions.MayBeEarlyOrLate)
				{ //Is is an early or late harvest year?
					if (CurrentDateMonth == ListBoxHelper.GetSelectedIndex(lstBMonth) + 1)
					{
						LateHarvest(CurrentDateMonth);
					}
					else
					{
						EarlyHarvest(CurrentDateMonth);
					}
				}
				if (modBiblcalFunctions.ThirteenthMonthFlag)
				{
					modBiblcalFunctions.TPrint("This may be the first month of the next year if the barley harvest is early." + Environment.NewLine + Environment.NewLine);
				}
				modBiblcalFunctions.BiblicalToJulian(Convert.ToInt32(CurrentDateMonth), 1, BYear, ref modBiblcalFunctions.JD); //Get criteria for month and year.
				modBiblcalFunctions.PrintFlag = false;
			}
			else if (modBiblcalFunctions.JD == modBiblcalFunctions.SecondDate)
			{  //Is second date button selected?
				if (modBiblcalFunctions.MayBeEarlyOrLate)
				{ //Is it an early or late harvest year?
					if (SecondDateMonth == ListBoxHelper.GetSelectedIndex(lstBMonth) + 1)
					{
						LateHarvest(SecondDateMonth);
					}
					else
					{
						EarlyHarvest(SecondDateMonth);
					}
				}
				if (modBiblcalFunctions.ThirteenthMonthFlag)
				{
					modBiblcalFunctions.TPrint("This may be the first month of the next year if the barley harvest is early." + Environment.NewLine + Environment.NewLine);
				}
				modBiblcalFunctions.BiblicalToJulian(Convert.ToInt32(SecondDateMonth), 1, BYear, ref modBiblcalFunctions.JD); //Get criteria for month and year.
				modBiblcalFunctions.PrintFlag = false;
			}
			else if (modBiblcalFunctions.JD == modBiblcalFunctions.ThirdDate)
			{  //Is third date button selected?
				if (modBiblcalFunctions.MayBeEarlyOrLate)
				{ //Is it an early or late harvest year?
					if (ThirdDateMonth == ListBoxHelper.GetSelectedIndex(lstBMonth) + 1)
					{
						LateHarvest(ThirdDateMonth);
					}
					else
					{
						EarlyHarvest(ThirdDateMonth);
					}
				}
				if (modBiblcalFunctions.ThirteenthMonthFlag)
				{
					modBiblcalFunctions.TPrint("This may be the first month of the next year if the barley harvest is early." + Environment.NewLine + Environment.NewLine);
				}
				modBiblcalFunctions.BiblicalToJulian(Convert.ToInt32(ThirdDateMonth), 1, BYear, ref modBiblcalFunctions.JD); //Get Criteria for month and year.
				modBiblcalFunctions.PrintFlag = false;
			}
			else if (modBiblcalFunctions.JD == modBiblcalFunctions.FourthDate)
			{  //Is fourth date button selected?
				if (modBiblcalFunctions.MayBeEarlyOrLate)
				{
					if (FourthDateMonth == ListBoxHelper.GetSelectedIndex(lstBMonth) + 1)
					{
						LateHarvest(FourthDateMonth);
					}
					else
					{
						EarlyHarvest(FourthDateMonth);
					}
				}
				if (modBiblcalFunctions.ThirteenthMonthFlag)
				{
					modBiblcalFunctions.TPrint("This may be the first month of the next year if the barley harvest is early." + Environment.NewLine + Environment.NewLine);
				}
				modBiblcalFunctions.BiblicalToJulian(Convert.ToInt32(FourthDateMonth), 1, BYear, ref modBiblcalFunctions.JD); //Get Criteria for month and year.
				modBiblcalFunctions.PrintFlag = false;
			}
			modBiblcalFunctions.TPrint("First day of the Month is ");
			if (modBiblcalFunctions.VS == 2)
			{
				modBiblcalFunctions.TPrint("(possibly one day later) ");
			} //Print the criteria for that date
			if (modBiblcalFunctions.VS == 1)
			{
				modBiblcalFunctions.TPrint("(possibly one day earlier) ");
			}
			modBiblcalFunctions.PrintDayAndDate(); //Print the date
			if (modBiblcalFunctions.GYear < 0)
			{
				GYearTypeString = " BCE";
			}
			else
			{
				GYearTypeString = " CE";
			}
			if (BYear < 0)
			{
				BYearTypeString = " Before Creation";
			}
			else
			{
				BYearTypeString = "";
			}
			modBiblcalFunctions.TPrint(Environment.NewLine + "The " + txtBDay.Text + NumberSuffex(Convert.ToInt32(Conversion.Val(txtBDay.Text))) + "day of the " + txtBMonth.Text + " Month of Biblical year " + Math.Abs(Conversion.Val(txtBYear.Text)).ToString() + BYearTypeString + Environment.NewLine + "would fall on the " + txtGDay.Text + NumberSuffex(Convert.ToInt32(Conversion.Val(txtGDay.Text))) + "of " + txtGMonth.Text + " " + Math.Abs(Conversion.Val(txtGYear.Text)).ToString() + GYearTypeString + ".");
			modBiblcalFunctions.Mode = TempMode; //Restore everything back to normal
			modBiblcalFunctions.PrintFlag = true;
			modBiblcalFunctions.PrintCriteria = false;
			modBiblcalFunctions.CriteriaFlag = false;
			modBiblcalFunctions.EJWString = TempEJWString;
			modBiblcalFunctions.JD = TempJD;
		}

		private void EarlyHarvest(double NumberOfMonth)
		{
			modBiblcalFunctions.TPrint("This is the " + txtBMonth.Text + " month if the barley harvest is early." + Environment.NewLine + Environment.NewLine);
		}

		private void LateHarvest(double NumberOfMonth)
		{
			modBiblcalFunctions.TPrint("This is the " + txtBMonth.Text + " month if the barley harvest is late." + Environment.NewLine + Environment.NewLine);
		}

		private string NumberSuffex(int Number)
		{
			string result = "";
			string NumberString = "";
			//Builds suffexs for numbers

			if (Number > 10 && Number < 20)
			{
				result = "th ";
			}
			else
			{
				NumberString = Conversion.Str(Number);
				int switchVar = Convert.ToInt32(Conversion.Val(NumberString.Substring(Math.Max(NumberString.Length - 1, 0))));
				if (switchVar == 0)
				{
					result = ("th ");
				}
				else if (switchVar == 1)
				{ 
					result = ("st ");
				}
				else if (switchVar == 2)
				{ 
					result = ("nd ");
				}
				else if (switchVar == 3)
				{ 
					result = ("rd ");
				}
				else if (switchVar > 3)
				{ 
					result = ("th ");
				}
			}
			return result;
		}

		private bool isInitializingComponent;
		private void optDate1_CheckedChanged(Object eventSender, EventArgs eventArgs)
		{
			if (((RadioButton) eventSender).Checked)
			{
				if (isInitializingComponent)
				{
					return;
				}
				//Shows the first date this date could fall on.
				if (modBiblcalFunctions.CurrentDate != 0)
				{
					txtJDCount.Text = modBiblcalFunctions.CurrentDate.ToString();
					modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
					modBiblcalFunctions.PrintFlag = false; //Don't print when geting day number
					modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
					modBiblcalFunctions.Mode = "Conversions";
					modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
					modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
					modBiblcalFunctions.PrintFlag = true; //Enable printing
					lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
					UpDateHebrew(); //Do the Rabbinic variables
					UpDateJulianCalendar(); //Do the Julian Calendar variables
					UpDateGregorian(); //Do the Gregorian Calendar variables
					if (frmCriteria.DefInstance.Visible)
					{
						ComputeCriteria();
					}
					optDate1.Checked = true;
				}
				ShowMoon();
			}
		}

		private void optDate2_CheckedChanged(Object eventSender, EventArgs eventArgs)
		{
			if (((RadioButton) eventSender).Checked)
			{
				if (isInitializingComponent)
				{
					return;
				}
				//Shows the second date this date could fall on.
				if (modBiblcalFunctions.SecondDate != 0)
				{
					txtJDCount.Text = modBiblcalFunctions.SecondDate.ToString();
				}
				else
				{
					if (modBiblcalFunctions.ThirdDate != 0)
					{
						txtJDCount.Text = modBiblcalFunctions.ThirdDate.ToString();
					}
				}
				modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
				modBiblcalFunctions.PrintFlag = false; //Don't print when geting day number
				modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
				modBiblcalFunctions.Mode = "Conversions";
				modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
				modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
				modBiblcalFunctions.PrintFlag = true; //Enable printing
				lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
				UpDateHebrew(); //Do the Rabbinic variables
				UpDateJulianCalendar(); //Do the Julian Calendar variables
				UpDateGregorian(); //Do the Gregorian Calendar variables
				if (frmCriteria.DefInstance.Visible)
				{
					ComputeCriteria();
				}
				optDate2.Checked = true;
				ShowMoon();
			}
		}

		private void optDate3_CheckedChanged(Object eventSender, EventArgs eventArgs)
		{
			if (((RadioButton) eventSender).Checked)
			{
				if (isInitializingComponent)
				{
					return;
				}
				//Shows the third date this date could fall on.
				if (modBiblcalFunctions.ThirdDate != 0)
				{
					txtJDCount.Text = modBiblcalFunctions.ThirdDate.ToString();
				}
				else
				{
					if (modBiblcalFunctions.FourthDate != 0)
					{
						txtJDCount.Text = modBiblcalFunctions.FourthDate.ToString();
					}
				}
				modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
				modBiblcalFunctions.PrintFlag = false; //Don't print when geting day number
				modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
				modBiblcalFunctions.Mode = "Conversions";
				modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
				modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
				modBiblcalFunctions.PrintFlag = true; //Enable printing
				lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
				UpDateHebrew(); //Do the Rabbinic variables
				UpDateJulianCalendar(); //Do the Julian Calendar variables
				UpDateGregorian(); //Do the Gregorian Calendar variables
				if (frmCriteria.DefInstance.Visible)
				{
					ComputeCriteria();
				}
				optDate3.Checked = true;
				ShowMoon();
			}
		}

		private void optDate4_CheckedChanged(Object eventSender, EventArgs eventArgs)
		{
			if (((RadioButton) eventSender).Checked)
			{
				if (isInitializingComponent)
				{
					return;
				}
				//Shows the fourth and last date this date could fall on.
				if (modBiblcalFunctions.FourthDate != 0)
				{
					txtJDCount.Text = modBiblcalFunctions.FourthDate.ToString();
				}
				modBiblcalFunctions.AA = Conversion.Val(txtJDCount.Text) + 0.5d; //Get integer Julian Day Number for Biblical
				modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
				modBiblcalFunctions.Mode = "Conversions";
				modBiblcalFunctions.PrintFlag = false; //Don't print when geting day number
				modBiblcalFunctions.PrintDayAndDate(); //Get the Biblical Day of Week
				modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
				modBiblcalFunctions.PrintFlag = true; //Enable printing
				lblBDayOfWeek.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(modBiblcalFunctions.D)]; //Put the Day of week name in label caption
				UpDateHebrew(); //Do the Rabbinic variables
				UpDateJulianCalendar(); //Do the Julian Calendar variables
				UpDateGregorian(); //Do the Gregorian Calendar variables
				if (frmCriteria.DefInstance.Visible)
				{
					ComputeCriteria();
				}
				optDate4.Checked = true;
				ShowMoon();
			}
		}

		private void cmdHCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			ComputeHebrew(); //Do the Hebrew calculations
			UpDateGregorian(); //Do the Gregorian calculations
			UpDateHebrew(); //Update in case values changed for the date
			UpDateJulianCalendar();
			UpDateBiblical(); //Update the Biblical area
			ComputeBiblical();
			if (frmCriteria.DefInstance.Visible)
			{ //If the 'Criteria' form is showing then
				optDate1.Checked = false;
				optDate1.Checked = true;
			}
			ShowMoon();
		}

		private void ComputeHebrew()
		{
			//Computes from the Hebrew date and places Julian Day count in JDCount text box.

			int GYear = 0; //Gregorian Year number
			int GMonth = 0; //Gregorian Month number
			int GDay = 0; //Gregorian Day number
			double jdn = 0; //Julian Day Number

			if (Conversion.Val(txtHYear.Text) > 32760)
			{
				txtHYear.Text = "32760"; //Set high limit for input
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtHYear.Text) < -739)
			{
				txtHYear.Text = "-739"; //Set low limit for input
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtHDay.Text) > 1000)
			{
				txtHDay.Text = "1000"; //Limit days to keep from failure
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtHDay.Text) < -1000)
			{
				txtHDay.Text = "-1000"; //Limit days to keep from failure
				SystemSounds.Beep.Play();
			}
			int iYear = Convert.ToInt32(Conversion.Val(txtHYear.Text)); //Hebrew Year number //Get Hebrew year number
			int iDay = Convert.ToInt32(Conversion.Val(txtHDay.Text)); //Hebrew Day number //Get Hebrew day number
			int iMonth = ListBoxHelper.GetSelectedIndex(lstHMonth) + 1; //Hebrew Month number //Get Hebrew month number from list, 1 is Nisan
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.HebrewToJD(iMonth, iDay, iYear); //Get the Julian day count for this Hebrew date
			txtJDCount.Text = modBiblcalFunctions.JD.ToString(); //put it into the Julian day count text box.
			lblHDay.Text = modHebrewCalendarFunctions.BDayName[Convert.ToInt32(Conversion.Val(((Convert.ToInt32((Double.Parse(txtJDCount.Text)) + 1.5d)) % 7).ToString()))];
		}

		private void cmdJCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			//Button to Compute from the Julian Day count to the other calendars
			//Next line fixes when people put in integer Julian Day Count numbers in.
			if (Conversion.Val(txtJDCount.Text) - Math.Floor(Conversion.Val(txtJDCount.Text)) == 0)
			{
				txtJDCount.Text = (Conversion.Val(txtJDCount.Text) - 0.5d).ToString();
			}
			if (Conversion.Val(txtJDCount.Text) < 78166.5d)
			{ //Minimum JDN
				txtJDCount.Text = "78166.5";
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtJDCount.Text) > 12313456.5d)
			{ //Maximum JDN
				txtJDCount.Text = "12313456.5";
				SystemSounds.Beep.Play();
			}
			UpDateGregorian(); //Get the Gregorian date in text boxes
			UpDateJulianCalendar();
			UpDateHebrew(); //Update Hebrew area
			UpDateBiblical(); //Update Biblical area
			ComputeBiblical(); //Get the data for it
			if (frmCriteria.DefInstance.Visible)
			{ //If the 'Criteria' form is showing then
				optDate1.Checked = false;
				optDate1.Checked = true;
			}
			ShowMoon();
		}

		private void ShowMoon()
		{
			int Index = 0;

			modBiblcalFunctions.PrintFlag = false;
			modBiblcalFunctions.InitializeVariables();
			modBiblcalFunctions.MoonFlag = true;
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text);
			modTimes.Times(modBiblcalFunctions.JD + 0.5d);
			float FirstPercent = (float) ((Conversion.Val(modBiblcalFunctions.ILString) + Conversion.Val(modTimes.ILSString)) / 2d);
			if (modBiblcalFunctions.ILString == " ----")
			{
				FirstPercent = (float) Conversion.Val(modTimes.ILSString);
			}
			if (modTimes.ILSString == " ----")
			{
				FirstPercent = (float) Conversion.Val(modBiblcalFunctions.ILString);
			}
			modBiblcalFunctions.JD = Conversion.Val(txtJDCount.Text);
			modTimes.Times(modBiblcalFunctions.JD + 1.5d);
			float SecondPercent = (float) ((Conversion.Val(modBiblcalFunctions.ILString) + Conversion.Val(modTimes.ILSString)) / 2d);
			if (modBiblcalFunctions.ILString == " ----")
			{
				SecondPercent = (float) Conversion.Val(modTimes.ILSString);
			}
			if (modTimes.ILSString == " ----")
			{
				SecondPercent = (float) Conversion.Val(modBiblcalFunctions.ILString);
			}
			modBiblcalFunctions.PrintFlag = true;
			modBiblcalFunctions.MoonFlag = false;
			if (FirstPercent < SecondPercent)
			{ //Waxing moon
				Index = -1; //Start at no moon and work up

				do 
				{
					Index++;
					if (Index > 30)
					{
						break;
					}
				}
				while(MoonKey[Index] <= FirstPercent);
				Index--;
				if (Index == -1)
				{
					Index = 0;
				}
				picMoon[modHebrewCalendarFunctions.PicMoonVisible].Visible = false;
				picMoon[Index].Visible = true;
				modHebrewCalendarFunctions.PicMoonVisible = Index;
			}
			else
			{
				//Waining moon
				Index = 30; //Start at full moon and work down

				do 
				{
					Index++;
					if (Index == 59)
					{
						break;
					}
				}
				while(MoonKey[Index] >= FirstPercent);
				Index--;
				if (FirstPercent < 3)
				{
					Index = 0;
				}
				picMoon[modHebrewCalendarFunctions.PicMoonVisible].Visible = false;
				picMoon[Index].Visible = true;
				modHebrewCalendarFunctions.PicMoonVisible = Index;
			}
		}

		private void chkOnTop_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			//Makes the form stay on top till unchecked

			int lR = 0; //Used by module 'modStayOnTop'

			if (((int) chkOnTop.CheckState) == ((int) CheckState.Checked))
			{
				lR = modStayOnTop.SetTopMostWindow(frmConversion.DefInstance.Handle.ToInt32(), true);
			}
			else
			{
				lR = modStayOnTop.SetTopMostWindow(frmConversion.DefInstance.Handle.ToInt32(), false);
			}
		}

		private void chkOnTop_Enter(Object eventSender, EventArgs eventArgs)
		{
			//Makes an signal to show chkOnTop has the focus
			lblTabInd.Visible = true;
		}
		private void chkOnTop_Leave(Object eventSender, EventArgs eventArgs)
		{
			//Turns off a signal to show chkOnTop does not have focus
			lblTabInd.Visible = false;
		}

		//*****************************************************************************************
		//*                           Month selection routines follow                             *
		//*****************************************************************************************

		private void txtGMonth_Click(Object eventSender, EventArgs eventArgs)
		{
			//Pops open the Gregorian month list box for selection of a Gregorian month name
			lstGMonth.Visible = true; //list box opens
		}

		private void txtGMonth_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				//Allows the user to select months by using the up and down arrow keys

				if (KeyCode == ((int) Keys.Up) && ListBoxHelper.GetSelectedIndex(lstGMonth) > 0)
				{
					ListBoxHelper.SetSelected(lstGMonth, ListBoxHelper.GetSelectedIndex(lstGMonth) - 1, true);
				}
				if (KeyCode == ((int) Keys.Down) && ListBoxHelper.GetSelectedIndex(lstGMonth) < 11)
				{
					ListBoxHelper.SetSelected(lstGMonth, ListBoxHelper.GetSelectedIndex(lstGMonth) + 1, true);
				}
				if (KeyCode == ((int) Keys.Return))
				{
					txtGDay.Focus();
					KeyCode = (int) Keys.Tab;
				}
				else
				{
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		private void lstGMonth_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			//User selects the Gregorian month name from the list box
			lstGMonth.Visible = false;
			txtGMonth.Text = lstGMonth.Text; //Puts the selected month name in it's text box
		}

		private void txtHMonth_Click(Object eventSender, EventArgs eventArgs)
		{
			//Pops open the Hebrew month list box for selection of a Hebrew month name
			lstHMonth.Visible = true; //list box opens
		}

		private void txtControl_Click(Object eventSender, EventArgs eventArgs)
		{
			//Used to prove we wrote this program. (In case having the source isn't enough.)
			modBiblcalFunctions.ControlFlag = true;
			frmHolyDays.DefInstance.txtVerification.Visible = true;
		}

		private void txtHMonth_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				//Allows user to select months using the up and down arrow keys
				if (KeyCode == ((int) Keys.Up) && ListBoxHelper.GetSelectedIndex(lstHMonth) > 0)
				{
					ListBoxHelper.SetSelected(lstHMonth, ListBoxHelper.GetSelectedIndex(lstHMonth) - 1, true);
				}
				if (KeyCode == ((int) Keys.Down) && ListBoxHelper.GetSelectedIndex(lstHMonth) < 12)
				{
					ListBoxHelper.SetSelected(lstHMonth, ListBoxHelper.GetSelectedIndex(lstHMonth) + 1, true);
				}
				if (KeyCode == ((int) Keys.Return))
				{
					txtHDay.Focus();
					KeyCode = (int) Keys.Tab;
				}
				else
				{
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		private void lstHMonth_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			//User selects the Hebrew month name from the list box
			lstHMonth.Visible = false; //list box closes
			txtHMonth.Text = lstHMonth.Text; //Puts the selected month name in it's text box
		}

		private void txtJCMonth_Click(Object eventSender, EventArgs eventArgs)
		{
			//Pops open the Biblical month list box for selection of a Biblical month name
			lstJCMonth.Visible = true; //list box opens
		}

		private void txtJCMonth_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				//Allows user to select months using the up and down arrow keys
				if (KeyCode == ((int) Keys.Up) && ListBoxHelper.GetSelectedIndex(lstJCMonth) > 0)
				{
					ListBoxHelper.SetSelected(lstJCMonth, ListBoxHelper.GetSelectedIndex(lstJCMonth) - 1, true);
				}
				if (KeyCode == ((int) Keys.Down) && ListBoxHelper.GetSelectedIndex(lstJCMonth) < 12)
				{
					ListBoxHelper.SetSelected(lstJCMonth, ListBoxHelper.GetSelectedIndex(lstJCMonth) + 1, true);
				}
				if (KeyCode == ((int) Keys.Return))
				{
					txtJCDay.Focus();
					KeyCode = (int) Keys.Tab;
				}
				else
				{
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		private void lstJCMonth_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			//User selects the Biblical month name from the list box
			lstJCMonth.Visible = false; //list box closes
			txtJCMonth.Text = lstJCMonth.Text; //Puts the selected month name in it's text box
		}

		private void txtBMonth_Click(Object eventSender, EventArgs eventArgs)
		{
			//Pops open the Biblical month list box for selection of a Biblical month name
			lstBMonth.Visible = true; //list box opens
		}

		private void txtBMonth_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				//Allows user to select months using the up and down arrow keys
				if (KeyCode == ((int) Keys.Up) && ListBoxHelper.GetSelectedIndex(lstBMonth) > 0)
				{
					ListBoxHelper.SetSelected(lstBMonth, ListBoxHelper.GetSelectedIndex(lstBMonth) - 1, true);
				}
				if (KeyCode == ((int) Keys.Down) && ListBoxHelper.GetSelectedIndex(lstBMonth) < 12)
				{
					ListBoxHelper.SetSelected(lstBMonth, ListBoxHelper.GetSelectedIndex(lstBMonth) + 1, true);
				}
				if (KeyCode == ((int) Keys.Return))
				{
					txtBDay.Focus();
					KeyCode = (int) Keys.Tab;
				}
				else
				{
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		private void lstBMonth_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			//User selects the Biblical month name from the list box
			lstBMonth.Visible = false; //list box closes
			txtBMonth.Text = lstBMonth.Text; //Puts the selected month name in it's text box
		}

		//Gregorian year filter for up down keys
		private void txtGYear_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtGYear.Text));
					txtGYear.Text = (Conversion.Val(txtGYear.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtGYear.Text));
					txtGYear.Text = (Conversion.Val(txtGYear.Text) - 1).ToString();
				}
				if (txtGYear.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtGYear.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtGYear.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Gregorian year filter for text box
		private void txtGYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdGCompute_Click(cmdGCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Gregorian day filter for up down keys
		private void txtGDay_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.Up))
				{
					txtGDay.Text = (Conversion.Val(txtGDay.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					txtGDay.Text = (Conversion.Val(txtGDay.Text) - 1).ToString();
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Gregorian day filter for text box
		private void txtGDay_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdGCompute_Click(cmdGCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Biblical Year filter for up down keys
		private void txtBYear_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Double.Parse(txtBYear.Text));
					txtBYear.Text = (Conversion.Val(txtBYear.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Double.Parse(txtBYear.Text));
					txtBYear.Text = (Conversion.Val(txtBYear.Text) - 1).ToString();
				}

				if (txtBYear.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtBYear.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtBYear.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}

		}

		//Biblical year filter for text box
		private void txtBYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdBCompute_Click(cmdBCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Biblical day filter for up down keys
		private void txtBDay_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.Up))
				{
					txtBDay.Text = (Conversion.Val(txtBDay.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					txtBDay.Text = (Conversion.Val(txtBDay.Text) - 1).ToString();
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Biblical day filter for text box
		private void txtBDay_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdBCompute_Click(cmdBCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Hebrew Rabbinical filter for year text box up down keys
		private void txtHYear_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtHYear.Text));
					txtHYear.Text = (Conversion.Val(txtHYear.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtHYear.Text));
					txtHYear.Text = (Conversion.Val(txtHYear.Text) - 1).ToString();
				}
				if (txtHYear.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtHYear.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtHYear.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}


		//Hebrew Rabbinical filter for year text box
		private void txtHYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdHCompute_Click(cmdHCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Hebrew Day filter for up down keys
		private void txtHDay_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.Up))
				{
					txtHDay.Text = (Conversion.Val(txtHDay.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					txtHDay.Text = (Conversion.Val(txtHDay.Text) - 1).ToString();
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Hebrew day filter for text box
		private void txtHDay_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdHCompute_Click(cmdHCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Julian Calendar filer for year up down keys
		private void txtJCYear_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtJCYear.Text));
					txtJCYear.Text = (Conversion.Val(txtJCYear.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtJCYear.Text));
					txtJCYear.Text = (Conversion.Val(txtJCYear.Text) - 1).ToString();
				}
				if (txtJCYear.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtJCYear.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtJCYear.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Julian Calendar filter for year text box
		private void txtJCYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdJCCompute_Click(cmdJCCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Julian Calendar day up down key filter
		private void txtJCDay_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.Up))
				{
					txtJCDay.Text = (Conversion.Val(txtJCDay.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					txtJCDay.Text = (Conversion.Val(txtJCDay.Text) - 1).ToString();
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Julian Calendar filter for day text box
		private void txtJCDay_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdJCCompute_Click(cmdJCCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('-') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Julian Count filter for text box up down keys.
		private void txtJDCount_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.Up))
				{
					txtJDCount.Text = (Conversion.Val(txtJDCount.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					txtJDCount.Text = (Conversion.Val(txtJDCount.Text) - 1).ToString();
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Julian Day Count filter for text box
		private void txtJDCount_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdJCompute_Click(cmdJCompute, new EventArgs());
				}
				if (KeyAscii != 0)
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('.') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0;
						SystemSounds.Beep.Play();
					}
				}
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		//Keeps an eye open for the F1 key so Help may be administered
		private void Form_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				if (KeyCode == ((int) Keys.F1))
				{
					modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
					modBiblcalFunctions.Mode = "Conversions";
					modDocumentation.GetDocumentation();
					frmConversionsHelp.DefInstance.txtHelp.Text = "";
					frmConversionsHelp.DefInstance.txtHelp.Text = modBiblcalFunctions.Instructions;
					frmConversionsHelp.DefInstance.Show();
					modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}

		}
		//*****************************************************************************************
		//*                                END OF frmConversion CODE                              *
		//*****************************************************************************************
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}