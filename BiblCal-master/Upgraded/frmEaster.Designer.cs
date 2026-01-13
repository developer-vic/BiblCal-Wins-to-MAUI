
namespace BiblCal
{
	partial class frmEaster
	{

		#region "Upgrade Support "
		private static frmEaster m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmEaster DefInstance
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
		public static frmEaster CreateInstance()
		{
			frmEaster theInstance = new frmEaster();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdHelp", "cmdEaster", "txtOut", "txtYear"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdHelp;
		public System.Windows.Forms.Button cmdEaster;
		public System.Windows.Forms.TextBox txtOut;
		public System.Windows.Forms.TextBox txtYear;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEaster));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdHelp = new System.Windows.Forms.Button();
			this.cmdEaster = new System.Windows.Forms.Button();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdHelp
			// 
			this.cmdHelp.AllowDrop = true;
			this.cmdHelp.BackColor = System.Drawing.SystemColors.Control;
			this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdHelp.Location = new System.Drawing.Point(232, 8);
			this.cmdHelp.Name = "cmdHelp";
			this.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdHelp.Size = new System.Drawing.Size(57, 25);
			this.cmdHelp.TabIndex = 2;
			this.cmdHelp.Text = "Help";
			this.cmdHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdHelp.UseVisualStyleBackColor = false;
			this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
			// 
			// cmdEaster
			// 
			this.cmdEaster.AllowDrop = true;
			this.cmdEaster.BackColor = System.Drawing.SystemColors.Control;
			this.cmdEaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdEaster.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEaster.Location = new System.Drawing.Point(96, 8);
			this.cmdEaster.Name = "cmdEaster";
			this.cmdEaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdEaster.Size = new System.Drawing.Size(105, 25);
			this.cmdEaster.TabIndex = 1;
			this.cmdEaster.Text = "Find Easter";
			this.cmdEaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdEaster.UseVisualStyleBackColor = false;
			this.cmdEaster.Click += new System.EventHandler(this.cmdEaster_Click);
			// 
			// txtOut
			// 
			this.txtOut.AcceptsReturn = true;
			this.txtOut.AllowDrop = true;
			this.txtOut.BackColor = System.Drawing.SystemColors.Window;
			this.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOut.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtOut.Font = new System.Drawing.Font("Courier New", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtOut.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOut.Location = new System.Drawing.Point(8, 40);
			this.txtOut.MaxLength = 0;
			this.txtOut.Multiline = true;
			this.txtOut.Name = "txtOut";
			this.txtOut.ReadOnly = true;
			this.txtOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOut.Size = new System.Drawing.Size(657, 409);
			this.txtOut.TabIndex = 3;
			// 
			// txtYear
			// 
			this.txtYear.AcceptsReturn = true;
			this.txtYear.AllowDrop = true;
			this.txtYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtYear.Location = new System.Drawing.Point(16, 8);
			this.txtYear.MaxLength = 0;
			this.txtYear.Name = "txtYear";
			this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtYear.Size = new System.Drawing.Size(65, 25);
			this.txtYear.TabIndex = 0;
			this.txtYear.Text = "Year";
			this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			// 
			// frmEaster
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.ClientSize = new System.Drawing.Size(675, 459);
			this.Controls.Add(this.cmdHelp);
			this.Controls.Add(this.cmdEaster);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.txtYear);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmEaster.Icon");
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(288, 108);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEaster";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Easter";
			this.Visible = false;
			this.ToolTipMain.SetToolTip(this.cmdEaster, "Computes 500 years of dates.");
			this.ToolTipMain.SetToolTip(this.txtYear, "Year to calculate. (1 to 9499)");
			this.Activated += new System.EventHandler(this.frmEaster_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.ResumeLayout(false);
		}
		#endregion
	}
}