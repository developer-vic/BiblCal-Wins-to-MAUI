
namespace BiblCal
{
	partial class frmConversionsHelp
	{

		#region "Upgrade Support "
		private static frmConversionsHelp m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmConversionsHelp DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmConversionsHelp CreateInstance()
		{
			frmConversionsHelp theInstance = new frmConversionsHelp();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtHelp"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtHelp;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversionsHelp));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtHelp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtHelp
			// 
			this.txtHelp.AcceptsReturn = true;
			this.txtHelp.AllowDrop = true;
			this.txtHelp.BackColor = System.Drawing.SystemColors.Window;
			this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHelp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHelp.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHelp.Location = new System.Drawing.Point(8, 8);
			this.txtHelp.MaxLength = 0;
			this.txtHelp.Multiline = true;
			this.txtHelp.Name = "txtHelp";
			this.txtHelp.ReadOnly = true;
			this.txtHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHelp.Size = new System.Drawing.Size(457, 433);
			this.txtHelp.TabIndex = 0;
			// 
			// frmConversionsHelp
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(473, 448);
			this.Controls.Add(this.txtHelp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmConversionsHelp.Icon");
			this.Location = new System.Drawing.Point(160, 55);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConversionsHelp";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Conversions Help";
			this.Activated += new System.EventHandler(this.frmConversionsHelp_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}