using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Media;
using System.Windows.Forms;
using UpgradeHelpers.Gui;
using UpgradeHelpers.Helpers;
using UpgradeHelpers.VB;

namespace BiblCal
{
	internal partial class frmHolyDays
		: System.Windows.Forms.Form
	{
		bool isExiting = false;

		public frmHolyDays()
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


		private void frmHolyDays_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		//*******************************************************************************************
		//*                           Calculated Biblical Calendar PROGRAM (BiblCal)                           *
		//*                                       Ver 11.0                                         *
		//*               Main Form used to do Calculated Biblical Calendar calculations                       *
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
		//Form frmHolyDays

		int TempYear = 0;

		//Loads the forms initial variables
		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			frmSplash.DefInstance.ShowDialog();
			
			modBiblcalFunctions.Mode = "HolyDays";
			modBiblcalFunctions.CRLF = "\r" + "\n"; //Define Carriage Return and line feed string
			modDocumentation.GetDocumentation();
			frmHolyDays.DefInstance.txtOut.Text = modBiblcalFunctions.Instructions;
			// Migrate existing User Data to xml format? First time run?
			modBiblcalFunctions.ReadUserDataXML(); //Load in the locations saved on the drive.
			modBiblcalFunctions.ChangeFlag = false; //Flag to indicate changes were made to data.
			frmHolyDays.DefInstance.lblChange.Visible = false;
			modBiblcalFunctions.MonthsFlag = false; //Clear the flag so months are not calculated yet.
			modBiblcalFunctions.PrintFlag = true;
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			txtYear.Text = DateTime.Today.Year.ToString(); //Put the current year from the computer in the input Box.
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			modBiblcalFunctions.LoadBiblicalVariables(); //Load up the variables used in this form.
			frmHolyDays.DefInstance.txtYear.SelectionStart = 0;
			frmHolyDays.DefInstance.txtYear.SelectionLength = 8;
		}

