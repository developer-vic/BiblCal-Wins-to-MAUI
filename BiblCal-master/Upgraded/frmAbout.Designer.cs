
namespace BiblCal
{
	partial class frmAbout
	{

		#region "Upgrade Support "
		private static frmAbout m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAbout DefInstance
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
		public static frmAbout CreateInstance()
		{
			frmAbout theInstance = new frmAbout();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtAbout", "cmdClose"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtAbout;
		public System.Windows.Forms.Button cmdClose;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAbout
            // 
            this.txtAbout.AcceptsReturn = true;
            this.txtAbout.AllowDrop = true;
            this.txtAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAbout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAbout.Location = new System.Drawing.Point(16, 8);
            this.txtAbout.MaxLength = 0;
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ReadOnly = true;
            this.txtAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAbout.Size = new System.Drawing.Size(409, 233);
            this.txtAbout.TabIndex = 0;
            this.txtAbout.Text = resources.GetString("txtAbout.Text");
            this.txtAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdClose
            // 
            this.cmdClose.AllowDrop = true;
            this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClose.Location = new System.Drawing.Point(8, 248);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClose.Size = new System.Drawing.Size(409, 25);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close this Form";
            this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // frmAbout
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 281);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(316, 164);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "About BiblCal";
            this.Activated += new System.EventHandler(this.frmAbout_Activated);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
	}
}