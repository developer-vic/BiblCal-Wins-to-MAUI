
namespace BiblCal
{
	partial class frmBackColor
	{

		#region "Upgrade Support "
		private static frmBackColor m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmBackColor DefInstance
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
		public static frmBackColor CreateInstance()
		{
			frmBackColor theInstance = new frmBackColor();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "chkStayOnTop", "txtAboutTxt", "txtAboutForm", "fraAbout", "txtJulianCalendarFrame", "txtBDayOfWeek", "txtBiblicalFrame", "txtRules", "txtGDayOfWeek", "txtMolad", "txtHebrewFrame", "txtJulianFrame", "txtGregorianFrame", "txtConversionsMain", "fraConversions", "dlgColorColor", "dlgColor", "txtRabFormTxt", "txtRabbinicalMain", "fraRabbinical", "txtMainFormTxt", "txtMainForm", "fraMain"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.CheckBox chkStayOnTop;
		public System.Windows.Forms.TextBox txtAboutTxt;
		public System.Windows.Forms.TextBox txtAboutForm;
		public System.Windows.Forms.GroupBox fraAbout;
		public System.Windows.Forms.TextBox txtJulianCalendarFrame;
		public System.Windows.Forms.TextBox txtBDayOfWeek;
		public System.Windows.Forms.TextBox txtBiblicalFrame;
		public System.Windows.Forms.TextBox txtRules;
		public System.Windows.Forms.TextBox txtGDayOfWeek;
		public System.Windows.Forms.TextBox txtMolad;
		public System.Windows.Forms.TextBox txtHebrewFrame;
		public System.Windows.Forms.TextBox txtJulianFrame;
		public System.Windows.Forms.TextBox txtGregorianFrame;
		public System.Windows.Forms.TextBox txtConversionsMain;
		public System.Windows.Forms.GroupBox fraConversions;
		public System.Windows.Forms.ColorDialog dlgColorColor;
		public UpgradeStubs.AxMSComDlg_AxCommonDialog dlgColor;
		public System.Windows.Forms.TextBox txtRabFormTxt;
		public System.Windows.Forms.TextBox txtRabbinicalMain;
		public System.Windows.Forms.GroupBox fraRabbinical;
		public System.Windows.Forms.TextBox txtMainFormTxt;
		public System.Windows.Forms.TextBox txtMainForm;
		public System.Windows.Forms.GroupBox fraMain;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackColor));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.chkStayOnTop = new System.Windows.Forms.CheckBox();
			this.fraAbout = new System.Windows.Forms.GroupBox();
			this.txtAboutTxt = new System.Windows.Forms.TextBox();
			this.txtAboutForm = new System.Windows.Forms.TextBox();
			this.fraConversions = new System.Windows.Forms.GroupBox();
			this.txtJulianCalendarFrame = new System.Windows.Forms.TextBox();
			this.txtBDayOfWeek = new System.Windows.Forms.TextBox();
			this.txtBiblicalFrame = new System.Windows.Forms.TextBox();
			this.txtRules = new System.Windows.Forms.TextBox();
			this.txtGDayOfWeek = new System.Windows.Forms.TextBox();
			this.txtMolad = new System.Windows.Forms.TextBox();
			this.txtHebrewFrame = new System.Windows.Forms.TextBox();
			this.txtJulianFrame = new System.Windows.Forms.TextBox();
			this.txtGregorianFrame = new System.Windows.Forms.TextBox();
			this.txtConversionsMain = new System.Windows.Forms.TextBox();
			this.fraRabbinical = new System.Windows.Forms.GroupBox();
			this.dlgColorColor = new System.Windows.Forms.ColorDialog();
			this.dlgColor = new UpgradeStubs.AxMSComDlg_AxCommonDialog();
			this.txtRabFormTxt = new System.Windows.Forms.TextBox();
			this.txtRabbinicalMain = new System.Windows.Forms.TextBox();
			this.fraMain = new System.Windows.Forms.GroupBox();
			this.txtMainFormTxt = new System.Windows.Forms.TextBox();
			this.txtMainForm = new System.Windows.Forms.TextBox();
			this.fraAbout.SuspendLayout();
			this.fraConversions.SuspendLayout();
			this.fraRabbinical.SuspendLayout();
			this.fraMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkStayOnTop
			// 
			this.chkStayOnTop.AllowDrop = true;
			this.chkStayOnTop.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkStayOnTop.BackColor = System.Drawing.SystemColors.Control;
			this.chkStayOnTop.CausesValidation = true;
			this.chkStayOnTop.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkStayOnTop.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkStayOnTop.Enabled = true;
			this.chkStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkStayOnTop.Location = new System.Drawing.Point(200, 0);
			this.chkStayOnTop.Name = "chkStayOnTop";
			this.chkStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkStayOnTop.Size = new System.Drawing.Size(17, 17);
			this.chkStayOnTop.TabIndex = 19;
			this.chkStayOnTop.TabStop = true;
			this.chkStayOnTop.Text = "Check1";
			this.chkStayOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkStayOnTop.Visible = true;
			this.chkStayOnTop.CheckStateChanged += new System.EventHandler(this.chkStayOnTop_CheckStateChanged);
			// 
			// fraAbout
			// 
			this.fraAbout.AllowDrop = true;
			this.fraAbout.BackColor = System.Drawing.SystemColors.Control;
			this.fraAbout.Controls.Add(this.txtAboutTxt);
			this.fraAbout.Controls.Add(this.txtAboutForm);
			this.fraAbout.Enabled = true;
			this.fraAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraAbout.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraAbout.Location = new System.Drawing.Point(8, 424);
			this.fraAbout.Name = "fraAbout";
			this.fraAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraAbout.Size = new System.Drawing.Size(201, 73);
			this.fraAbout.TabIndex = 18;
			this.fraAbout.Text = "About";
			this.fraAbout.Visible = true;
			// 
			// txtAboutTxt
			// 
			this.txtAboutTxt.AcceptsReturn = true;
			this.txtAboutTxt.AllowDrop = true;
			this.txtAboutTxt.BackColor = System.Drawing.SystemColors.Window;
			this.txtAboutTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtAboutTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAboutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtAboutTxt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAboutTxt.Location = new System.Drawing.Point(8, 40);
			this.txtAboutTxt.MaxLength = 0;
			this.txtAboutTxt.Name = "txtAboutTxt";
			this.txtAboutTxt.ReadOnly = true;
			this.txtAboutTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtAboutTxt.Size = new System.Drawing.Size(185, 25);
			this.txtAboutTxt.TabIndex = 15;
			this.txtAboutTxt.Text = "About Text";
			this.txtAboutTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAboutTxt.Click += new System.EventHandler(this.txtAboutTxt_Click);
			// 
			// txtAboutForm
			// 
			this.txtAboutForm.AcceptsReturn = true;
			this.txtAboutForm.AllowDrop = true;
			this.txtAboutForm.BackColor = System.Drawing.SystemColors.Window;
			this.txtAboutForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtAboutForm.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAboutForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtAboutForm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAboutForm.Location = new System.Drawing.Point(8, 16);
			this.txtAboutForm.MaxLength = 0;
			this.txtAboutForm.Name = "txtAboutForm";
			this.txtAboutForm.ReadOnly = true;
			this.txtAboutForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtAboutForm.Size = new System.Drawing.Size(185, 25);
			this.txtAboutForm.TabIndex = 14;
			this.txtAboutForm.Text = "About Form";
			this.txtAboutForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAboutForm.Click += new System.EventHandler(this.txtAboutForm_Click);
			// 
			// fraConversions
			// 
			this.fraConversions.AllowDrop = true;
			this.fraConversions.BackColor = System.Drawing.SystemColors.Control;
			this.fraConversions.Controls.Add(this.txtJulianCalendarFrame);
			this.fraConversions.Controls.Add(this.txtBDayOfWeek);
			this.fraConversions.Controls.Add(this.txtBiblicalFrame);
			this.fraConversions.Controls.Add(this.txtRules);
			this.fraConversions.Controls.Add(this.txtGDayOfWeek);
			this.fraConversions.Controls.Add(this.txtMolad);
			this.fraConversions.Controls.Add(this.txtHebrewFrame);
			this.fraConversions.Controls.Add(this.txtJulianFrame);
			this.fraConversions.Controls.Add(this.txtGregorianFrame);
			this.fraConversions.Controls.Add(this.txtConversionsMain);
			this.fraConversions.Enabled = true;
			this.fraConversions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraConversions.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraConversions.Location = new System.Drawing.Point(8, 160);
			this.fraConversions.Name = "fraConversions";
			this.fraConversions.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraConversions.Size = new System.Drawing.Size(201, 265);
			this.fraConversions.TabIndex = 17;
			this.fraConversions.Text = "Conversions";
			this.fraConversions.Visible = true;
			// 
			// txtJulianCalendarFrame
			// 
			this.txtJulianCalendarFrame.AcceptsReturn = true;
			this.txtJulianCalendarFrame.AllowDrop = true;
			this.txtJulianCalendarFrame.BackColor = System.Drawing.SystemColors.Window;
			this.txtJulianCalendarFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJulianCalendarFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJulianCalendarFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJulianCalendarFrame.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJulianCalendarFrame.Location = new System.Drawing.Point(8, 64);
			this.txtJulianCalendarFrame.MaxLength = 0;
			this.txtJulianCalendarFrame.Name = "txtJulianCalendarFrame";
			this.txtJulianCalendarFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJulianCalendarFrame.Size = new System.Drawing.Size(185, 25);
			this.txtJulianCalendarFrame.TabIndex = 20;
			this.txtJulianCalendarFrame.Text = "Julian Frame";
			this.txtJulianCalendarFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJulianCalendarFrame.Click += new System.EventHandler(this.txtJulianCalendarFrame_Click);
			// 
			// txtBDayOfWeek
			// 
			this.txtBDayOfWeek.AcceptsReturn = true;
			this.txtBDayOfWeek.AllowDrop = true;
			this.txtBDayOfWeek.BackColor = System.Drawing.SystemColors.Window;
			this.txtBDayOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBDayOfWeek.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBDayOfWeek.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBDayOfWeek.Location = new System.Drawing.Point(8, 184);
			this.txtBDayOfWeek.MaxLength = 0;
			this.txtBDayOfWeek.Name = "txtBDayOfWeek";
			this.txtBDayOfWeek.ReadOnly = true;
			this.txtBDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBDayOfWeek.Size = new System.Drawing.Size(185, 25);
			this.txtBDayOfWeek.TabIndex = 11;
			this.txtBDayOfWeek.Text = "Biblical Day of Week";
			this.txtBDayOfWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBDayOfWeek.Click += new System.EventHandler(this.txtBDayOfWeek_Click);
			// 
			// txtBiblicalFrame
			// 
			this.txtBiblicalFrame.AcceptsReturn = true;
			this.txtBiblicalFrame.AllowDrop = true;
			this.txtBiblicalFrame.BackColor = System.Drawing.SystemColors.Window;
			this.txtBiblicalFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBiblicalFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBiblicalFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBiblicalFrame.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBiblicalFrame.Location = new System.Drawing.Point(8, 88);
			this.txtBiblicalFrame.MaxLength = 0;
			this.txtBiblicalFrame.Name = "txtBiblicalFrame";
			this.txtBiblicalFrame.ReadOnly = true;
			this.txtBiblicalFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBiblicalFrame.Size = new System.Drawing.Size(185, 25);
			this.txtBiblicalFrame.TabIndex = 8;
			this.txtBiblicalFrame.Text = "Biblical Frame";
			this.txtBiblicalFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBiblicalFrame.Click += new System.EventHandler(this.txtBiblicalFrame_Click);
			// 
			// txtRules
			// 
			this.txtRules.AcceptsReturn = true;
			this.txtRules.AllowDrop = true;
			this.txtRules.BackColor = System.Drawing.SystemColors.Window;
			this.txtRules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtRules.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtRules.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRules.Location = new System.Drawing.Point(8, 232);
			this.txtRules.MaxLength = 0;
			this.txtRules.Name = "txtRules";
			this.txtRules.ReadOnly = true;
			this.txtRules.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRules.Size = new System.Drawing.Size(185, 25);
			this.txtRules.TabIndex = 13;
			this.txtRules.Text = "Postponement Rules";
			this.txtRules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRules.Click += new System.EventHandler(this.txtRules_Click);
			// 
			// txtGDayOfWeek
			// 
			this.txtGDayOfWeek.AcceptsReturn = true;
			this.txtGDayOfWeek.AllowDrop = true;
			this.txtGDayOfWeek.BackColor = System.Drawing.SystemColors.Window;
			this.txtGDayOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtGDayOfWeek.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGDayOfWeek.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGDayOfWeek.Location = new System.Drawing.Point(8, 160);
			this.txtGDayOfWeek.MaxLength = 0;
			this.txtGDayOfWeek.Name = "txtGDayOfWeek";
			this.txtGDayOfWeek.ReadOnly = true;
			this.txtGDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGDayOfWeek.Size = new System.Drawing.Size(185, 25);
			this.txtGDayOfWeek.TabIndex = 10;
			this.txtGDayOfWeek.Text = "Gregorian Day of Week";
			this.txtGDayOfWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGDayOfWeek.Click += new System.EventHandler(this.txtGDayOfWeek_Click);
			// 
			// txtMolad
			// 
			this.txtMolad.AcceptsReturn = true;
			this.txtMolad.AllowDrop = true;
			this.txtMolad.BackColor = System.Drawing.SystemColors.Window;
			this.txtMolad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtMolad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMolad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtMolad.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtMolad.Location = new System.Drawing.Point(8, 208);
			this.txtMolad.MaxLength = 0;
			this.txtMolad.Name = "txtMolad";
			this.txtMolad.ReadOnly = true;
			this.txtMolad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMolad.Size = new System.Drawing.Size(185, 25);
			this.txtMolad.TabIndex = 12;
			this.txtMolad.Text = "Molad of Tishri";
			this.txtMolad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMolad.Click += new System.EventHandler(this.txtMolad_Click);
			// 
			// txtHebrewFrame
			// 
			this.txtHebrewFrame.AcceptsReturn = true;
			this.txtHebrewFrame.AllowDrop = true;
			this.txtHebrewFrame.BackColor = System.Drawing.SystemColors.Window;
			this.txtHebrewFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHebrewFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHebrewFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHebrewFrame.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHebrewFrame.Location = new System.Drawing.Point(8, 112);
			this.txtHebrewFrame.MaxLength = 0;
			this.txtHebrewFrame.Name = "txtHebrewFrame";
			this.txtHebrewFrame.ReadOnly = true;
			this.txtHebrewFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHebrewFrame.Size = new System.Drawing.Size(185, 25);
			this.txtHebrewFrame.TabIndex = 9;
			this.txtHebrewFrame.Text = "Hebrew Frame";
			this.txtHebrewFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHebrewFrame.Click += new System.EventHandler(this.txtHebrewFrame_Click);
			// 
			// txtJulianFrame
			// 
			this.txtJulianFrame.AcceptsReturn = true;
			this.txtJulianFrame.AllowDrop = true;
			this.txtJulianFrame.BackColor = System.Drawing.SystemColors.Window;
			this.txtJulianFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJulianFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJulianFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJulianFrame.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJulianFrame.Location = new System.Drawing.Point(8, 136);
			this.txtJulianFrame.MaxLength = 0;
			this.txtJulianFrame.Name = "txtJulianFrame";
			this.txtJulianFrame.ReadOnly = true;
			this.txtJulianFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJulianFrame.Size = new System.Drawing.Size(185, 25);
			this.txtJulianFrame.TabIndex = 7;
			this.txtJulianFrame.Text = "Julian Day Frame";
			this.txtJulianFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJulianFrame.Click += new System.EventHandler(this.txtJulianFrame_Click);
			// 
			// txtGregorianFrame
			// 
			this.txtGregorianFrame.AcceptsReturn = true;
			this.txtGregorianFrame.AllowDrop = true;
			this.txtGregorianFrame.BackColor = System.Drawing.SystemColors.Window;
			this.txtGregorianFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtGregorianFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGregorianFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGregorianFrame.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGregorianFrame.Location = new System.Drawing.Point(8, 40);
			this.txtGregorianFrame.MaxLength = 0;
			this.txtGregorianFrame.Name = "txtGregorianFrame";
			this.txtGregorianFrame.ReadOnly = true;
			this.txtGregorianFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGregorianFrame.Size = new System.Drawing.Size(185, 25);
			this.txtGregorianFrame.TabIndex = 6;
			this.txtGregorianFrame.Text = "Gregorian Frame";
			this.txtGregorianFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGregorianFrame.Click += new System.EventHandler(this.txtGregorianFrame_Click);
			// 
			// txtConversionsMain
			// 
			this.txtConversionsMain.AcceptsReturn = true;
			this.txtConversionsMain.AllowDrop = true;
			this.txtConversionsMain.BackColor = System.Drawing.SystemColors.Window;
			this.txtConversionsMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtConversionsMain.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtConversionsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtConversionsMain.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtConversionsMain.Location = new System.Drawing.Point(8, 16);
			this.txtConversionsMain.MaxLength = 0;
			this.txtConversionsMain.Name = "txtConversionsMain";
			this.txtConversionsMain.ReadOnly = true;
			this.txtConversionsMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtConversionsMain.Size = new System.Drawing.Size(185, 25);
			this.txtConversionsMain.TabIndex = 5;
			this.txtConversionsMain.Text = "Conversions Form";
			this.txtConversionsMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtConversionsMain.Click += new System.EventHandler(this.txtConversionsMain_Click);
			// 
			// fraRabbinical
			// 
			this.fraRabbinical.AllowDrop = true;
			this.fraRabbinical.BackColor = System.Drawing.SystemColors.Control;
			this.fraRabbinical.Controls.Add(this.txtRabFormTxt);
			this.fraRabbinical.Controls.Add(this.txtRabbinicalMain);
			this.fraRabbinical.Enabled = true;
			this.fraRabbinical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraRabbinical.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraRabbinical.Location = new System.Drawing.Point(8, 88);
			this.fraRabbinical.Name = "fraRabbinical";
			this.fraRabbinical.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraRabbinical.Size = new System.Drawing.Size(201, 73);
			this.fraRabbinical.TabIndex = 16;
			this.fraRabbinical.Text = "Rabbinical Calendar";
			this.fraRabbinical.Visible = true;
			// 
			// dlgColorColor
			// 
			this.dlgColorColor.Color = System.Drawing.Color.White;
			// 
			// txtRabFormTxt
			// 
			this.txtRabFormTxt.AcceptsReturn = true;
			this.txtRabFormTxt.AllowDrop = true;
			this.txtRabFormTxt.BackColor = System.Drawing.SystemColors.Window;
			this.txtRabFormTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtRabFormTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRabFormTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtRabFormTxt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRabFormTxt.Location = new System.Drawing.Point(8, 40);
			this.txtRabFormTxt.MaxLength = 0;
			this.txtRabFormTxt.Name = "txtRabFormTxt";
			this.txtRabFormTxt.ReadOnly = true;
			this.txtRabFormTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRabFormTxt.Size = new System.Drawing.Size(185, 25);
			this.txtRabFormTxt.TabIndex = 4;
			this.txtRabFormTxt.Text = "Rabbinical Text";
			this.txtRabFormTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRabFormTxt.Click += new System.EventHandler(this.txtRabFormTxt_Click);
			// 
			// txtRabbinicalMain
			// 
			this.txtRabbinicalMain.AcceptsReturn = true;
			this.txtRabbinicalMain.AllowDrop = true;
			this.txtRabbinicalMain.BackColor = System.Drawing.SystemColors.Window;
			this.txtRabbinicalMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtRabbinicalMain.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRabbinicalMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtRabbinicalMain.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRabbinicalMain.Location = new System.Drawing.Point(8, 16);
			this.txtRabbinicalMain.MaxLength = 0;
			this.txtRabbinicalMain.Name = "txtRabbinicalMain";
			this.txtRabbinicalMain.ReadOnly = true;
			this.txtRabbinicalMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRabbinicalMain.Size = new System.Drawing.Size(185, 25);
			this.txtRabbinicalMain.TabIndex = 3;
			this.txtRabbinicalMain.Text = "Rabbinical Form";
			this.txtRabbinicalMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRabbinicalMain.Click += new System.EventHandler(this.txtRabbinicalMain_Click);
			// 
			// fraMain
			// 
			this.fraMain.AllowDrop = true;
			this.fraMain.BackColor = System.Drawing.SystemColors.Control;
			this.fraMain.Controls.Add(this.txtMainFormTxt);
			this.fraMain.Controls.Add(this.txtMainForm);
			this.fraMain.Enabled = true;
			this.fraMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraMain.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraMain.Location = new System.Drawing.Point(8, 16);
			this.fraMain.Name = "fraMain";
			this.fraMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraMain.Size = new System.Drawing.Size(201, 73);
			this.fraMain.TabIndex = 0;
			this.fraMain.Text = "Main Program Form";
			this.fraMain.Visible = true;
			// 
			// txtMainFormTxt
			// 
			this.txtMainFormTxt.AcceptsReturn = true;
			this.txtMainFormTxt.AllowDrop = true;
			this.txtMainFormTxt.BackColor = System.Drawing.SystemColors.Window;
			this.txtMainFormTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtMainFormTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMainFormTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtMainFormTxt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtMainFormTxt.Location = new System.Drawing.Point(8, 40);
			this.txtMainFormTxt.MaxLength = 0;
			this.txtMainFormTxt.Name = "txtMainFormTxt";
			this.txtMainFormTxt.ReadOnly = true;
			this.txtMainFormTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMainFormTxt.Size = new System.Drawing.Size(185, 25);
			this.txtMainFormTxt.TabIndex = 2;
			this.txtMainFormTxt.Text = "Biblical Calendar Text";
			this.txtMainFormTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMainFormTxt.Click += new System.EventHandler(this.txtMainFormTxt_Click);
			// 
			// txtMainForm
			// 
			this.txtMainForm.AcceptsReturn = true;
			this.txtMainForm.AllowDrop = true;
			this.txtMainForm.BackColor = System.Drawing.SystemColors.Window;
			this.txtMainForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtMainForm.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtMainForm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtMainForm.Location = new System.Drawing.Point(8, 16);
			this.txtMainForm.MaxLength = 0;
			this.txtMainForm.Name = "txtMainForm";
			this.txtMainForm.ReadOnly = true;
			this.txtMainForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMainForm.Size = new System.Drawing.Size(185, 25);
			this.txtMainForm.TabIndex = 1;
			this.txtMainForm.Text = "Biblical Calendar Form";
			this.txtMainForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMainForm.Click += new System.EventHandler(this.txtMainForm_Click);
			// 
			// frmBackColor
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(217, 506);
			this.Controls.Add(this.chkStayOnTop);
			this.Controls.Add(this.fraAbout);
			this.Controls.Add(this.fraConversions);
			this.Controls.Add(this.fraRabbinical);
			this.Controls.Add(this.fraMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmBackColor.Icon");
			this.Location = new System.Drawing.Point(710, 29);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBackColor";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Background Colors";
			this.ToolTipMain.SetToolTip(this.chkStayOnTop, "Make this window stay on top of others");
			this.ToolTipMain.SetToolTip(this.txtAboutTxt, "About Text");
			this.ToolTipMain.SetToolTip(this.txtAboutForm, "About Form");
			this.ToolTipMain.SetToolTip(this.txtBDayOfWeek, "Biblical Day of Week");
			this.ToolTipMain.SetToolTip(this.txtBiblicalFrame, "Biblical Frame");
			this.ToolTipMain.SetToolTip(this.txtRules, "Postponement Rules");
			this.ToolTipMain.SetToolTip(this.txtGDayOfWeek, "Gregorian Day of Week");
			this.ToolTipMain.SetToolTip(this.txtMolad, "Molad of Tishri");
			this.ToolTipMain.SetToolTip(this.txtHebrewFrame, "Hebrew Frame");
			this.ToolTipMain.SetToolTip(this.txtJulianFrame, "Julian Frame");
			this.ToolTipMain.SetToolTip(this.txtGregorianFrame, "Gregorian Frame");
			this.ToolTipMain.SetToolTip(this.txtConversionsMain, "Conversions Form");
			this.ToolTipMain.SetToolTip(this.txtRabFormTxt, "Rabbinical Text");
			this.ToolTipMain.SetToolTip(this.txtRabbinicalMain, "Rabbinical Form");
			this.ToolTipMain.SetToolTip(this.txtMainFormTxt, "Biblical Calendar Text");
			this.ToolTipMain.SetToolTip(this.txtMainForm, "Biblical Calendar Form");
			this.Activated += new System.EventHandler(this.frmBackColor_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.fraAbout.ResumeLayout(false);
			this.fraConversions.ResumeLayout(false);
			this.fraRabbinical.ResumeLayout(false);
			this.fraMain.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
	}
}