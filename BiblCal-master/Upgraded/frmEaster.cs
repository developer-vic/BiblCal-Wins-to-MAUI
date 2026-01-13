using Microsoft.VisualBasic;
using System;
using System.Media;
using System.Windows.Forms;

namespace BiblCal
{
	internal partial class frmEaster
		: System.Windows.Forms.Form
	{

		public frmEaster()
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


		private void frmEaster_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		double Y = 0;
		double A = 0;
		double B = 0;
		double C = 0;
		double F = 0;

		private void cmdEaster_Click(Object eventSender, EventArgs eventArgs)
		{
			txtOut.Text = ""; //Clear the text screen
			if (Conversion.Val(txtYear.Text) < 1)
			{ //Range check for less than year 1
				txtYear.Text = "1";
				SystemSounds.Beep.Play();
			}
			if (Conversion.Val(txtYear.Text) > 9499)
			{ //Range check for greater than 9499 - gives total of 9999
				txtYear.Text = "9499";
				SystemSounds.Beep.Play();
			}

			double tempForEndVar = Conversion.Val(txtYear.Text) + 59;
			for (Y = Conversion.Val(txtYear.Text); Y <= tempForEndVar; Y++)
			{ //Compute 500 years of dates.
				if (Y < 1583)
				{
					Julian(); //Call appropriate routine to get dates.
				}
				else
				{
					Gregorian();
				}
			}

		}
		private void Gregorian()
		{
			//Finds the Gregorian year dates for 'Good Friday' and Easter.
			double GFM = 0;
			string NString = "";
			string GFMString = "";
			Y = Math.Floor(Y);
			A = Y / 19d;
			A -= Math.Floor(A);
			A = Convert.ToInt32(A * 19);
			B = Y / 100d;
			C = B - Math.Floor(B);
			C = Convert.ToInt32(C * 100);
			B = Math.Floor(B);
			modBiblcalFunctions.D = B / 4d;
			modBiblcalFunctions.E = modBiblcalFunctions.D - Math.Floor(modBiblcalFunctions.D);
			modBiblcalFunctions.E = Convert.ToInt32(modBiblcalFunctions.E * 4);
			modBiblcalFunctions.D = Math.Floor(modBiblcalFunctions.D);
			F = (B + 8) / 25d;
			F = Math.Floor(F);
			modBiblcalFunctions.G = (B - F + 1) / 3d;
			modBiblcalFunctions.G = Math.Floor(modBiblcalFunctions.G);
			modBiblcalFunctions.H = (19 * A + B - modBiblcalFunctions.D - modBiblcalFunctions.G + 15) / 30d;
			modBiblcalFunctions.H -= Math.Floor(modBiblcalFunctions.H);
			modBiblcalFunctions.H = Convert.ToInt32(modBiblcalFunctions.H * 30);
			double I = C / 4d;
			double K = I - Math.Floor(I);
			K = Convert.ToInt32(K * 4);
			I = Math.Floor(I);
			modBiblcalFunctions.L = (32 + 2 * modBiblcalFunctions.E + 2 * I - modBiblcalFunctions.H - K) / 7d;
			modBiblcalFunctions.L -= Math.Floor(modBiblcalFunctions.L);
			modBiblcalFunctions.L = Convert.ToInt32(modBiblcalFunctions.L * 7);
			modBiblcalFunctions.M = (A + 11 * modBiblcalFunctions.H + 22 * modBiblcalFunctions.L) / 451d;
			modBiblcalFunctions.M = Math.Floor(modBiblcalFunctions.M);
			double N = (modBiblcalFunctions.H + modBiblcalFunctions.L - 7 * modBiblcalFunctions.M + 114) / 31d;
			double P = N - Math.Floor(N);
			N = Math.Floor(N);
			P = Convert.ToInt32(P * 31) + 1;
			if (N == 3)
			{
				NString = " March,";
			}
			else
			{
				NString = " April,";
			}
			double GFD = P - 2;
			if (GFD <= 0)
			{
				GFD += 31;
				GFM = N - 1;
			}
			else
			{
				GFM = N;
			}
			if (GFM == 3)
			{
				GFMString = " March,";
			}
			else
			{
				GFMString = " April,";
			}
			txtOut.Text = txtOut.Text + "'Good Friday' is" + DayString(Convert.ToInt32(GFD)) + GFMString + " " + YearString(Convert.ToInt32(Y)) + 
			              "   Easter Sunday is" + DayString(Convert.ToInt32(P)) + NString + " " + YearString(Convert.ToInt32(Y)) + Environment.NewLine;
		}

		private void Julian()
		{
			//Finds the Julian year dates for 'Good Friday' and Easter.
			string FString = "";
			double GFD = 0;
			double JFM = 0;
			string JFMString = "";

			Y = Math.Floor(Y);
			A = Y / 4d;
			A -= Math.Floor(A);
			A = Convert.ToInt32(A * 4);
			B = Y / 7d;
			B -= Math.Floor(B);
			B = Convert.ToInt32(B * 7);
			C = Y / 19d;
			C -= Math.Floor(C);
			C = Convert.ToInt32(C * 19);
			modBiblcalFunctions.D = (19 * C + 15) / 30d;
			modBiblcalFunctions.D -= Math.Floor(modBiblcalFunctions.D);
			modBiblcalFunctions.D = Convert.ToInt32(modBiblcalFunctions.D * 30);
			modBiblcalFunctions.E = (2 * A + 4 * B - modBiblcalFunctions.D + 34) / 7d;
			modBiblcalFunctions.E -= Math.Floor(modBiblcalFunctions.E);
			modBiblcalFunctions.E = Convert.ToInt32(modBiblcalFunctions.E * 7);
			F = (modBiblcalFunctions.D + modBiblcalFunctions.E + 114) / 31d;
			modBiblcalFunctions.G = F - Math.Floor(F);
			modBiblcalFunctions.G = Convert.ToInt32(modBiblcalFunctions.G * 31) + 1;
			F = Math.Floor(F);
			if (F == 3)
			{
				FString = " March,";
			}
			else
			{
				FString = " April,";
			}
			double JFD = modBiblcalFunctions.G - 2;
			if (JFD <= 0)
			{
				JFD += 31;
				JFM = F - 1;
			}
			else
			{
				JFM = F;
			}
			if (JFM == 3)
			{
				JFMString = " March,";
			}
			else
			{
				JFMString = " April,";
			}
			txtOut.Text = txtOut.Text + "'Good Friday' is" + DayString(Convert.ToInt32(JFD)) + JFMString + " " + YearString(Convert.ToInt32(Y)) + 
			              "   Easter Sunday is" + DayString(Convert.ToInt32(modBiblcalFunctions.G)) + FString + " " + YearString(Convert.ToInt32(Y)) + " (Julian)" + Environment.NewLine;
		}

		//Makes the year strings 4 characters long
		private string YearString(int Year)
		{

			string YString = Conversion.Str(Year);
			YString = YString.Substring(Math.Max(YString.Length - (Strings.Len(YString) - 1), 0));
			while (Strings.Len(YString) < 4)
			{
				YString = "0" + YString;
			}
			return YString;
		}

		//Makes the day strings 2 characters long
		private string DayString(int Day)
		{

			string DString = Conversion.Str(Day);
			if (Strings.Len(DString) < 3)
			{
				DString = " 0" + DString.Substring(Math.Max(DString.Length - 1, 0));
			}
			return DString;
		}

		private void cmdHelp_Click(Object eventSender, EventArgs eventArgs)
		{
			//This is the Help Part of the 'Easter' module
			string TempMode = modBiblcalFunctions.Mode;
			modBiblcalFunctions.Mode = "Easter";
			modDocumentation.GetDocumentation();
			txtOut.Text = "";
			txtOut.Text = modBiblcalFunctions.Instructions;
			modBiblcalFunctions.Mode = TempMode;
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			txtYear.Text = DateTime.Today.Year.ToString();
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
					modBiblcalFunctions.Mode = "Easter";
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

		private void txtYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					cmdEaster_Click(cmdEaster, new EventArgs());
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