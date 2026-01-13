using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Windows.Forms;
using UpgradeHelpers.Helpers;

namespace BiblCal
{
	internal partial class frmHebrew
		: System.Windows.Forms.Form
	{

		public frmHebrew()
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
			InitializeComponent();
		}


		private void frmHebrew_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		//*******************************************************************************************
		//*                               HEBREW CALENDAR PROGRAM                                   *
		//*                                       Ver 11.0                                         *
		//*          Computes the start of the Rabbinic Hebrew months for a given Hebrew Year       *
		//*                    Also shows the computed dates for the Holy Days                      *
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
		//Form frmHebrew

		//To check the Julian Day numbers, goto:
		// http://aa.usno.navy.mil/data/docs/JulianDate.html
		//To check the output goto:
		// http://calendarhome.com/converter/
		// don't forget years before year one are (Year + 1) for that web site etc.

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			modHebrewCalendarFunctions.LoadHebrewVariables();
			txtYear.Text = DateTime.Today.Year.ToString(); //Put current year in Year text box.
			cmdHelp_Click(cmdHelp, new EventArgs());
		}

		private void Form_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				string TempMode = "";

				if (KeyCode == ((int) Keys.F1))
				{
					TempMode = modBiblcalFunctions.Mode;
					modBiblcalFunctions.Mode = "Rabbinic";
					modDocumentation.GetDocumentation();
					txtOut.Text = "";
					txtOut.Text = modBiblcalFunctions.Instructions;
					modBiblcalFunctions.Mode = TempMode;
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//UPGRADE_NOTE: (7001) The following declaration (PrintDayAndDate) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
		//private object PrintDayAndDate(double JD)
		//{
			//Prints the Gregorian Day name and the date
			//txtOut.Text = txtOut.Text + modHebrewCalendarFunctions.DayName2[Convert.ToInt32(Convert.ToInt32(Math.Floor(JD + 1.5d)) % 7)]; //Find day number and print day name
			//modHebrewCalendarFunctions.JulianToMDY2(); //Convert JD to Gregorian date
			//txtOut.Text = txtOut.Text + "," + modBiblcalFunctions.DAString + " " + modHebrewCalendarFunctions.MonthName2[Convert.ToInt32(Conversion.Val(modBiblcalFunctions.MHString))] + " " + modBiblcalFunctions.GregorianYearString;
			//return null;
		//}

		private object PrintDayAndDate2(double JD)
		{
			//Prints the Gregorian Day name and the date
			txtOut.Text = txtOut.Text + modHebrewCalendarFunctions.SDayName[Convert.ToInt32(Convert.ToInt32(Math.Floor(JD + 1.5d)) % 7)]; //Find day number and print day name
			modHebrewCalendarFunctions.JulianToMDY2(); //Convert JD to Gregorian date
			txtOut.Text = txtOut.Text + "," + modBiblcalFunctions.DAString + " " + modHebrewCalendarFunctions.SMonthName[Convert.ToInt32(Conversion.Val(modBiblcalFunctions.MHString))] + " " + modBiblcalFunctions.GregorianYearString;
			return null;
		}


		private object HolyDays(int YearNum)
		{
			//Prints the calculated Rabbinic Holy Days

			txtOut.Text = txtOut.Text + "Rabbinical Holy Days are: " + Environment.NewLine;
			int TypeYear = modHebrewCalendarFunctions.TypeOfYear(YearNum); //Set up month lengths and get type of year.
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.StartOfMonth(1, YearNum); //Get JD for 1st of Nisan
			modBiblcalFunctions.JD += 13; //Add 13 days to get the 14th of Nisan, Passover
			txtOut.Text = txtOut.Text + "Passover preparation day is ";
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Passover
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine;
			modBiblcalFunctions.JD++; //Add 1 day to get the start of Feast of Unleavened Bread
			txtOut.Text = txtOut.Text + "Feast of Unleavened Bread starts ";
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Feast of Unleavened Bread
			double WaveOffering = modBiblcalFunctions.JD + 1; //Jews start count the day after first day of Unleavend Bread.
			// WaveOffering = Int(7 - (JD + 1.5) Mod 7) + JD      'Find WaveOffering
			//Fix it if it is greater than 6
			//If Int(7 - (JD + 1.5) Mod 7) = 7 Then WaveOffering = WaveOffering - 7
			txtOut.Text = txtOut.Text + Environment.NewLine + "and runs through ";
			modBiblcalFunctions.JD += 6; //Add 6 more days for the Feast of Unleavened Bread
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print end date of Feast of Unleavened Bread
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "(Wave Offering) is ";
			modBiblcalFunctions.JD = WaveOffering; //Set up to print Wave Offering
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Wave Offering
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "Pentecost is ";
			modBiblcalFunctions.JD = WaveOffering + 49; //Add 49 days from Wave Offering to get Pentecost
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Pentecost
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "Feast of Trumpets is ";
			modBiblcalFunctions.JD = modHebrewCalendarFunctions.StartOfMonth(7, YearNum); //Get the first day of the 7th month
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Feast of Trumpets
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "Day of Atonement is ";
			modBiblcalFunctions.JD += 9; //Add 9 days to get the Day of Atonement
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Day of Atonement
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "Feast of Booths starts ";
			modBiblcalFunctions.JD += 5; //Add 5 days to get the Feast of Booths
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print start date of Feast of Booths
			txtOut.Text = txtOut.Text + Environment.NewLine + "and runs through ";
			modBiblcalFunctions.JD += 6; //Add 6 more days for Feast of Booths
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print end date of Feast of Booths
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "Last Great Day is ";
			modBiblcalFunctions.JD++; //Add 1 day to get the Last Great Day
			PrintDayAndDate2(modBiblcalFunctions.JD); //Print date of Last Great Day
			txtOut.Text = txtOut.Text + Environment.NewLine + Environment.NewLine + "The Rabbinical Holy Day dates are frequently wrong.";
			txtOut.Text = txtOut.Text + Environment.NewLine + "Read the [Help] documentation for details.";
			return null;
		}

		private void cmdCompute_Click(Object eventSender, EventArgs eventArgs)
		{
			int Index = 0;

			if (StringsHelper.ToDoubleSafe(txtYear.Text) == 0)
			{
				txtYear.Text = "-1";
			}
			if (StringsHelper.ToDoubleSafe(txtYear.Text) < -4600)
			{
				txtYear.Text = "-4600";
			}
			if (StringsHelper.ToDoubleSafe(txtYear.Text) > 32000)
			{
				txtYear.Text = "32000";
			}
			int YearNum = Convert.ToInt32(Double.Parse(txtYear.Text));
			modBiblcalFunctions.GregorianYear = YearNum;
			txtOut.Text = "";
			if (modBiblcalFunctions.GregorianYear < 0)
			{
				modBiblcalFunctions.GregorianYear++;
			}
			int HYear = Convert.ToInt32(modBiblcalFunctions.GregorianYear + 3760);
			//Print out the Sacred year sequence
			txtOut.Text = txtOut.Text + modHebrewCalendarFunctions.TypeYear[modHebrewCalendarFunctions.TypeOfYear(YearNum - 1)] + 
			              " for year " + HYear.ToString() + Environment.NewLine + Environment.NewLine + "Start of months for 'Sacred' Year" + Environment.NewLine;
			int NumOfMonths = modHebrewCalendarFunctions.NumberOfMonths(YearNum); //Get Number of Months in this year
			int tempForEndVar = NumOfMonths;
			for (Index = 1; Index <= tempForEndVar; Index++)
			{
				txtOut.Text = txtOut.Text + modHebrewCalendarFunctions.SHMonthName[Index] + " ";
				if (Index > 6)
				{
					HYear = Convert.ToInt32(modBiblcalFunctions.GregorianYear + 3761);
				}
				else
				{
					HYear = Convert.ToInt32(modBiblcalFunctions.GregorianYear + 3760);
				}
				txtOut.Text = txtOut.Text + HYear.ToString() + " - ";
				modBiblcalFunctions.JD = modHebrewCalendarFunctions.StartOfMonth(Index, YearNum); //Get JD for start of each month
				PrintDayAndDate2(modBiblcalFunctions.JD); //Print the Gregorian day and date of that JD
				txtOut.Text = txtOut.Text + Environment.NewLine;
			}
			txtOut.Text = txtOut.Text + Environment.NewLine;
			HolyDays(YearNum); //Print the calculated Holy Days
		}

		private void cmdHelp_Click(Object eventSender, EventArgs eventArgs)
		{
			//This is the Help Part of the Rabinical 'Holy Days' program
			modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "Rabbinic";
			modDocumentation.GetDocumentation();
			txtOut.Text = "";
			txtOut.Text = modBiblcalFunctions.Instructions;
			modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
		}

		private void txtYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdCompute_Click(cmdCompute, new EventArgs());
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

		//Year text box filter for up and down keys
		private void txtYear_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
					txtYear.Text = (Conversion.Val(txtYear.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
					txtYear.Text = (Conversion.Val(txtYear.Text) - 1).ToString();
				}
				if (txtYear.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtYear.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtYear.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}