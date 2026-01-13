using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiblCal
{
	internal partial class frmBackColor
		: System.Windows.Forms.Form
	{

		public frmBackColor()
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


		private void frmBackColor_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		//*******************************************************************************************
		//*                               BIBLICAL CALENDAR PROGRAM                                 *
		//*                                       Ver 11.0                                         *
		//*              Background Color form used with Biblical calendar calculations             *
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
		//Form frmBackColor

		Color OriginalColor = System.Drawing.Color.Black;

		private void chkStayOnTop_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			//Makes the form stay on top till unchecked

			int lR = 0; //Used by module 'modStayOnTop'

			if (((int) chkStayOnTop.CheckState) == ((int) CheckState.Checked))
			{
				lR = modStayOnTop.SetTopMostWindow(frmBackColor.DefInstance.Handle.ToInt32(), true);
			}
			else
			{
				lR = modStayOnTop.SetTopMostWindow(frmBackColor.DefInstance.Handle.ToInt32(), false);
			}
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			//UPGRADE_ISSUE: (2064) MSComDlg.ColorConstants property ColorConstants.cdlCCRGBInit was not upgraded. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2064
			//UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property dlgColor.FLAGS was not upgraded. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2064
			//dlgColor.setFlags((int) UpgradeStubs.MSComDlg_ColorConstants.getcdlCCRGBInit());
			txtAboutForm.BackColor = frmAbout.DefInstance.BackColor;
			txtAboutTxt.BackColor = frmAbout.DefInstance.txtAbout.BackColor;
			txtConversionsMain.BackColor = frmConversion.DefInstance.BackColor;
			txtGDayOfWeek.BackColor = frmConversion.DefInstance.lblGDayOfWeek.BackColor;
			txtBDayOfWeek.BackColor = frmConversion.DefInstance.lblBDayOfWeek.BackColor;
			txtGregorianFrame.BackColor = frmConversion.DefInstance.fraGregorian.BackColor;
			txtBiblicalFrame.BackColor = frmConversion.DefInstance.fraBiblical.BackColor;
			txtHebrewFrame.BackColor = frmConversion.DefInstance.fraHebrew.BackColor;
			txtJulianFrame.BackColor = frmConversion.DefInstance.fraJulian.BackColor;
			txtMainForm.BackColor = frmHolyDays.DefInstance.BackColor;
			txtMainFormTxt.BackColor = frmHolyDays.DefInstance.txtOut.BackColor;
			txtMolad.BackColor = frmConversion.DefInstance.lblMolad1.BackColor;
			txtRabbinicalMain.BackColor = frmHebrew.DefInstance.BackColor;
			txtRabFormTxt.BackColor = frmHebrew.DefInstance.txtOut.BackColor;
			txtRules.BackColor = frmConversion.DefInstance.lblRules.BackColor;
			txtJulianCalendarFrame.BackColor = frmConversion.DefInstance.fraJulianCal.BackColor;
		}

		private void txtAboutForm_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmAbout.DefInstance.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmAbout.DefInstance.BackColor = dlgColorColor.Color;
			txtAboutForm.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmAbout.DefInstance.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtAboutTxt_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmAbout.DefInstance.txtAbout.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmAbout.DefInstance.txtAbout.BackColor = dlgColorColor.Color;
			txtAboutTxt.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmAbout.DefInstance.txtAbout.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtConversionsMain_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.BackColor = dlgColorColor.Color;
			txtConversionsMain.BackColor = dlgColorColor.Color;
			frmConversion.DefInstance.txtControl.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtGDayOfWeek_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.lblGDayOfWeek.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.lblGDayOfWeek.BackColor = dlgColorColor.Color;
			txtGDayOfWeek.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.lblGDayOfWeek.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtBDayOfWeek_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.lblBDayOfWeek.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.lblBDayOfWeek.BackColor = dlgColorColor.Color;
			txtBDayOfWeek.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.lblBDayOfWeek.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtGregorianFrame_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.fraGregorian.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.fraGregorian.BackColor = dlgColorColor.Color;
			txtGregorianFrame.BackColor = dlgColorColor.Color;
			frmConversion.DefInstance.lblGYearType.BackColor = frmConversion.DefInstance.fraGregorian.BackColor;
			if (OriginalColor != frmConversion.DefInstance.fraGregorian.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtBiblicalFrame_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.fraBiblical.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.fraBiblical.BackColor = dlgColorColor.Color;
			txtBiblicalFrame.BackColor = dlgColorColor.Color;
			// frmConversion.lblBYearType.BackColor = frmConversion.fraGregorian.BackColor
			if (OriginalColor != frmConversion.DefInstance.fraBiblical.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtHebrewFrame_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.fraHebrew.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.fraHebrew.BackColor = dlgColorColor.Color;
			txtHebrewFrame.BackColor = dlgColorColor.Color;
			frmConversion.DefInstance.lblHYearType.BackColor = frmConversion.DefInstance.fraHebrew.BackColor;
			frmConversion.DefInstance.lblMolad.BackColor = frmConversion.DefInstance.fraHebrew.BackColor;
			frmConversion.DefInstance.chkOnTop.BackColor = frmConversion.DefInstance.fraHebrew.BackColor;
			frmConversion.DefInstance.lblTabInd.BackColor = frmConversion.DefInstance.fraHebrew.BackColor;
			frmConversion.DefInstance.txtControl.BackColor = frmConversion.DefInstance.BackColor;
			if (OriginalColor != frmConversion.DefInstance.fraHebrew.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}

		}

		private void txtJulianCalendarFrame_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.fraJulianCal.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.fraJulianCal.BackColor = dlgColorColor.Color;
			txtJulianCalendarFrame.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.fraJulianCal.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtJulianFrame_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.fraJulian.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.fraJulian.BackColor = dlgColorColor.Color;
			txtJulianFrame.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.fraJulian.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtMainForm_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmHolyDays.DefInstance.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmHolyDays.DefInstance.BackColor = dlgColorColor.Color;
			txtMainForm.BackColor = dlgColorColor.Color;
			frmHolyDays.DefInstance.chkEJW.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.lblLat.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.lblLong.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.lblGMT.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.txtVerification.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.chkGregYear.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.lblLocation.BackColor = frmHolyDays.DefInstance.BackColor;
			frmHolyDays.DefInstance.txtWorking.BackColor = frmHolyDays.DefInstance.BackColor;
			if (OriginalColor != frmHolyDays.DefInstance.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtMainFormTxt_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmHolyDays.DefInstance.txtOut.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmHolyDays.DefInstance.txtOut.BackColor = dlgColorColor.Color;
			txtMainFormTxt.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmHolyDays.DefInstance.txtOut.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtMolad_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.lblMolad1.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.lblMolad1.BackColor = dlgColorColor.Color;
			txtMolad.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.lblMolad1.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtRabbinicalMain_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmHebrew.DefInstance.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmHebrew.DefInstance.BackColor = dlgColorColor.Color;
			txtRabbinicalMain.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmHebrew.DefInstance.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtRabFormTxt_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmHebrew.DefInstance.txtOut.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmHebrew.DefInstance.txtOut.BackColor = dlgColorColor.Color;
			txtRabFormTxt.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmHebrew.DefInstance.txtOut.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}

		private void txtRules_Click(Object eventSender, EventArgs eventArgs)
		{
			OriginalColor = frmConversion.DefInstance.lblRules.BackColor;
			dlgColorColor.Color = OriginalColor;
			dlgColorColor.ShowDialog();
			frmConversion.DefInstance.lblRules.BackColor = dlgColorColor.Color;
			frmConversion.DefInstance.lblHDay.BackColor = dlgColorColor.Color;
			txtRules.BackColor = dlgColorColor.Color;
			if (OriginalColor != frmConversion.DefInstance.lblRules.BackColor)
			{
				modBiblcalFunctions.ChangeFlag = true;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}