		//This is the 'Holy Days' module command button
		private void cmdHolyDays_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.LocalCalcFlag = false;
			modBiblcalFunctions.MonthsFlag = false; //Used to check what to change when CHKEJW is checked.
			if (((int) chkEJW.CheckState) == ((int) CheckState.Checked))
			{
				modBiblcalFunctions.EJWString = "Y";
			}
			else
			{
				modBiblcalFunctions.EJWString = "";
			}
			modBiblcalFunctions.CalcHolyDays();
			modBiblcalFunctions.EJWString = "";
		}

		//This is the 'Jerusalem Months' module command button
		private void cmdMonths_Click(Object eventSender, EventArgs eventArgs)
		{
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			modBiblcalFunctions.LocalCalcFlag = false;
			modBiblcalFunctions.MonthsFlag = true;
			txtOut.Text = "";
			if (((int) chkEJW.CheckState) == ((int) CheckState.Checked))
			{
				modBiblcalFunctions.EJWString = "Y";
			}
			else
			{
				modBiblcalFunctions.EJWString = "";
			}
			modBiblcalFunctions.CalcNewMoons();
			modBiblcalFunctions.EJWString = "";
		}

		//This is the 'Local Moons' module command button
		public void cmdLocMon_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.LocalCalcFlag = true;
			chkEJW.CheckState = CheckState.Unchecked;
			modBiblcalFunctions.DateOfFirstMonth = 0; //Clear 'DateOfFirstMonth' so it will record the first event.
			modBiblcalFunctions.GetLocation();
			modBiblcalFunctions.MonthsFlag = true;
			txtOut.Text = "";
			if (modBiblcalFunctions.ChangeFlag)
			{
				modBiblcalFunctions.WriteUserDataXML();
			}
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			modBiblcalFunctions.CalcNewMoons();
			modBiblcalFunctions.LocalCalcFlag = false;
		}

		//This is the 'Sunsets' module command button
		private void cmdSunset_Click(Object eventSender, EventArgs eventArgs)
		{
			modSunsets.DoSunsets();
		}

		//This is the 'Times' module command button
		private void cmdTimes_Click(Object eventSender, EventArgs eventArgs)
		{
			modTimes.DoTimes();
		}

		//This is the 'Golgotha' module command button
		private void cmdGolgotha_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.Mode = "Golgotha";
			modBiblcalFunctions.TempMode = "Golgotha";
			modGolgotha.DoGolgotha(); //DoGolgotha is shared by three modules
		}

		//This is the 'Jordan' module command button
		private void cmdJordan_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.Mode = "Jordan";
			modBiblcalFunctions.TempMode = "Jordan";
			modGolgotha.DoGolgotha(); //DoGolgotha is shared by three modules
		}

		//This is the 'Creation' module command button
		private void cmdCreation_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.Mode = "Creation";
			modBiblcalFunctions.TempMode = "Creation";
			modGolgotha.DoGolgotha(); //DoGolgotha is shared by three modules
		}

		//This is the 'Flood' module command button
		private void cmdFlood_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.Mode = "Flood";
			modBiblcalFunctions.TempMode = "Flood";
			modFlood.DoFlood();
		}

		//This is the 'Conversions' module command button
		//UPGRADE_NOTE: (7001) The following declaration (CalendarConversions_Click) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
		//private void CalendarConversions_Click()
		//{
			//frmConversion.DefInstance.Show();
		//}

		public void mnuColors_Click(Object eventSender, EventArgs eventArgs)
		{
			frmBackColor.DefInstance.Show();
		}

		public void mnuConversions_Click(Object eventSender, EventArgs eventArgs)
		{
			frmConversion.DefInstance.Show();
		}

		private void Form_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{
				if (KeyCode == ((int) Keys.F1))
				{
					modBiblcalFunctions.TempMode = modBiblcalFunctions.Mode;
					modBiblcalFunctions.Mode = "HolyDays";
					modDocumentation.GetDocumentation();
					txtOut.Text = "";
					txtOut.Text = modBiblcalFunctions.Instructions;
					KeyCode = 0;
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Selects correction for East of Jerusalem (Israel) and West of International Date Line
		private void CHKEJW_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			if (modBiblcalFunctions.LocalCalcFlag || modBiblcalFunctions.FloodFlag)
			{
				return;
			} //Don't allow this routine to run on local New Moons.
			txtOut.Text = "";
			if (((int) chkEJW.CheckState) == ((int) CheckState.Checked))
			{
				modBiblcalFunctions.EJWString = "Y";
			}
			else
			{
				modBiblcalFunctions.EJWString = "";
			}
			if (modBiblcalFunctions.MonthsFlag)
			{
				modBiblcalFunctions.CalcNewMoons();
			}
			else
			{
				modBiblcalFunctions.CalcHolyDays();
			}
			modBiblcalFunctions.EJWString = "";
		}

		//***************************************************************************************
		// This Subroutine is what does the work of adding to the Combo Box for locations.
		// It also allows editing the location information and time zone.
		// If nothing was changed and the location name was selected and the ENTER key pressed
		// then the program will ask if you want to delete the location item.
		//***************************************************************************************
		private void AddEditDeleteLocation()
		{
			int Index = 0;
			DialogResult Reply = (DialogResult) 0;
			int Degree = 0;
			int Minutes = 0;
			double Latitude = 0;
			double Longitude = 0;
			int IndexNumber = 0;
			bool Found = false;
			modBiblcalFunctions.GetLocation();
			modBiblcalFunctions.NumberOfLocations = cboLocation.Items.Count - 1;
			do 
			{
				if (cboLocation.Text == modBiblcalFunctions.LocationName[Index])
				{
					Found = true;
					IndexNumber = Index; //Keep track of what entry it was in the arrays.
				}
				Index++;
			}
			while(!Found && Index <= modBiblcalFunctions.NumberOfLocations);
			if (!Found)
			{ //Item was not found so ask if yow want to add it.
				Reply = MessageBox.Show("Do you wish to add this location?" + modBiblcalFunctions.CRLF + 
				        "Selecting [Yes] will add the location" + modBiblcalFunctions.CRLF + "to the list.", "Add this location information?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Reply == System.Windows.Forms.DialogResult.Yes)
				{ //Add the item to the locations list.
					if (cboLocation.Items.Count > 499)
					{
						Reply = MessageBox.Show("There is no room to add any more locations!", "No room to add more locations!");
					}
					else
					{
						modBiblcalFunctions.LocationName[cboLocation.Items.Count] = cboLocation.Text;
						Degree = Convert.ToInt32(Double.Parse(txtLatDeg.Text));
						Minutes = Convert.ToInt32(Double.Parse(txtLatMin.Text));
						Latitude = modBiblcalFunctions.Degrees(Degree, Minutes);
						if (txtLatDir.Text == "S")
						{
							Latitude = -Latitude;
						}
						modBiblcalFunctions.DegLat[cboLocation.Items.Count] = Latitude;
						Degree = Convert.ToInt32(Double.Parse(txtLongDeg.Text));
						Minutes = Convert.ToInt32(Double.Parse(txtLongMin.Text));
						Longitude = modBiblcalFunctions.Degrees(Degree, Minutes);
						if (txtLonDir.Text == "E")
						{
							Longitude = -Longitude;
						}
						modBiblcalFunctions.DegLon[cboLocation.Items.Count] = Longitude;
						modBiblcalFunctions.GMTOffset[cboLocation.Items.Count] = txtGMT.Text;
						cboLocation.AddItem(cboLocation.Text);
						modBiblcalFunctions.NumberOfLocations++;
						modBiblcalFunctions.CurrentLocation = cboLocation.Text;
						modBiblcalFunctions.GetLocation();
						modBiblcalFunctions.WriteUserDataXML();
					}
				}
			}
			else
			{
				if (modBiblcalFunctions.ChangeFlag)
				{ //There was a change in the location data
					Reply = MessageBox.Show("Do you wish to edit this location?" + modBiblcalFunctions.CRLF + " Selecting [Yes] will change the location information.", "Edit this location information?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (Reply == System.Windows.Forms.DialogResult.Yes)
					{
						Degree = Convert.ToInt32(Double.Parse(txtLatDeg.Text));
						Minutes = Convert.ToInt32(Double.Parse(txtLatMin.Text));
						Latitude = modBiblcalFunctions.Degrees(Degree, Minutes);
						if (txtLatDir.Text == "S")
						{
							Latitude = -Latitude;
						}
						modBiblcalFunctions.DegLat[IndexNumber] = Latitude;
						Degree = Convert.ToInt32(Double.Parse(txtLongDeg.Text));
						Minutes = Convert.ToInt32(Double.Parse(txtLongMin.Text));
						Longitude = modBiblcalFunctions.Degrees(Degree, Minutes);
						if (txtLonDir.Text == "E")
						{
							Longitude = -Longitude;
						}
						modBiblcalFunctions.DegLon[IndexNumber] = Longitude;
						modBiblcalFunctions.GMTOffset[IndexNumber] = txtGMT.Text;
						modBiblcalFunctions.GetLocation();
						modBiblcalFunctions.WriteUserDataXML();
					}
					else
					{
						modBiblcalFunctions.ChangeFlag = false; //User didn't want to edit the location information
						lblChange.Visible = false;
					}
				}
				else
				{
					//There was no change and the item was found
					Reply = MessageBox.Show("Do you wish to delete this location?", "Delete this location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (Reply == System.Windows.Forms.DialogResult.Yes)
					{
						if (IndexNumber == modBiblcalFunctions.NumberOfLocations)
						{
							modBiblcalFunctions.NumberOfLocations--;
						}
						else
						{
							modBiblcalFunctions.NumberOfLocations--;
							int tempForEndVar = modBiblcalFunctions.NumberOfLocations;
							for (Index = IndexNumber; Index <= tempForEndVar; Index++)
							{
								modBiblcalFunctions.LocationName[Index] = modBiblcalFunctions.LocationName[Index + 1];
								modBiblcalFunctions.DegLat[Index] = modBiblcalFunctions.DegLat[Index + 1];
								modBiblcalFunctions.DegLon[Index] = modBiblcalFunctions.DegLon[Index + 1];
								modBiblcalFunctions.GMTOffset[Index] = modBiblcalFunctions.GMTOffset[Index + 1];
							}
						}
						cboLocation.Items.Clear();
						int tempForEndVar2 = modBiblcalFunctions.NumberOfLocations;
						for (Index = 0; Index <= tempForEndVar2; Index++)
						{
							cboLocation.AddItem(modBiblcalFunctions.LocationName[Index]);
						}
						modBiblcalFunctions.CurrentLocation = modBiblcalFunctions.LocationName[0];
						cboLocation.Text = modBiblcalFunctions.CurrentLocation;
						modBiblcalFunctions.GetLocation();
						modBiblcalFunctions.WriteUserDataXML();
					}
				}
			}
		}

		public void mnuEaster_Click(Object eventSender, EventArgs eventArgs)
		{
			frmEaster.DefInstance.Show();
		}

		public void mnuHebrew_Click(Object eventSender, EventArgs eventArgs)
		{
			frmHebrew.DefInstance.Show();
		}

		public void mnuSave_Click(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.WriteUserDataXML();
		}

		public void mnuPrint_Click(Object eventSender, EventArgs eventArgs)
		{
			bool ErrorHandler = false;
			DialogResult Reply = MessageBox.Show("Do you wish to print these results to the printer?", "Verify Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			try
			{
				if (Reply == System.Windows.Forms.DialogResult.Yes)
				{
					if (txtOut.Text != "")
					{
						ErrorHandler = true; //The exception for using a GOTO statement.
						PrinterHelper.Printer.FontSize = 10;
						PrinterHelper.Printer.Font = PrinterHelper.Printer.Font.Change(name:"Courier New");
						PrinterHelper.Printer.Print(modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF + modBiblcalFunctions.CRLF);
						PrinterHelper.Printer.Print(txtOut.Text);
						PrinterHelper.Printer.EndDoc();
					}
				}
			}
			catch (Exception excep)
			{
				if (!ErrorHandler)
				{
					throw excep;
				}
				if (ErrorHandler)
				{

					MessageBox.Show("There was a problem printing to your printer.", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
					return;
				}
			}
		}

		public void mnuExit_Click(Object eventSender, EventArgs eventArgs)
		{
			this.isExiting = true;

			//If changes were made to user data then save them.
			if (modBiblcalFunctions.ChangeFlag)
			{
				modBiblcalFunctions.WriteUserDataXML();
			}
			//Unload all forms
			frmAbout.DefInstance.Close();
			frmBackColor.DefInstance.Close();
			frmConversion.DefInstance.Close();
			frmConversionsHelp.DefInstance.Close();
			frmCriteria.DefInstance.Close();
			frmHebrew.DefInstance.Close();
			frmSplash.DefInstance.Close();
			frmEaster.DefInstance.Close();
			this.Close();
		}

		private void Form_FormClosing(Object eventSender, FormClosingEventArgs eventArgs)
		{
			int Cancel = (eventArgs.Cancel) ? 1 : 0;
			CloseReason closeReason = eventArgs.CloseReason;
			try
			{
				if (closeReason == CloseReason.UserClosing && !this.isExiting)
                {
					mnuExit_Click(mnuExit, new EventArgs()); //User clicked on the X button on top corner of window.
				}				
				Environment.Exit(0);
			}
			finally
			{
				eventArgs.Cancel = Cancel != 0;
			}
		}

		public void mnuHolyDays_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up the form for 'Holy Days' calculations.
			txtYear.Text = Conversion.Str(TempYear);
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - HOLY DAYS / NEW MOONS - www.chcpublications.net";
			modBiblcalFunctions.Mode = "HolyDays";
			modBiblcalFunctions.TempMode = "HolyDays";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = true; //Show the 'Holy Days' button
			cmdHolyDays.TabIndex = 1; //Set up the TAB key.
			cmdMonths.Visible = true; //Show the 'Months' button
			cmdMonths.TabIndex = 2; //Set up the TAB key.
			cmdSunset.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			cmdLocMon.Visible = false;
			txtYear2.Visible = false;
			chkEJW.Visible = true; //Show the check box for correcting EJW
			chkEJW.TabIndex = 3; //Set up the TAB key.
			txtLatDir.Visible = false;
			txtLonDir.Visible = false;
			txtLatDeg.Visible = false;
			txtLongDeg.Visible = false;
			txtLatMin.Visible = false;
			txtLongMin.Visible = false;
			txtGMT.Visible = false;
			lblLat.Visible = false;
			lblLong.Visible = false;
			lblGMT.Visible = false;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = false;
			lblLocation.Visible = false;
			ToolTipMain.SetToolTip(txtYear, "Year to compute (Range -4004 to 9999)");
		}

		public void mnuLocalMoons_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up for form for 'Local New moons' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - LOCAL NEW MOONS - www.chcpublications.net";
			txtYear.Text = Conversion.Str(TempYear);
			modBiblcalFunctions.Mode = "LocalMoons";
			modBiblcalFunctions.TempMode = "LocalMoons";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			cmdLocMon.Visible = true;
			cmdLocMon.TabIndex = 1; //Set up the TAB key.
			txtYear2.Visible = false;
			chkEJW.Visible = false;
			txtLatDir.Visible = true;
			txtLonDir.Visible = true;
			txtLatDeg.Visible = true;
			txtLongDeg.Visible = true;
			txtLatMin.Visible = true;
			txtLongMin.Visible = true;
			txtGMT.Visible = true;
			lblLat.Visible = true;
			lblLong.Visible = true;
			lblGMT.Visible = true;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = true;
			cboLocation.TabIndex = 2; //Set up the TAB key.
			lblLocation.Visible = true;
			ToolTipMain.SetToolTip(txtYear, "Year to compute (Range -4004 to 9999)");
		}

		public void mnuSunset_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up the form for 'local Sunsets' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - LOCAL SUNSETS - www.chcpublications.net";
			txtYear.Text = Conversion.Str(TempYear);
			modBiblcalFunctions.Mode = "Sunset";
			modBiblcalFunctions.TempMode = "Sunset";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(1080, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(7695, 8910, 594));
			chkGregYear.Visible = true;
			chkGregYear.TabIndex = 2; //Set up the TAB key.
			modBiblcalFunctions.CheckGregYearChange = true; //Don't let the chkGregYear change cause program to run
			chkGregYear.CheckState = CheckState.Unchecked;
			modBiblcalFunctions.CheckGregYearChange = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = true;
			cmdSunset.TabIndex = 1; //Set up the TAB key.
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			chkEJW.Visible = false;
			txtYear2.Visible = false;
			cmdLocMon.Visible = false;
			txtLatDir.Visible = true;
			txtLonDir.Visible = true;
			txtLatDeg.Visible = true;
			txtLongDeg.Visible = true;
			txtLatMin.Visible = true;
			txtLongMin.Visible = true;
			txtGMT.Visible = true;
			lblLat.Visible = true;
			lblLong.Visible = true;
			lblGMT.Visible = true;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = true;
			lblLocation.Visible = true;
			ToolTipMain.SetToolTip(txtYear, "Year to compute (Range -4004 to 9999)");
		}

		public void mnuTimes_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up the form for 'local Times' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - LOCAL TIMES - www.chcpublications.net";
			txtYear.Text = Conversion.Str(TempYear);
			modBiblcalFunctions.Mode = "Times";
			modBiblcalFunctions.TempMode = "Times";
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(1080, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(7695, 8910, 594));
			modDocumentation.GetDocumentation();
			chkGregYear.Visible = true;
			chkGregYear.TabIndex = 3; //Set up the TAB key.
			modBiblcalFunctions.CheckGregYearChange = true; //Don't let the chkGregYear change cause program to run
			chkGregYear.CheckState = CheckState.Unchecked;
			modBiblcalFunctions.CheckGregYearChange = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdTimes.Visible = true;
			cmdTimes.TabIndex = 1; //Set up the TAB key.
			cmdFlood.Visible = false;
			chkEJW.Visible = false;
			cmdLocMon.Visible = false;
			txtYear2.Visible = false;
			txtLatDir.Visible = true;
			txtLonDir.Visible = true;
			txtLatDeg.Visible = true;
			txtLongDeg.Visible = true;
			txtLatMin.Visible = true;
			txtLongMin.Visible = true;
			txtGMT.Visible = true;
			lblLat.Visible = true;
			lblLong.Visible = true;
			lblGMT.Visible = true;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = true;
			lblLocation.Visible = true;
			ToolTipMain.SetToolTip(txtYear, "Year to compute (Range -4004 to 9999)");
		}

		public void mnuGolgotha_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up for form for the 'Golgotha' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - GOLGOTHA - www.chcpublications.net";
			modBiblcalFunctions.Mode = "Golgotha";
			modBiblcalFunctions.TempMode = "Golgotha";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			txtYear.Text = "28";
			txtYear2.Text = "35";
			txtYear.SelectionStart = 0;
			txtYear.SelectionLength = 6;
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdLocMon.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			chkEJW.Visible = false;
			txtYear2.Visible = true;
			txtLatDir.Visible = false;
			txtLonDir.Visible = false;
			txtLatDeg.Visible = false;
			txtLongDeg.Visible = false;
			txtLatMin.Visible = false;
			txtLongMin.Visible = false;
			txtGMT.Visible = false;
			lblLat.Visible = false;
			lblLong.Visible = false;
			lblGMT.Visible = false;
			cmdGolgotha.Visible = true;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = false;
			lblLocation.Visible = false;
			ToolTipMain.SetToolTip(txtYear, "Year to start run (Range -4004 to 9999)");
			ToolTipMain.SetToolTip(txtYear2, "Year to end run (Range -4004 to 9999)");
		}

		public void mnuJordan_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up for form for the 'Jordan' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - JORDAN CROSSING - www.chcpublications.net";
			modBiblcalFunctions.Mode = "Jordan";
			modBiblcalFunctions.TempMode = "Jordan";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			txtYear.Text = "-1525";
			txtYear2.Text = "-1495";
			txtYear.SelectionStart = 0;
			txtYear.SelectionLength = 6;
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdLocMon.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			chkEJW.Visible = false;
			txtYear2.Visible = true;
			txtLatDir.Visible = false;
			txtLonDir.Visible = false;
			txtLatDeg.Visible = false;
			txtLongDeg.Visible = false;
			txtLatMin.Visible = false;
			txtLongMin.Visible = false;
			txtGMT.Visible = false;
			lblLat.Visible = false;
			lblLong.Visible = false;
			lblGMT.Visible = false;
			cmdGolgotha.Visible = false;
			cboLocation.Visible = false;
			lblLocation.Visible = false;
			cmdJordan.Visible = true;
			cmdCreation.Visible = false;
			ToolTipMain.SetToolTip(txtYear, "Year to start run (Range -4004 to 9999)");
			ToolTipMain.SetToolTip(txtYear2, "Year to end run (Range -4004 to 9999)");
		}

		public void mnuFlood_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up for form for the 'Flood' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - FLOOD - www.chcpublications.net";
			modBiblcalFunctions.Mode = "Flood";
			modBiblcalFunctions.TempMode = "Flood";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			txtYear.Text = "-2400";
			txtYear2.Text = "-2300";
			txtYear.SelectionStart = 0;
			txtYear.SelectionLength = 6;
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdLocMon.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = true;
			chkEJW.Visible = false;
			txtYear2.Visible = true;
			txtLatDir.Visible = false;
			txtLonDir.Visible = false;
			txtLatDeg.Visible = false;
			txtLongDeg.Visible = false;
			txtLatMin.Visible = false;
			txtLongMin.Visible = false;
			txtGMT.Visible = false;
			lblLat.Visible = false;
			lblLong.Visible = false;
			lblGMT.Visible = false;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = false;
			cboLocation.Visible = false;
			lblLocation.Visible = false;
			ToolTipMain.SetToolTip(txtYear, "Year to start run (Range -4004 to 9999)");
			ToolTipMain.SetToolTip(txtYear2, "Year to end run (Range -4004 to 9999)");
		}

		public void mnuCreation_Click(Object eventSender, EventArgs eventArgs)
		{
			//Sets up for form for the 'Creation' calculations.
			frmHolyDays.DefInstance.Text = "Calculated Biblical Calendar - CREATION - www.chcpublications.net";
			modBiblcalFunctions.Mode = "Creation";
			modBiblcalFunctions.TempMode = "Creation";
			modDocumentation.GetDocumentation();
			txtOut.Text = modBiblcalFunctions.Instructions;
//			txtOut.Top = Convert.ToInt32(Support.ToPixelsUserY(720, 0, 8910, 594));
//			txtOut.Height = Convert.ToInt32(Support.ToPixelsUserHeight(8055, 8910, 594));
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
			txtYear.Text = "-4040";
			txtYear2.Text = "-3965";
			txtYear.SelectionStart = 0;
			txtYear.SelectionLength = 6;
			chkGregYear.Visible = false;
			cmdHolyDays.Visible = false;
			cmdMonths.Visible = false;
			cmdSunset.Visible = false;
			cmdLocMon.Visible = false;
			cmdTimes.Visible = false;
			cmdFlood.Visible = false;
			chkEJW.Visible = false;
			txtYear2.Visible = true;
			txtLatDir.Visible = false;
			txtLonDir.Visible = false;
			txtLatDeg.Visible = false;
			txtLongDeg.Visible = false;
			txtLatMin.Visible = false;
			txtLongMin.Visible = false;
			txtGMT.Visible = false;
			lblLat.Visible = false;
			lblLong.Visible = false;
			lblGMT.Visible = false;
			cmdGolgotha.Visible = false;
			cmdJordan.Visible = false;
			cmdCreation.Visible = true;
			cboLocation.Visible = false;
			lblLocation.Visible = false;
			ToolTipMain.SetToolTip(txtYear, "Year to start run (Range -6000 to 9999)");
			ToolTipMain.SetToolTip(txtYear2, "Year to end run (Range -6000 to 9999)");
		}

		public void mnuDocumentation_Click(Object eventSender, EventArgs eventArgs)
		{
			//Retrieves the documentation for the mode using the menu bar.
			//The line below corrects the lack of documentation and was added to version 10.4.1
			if (modBiblcalFunctions.Mode == "")
			{
				modBiblcalFunctions.Mode = "HolyDays";
			}
			modDocumentation.GetDocumentation();
			txtOut.Text = "";
			txtOut.Text = modBiblcalFunctions.Instructions;
		}

		public void mnuAbout_Click(Object eventSender, EventArgs eventArgs)
		{
			frmAbout.DefInstance.Show();
		}

		//UPGRADE_WARNING: (2074) ComboBox event cboLocation.Change was upgraded to cboLocation.TextChanged which has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2074
		private bool isInitializingComponent;
		private void cboLocation_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			if (isInitializingComponent)
			{
				return;
			}
			if (Strings.Len(cboLocation.Text) > 40)
			{
				cboLocation.Text = cboLocation.Text.Substring(0, Math.Min(40, cboLocation.Text.Length));
				cboLocation.SelectionStart = 42;
				cboLocation.SelectionLength = 0;
			}
		}

		private void cboLocation_SelectionChangeCommitted(Object eventSender, EventArgs eventArgs)
		{
			
		}

		private void cboLocation_Enter(Object eventSender, EventArgs eventArgs)
		{
			cboLocation.SelectionStart = 42;
			cboLocation.SelectionLength = 0;
		}

		private void cboLocation_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					AddEditDeleteLocation();
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

		private void CHKEJW_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					if (((int) chkEJW.CheckState) == ((int) CheckState.Checked))
					{
						chkEJW.CheckState = CheckState.Unchecked;
					}
					else
					{
						chkEJW.CheckState = CheckState.Checked;
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

		private void chkGregYear_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			if (!modBiblcalFunctions.CheckGregYearChange)
			{ //If program MODE didn't change (Sunset/Times)
				if (modBiblcalFunctions.Mode == "Sunset")
				{
					cmdSunset_Click(cmdSunset, new EventArgs());
				}
				if (modBiblcalFunctions.Mode == "Times")
				{
					cmdTimes_Click(cmdTimes, new EventArgs());
				}
			}
		}

		//Check box to begin calculations with start of Gregorian year
		private void chkGregYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					if (((int) chkGregYear.CheckState) == ((int) CheckState.Checked))
					{
						chkGregYear.CheckState = CheckState.Unchecked;
					}
					else
					{
						chkGregYear.CheckState = CheckState.Checked;
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

		private void txtVerification_Click(Object eventSender, EventArgs eventArgs)
		{
			//Used to prove we wrote this program. (In case having the source isn't enough.)
			if (modBiblcalFunctions.ControlFlag)
			{
				Environment.Exit(0);
			}
			modBiblcalFunctions.ControlFlag = false;
		}

		private void txtGMT_TextChanged(Object eventSender, EventArgs eventArgs)
		{ //Set up for saving the changes made to local location
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtGMT_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtGMT.SelectionStart = 0;
			txtGMT.SelectionLength = 5;
		}

		private void txtLatDeg_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLatDeg.SelectionStart = 0;
			txtLatDeg.SelectionLength = 5;
		}

		private void txtLatDeg_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtLatMin.Focus();
				}
				else
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLatDeg_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Conversion.Val(txtLatDeg.Text) > 60)
			{
				txtLatDeg.Text = "60";
			}
			if (Conversion.Val(txtLatDeg.Text) < 0)
			{
				txtLatDeg.Text = "00";
			}
		}

		private void txtLatMin_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtLatDir.Focus();
				}
				else
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLatMin_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Conversion.Val(txtLatMin.Text) > 59)
			{
				txtLatMin.Text = "59";
			}
			if (Conversion.Val(txtLatMin.Text) < 0)
			{
				txtLatMin.Text = "00";
			}
		}

		private void txtLatDir_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtLongDeg.Focus();
				}
				else
				{
					//UPGRADE_ISSUE: (1058) Assignment not supported: KeyAscii to a non-positive constant More Information: https://www.mobilize.net/vbtonet/ewis/ewi1058
					KeyAscii = Strings.Asc(Strings.Chr(KeyAscii).ToString().ToUpper()[0]);
					if (KeyAscii != Strings.Asc('N') && KeyAscii != Strings.Asc('S') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLongDeg_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtLongMin.Focus();
				}
				else
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLongDeg_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Conversion.Val(txtLongDeg.Text) > 180)
			{
				txtLongDeg.Text = "180";
			}
			if (Conversion.Val(txtLongDeg.Text) < 0)
			{
				txtLongDeg.Text = "000";
			}
		}

		private void txtLongMin_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtLonDir.Focus();
				}
				else
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLongMin_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Conversion.Val(txtLongMin.Text) > 59)
			{
				txtLongMin.Text = "59";
			}
			if (Conversion.Val(txtLongMin.Text) < 0)
			{
				txtLongMin.Text = "00";
			}
		}

		private void txtLonDir_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					txtGMT.Focus();
				}
				else
				{
					//UPGRADE_ISSUE: (1058) Assignment not supported: KeyAscii to a non-positive constant More Information: https://www.mobilize.net/vbtonet/ewis/ewi1058
					KeyAscii = Strings.Asc(Strings.Chr(KeyAscii).ToString().ToUpper()[0]); //Change it to uppercase
					if (KeyAscii != Strings.Asc('E') && KeyAscii != Strings.Asc('W'))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtGMT_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == ((int) Keys.Space) || KeyAscii == Strings.Asc(','))
				{
					KeyAscii = 0;
					if (modBiblcalFunctions.Mode == "Sunset" || modBiblcalFunctions.Mode == "Times")
					{
						chkGregYear.Focus();
					}
				}
				else
				{
					if ((KeyAscii < Strings.Asc('0') || KeyAscii > Strings.Asc('9')) && KeyAscii != Strings.Asc('.') && KeyAscii != ((int) Keys.Back))
					{
						KeyAscii = 0; // Cancel the character.
						SystemSounds.Beep.Play(); // Sound error signal.
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

		private void txtLatDir_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLatDeg_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLatDir_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLatDir.SelectionStart = 0;
			txtLatDir.SelectionLength = 5;
		}

		private void txtLatMin_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLatMin_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLatMin.SelectionStart = 0;
			txtLatMin.SelectionLength = 5;
		}

		private void txtLonDir_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLonDir_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLonDir.SelectionStart = 0;
			txtLonDir.SelectionLength = 5;
		}

		private void txtLongDeg_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLongDeg_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLongDeg.SelectionStart = 0;
			txtLongDeg.SelectionLength = 5;
		}

		private void txtLongMin_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			modBiblcalFunctions.ChangeFlag = true;
			lblChange.Visible = true;
		}

		private void txtLongMin_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtLongMin.SelectionStart = 0;
			txtLongMin.SelectionLength = 5;
		}

		private void txtYear_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtYear.SelectionStart = 0;
			txtYear.SelectionLength = 8;
		}

		//Makes the number in txtYear go higher or lower with the up and down arrow keys.
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

		//Filter for first year text box
		private void txtYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{

				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					if (modBiblcalFunctions.Mode == "")
					{
						modBiblcalFunctions.Mode = modBiblcalFunctions.TempMode;
					}
					switch(modBiblcalFunctions.Mode)
					{
						case "HolyDays" : 
							if (modBiblcalFunctions.MonthsFlag)
							{
								cmdMonths_Click(cmdMonths, new EventArgs());
							}
							else
							{
								cmdHolyDays_Click(cmdHolyDays, new EventArgs());
							} 
							break;
						case "LocalMoons" : 
							cmdLocMon.Enabled = false; 
							cmdLocMon_Click(cmdLocMon, new EventArgs()); 
							cmdLocMon.Enabled = true; 
							break;
						case "Sunset" : 
							cmdSunset_Click(cmdSunset, new EventArgs()); 
							break;
						case "Times" : 
							cmdTimes_Click(cmdTimes, new EventArgs()); 
							break;
						case "Flood" : 
							cmdFlood.Enabled = false; 
							cmdFlood_Click(cmdFlood, new EventArgs()); 
							cmdFlood.Enabled = true; 
							break;
						case "Jordan" : case "Creation" : case "Golgotha" : 
							modGolgotha.DoGolgotha(); 
							break;
					}
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

		private void txtYear_Leave(Object eventSender, EventArgs eventArgs)
		{
			TempYear = Convert.ToInt32(Conversion.Val(txtYear.Text));
		}

		//Selects everything in the text box.
		private void txtYear2_Enter(Object eventSender, EventArgs eventArgs)
		{
			txtYear2.SelectionStart = 0;
			txtYear2.SelectionLength = 8;
		}

		//Makes the number in txtYear2 go higher or lower with the up and down arrow keys.
		private void txtYear2_KeyDown(Object eventSender, KeyEventArgs eventArgs)
		{
			int KeyCode = (int) eventArgs.KeyCode;
			int Shift = ((int) eventArgs.KeyData) / 65536;
			try
			{

				int LastYear = 2;
				if (KeyCode == ((int) Keys.Up))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtYear2.Text));
					txtYear2.Text = (Conversion.Val(txtYear2.Text) + 1).ToString();
				}
				if (KeyCode == ((int) Keys.Down))
				{
					LastYear = Convert.ToInt32(Conversion.Val(txtYear2.Text));
					txtYear2.Text = (Conversion.Val(txtYear2.Text) - 1).ToString();
				}
				if (txtYear2.Text == "0")
				{ //Make year skip zero
					if (LastYear == 1)
					{
						txtYear2.Text = "-1";
					}
					if (LastYear == -1)
					{
						txtYear2.Text = "1";
					}
				}
			}
			finally
			{
				eventArgs.Handled = KeyCode == 0;
			}
		}

		//Filter for input to Year2 text box.
		private void txtYear2_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (KeyAscii == 13)
				{
					KeyAscii = 0;
					switch(modBiblcalFunctions.Mode)
					{
						case "Golgotha" : case "Jordan" : case "Creation" : 
							modGolgotha.DoGolgotha(); 
							break;
						case "Flood" : 
							cmdFlood.Enabled = false; 
							cmdFlood_Click(cmdFlood, new EventArgs()); 
							cmdFlood.Enabled = true; 
							break;
					}
				}
				if (KeyAscii != 0)
				{ //Filter out keypresses not to be used
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
		[STAThread]
		static void Main()
		{
			Application.Run(CreateInstance());
		}

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
			modBiblcalFunctions.CurrentLocation = cboLocation.Text;
			modBiblcalFunctions.SetupLocation();
		}
    }
}