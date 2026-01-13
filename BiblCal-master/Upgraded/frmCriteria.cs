using System;
using System.Windows.Forms;

namespace BiblCal
{
	internal partial class frmCriteria
		: System.Windows.Forms.Form
	{

		public frmCriteria()
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


		private void frmCriteria_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		//*******************************************************************************************
		//*                               BIBLICAL CALENDAR PROGRAM                                 *
		//*                                       Ver 11.0                                         *
		//*               Criteria Form used to do Biblical calendar calculations                   *
		//*                                          -                                              *
		//*   Written by:         Dale D. Donelson, 22 November 2006                                *
		//*                      10140 E Brooks Rd., Lennon, Michigan                               *
		//*                                Phone 810 621 3163                                       *
		//*                         Email: donelson@power-net.net                                   *
		//*                                          -                                              *
		//*   Written for:     CENTRAL HIGHLANDS CHRISTIAN PUBLICATIONS                             *
		//*                    PO Box 236, Creswick, Vic. 3363 Australia                            *
		//*                            Phone (614) 0428 457 363                                     *
		//*                         http://www.chcpublications.net/                                 *
		//*                         Email: info@chcpublications.net                                 *
		//*******************************************************************************************
		//Form frmCriteria

		private void txtCriteria_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			frmConversion.DefInstance.Show();
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}