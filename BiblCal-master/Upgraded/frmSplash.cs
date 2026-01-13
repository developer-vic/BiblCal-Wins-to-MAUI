using System;
using System.Diagnostics;
using System.Windows.Forms;
using UpgradeHelpers.Helpers;

namespace BiblCal
{
	internal partial class frmSplash
		: System.Windows.Forms.Form
	{

		public frmSplash()
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


		private void frmSplash_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		int Index = 0;

		private void Form_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				frmHolyDays.DefInstance.Visible = true;
				this.Close();
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

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			Index = 2;
			frmHolyDays.DefInstance.Visible = false;
			lblVersion.Text = "Version " + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMajorPart.ToString() + "." + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileMinorPart.ToString() + "." + FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FilePrivatePart.ToString();
			lblProductName.Text = AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
		}

		private void Frame1_Click(Object eventSender, EventArgs eventArgs)
		{
			frmHolyDays.DefInstance.Visible = true;
			this.Close();
		}

		private void timDelay_Tick(Object eventSender, EventArgs eventArgs)
		{
			frmHolyDays.DefInstance.Visible = true;
			this.Close();
		}

		private void tmrPicRot_Tick(Object eventSender, EventArgs eventArgs)
		{
			imgLogo.Image = frmConversion.DefInstance.picMoon[Index].Image;
			Index++;
			if (Index > 58)
			{
				Index = 0;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}

        private void ToolTipMain_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}