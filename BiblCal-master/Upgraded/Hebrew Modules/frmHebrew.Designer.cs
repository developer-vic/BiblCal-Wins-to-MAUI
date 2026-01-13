
namespace BiblCal
{
	partial class frmHebrew
	{

		#region "Upgrade Support "
		private static frmHebrew m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmHebrew DefInstance
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
		public static frmHebrew CreateInstance()
		{
			frmHebrew theInstance = new frmHebrew();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdHelp", "cmdCompute", "txtYear", "txtOut"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdHelp;
		public System.Windows.Forms.Button cmdCompute;
		public System.Windows.Forms.TextBox txtYear;
		public System.Windows.Forms.TextBox txtOut;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHebrew));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdHelp = new System.Windows.Forms.Button();
			this.cmdCompute = new System.Windows.Forms.Button();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdHelp
			// 
			this.cmdHelp.AllowDrop = true;
			this.cmdHelp.BackColor = System.Drawing.SystemColors.Control;
			this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdHelp.Location = new System.Drawing.Point(200, 8);
			this.cmdHelp.Name = "cmdHelp";
			this.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdHelp.Size = new System.Drawing.Size(49, 25);
			this.cmdHelp.TabIndex = 3;
			this.cmdHelp.Text = "Help";
			this.cmdHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdHelp.UseVisualStyleBackColor = false;
			this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
			// 
			// cmdCompute
			// 
			this.cmdCompute.AllowDrop = true;
			this.cmdCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCompute.Location = new System.Drawing.Point(72, 8);
			this.cmdCompute.Name = "cmdCompute";
			this.cmdCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCompute.Size = new System.Drawing.Size(97, 25);
			this.cmdCompute.TabIndex = 2;
			this.cmdCompute.Text = "Compute";
			this.cmdCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCompute.UseVisualStyleBackColor = false;
			this.cmdCompute.Click += new System.EventHandler(this.cmdCompute_Click);
			// 
			// txtYear
			// 
			this.txtYear.AcceptsReturn = true;
			this.txtYear.AllowDrop = true;
			this.txtYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtYear.Location = new System.Drawing.Point(16, 8);
			this.txtYear.MaxLength = 0;
			this.txtYear.Name = "txtYear";
			this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtYear.Size = new System.Drawing.Size(49, 25);
			this.txtYear.TabIndex = 1;
			this.txtYear.Text = "2000";
			this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			// 
			// txtOut
			// 
			this.txtOut.AcceptsReturn = true;
			this.txtOut.AllowDrop = true;
			this.txtOut.BackColor = System.Drawing.SystemColors.Window;
			this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOut.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtOut.Font = new System.Drawing.Font("Arial", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtOut.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOut.Location = new System.Drawing.Point(16, 40);
			this.txtOut.MaxLength = 0;
			this.txtOut.Multiline = true;
			this.txtOut.Name = "txtOut";
			this.txtOut.ReadOnly = true;
			this.txtOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOut.Size = new System.Drawing.Size(457, 505);
			this.txtOut.TabIndex = 0;
			this.txtOut.TabStop = false;
			// 
			// frmHebrew
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(255, 128, 255);
			this.ClientSize = new System.Drawing.Size(489, 565);
			this.Controls.Add(this.cmdHelp);
			this.Controls.Add(this.cmdCompute);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.txtOut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmHebrew.Icon");
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(461, 85);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHebrew";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Hebrew Calendar - Rabbinic";
			this.Activated += new System.EventHandler(this.frmHebrew_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.ResumeLayout(false);
		}
		#endregion
	}
}