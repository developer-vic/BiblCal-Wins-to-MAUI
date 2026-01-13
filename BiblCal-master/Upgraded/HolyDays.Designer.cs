
using System;

namespace BiblCal
{
	partial class frmHolyDays
	{

		#region "Upgrade Support "
		private static frmHolyDays m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmHolyDays DefInstance
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
		public static frmHolyDays CreateInstance()
		{
			frmHolyDays theInstance = new frmHolyDays();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "mnuSave", "mnuPrint", "mnuExit", "mnuFile", "mnuHolyDays", "mnuLocalMoons", "mnuSunset", "mnuTimes", "mnuGolgotha", "mnuJordan", "mnuFlood", "mnuCreation", "mnuModule", "mnuConversions", "mnuHebrew", "mnuEaster", "mnuNonScriptural", "mnuDocumentation", "mnuColors", "mnuAbout", "mnuHelp", "MainMenu1", "cmdCreation", "cmdJordan", "cmdGolgotha", "txtVerification", "txtWorking", "cboLocation", "chkGregYear", "cmdTimes", "cmdSunset", "txtYear2", "cmdFlood", "txtLonDir", "txtLatDir", "cmdLocMon", "txtLongMin", "txtLongDeg", "txtGMT", "txtLatMin", "txtLatDeg", "cmdMonths", "chkEJW", "txtOut", "txtYear", "cmdHolyDays", "lblChange", "lblLocation", "lblGMT", "lblLong", "lblLat", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ToolStripMenuItem mnuSave;
		public System.Windows.Forms.ToolStripMenuItem mnuPrint;
		public System.Windows.Forms.ToolStripMenuItem mnuExit;
		public System.Windows.Forms.ToolStripMenuItem mnuFile;
		public System.Windows.Forms.ToolStripMenuItem mnuHolyDays;
		public System.Windows.Forms.ToolStripMenuItem mnuLocalMoons;
		public System.Windows.Forms.ToolStripMenuItem mnuSunset;
		public System.Windows.Forms.ToolStripMenuItem mnuTimes;
		public System.Windows.Forms.ToolStripMenuItem mnuGolgotha;
		public System.Windows.Forms.ToolStripMenuItem mnuJordan;
		public System.Windows.Forms.ToolStripMenuItem mnuFlood;
		public System.Windows.Forms.ToolStripMenuItem mnuCreation;
		public System.Windows.Forms.ToolStripMenuItem mnuModule;
		public System.Windows.Forms.ToolStripMenuItem mnuConversions;
		public System.Windows.Forms.ToolStripMenuItem mnuHebrew;
		public System.Windows.Forms.ToolStripMenuItem mnuEaster;
		public System.Windows.Forms.ToolStripMenuItem mnuNonScriptural;
		public System.Windows.Forms.ToolStripMenuItem mnuDocumentation;
		public System.Windows.Forms.ToolStripMenuItem mnuColors;
		public System.Windows.Forms.ToolStripMenuItem mnuAbout;
		public System.Windows.Forms.ToolStripMenuItem mnuHelp;
		public System.Windows.Forms.MenuStrip MainMenu1;
		public System.Windows.Forms.Button cmdCreation;
		public System.Windows.Forms.Button cmdJordan;
		public System.Windows.Forms.Button cmdGolgotha;
		public System.Windows.Forms.TextBox txtVerification;
		public System.Windows.Forms.TextBox txtWorking;
		public System.Windows.Forms.ComboBox cboLocation;
		public System.Windows.Forms.CheckBox chkGregYear;
		public System.Windows.Forms.Button cmdTimes;
		public System.Windows.Forms.Button cmdSunset;
		public System.Windows.Forms.TextBox txtYear2;
		public System.Windows.Forms.Button cmdFlood;
		public System.Windows.Forms.TextBox txtLonDir;
		public System.Windows.Forms.TextBox txtLatDir;
		public System.Windows.Forms.Button cmdLocMon;
		public System.Windows.Forms.TextBox txtLongMin;
		public System.Windows.Forms.TextBox txtLongDeg;
		public System.Windows.Forms.TextBox txtGMT;
		public System.Windows.Forms.TextBox txtLatMin;
		public System.Windows.Forms.TextBox txtLatDeg;
		public System.Windows.Forms.Button cmdMonths;
		public System.Windows.Forms.CheckBox chkEJW;
		public System.Windows.Forms.TextBox txtOut;
		public System.Windows.Forms.TextBox txtYear;
		public System.Windows.Forms.Button cmdHolyDays;
		public System.Windows.Forms.Label lblChange;
		public System.Windows.Forms.Label lblLocation;
		public System.Windows.Forms.Label lblGMT;
		public System.Windows.Forms.Label lblLong;
		public System.Windows.Forms.Label lblLat;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHolyDays));
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.cmdCreation = new System.Windows.Forms.Button();
            this.cmdJordan = new System.Windows.Forms.Button();
            this.cmdGolgotha = new System.Windows.Forms.Button();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.chkGregYear = new System.Windows.Forms.CheckBox();
            this.cmdTimes = new System.Windows.Forms.Button();
            this.cmdSunset = new System.Windows.Forms.Button();
            this.txtYear2 = new System.Windows.Forms.TextBox();
            this.cmdFlood = new System.Windows.Forms.Button();
            this.txtLonDir = new System.Windows.Forms.TextBox();
            this.txtLatDir = new System.Windows.Forms.TextBox();
            this.cmdLocMon = new System.Windows.Forms.Button();
            this.txtLongMin = new System.Windows.Forms.TextBox();
            this.txtLongDeg = new System.Windows.Forms.TextBox();
            this.txtGMT = new System.Windows.Forms.TextBox();
            this.txtLatMin = new System.Windows.Forms.TextBox();
            this.txtLatDeg = new System.Windows.Forms.TextBox();
            this.cmdMonths = new System.Windows.Forms.Button();
            this.chkEJW = new System.Windows.Forms.CheckBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmdHolyDays = new System.Windows.Forms.Button();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHolyDays = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocalMoons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSunset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGolgotha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJordan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlood = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConversions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNonScriptural = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHebrew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVerification = new System.Windows.Forms.TextBox();
            this.txtWorking = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGMT = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
            this.MainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandButtonHelper1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCreation
            // 
            this.cmdCreation.AllowDrop = true;
            this.cmdCreation.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdCreation, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdCreation, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdCreation, null);
            this.cmdCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCreation.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreation.Image")));
            this.cmdCreation.Location = new System.Drawing.Point(160, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdCreation, System.Drawing.Color.Silver);
            this.cmdCreation.Name = "cmdCreation";
            this.cmdCreation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCreation.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdCreation, 1);
            this.cmdCreation.TabIndex = 6;
            this.cmdCreation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdCreation, "Calculate possible date of Creation");
            this.cmdCreation.UseVisualStyleBackColor = false;
            this.cmdCreation.Visible = false;
            this.cmdCreation.Click += new System.EventHandler(this.cmdCreation_Click);
            // 
            // cmdJordan
            // 
            this.cmdJordan.AllowDrop = true;
            this.cmdJordan.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdJordan, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdJordan, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdJordan, null);
            this.cmdJordan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJordan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdJordan.Image = ((System.Drawing.Image)(resources.GetObject("cmdJordan.Image")));
            this.cmdJordan.Location = new System.Drawing.Point(160, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdJordan, System.Drawing.Color.Silver);
            this.cmdJordan.Name = "cmdJordan";
            this.cmdJordan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdJordan.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdJordan, 1);
            this.cmdJordan.TabIndex = 5;
            this.cmdJordan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdJordan, "Calculate possible date of Jordan crossing");
            this.cmdJordan.UseVisualStyleBackColor = false;
            this.cmdJordan.Visible = false;
            this.cmdJordan.Click += new System.EventHandler(this.cmdJordan_Click);
            // 
            // cmdGolgotha
            // 
            this.cmdGolgotha.AllowDrop = true;
            this.cmdGolgotha.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdGolgotha, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdGolgotha, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdGolgotha, null);
            this.cmdGolgotha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGolgotha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGolgotha.Image = ((System.Drawing.Image)(resources.GetObject("cmdGolgotha.Image")));
            this.cmdGolgotha.Location = new System.Drawing.Point(160, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdGolgotha, System.Drawing.Color.Silver);
            this.cmdGolgotha.Name = "cmdGolgotha";
            this.cmdGolgotha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGolgotha.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdGolgotha, 1);
            this.cmdGolgotha.TabIndex = 4;
            this.cmdGolgotha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdGolgotha, "Calculate possible date of Crucifixion");
            this.cmdGolgotha.UseVisualStyleBackColor = false;
            this.cmdGolgotha.Visible = false;
            this.cmdGolgotha.Click += new System.EventHandler(this.cmdGolgotha_Click);
            // 
            // cboLocation
            // 
            this.cboLocation.AllowDrop = true;
            this.cboLocation.BackColor = System.Drawing.SystemColors.Window;
            this.cboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboLocation.Location = new System.Drawing.Point(136, 32);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboLocation.Size = new System.Drawing.Size(257, 21);
            this.cboLocation.Sorted = true;
            this.cboLocation.TabIndex = 7;
            this.cboLocation.Text = "cboLocation";
            this.ToolTipMain.SetToolTip(this.cboLocation, "To edit, add or delete a location (Press ENTER after the  location name)");
            this.cboLocation.Visible = false;
            this.cboLocation.SelectedIndexChanged += new System.EventHandler(this.cboLocation_SelectedIndexChanged);
            this.cboLocation.TextChanged += new System.EventHandler(this.cboLocation_TextChanged);
            this.cboLocation.Enter += new System.EventHandler(this.cboLocation_Enter);
            this.cboLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLocation_KeyPress);
            // 
            // chkGregYear
            // 
            this.chkGregYear.AllowDrop = true;
            this.chkGregYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chkGregYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkGregYear.Location = new System.Drawing.Point(16, 72);
            this.chkGregYear.Name = "chkGregYear";
            this.chkGregYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkGregYear.Size = new System.Drawing.Size(386, 17);
            this.chkGregYear.TabIndex = 20;
            this.chkGregYear.Text = "Check if you want to start calculations on the first of the Gregorian Year.";
            this.ToolTipMain.SetToolTip(this.chkGregYear, "Changes start from 1st month of the Biblical Calendar to 1st of Gregorian Calenda" +
        "r.");
            this.chkGregYear.UseVisualStyleBackColor = false;
            this.chkGregYear.Visible = false;
            this.chkGregYear.CheckStateChanged += new System.EventHandler(this.chkGregYear_CheckStateChanged);
            this.chkGregYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkGregYear_KeyPress);
            // 
            // cmdTimes
            // 
            this.cmdTimes.AllowDrop = true;
            this.cmdTimes.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdTimes, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdTimes, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdTimes, null);
            this.cmdTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTimes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdTimes.Image = ((System.Drawing.Image)(resources.GetObject("cmdTimes.Image")));
            this.cmdTimes.Location = new System.Drawing.Point(88, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdTimes, System.Drawing.Color.Silver);
            this.cmdTimes.Name = "cmdTimes";
            this.cmdTimes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdTimes.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdTimes, 1);
            this.cmdTimes.TabIndex = 3;
            this.cmdTimes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdTimes, "Calculates local Sun/Moon data for the location selected.");
            this.cmdTimes.UseVisualStyleBackColor = false;
            this.cmdTimes.Visible = false;
            this.cmdTimes.Click += new System.EventHandler(this.cmdTimes_Click);
            // 
            // cmdSunset
            // 
            this.cmdSunset.AllowDrop = true;
            this.cmdSunset.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdSunset, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdSunset, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdSunset, null);
            this.cmdSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSunset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSunset.Image = ((System.Drawing.Image)(resources.GetObject("cmdSunset.Image")));
            this.cmdSunset.Location = new System.Drawing.Point(88, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdSunset, System.Drawing.Color.Silver);
            this.cmdSunset.Name = "cmdSunset";
            this.cmdSunset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSunset.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdSunset, 1);
            this.cmdSunset.TabIndex = 11;
            this.cmdSunset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdSunset, "Calculates the local sunsets for the current year at the selected location.");
            this.cmdSunset.UseVisualStyleBackColor = false;
            this.cmdSunset.Visible = false;
            this.cmdSunset.Click += new System.EventHandler(this.cmdSunset_Click);
            // 
            // txtYear2
            // 
            this.txtYear2.AcceptsReturn = true;
            this.txtYear2.AllowDrop = true;
            this.txtYear2.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYear2.Location = new System.Drawing.Point(88, 32);
            this.txtYear2.MaxLength = 0;
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear2.Size = new System.Drawing.Size(63, 26);
            this.txtYear2.TabIndex = 2;
            this.txtYear2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtYear2, "Second Year for Flood Table should be later than the year to the left.");
            this.txtYear2.Visible = false;
            this.txtYear2.Enter += new System.EventHandler(this.txtYear2_Enter);
            this.txtYear2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear2_KeyDown);
            this.txtYear2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear2_KeyPress);
            // 
            // cmdFlood
            // 
            this.cmdFlood.AllowDrop = true;
            this.cmdFlood.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdFlood, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdFlood, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdFlood, null);
            this.cmdFlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFlood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFlood.Image = ((System.Drawing.Image)(resources.GetObject("cmdFlood.Image")));
            this.cmdFlood.Location = new System.Drawing.Point(160, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdFlood, System.Drawing.Color.Silver);
            this.cmdFlood.Name = "cmdFlood";
            this.cmdFlood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdFlood.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdFlood, 1);
            this.cmdFlood.TabIndex = 10;
            this.cmdFlood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdFlood, "Calculates number of days between the 17th of the second month and the 17th of th" +
        "e seventh month.");
            this.cmdFlood.UseVisualStyleBackColor = false;
            this.cmdFlood.Visible = false;
            this.cmdFlood.Click += new System.EventHandler(this.cmdFlood_Click);
            // 
            // txtLonDir
            // 
            this.txtLonDir.AcceptsReturn = true;
            this.txtLonDir.AllowDrop = true;
            this.txtLonDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtLonDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLonDir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLonDir.Location = new System.Drawing.Point(568, 32);
            this.txtLonDir.MaxLength = 1;
            this.txtLonDir.Name = "txtLonDir";
            this.txtLonDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLonDir.Size = new System.Drawing.Size(25, 20);
            this.txtLonDir.TabIndex = 18;
            this.txtLonDir.Text = "E";
            this.txtLonDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLonDir, "(E)ast or (W)est");
            this.txtLonDir.Visible = false;
            this.txtLonDir.TextChanged += new System.EventHandler(this.txtLonDir_TextChanged);
            this.txtLonDir.Enter += new System.EventHandler(this.txtLonDir_Enter);
            this.txtLonDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLonDir_KeyPress);
            // 
            // txtLatDir
            // 
            this.txtLatDir.AcceptsReturn = true;
            this.txtLatDir.AllowDrop = true;
            this.txtLatDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtLatDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatDir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLatDir.Location = new System.Drawing.Point(464, 32);
            this.txtLatDir.MaxLength = 1;
            this.txtLatDir.Name = "txtLatDir";
            this.txtLatDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLatDir.Size = new System.Drawing.Size(25, 20);
            this.txtLatDir.TabIndex = 15;
            this.txtLatDir.Text = "N";
            this.txtLatDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLatDir, "(N)orth or (S)outh");
            this.txtLatDir.Visible = false;
            this.txtLatDir.TextChanged += new System.EventHandler(this.txtLatDir_TextChanged);
            this.txtLatDir.Enter += new System.EventHandler(this.txtLatDir_Enter);
            this.txtLatDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatDir_KeyPress);
            // 
            // cmdLocMon
            // 
            this.cmdLocMon.AllowDrop = true;
            this.cmdLocMon.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdLocMon, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdLocMon, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdLocMon, null);
            this.cmdLocMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLocMon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLocMon.Image = ((System.Drawing.Image)(resources.GetObject("cmdLocMon.Image")));
            this.cmdLocMon.Location = new System.Drawing.Point(88, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdLocMon, System.Drawing.Color.Silver);
            this.cmdLocMon.Name = "cmdLocMon";
            this.cmdLocMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLocMon.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdLocMon, 1);
            this.cmdLocMon.TabIndex = 12;
            this.cmdLocMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdLocMon, "Calculates the Local New Moons for the current year at the Longitude and Latitude" +
        " you supply.");
            this.cmdLocMon.UseVisualStyleBackColor = false;
            this.cmdLocMon.Visible = false;
            this.cmdLocMon.Click += new System.EventHandler(this.cmdLocMon_Click);
            // 
            // txtLongMin
            // 
            this.txtLongMin.AcceptsReturn = true;
            this.txtLongMin.AllowDrop = true;
            this.txtLongMin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLongMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLongMin.Location = new System.Drawing.Point(544, 32);
            this.txtLongMin.MaxLength = 2;
            this.txtLongMin.Name = "txtLongMin";
            this.txtLongMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLongMin.Size = new System.Drawing.Size(25, 20);
            this.txtLongMin.TabIndex = 17;
            this.txtLongMin.Text = "13";
            this.txtLongMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLongMin, "Longitude Minutes");
            this.txtLongMin.Visible = false;
            this.txtLongMin.TextChanged += new System.EventHandler(this.txtLongMin_TextChanged);
            this.txtLongMin.Enter += new System.EventHandler(this.txtLongMin_Enter);
            this.txtLongMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongMin_KeyPress);
            this.txtLongMin.Leave += new System.EventHandler(this.txtLongMin_Leave);
            // 
            // txtLongDeg
            // 
            this.txtLongDeg.AcceptsReturn = true;
            this.txtLongDeg.AllowDrop = true;
            this.txtLongDeg.BackColor = System.Drawing.SystemColors.Window;
            this.txtLongDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLongDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLongDeg.Location = new System.Drawing.Point(512, 32);
            this.txtLongDeg.MaxLength = 3;
            this.txtLongDeg.Name = "txtLongDeg";
            this.txtLongDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLongDeg.Size = new System.Drawing.Size(33, 20);
            this.txtLongDeg.TabIndex = 16;
            this.txtLongDeg.Text = "35";
            this.txtLongDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLongDeg, "Longitude Degrees");
            this.txtLongDeg.Visible = false;
            this.txtLongDeg.TextChanged += new System.EventHandler(this.txtLongDeg_TextChanged);
            this.txtLongDeg.Enter += new System.EventHandler(this.txtLongDeg_Enter);
            this.txtLongDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongDeg_KeyPress);
            this.txtLongDeg.Leave += new System.EventHandler(this.txtLongDeg_Leave);
            // 
            // txtGMT
            // 
            this.txtGMT.AcceptsReturn = true;
            this.txtGMT.AllowDrop = true;
            this.txtGMT.BackColor = System.Drawing.SystemColors.Window;
            this.txtGMT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGMT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGMT.Location = new System.Drawing.Point(608, 32);
            this.txtGMT.MaxLength = 5;
            this.txtGMT.Name = "txtGMT";
            this.txtGMT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGMT.Size = new System.Drawing.Size(33, 20);
            this.txtGMT.TabIndex = 19;
            this.txtGMT.Text = "2";
            this.txtGMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtGMT, "Hour offset from UTC/GMT");
            this.txtGMT.Visible = false;
            this.txtGMT.TextChanged += new System.EventHandler(this.txtGMT_TextChanged);
            this.txtGMT.Enter += new System.EventHandler(this.txtGMT_Enter);
            this.txtGMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGMT_KeyPress);
            // 
            // txtLatMin
            // 
            this.txtLatMin.AcceptsReturn = true;
            this.txtLatMin.AllowDrop = true;
            this.txtLatMin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLatMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLatMin.Location = new System.Drawing.Point(440, 32);
            this.txtLatMin.MaxLength = 2;
            this.txtLatMin.Name = "txtLatMin";
            this.txtLatMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLatMin.Size = new System.Drawing.Size(25, 20);
            this.txtLatMin.TabIndex = 14;
            this.txtLatMin.Text = "47";
            this.txtLatMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLatMin, "Latitude Minutes");
            this.txtLatMin.Visible = false;
            this.txtLatMin.TextChanged += new System.EventHandler(this.txtLatMin_TextChanged);
            this.txtLatMin.Enter += new System.EventHandler(this.txtLatMin_Enter);
            this.txtLatMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatMin_KeyPress);
            this.txtLatMin.Leave += new System.EventHandler(this.txtLatMin_Leave);
            // 
            // txtLatDeg
            // 
            this.txtLatDeg.AcceptsReturn = true;
            this.txtLatDeg.AllowDrop = true;
            this.txtLatDeg.BackColor = System.Drawing.SystemColors.Window;
            this.txtLatDeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLatDeg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLatDeg.Location = new System.Drawing.Point(408, 32);
            this.txtLatDeg.MaxLength = 2;
            this.txtLatDeg.Name = "txtLatDeg";
            this.txtLatDeg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLatDeg.Size = new System.Drawing.Size(33, 20);
            this.txtLatDeg.TabIndex = 13;
            this.txtLatDeg.Text = "31";
            this.txtLatDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtLatDeg, "Latitude Degrees (0 to 60)");
            this.txtLatDeg.Visible = false;
            this.txtLatDeg.TextChanged += new System.EventHandler(this.txtLatDeg_TextChanged);
            this.txtLatDeg.Enter += new System.EventHandler(this.txtLatDeg_Enter);
            this.txtLatDeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatDeg_KeyPress);
            this.txtLatDeg.Leave += new System.EventHandler(this.txtLatDeg_Leave);
            // 
            // cmdMonths
            // 
            this.cmdMonths.AllowDrop = true;
            this.cmdMonths.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdMonths, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdMonths, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdMonths, null);
            this.cmdMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMonths.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdMonths.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonths.Image")));
            this.cmdMonths.Location = new System.Drawing.Point(128, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdMonths, System.Drawing.Color.Silver);
            this.cmdMonths.Name = "cmdMonths";
            this.cmdMonths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdMonths.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdMonths, 1);
            this.cmdMonths.TabIndex = 8;
            this.cmdMonths.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdMonths, "Calculate New Moons");
            this.cmdMonths.UseVisualStyleBackColor = false;
            this.cmdMonths.Click += new System.EventHandler(this.cmdMonths_Click);
            // 
            // chkEJW
            // 
            this.chkEJW.AllowDrop = true;
            this.chkEJW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chkEJW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEJW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEJW.Location = new System.Drawing.Point(376, 32);
            this.chkEJW.Name = "chkEJW";
            this.chkEJW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEJW.Size = new System.Drawing.Size(441, 17);
            this.chkEJW.TabIndex = 9;
            this.chkEJW.Text = "East of Israel and west of the International Date Line?";
            this.ToolTipMain.SetToolTip(this.chkEJW, "Check this box to adjust dates  for the region east of Israel and west of the Int" +
        "ernational Date Line.");
            this.chkEJW.UseVisualStyleBackColor = false;
            this.chkEJW.CheckStateChanged += new System.EventHandler(this.CHKEJW_CheckStateChanged);
            this.chkEJW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CHKEJW_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.AcceptsReturn = true;
            this.txtYear.AllowDrop = true;
            this.txtYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYear.Location = new System.Drawing.Point(16, 32);
            this.txtYear.MaxLength = 5;
            this.txtYear.Name = "txtYear";
            this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYear.Size = new System.Drawing.Size(63, 26);
            this.txtYear.TabIndex = 0;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipMain.SetToolTip(this.txtYear, "Year to compute (Range -4004 to 9999)");
            this.txtYear.Enter += new System.EventHandler(this.txtYear_Enter);
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // cmdHolyDays
            // 
            this.cmdHolyDays.AllowDrop = true;
            this.cmdHolyDays.BackColor = System.Drawing.SystemColors.Control;
            this.commandButtonHelper1.SetCorrectEventsBehavior(this.cmdHolyDays, true);
            this.commandButtonHelper1.SetDisabledPicture(this.cmdHolyDays, null);
            this.commandButtonHelper1.SetDownPicture(this.cmdHolyDays, null);
            this.cmdHolyDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHolyDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdHolyDays.Image = ((System.Drawing.Image)(resources.GetObject("cmdHolyDays.Image")));
            this.cmdHolyDays.Location = new System.Drawing.Point(88, 32);
            this.commandButtonHelper1.SetMaskColor(this.cmdHolyDays, System.Drawing.Color.Silver);
            this.cmdHolyDays.Name = "cmdHolyDays";
            this.cmdHolyDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdHolyDays.Size = new System.Drawing.Size(33, 33);
            this.commandButtonHelper1.SetStyle(this.cmdHolyDays, 1);
            this.cmdHolyDays.TabIndex = 1;
            this.cmdHolyDays.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolTipMain.SetToolTip(this.cmdHolyDays, "Calculate Holy Days");
            this.cmdHolyDays.UseVisualStyleBackColor = false;
            this.cmdHolyDays.Click += new System.EventHandler(this.cmdHolyDays_Click);
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuModule,
            this.mnuConversions,
            this.mnuNonScriptural,
            this.mnuHelp});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(825, 24);
            this.MainMenu1.TabIndex = 29;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuPrint,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(58, 20);
            this.mnuFile.Text = "     &File  ";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(140, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(140, 22);
            this.mnuPrint.Text = "&Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(140, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuModule
            // 
            this.mnuModule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHolyDays,
            this.mnuLocalMoons,
            this.mnuSunset,
            this.mnuTimes,
            this.mnuGolgotha,
            this.mnuJordan,
            this.mnuFlood,
            this.mnuCreation});
            this.mnuModule.Name = "mnuModule";
            this.mnuModule.Size = new System.Drawing.Size(53, 20);
            this.mnuModule.Text = "&Mode ";
            // 
            // mnuHolyDays
            // 
            this.mnuHolyDays.Name = "mnuHolyDays";
            this.mnuHolyDays.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuHolyDays.Size = new System.Drawing.Size(196, 22);
            this.mnuHolyDays.Text = "&Holy Days";
            this.mnuHolyDays.Click += new System.EventHandler(this.mnuHolyDays_Click);
            // 
            // mnuLocalMoons
            // 
            this.mnuLocalMoons.Name = "mnuLocalMoons";
            this.mnuLocalMoons.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuLocalMoons.Size = new System.Drawing.Size(196, 22);
            this.mnuLocalMoons.Text = "&Local Moons";
            this.mnuLocalMoons.Click += new System.EventHandler(this.mnuLocalMoons_Click);
            // 
            // mnuSunset
            // 
            this.mnuSunset.Name = "mnuSunset";
            this.mnuSunset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSunset.Size = new System.Drawing.Size(196, 22);
            this.mnuSunset.Text = "&Sunsets";
            this.mnuSunset.Click += new System.EventHandler(this.mnuSunset_Click);
            // 
            // mnuTimes
            // 
            this.mnuTimes.Name = "mnuTimes";
            this.mnuTimes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuTimes.Size = new System.Drawing.Size(196, 22);
            this.mnuTimes.Text = "&Times";
            this.mnuTimes.Click += new System.EventHandler(this.mnuTimes_Click);
            // 
            // mnuGolgotha
            // 
            this.mnuGolgotha.Name = "mnuGolgotha";
            this.mnuGolgotha.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuGolgotha.Size = new System.Drawing.Size(196, 22);
            this.mnuGolgotha.Text = "&Golgotha";
            this.mnuGolgotha.Click += new System.EventHandler(this.mnuGolgotha_Click);
            // 
            // mnuJordan
            // 
            this.mnuJordan.Name = "mnuJordan";
            this.mnuJordan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.mnuJordan.Size = new System.Drawing.Size(196, 22);
            this.mnuJordan.Text = "&Jordan Crossing";
            this.mnuJordan.Click += new System.EventHandler(this.mnuJordan_Click);
            // 
            // mnuFlood
            // 
            this.mnuFlood.Name = "mnuFlood";
            this.mnuFlood.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFlood.Size = new System.Drawing.Size(196, 22);
            this.mnuFlood.Text = "&Flood";
            this.mnuFlood.Click += new System.EventHandler(this.mnuFlood_Click);
            // 
            // mnuCreation
            // 
            this.mnuCreation.Name = "mnuCreation";
            this.mnuCreation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCreation.Size = new System.Drawing.Size(196, 22);
            this.mnuCreation.Text = "C&reation";
            this.mnuCreation.Click += new System.EventHandler(this.mnuCreation_Click);
            // 
            // mnuConversions
            // 
            this.mnuConversions.Name = "mnuConversions";
            this.mnuConversions.Size = new System.Drawing.Size(84, 20);
            this.mnuConversions.Text = "&Conversions";
            this.mnuConversions.Click += new System.EventHandler(this.mnuConversions_Click);
            // 
            // mnuNonScriptural
            // 
            this.mnuNonScriptural.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHebrew,
            this.mnuEaster});
            this.mnuNonScriptural.Name = "mnuNonScriptural";
            this.mnuNonScriptural.Size = new System.Drawing.Size(97, 20);
            this.mnuNonScriptural.Text = "&Non-Scriptural";
            // 
            // mnuHebrew
            // 
            this.mnuHebrew.Name = "mnuHebrew";
            this.mnuHebrew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuHebrew.Size = new System.Drawing.Size(170, 22);
            this.mnuHebrew.Text = "&Rabbinical";
            this.mnuHebrew.Click += new System.EventHandler(this.mnuHebrew_Click);
            // 
            // mnuEaster
            // 
            this.mnuEaster.Name = "mnuEaster";
            this.mnuEaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEaster.Size = new System.Drawing.Size(170, 22);
            this.mnuEaster.Text = "&Easter";
            this.mnuEaster.Click += new System.EventHandler(this.mnuEaster_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDocumentation,
            this.mnuColors,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuDocumentation
            // 
            this.mnuDocumentation.Name = "mnuDocumentation";
            this.mnuDocumentation.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuDocumentation.Size = new System.Drawing.Size(216, 22);
            this.mnuDocumentation.Text = "&Documentation";
            this.mnuDocumentation.Click += new System.EventHandler(this.mnuDocumentation_Click);
            // 
            // mnuColors
            // 
            this.mnuColors.Name = "mnuColors";
            this.mnuColors.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuColors.Size = new System.Drawing.Size(216, 22);
            this.mnuColors.Text = "&Background Colors";
            this.mnuColors.Click += new System.EventHandler(this.mnuColors_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAbout.Size = new System.Drawing.Size(216, 22);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // txtVerification
            // 
            this.txtVerification.AcceptsReturn = true;
            this.txtVerification.AllowDrop = true;
            this.txtVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtVerification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerification.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVerification.Location = new System.Drawing.Point(816, 616);
            this.txtVerification.MaxLength = 0;
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.ReadOnly = true;
            this.txtVerification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVerification.Size = new System.Drawing.Size(10, 13);
            this.txtVerification.TabIndex = 28;
            this.txtVerification.TabStop = false;
            this.txtVerification.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVerification.Visible = false;
            this.txtVerification.Click += new System.EventHandler(this.txtVerification_Click);
            // 
            // txtWorking
            // 
            this.txtWorking.AcceptsReturn = true;
            this.txtWorking.AllowDrop = true;
            this.txtWorking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtWorking.Location = new System.Drawing.Point(264, 176);
            this.txtWorking.MaxLength = 0;
            this.txtWorking.Name = "txtWorking";
            this.txtWorking.ReadOnly = true;
            this.txtWorking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWorking.Size = new System.Drawing.Size(233, 44);
            this.txtWorking.TabIndex = 27;
            this.txtWorking.Text = "WORKING";
            this.txtWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWorking.Visible = false;
            // 
            // txtOut
            // 
            this.txtOut.AcceptsReturn = true;
            this.txtOut.AllowDrop = true;
            this.txtOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOut.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOut.Location = new System.Drawing.Point(8, 104);
            this.txtOut.MaxLength = 0;
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(809, 513);
            this.txtOut.TabIndex = 21;
            // 
            // lblChange
            // 
            this.lblChange.AllowDrop = true;
            this.lblChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChange.Location = new System.Drawing.Point(376, 56);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(17, 17);
            this.lblChange.TabIndex = 26;
            this.lblChange.Text = "*";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblChange.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AllowDrop = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLocation.Location = new System.Drawing.Point(176, 56);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLocation.Size = new System.Drawing.Size(161, 17);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLocation.Visible = false;
            // 
            // lblGMT
            // 
            this.lblGMT.AllowDrop = true;
            this.lblGMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblGMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGMT.Location = new System.Drawing.Point(608, 56);
            this.lblGMT.Name = "lblGMT";
            this.lblGMT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGMT.Size = new System.Drawing.Size(97, 17);
            this.lblGMT.TabIndex = 24;
            this.lblGMT.Text = "UTC/GMT Offset";
            this.lblGMT.Visible = false;
            // 
            // lblLong
            // 
            this.lblLong.AllowDrop = true;
            this.lblLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLong.Location = new System.Drawing.Point(512, 56);
            this.lblLong.Name = "lblLong";
            this.lblLong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLong.Size = new System.Drawing.Size(73, 17);
            this.lblLong.TabIndex = 23;
            this.lblLong.Text = "Longitude";
            this.lblLong.Visible = false;
            // 
            // lblLat
            // 
            this.lblLat.AllowDrop = true;
            this.lblLat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLat.Location = new System.Drawing.Point(408, 56);
            this.lblLat.Name = "lblLat";
            this.lblLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLat.Size = new System.Drawing.Size(57, 17);
            this.lblLat.TabIndex = 22;
            this.lblLat.Text = "Latitude";
            this.lblLat.Visible = false;
            // 
            // frmHolyDays
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(825, 618);
            this.Controls.Add(this.cmdCreation);
            this.Controls.Add(this.cmdJordan);
            this.Controls.Add(this.cmdGolgotha);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.txtWorking);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.chkGregYear);
            this.Controls.Add(this.cmdTimes);
            this.Controls.Add(this.cmdSunset);
            this.Controls.Add(this.txtYear2);
            this.Controls.Add(this.cmdFlood);
            this.Controls.Add(this.txtLonDir);
            this.Controls.Add(this.txtLatDir);
            this.Controls.Add(this.cmdLocMon);
            this.Controls.Add(this.txtLongMin);
            this.Controls.Add(this.txtLongDeg);
            this.Controls.Add(this.txtGMT);
            this.Controls.Add(this.txtLatMin);
            this.Controls.Add(this.txtLatDeg);
            this.Controls.Add(this.cmdMonths);
            this.Controls.Add(this.chkEJW);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmdHolyDays);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblGMT);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.MainMenu1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(97, 82);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHolyDays";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculated Biblical Calendar - HOLY DAYS / NEW MOONS - www.chcpublications.net";
            this.Activated += new System.EventHandler(this.frmHolyDays_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandButtonHelper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
	}
}