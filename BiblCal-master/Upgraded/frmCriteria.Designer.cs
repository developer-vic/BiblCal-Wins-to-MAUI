
namespace BiblCal
{
	partial class frmCriteria
	{

		#region "Upgrade Support "
		private static frmCriteria m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCriteria DefInstance
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
		public static frmCriteria CreateInstance()
		{
			frmCriteria theInstance = new frmCriteria();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtCriteria"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtCriteria;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriteria));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtCriteria = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtCriteria
			// 
			this.txtCriteria.AcceptsReturn = true;
			this.txtCriteria.AllowDrop = true;
			this.txtCriteria.BackColor = System.Drawing.SystemColors.Window;
			this.txtCriteria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCriteria.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCriteria.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCriteria.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCriteria.Location = new System.Drawing.Point(8, 8);
			this.txtCriteria.MaxLength = 0;
			this.txtCriteria.Multiline = true;
			this.txtCriteria.Name = "txtCriteria";
			this.txtCriteria.ReadOnly = true;
			this.txtCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCriteria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCriteria.Size = new System.Drawing.Size(689, 185);
			this.txtCriteria.TabIndex = 0;
			this.txtCriteria.TextChanged += new System.EventHandler(this.txtCriteria_TextChanged);
			// 
			// frmCriteria
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(706, 201);
			this.Controls.Add(this.txtCriteria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmCriteria.Icon");
			this.Location = new System.Drawing.Point(3, 356);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCriteria";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Criteria";
			this.Activated += new System.EventHandler(this.frmCriteria_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}