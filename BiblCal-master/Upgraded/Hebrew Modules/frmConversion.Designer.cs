
namespace BiblCal
{
	partial class frmConversion
	{

		#region "Upgrade Support "
		private static frmConversion m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmConversion DefInstance
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
		public static frmConversion CreateInstance()
		{
			frmConversion theInstance = new frmConversion();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "lstJCMonth", "_picMoon_58", "_picMoon_57", "_picMoon_56", "_picMoon_55", "_picMoon_54", "_picMoon_53", "_picMoon_52", "_picMoon_51", "_picMoon_50", "_picMoon_49", "_picMoon_48", "_picMoon_47", "_picMoon_46", "_picMoon_45", "_picMoon_44", "_picMoon_43", "_picMoon_42", "_picMoon_41", "_picMoon_40", "_picMoon_39", "_picMoon_38", "_picMoon_37", "_picMoon_36", "_picMoon_35", "_picMoon_34", "_picMoon_33", "_picMoon_32", "_picMoon_31", "_picMoon_30", "_picMoon_29", "_picMoon_28", "_picMoon_27", "_picMoon_26", "_picMoon_25", "_picMoon_24", "_picMoon_23", "_picMoon_22", "_picMoon_21", "_picMoon_20", "_picMoon_19", "_picMoon_18", "_picMoon_17", "_picMoon_16", "_picMoon_15", "_picMoon_14", "_picMoon_13", "_picMoon_12", "_picMoon_11", "_picMoon_10", "_picMoon_9", "_picMoon_8", "_picMoon_7", "_picMoon_6", "_picMoon_5", "_picMoon_4", "_picMoon_3", "_picMoon_2", "_picMoon_1", "_picMoon_0", "fraMoon", "cmdJCCompute", "txtJCDay", "txtJCMonth", "txtJCYear", "fraJulianCal", "txtControl", "lstBMonth", "optDate4", "optDate3", "optDate2", "optDate1", "cmdCriteria", "cmdBCompute", "txtBDay", "txtBYear", "txtBMonth", "lblBDayOfWeek", "fraBiblical", "cmdJCompute", "txtJDCount", "fraJulian", "chkOnTop", "lstHMonth", "txtHMonth", "cmdHCompute", "txtHYear", "txtHDay", "lblHDay", "lblTabInd", "lblRules", "lblMolad1", "lblMolad", "lblHYearType", "fraHebrew", "lstGMonth", "txtGMonth", "cmdGCompute", "txtGYear", "txtGDay", "lblGDayOfWeek", "lblGYearType", "fraGregorian", "picMoon", "listBoxHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ListBox lstJCMonth;
		private System.Windows.Forms.PictureBox _picMoon_58;
		private System.Windows.Forms.PictureBox _picMoon_57;
		private System.Windows.Forms.PictureBox _picMoon_56;
		private System.Windows.Forms.PictureBox _picMoon_55;
		private System.Windows.Forms.PictureBox _picMoon_54;
		private System.Windows.Forms.PictureBox _picMoon_53;
		private System.Windows.Forms.PictureBox _picMoon_52;
		private System.Windows.Forms.PictureBox _picMoon_51;
		private System.Windows.Forms.PictureBox _picMoon_50;
		private System.Windows.Forms.PictureBox _picMoon_49;
		private System.Windows.Forms.PictureBox _picMoon_48;
		private System.Windows.Forms.PictureBox _picMoon_47;
		private System.Windows.Forms.PictureBox _picMoon_46;
		private System.Windows.Forms.PictureBox _picMoon_45;
		private System.Windows.Forms.PictureBox _picMoon_44;
		private System.Windows.Forms.PictureBox _picMoon_43;
		private System.Windows.Forms.PictureBox _picMoon_42;
		private System.Windows.Forms.PictureBox _picMoon_41;
		private System.Windows.Forms.PictureBox _picMoon_40;
		private System.Windows.Forms.PictureBox _picMoon_39;
		private System.Windows.Forms.PictureBox _picMoon_38;
		private System.Windows.Forms.PictureBox _picMoon_37;
		private System.Windows.Forms.PictureBox _picMoon_36;
		private System.Windows.Forms.PictureBox _picMoon_35;
		private System.Windows.Forms.PictureBox _picMoon_34;
		private System.Windows.Forms.PictureBox _picMoon_33;
		private System.Windows.Forms.PictureBox _picMoon_32;
		private System.Windows.Forms.PictureBox _picMoon_31;
		private System.Windows.Forms.PictureBox _picMoon_30;
		private System.Windows.Forms.PictureBox _picMoon_29;
		private System.Windows.Forms.PictureBox _picMoon_28;
		private System.Windows.Forms.PictureBox _picMoon_27;
		private System.Windows.Forms.PictureBox _picMoon_26;
		private System.Windows.Forms.PictureBox _picMoon_25;
		private System.Windows.Forms.PictureBox _picMoon_24;
		private System.Windows.Forms.PictureBox _picMoon_23;
		private System.Windows.Forms.PictureBox _picMoon_22;
		private System.Windows.Forms.PictureBox _picMoon_21;
		private System.Windows.Forms.PictureBox _picMoon_20;
		private System.Windows.Forms.PictureBox _picMoon_19;
		private System.Windows.Forms.PictureBox _picMoon_18;
		private System.Windows.Forms.PictureBox _picMoon_17;
		private System.Windows.Forms.PictureBox _picMoon_16;
		private System.Windows.Forms.PictureBox _picMoon_15;
		private System.Windows.Forms.PictureBox _picMoon_14;
		private System.Windows.Forms.PictureBox _picMoon_13;
		private System.Windows.Forms.PictureBox _picMoon_12;
		private System.Windows.Forms.PictureBox _picMoon_11;
		private System.Windows.Forms.PictureBox _picMoon_10;
		private System.Windows.Forms.PictureBox _picMoon_9;
		private System.Windows.Forms.PictureBox _picMoon_8;
		private System.Windows.Forms.PictureBox _picMoon_7;
		private System.Windows.Forms.PictureBox _picMoon_6;
		private System.Windows.Forms.PictureBox _picMoon_5;
		private System.Windows.Forms.PictureBox _picMoon_4;
		private System.Windows.Forms.PictureBox _picMoon_3;
		private System.Windows.Forms.PictureBox _picMoon_2;
		private System.Windows.Forms.PictureBox _picMoon_1;
		private System.Windows.Forms.PictureBox _picMoon_0;
		public System.Windows.Forms.GroupBox fraMoon;
		public System.Windows.Forms.Button cmdJCCompute;
		public System.Windows.Forms.TextBox txtJCDay;
		public System.Windows.Forms.TextBox txtJCMonth;
		public System.Windows.Forms.TextBox txtJCYear;
		public System.Windows.Forms.GroupBox fraJulianCal;
		public System.Windows.Forms.TextBox txtControl;
		public System.Windows.Forms.ListBox lstBMonth;
		public System.Windows.Forms.RadioButton optDate4;
		public System.Windows.Forms.RadioButton optDate3;
		public System.Windows.Forms.RadioButton optDate2;
		public System.Windows.Forms.RadioButton optDate1;
		public System.Windows.Forms.Button cmdCriteria;
		public System.Windows.Forms.Button cmdBCompute;
		public System.Windows.Forms.TextBox txtBDay;
		public System.Windows.Forms.TextBox txtBYear;
		public System.Windows.Forms.TextBox txtBMonth;
		public System.Windows.Forms.Label lblBDayOfWeek;
		public System.Windows.Forms.GroupBox fraBiblical;
		public System.Windows.Forms.Button cmdJCompute;
		public System.Windows.Forms.TextBox txtJDCount;
		public System.Windows.Forms.GroupBox fraJulian;
		public System.Windows.Forms.CheckBox chkOnTop;
		public System.Windows.Forms.ListBox lstHMonth;
		public System.Windows.Forms.TextBox txtHMonth;
		public System.Windows.Forms.Button cmdHCompute;
		public System.Windows.Forms.TextBox txtHYear;
		public System.Windows.Forms.TextBox txtHDay;
		public System.Windows.Forms.Label lblHDay;
		public System.Windows.Forms.Label lblTabInd;
		public System.Windows.Forms.Label lblRules;
		public System.Windows.Forms.Label lblMolad1;
		public System.Windows.Forms.Label lblMolad;
		public System.Windows.Forms.Label lblHYearType;
		public System.Windows.Forms.GroupBox fraHebrew;
		public System.Windows.Forms.ListBox lstGMonth;
		public System.Windows.Forms.TextBox txtGMonth;
		public System.Windows.Forms.Button cmdGCompute;
		public System.Windows.Forms.TextBox txtGYear;
		public System.Windows.Forms.TextBox txtGDay;
		public System.Windows.Forms.Label lblGDayOfWeek;
		public System.Windows.Forms.Label lblGYearType;
		public System.Windows.Forms.GroupBox fraGregorian;
		public System.Windows.Forms.PictureBox[] picMoon = new System.Windows.Forms.PictureBox[59];
		public UpgradeHelpers.Gui.ListBoxHelper listBoxHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversion));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.lstJCMonth = new System.Windows.Forms.ListBox();
			this.fraMoon = new System.Windows.Forms.GroupBox();
			this._picMoon_58 = new System.Windows.Forms.PictureBox();
			this._picMoon_57 = new System.Windows.Forms.PictureBox();
			this._picMoon_56 = new System.Windows.Forms.PictureBox();
			this._picMoon_55 = new System.Windows.Forms.PictureBox();
			this._picMoon_54 = new System.Windows.Forms.PictureBox();
			this._picMoon_53 = new System.Windows.Forms.PictureBox();
			this._picMoon_52 = new System.Windows.Forms.PictureBox();
			this._picMoon_51 = new System.Windows.Forms.PictureBox();
			this._picMoon_50 = new System.Windows.Forms.PictureBox();
			this._picMoon_49 = new System.Windows.Forms.PictureBox();
			this._picMoon_48 = new System.Windows.Forms.PictureBox();
			this._picMoon_47 = new System.Windows.Forms.PictureBox();
			this._picMoon_46 = new System.Windows.Forms.PictureBox();
			this._picMoon_45 = new System.Windows.Forms.PictureBox();
			this._picMoon_44 = new System.Windows.Forms.PictureBox();
			this._picMoon_43 = new System.Windows.Forms.PictureBox();
			this._picMoon_42 = new System.Windows.Forms.PictureBox();
			this._picMoon_41 = new System.Windows.Forms.PictureBox();
			this._picMoon_40 = new System.Windows.Forms.PictureBox();
			this._picMoon_39 = new System.Windows.Forms.PictureBox();
			this._picMoon_38 = new System.Windows.Forms.PictureBox();
			this._picMoon_37 = new System.Windows.Forms.PictureBox();
			this._picMoon_36 = new System.Windows.Forms.PictureBox();
			this._picMoon_35 = new System.Windows.Forms.PictureBox();
			this._picMoon_34 = new System.Windows.Forms.PictureBox();
			this._picMoon_33 = new System.Windows.Forms.PictureBox();
			this._picMoon_32 = new System.Windows.Forms.PictureBox();
			this._picMoon_31 = new System.Windows.Forms.PictureBox();
			this._picMoon_30 = new System.Windows.Forms.PictureBox();
			this._picMoon_29 = new System.Windows.Forms.PictureBox();
			this._picMoon_28 = new System.Windows.Forms.PictureBox();
			this._picMoon_27 = new System.Windows.Forms.PictureBox();
			this._picMoon_26 = new System.Windows.Forms.PictureBox();
			this._picMoon_25 = new System.Windows.Forms.PictureBox();
			this._picMoon_24 = new System.Windows.Forms.PictureBox();
			this._picMoon_23 = new System.Windows.Forms.PictureBox();
			this._picMoon_22 = new System.Windows.Forms.PictureBox();
			this._picMoon_21 = new System.Windows.Forms.PictureBox();
			this._picMoon_20 = new System.Windows.Forms.PictureBox();
			this._picMoon_19 = new System.Windows.Forms.PictureBox();
			this._picMoon_18 = new System.Windows.Forms.PictureBox();
			this._picMoon_17 = new System.Windows.Forms.PictureBox();
			this._picMoon_16 = new System.Windows.Forms.PictureBox();
			this._picMoon_15 = new System.Windows.Forms.PictureBox();
			this._picMoon_14 = new System.Windows.Forms.PictureBox();
			this._picMoon_13 = new System.Windows.Forms.PictureBox();
			this._picMoon_12 = new System.Windows.Forms.PictureBox();
			this._picMoon_11 = new System.Windows.Forms.PictureBox();
			this._picMoon_10 = new System.Windows.Forms.PictureBox();
			this._picMoon_9 = new System.Windows.Forms.PictureBox();
			this._picMoon_8 = new System.Windows.Forms.PictureBox();
			this._picMoon_7 = new System.Windows.Forms.PictureBox();
			this._picMoon_6 = new System.Windows.Forms.PictureBox();
			this._picMoon_5 = new System.Windows.Forms.PictureBox();
			this._picMoon_4 = new System.Windows.Forms.PictureBox();
			this._picMoon_3 = new System.Windows.Forms.PictureBox();
			this._picMoon_2 = new System.Windows.Forms.PictureBox();
			this._picMoon_1 = new System.Windows.Forms.PictureBox();
			this._picMoon_0 = new System.Windows.Forms.PictureBox();
			this.fraJulianCal = new System.Windows.Forms.GroupBox();
			this.cmdJCCompute = new System.Windows.Forms.Button();
			this.txtJCDay = new System.Windows.Forms.TextBox();
			this.txtJCMonth = new System.Windows.Forms.TextBox();
			this.txtJCYear = new System.Windows.Forms.TextBox();
			this.txtControl = new System.Windows.Forms.TextBox();
			this.fraBiblical = new System.Windows.Forms.GroupBox();
			this.lstBMonth = new System.Windows.Forms.ListBox();
			this.optDate4 = new System.Windows.Forms.RadioButton();
			this.optDate3 = new System.Windows.Forms.RadioButton();
			this.optDate2 = new System.Windows.Forms.RadioButton();
			this.optDate1 = new System.Windows.Forms.RadioButton();
			this.cmdCriteria = new System.Windows.Forms.Button();
			this.cmdBCompute = new System.Windows.Forms.Button();
			this.txtBDay = new System.Windows.Forms.TextBox();
			this.txtBYear = new System.Windows.Forms.TextBox();
			this.txtBMonth = new System.Windows.Forms.TextBox();
			this.lblBDayOfWeek = new System.Windows.Forms.Label();
			this.fraJulian = new System.Windows.Forms.GroupBox();
			this.cmdJCompute = new System.Windows.Forms.Button();
			this.txtJDCount = new System.Windows.Forms.TextBox();
			this.fraHebrew = new System.Windows.Forms.GroupBox();
			this.chkOnTop = new System.Windows.Forms.CheckBox();
			this.lstHMonth = new System.Windows.Forms.ListBox();
			this.txtHMonth = new System.Windows.Forms.TextBox();
			this.cmdHCompute = new System.Windows.Forms.Button();
			this.txtHYear = new System.Windows.Forms.TextBox();
			this.txtHDay = new System.Windows.Forms.TextBox();
			this.lblHDay = new System.Windows.Forms.Label();
			this.lblTabInd = new System.Windows.Forms.Label();
			this.lblRules = new System.Windows.Forms.Label();
			this.lblMolad1 = new System.Windows.Forms.Label();
			this.lblMolad = new System.Windows.Forms.Label();
			this.lblHYearType = new System.Windows.Forms.Label();
			this.fraGregorian = new System.Windows.Forms.GroupBox();
			this.lstGMonth = new System.Windows.Forms.ListBox();
			this.txtGMonth = new System.Windows.Forms.TextBox();
			this.cmdGCompute = new System.Windows.Forms.Button();
			this.txtGYear = new System.Windows.Forms.TextBox();
			this.txtGDay = new System.Windows.Forms.TextBox();
			this.lblGDayOfWeek = new System.Windows.Forms.Label();
			this.lblGYearType = new System.Windows.Forms.Label();
			this.fraMoon.SuspendLayout();
			this.fraJulianCal.SuspendLayout();
			this.fraBiblical.SuspendLayout();
			this.fraJulian.SuspendLayout();
			this.fraHebrew.SuspendLayout();
			this.fraGregorian.SuspendLayout();
			this.SuspendLayout();
			this.listBoxHelper1 = new UpgradeHelpers.Gui.ListBoxHelper(this.components);
			// 
			// lstJCMonth
			// 
			this.lstJCMonth.AllowDrop = true;
			this.lstJCMonth.BackColor = System.Drawing.SystemColors.Window;
			this.lstJCMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstJCMonth.CausesValidation = true;
			this.lstJCMonth.Enabled = true;
			this.lstJCMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstJCMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstJCMonth.IntegralHeight = true;
			this.lstJCMonth.Location = new System.Drawing.Point(224, 16);
			this.lstJCMonth.MultiColumn = false;
			this.lstJCMonth.Name = "lstJCMonth";
			this.lstJCMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lstJCMonth.Size = new System.Drawing.Size(89, 163);
			this.lstJCMonth.Sorted = false;
			this.lstJCMonth.TabIndex = 102;
			this.lstJCMonth.TabStop = true;
			this.lstJCMonth.Visible = true;
			this.lstJCMonth.SelectedIndexChanged += new System.EventHandler(this.lstJCMonth_SelectedIndexChanged);
			// 
			// fraMoon
			// 
			this.fraMoon.AllowDrop = true;
			this.fraMoon.BackColor = System.Drawing.Color.Black;
			this.fraMoon.Controls.Add(this._picMoon_58);
			this.fraMoon.Controls.Add(this._picMoon_57);
			this.fraMoon.Controls.Add(this._picMoon_56);
			this.fraMoon.Controls.Add(this._picMoon_55);
			this.fraMoon.Controls.Add(this._picMoon_54);
			this.fraMoon.Controls.Add(this._picMoon_53);
			this.fraMoon.Controls.Add(this._picMoon_52);
			this.fraMoon.Controls.Add(this._picMoon_51);
			this.fraMoon.Controls.Add(this._picMoon_50);
			this.fraMoon.Controls.Add(this._picMoon_49);
			this.fraMoon.Controls.Add(this._picMoon_48);
			this.fraMoon.Controls.Add(this._picMoon_47);
			this.fraMoon.Controls.Add(this._picMoon_46);
			this.fraMoon.Controls.Add(this._picMoon_45);
			this.fraMoon.Controls.Add(this._picMoon_44);
			this.fraMoon.Controls.Add(this._picMoon_43);
			this.fraMoon.Controls.Add(this._picMoon_42);
			this.fraMoon.Controls.Add(this._picMoon_41);
			this.fraMoon.Controls.Add(this._picMoon_40);
			this.fraMoon.Controls.Add(this._picMoon_39);
			this.fraMoon.Controls.Add(this._picMoon_38);
			this.fraMoon.Controls.Add(this._picMoon_37);
			this.fraMoon.Controls.Add(this._picMoon_36);
			this.fraMoon.Controls.Add(this._picMoon_35);
			this.fraMoon.Controls.Add(this._picMoon_34);
			this.fraMoon.Controls.Add(this._picMoon_33);
			this.fraMoon.Controls.Add(this._picMoon_32);
			this.fraMoon.Controls.Add(this._picMoon_31);
			this.fraMoon.Controls.Add(this._picMoon_30);
			this.fraMoon.Controls.Add(this._picMoon_29);
			this.fraMoon.Controls.Add(this._picMoon_28);
			this.fraMoon.Controls.Add(this._picMoon_27);
			this.fraMoon.Controls.Add(this._picMoon_26);
			this.fraMoon.Controls.Add(this._picMoon_25);
			this.fraMoon.Controls.Add(this._picMoon_24);
			this.fraMoon.Controls.Add(this._picMoon_23);
			this.fraMoon.Controls.Add(this._picMoon_22);
			this.fraMoon.Controls.Add(this._picMoon_21);
			this.fraMoon.Controls.Add(this._picMoon_20);
			this.fraMoon.Controls.Add(this._picMoon_19);
			this.fraMoon.Controls.Add(this._picMoon_18);
			this.fraMoon.Controls.Add(this._picMoon_17);
			this.fraMoon.Controls.Add(this._picMoon_16);
			this.fraMoon.Controls.Add(this._picMoon_15);
			this.fraMoon.Controls.Add(this._picMoon_14);
			this.fraMoon.Controls.Add(this._picMoon_13);
			this.fraMoon.Controls.Add(this._picMoon_12);
			this.fraMoon.Controls.Add(this._picMoon_11);
			this.fraMoon.Controls.Add(this._picMoon_10);
			this.fraMoon.Controls.Add(this._picMoon_9);
			this.fraMoon.Controls.Add(this._picMoon_8);
			this.fraMoon.Controls.Add(this._picMoon_7);
			this.fraMoon.Controls.Add(this._picMoon_6);
			this.fraMoon.Controls.Add(this._picMoon_5);
			this.fraMoon.Controls.Add(this._picMoon_4);
			this.fraMoon.Controls.Add(this._picMoon_3);
			this.fraMoon.Controls.Add(this._picMoon_2);
			this.fraMoon.Controls.Add(this._picMoon_1);
			this.fraMoon.Controls.Add(this._picMoon_0);
			this.fraMoon.Enabled = true;
			this.fraMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraMoon.ForeColor = System.Drawing.Color.FromArgb(128, 255, 255);
			this.fraMoon.Location = new System.Drawing.Point(208, 168);
			this.fraMoon.Name = "fraMoon";
			this.fraMoon.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraMoon.Size = new System.Drawing.Size(121, 121);
			this.fraMoon.TabIndex = 41;
			this.fraMoon.Text = "Moon";
			this.fraMoon.Visible = true;
			// 
			// _picMoon_58
			// 
			this._picMoon_58.AllowDrop = true;
			this._picMoon_58.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_58.CausesValidation = true;
			this._picMoon_58.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_58.Enabled = true;
			this._picMoon_58.Image = (System.Drawing.Image) resources.GetObject("_picMoon_58.Image");
			this._picMoon_58.Location = new System.Drawing.Point(8, 16);
			this._picMoon_58.Name = "_picMoon_58";
			this._picMoon_58.Size = new System.Drawing.Size(102, 102);
			this._picMoon_58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this._picMoon_58.TabIndex = 99;
			this._picMoon_58.TabStop = false;
			this._picMoon_58.Visible = false;
			// 
			// _picMoon_57
			// 
			this._picMoon_57.AllowDrop = true;
			this._picMoon_57.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_57.CausesValidation = true;
			this._picMoon_57.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_57.Enabled = true;
			this._picMoon_57.Image = (System.Drawing.Image) resources.GetObject("_picMoon_57.Image");
			this._picMoon_57.Location = new System.Drawing.Point(8, 16);
			this._picMoon_57.Name = "_picMoon_57";
			this._picMoon_57.Size = new System.Drawing.Size(102, 102);
			this._picMoon_57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_57.TabIndex = 98;
			this._picMoon_57.TabStop = false;
			this._picMoon_57.Visible = false;
			// 
			// _picMoon_56
			// 
			this._picMoon_56.AllowDrop = true;
			this._picMoon_56.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_56.CausesValidation = true;
			this._picMoon_56.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_56.Enabled = true;
			this._picMoon_56.Image = (System.Drawing.Image) resources.GetObject("_picMoon_56.Image");
			this._picMoon_56.Location = new System.Drawing.Point(8, 16);
			this._picMoon_56.Name = "_picMoon_56";
			this._picMoon_56.Size = new System.Drawing.Size(102, 102);
			this._picMoon_56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_56.TabIndex = 97;
			this._picMoon_56.TabStop = false;
			this._picMoon_56.Visible = false;
			// 
			// _picMoon_55
			// 
			this._picMoon_55.AllowDrop = true;
			this._picMoon_55.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_55.CausesValidation = true;
			this._picMoon_55.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_55.Enabled = true;
			this._picMoon_55.Image = (System.Drawing.Image) resources.GetObject("_picMoon_55.Image");
			this._picMoon_55.Location = new System.Drawing.Point(8, 16);
			this._picMoon_55.Name = "_picMoon_55";
			this._picMoon_55.Size = new System.Drawing.Size(102, 102);
			this._picMoon_55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_55.TabIndex = 96;
			this._picMoon_55.TabStop = false;
			this._picMoon_55.Visible = false;
			// 
			// _picMoon_54
			// 
			this._picMoon_54.AllowDrop = true;
			this._picMoon_54.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_54.CausesValidation = true;
			this._picMoon_54.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_54.Enabled = true;
			this._picMoon_54.Image = (System.Drawing.Image) resources.GetObject("_picMoon_54.Image");
			this._picMoon_54.Location = new System.Drawing.Point(8, 16);
			this._picMoon_54.Name = "_picMoon_54";
			this._picMoon_54.Size = new System.Drawing.Size(102, 102);
			this._picMoon_54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_54.TabIndex = 95;
			this._picMoon_54.TabStop = false;
			this._picMoon_54.Visible = false;
			// 
			// _picMoon_53
			// 
			this._picMoon_53.AllowDrop = true;
			this._picMoon_53.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_53.CausesValidation = true;
			this._picMoon_53.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_53.Enabled = true;
			this._picMoon_53.Image = (System.Drawing.Image) resources.GetObject("_picMoon_53.Image");
			this._picMoon_53.Location = new System.Drawing.Point(8, 16);
			this._picMoon_53.Name = "_picMoon_53";
			this._picMoon_53.Size = new System.Drawing.Size(102, 102);
			this._picMoon_53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_53.TabIndex = 94;
			this._picMoon_53.TabStop = false;
			this._picMoon_53.Visible = false;
			// 
			// _picMoon_52
			// 
			this._picMoon_52.AllowDrop = true;
			this._picMoon_52.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_52.CausesValidation = true;
			this._picMoon_52.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_52.Enabled = true;
			this._picMoon_52.Image = (System.Drawing.Image) resources.GetObject("_picMoon_52.Image");
			this._picMoon_52.Location = new System.Drawing.Point(8, 16);
			this._picMoon_52.Name = "_picMoon_52";
			this._picMoon_52.Size = new System.Drawing.Size(102, 102);
			this._picMoon_52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_52.TabIndex = 93;
			this._picMoon_52.TabStop = false;
			this._picMoon_52.Visible = false;
			// 
			// _picMoon_51
			// 
			this._picMoon_51.AllowDrop = true;
			this._picMoon_51.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_51.CausesValidation = true;
			this._picMoon_51.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_51.Enabled = true;
			this._picMoon_51.Image = (System.Drawing.Image) resources.GetObject("_picMoon_51.Image");
			this._picMoon_51.Location = new System.Drawing.Point(8, 16);
			this._picMoon_51.Name = "_picMoon_51";
			this._picMoon_51.Size = new System.Drawing.Size(102, 102);
			this._picMoon_51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_51.TabIndex = 92;
			this._picMoon_51.TabStop = false;
			this._picMoon_51.Visible = false;
			// 
			// _picMoon_50
			// 
			this._picMoon_50.AllowDrop = true;
			this._picMoon_50.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_50.CausesValidation = true;
			this._picMoon_50.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_50.Enabled = true;
			this._picMoon_50.Image = (System.Drawing.Image) resources.GetObject("_picMoon_50.Image");
			this._picMoon_50.Location = new System.Drawing.Point(8, 16);
			this._picMoon_50.Name = "_picMoon_50";
			this._picMoon_50.Size = new System.Drawing.Size(102, 102);
			this._picMoon_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_50.TabIndex = 91;
			this._picMoon_50.TabStop = false;
			this._picMoon_50.Visible = false;
			// 
			// _picMoon_49
			// 
			this._picMoon_49.AllowDrop = true;
			this._picMoon_49.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_49.CausesValidation = true;
			this._picMoon_49.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_49.Enabled = true;
			this._picMoon_49.Image = (System.Drawing.Image) resources.GetObject("_picMoon_49.Image");
			this._picMoon_49.Location = new System.Drawing.Point(8, 16);
			this._picMoon_49.Name = "_picMoon_49";
			this._picMoon_49.Size = new System.Drawing.Size(102, 102);
			this._picMoon_49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_49.TabIndex = 90;
			this._picMoon_49.TabStop = false;
			this._picMoon_49.Visible = false;
			// 
			// _picMoon_48
			// 
			this._picMoon_48.AllowDrop = true;
			this._picMoon_48.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_48.CausesValidation = true;
			this._picMoon_48.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_48.Enabled = true;
			this._picMoon_48.Image = (System.Drawing.Image) resources.GetObject("_picMoon_48.Image");
			this._picMoon_48.Location = new System.Drawing.Point(8, 16);
			this._picMoon_48.Name = "_picMoon_48";
			this._picMoon_48.Size = new System.Drawing.Size(102, 102);
			this._picMoon_48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_48.TabIndex = 89;
			this._picMoon_48.TabStop = false;
			this._picMoon_48.Visible = false;
			// 
			// _picMoon_47
			// 
			this._picMoon_47.AllowDrop = true;
			this._picMoon_47.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_47.CausesValidation = true;
			this._picMoon_47.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_47.Enabled = true;
			this._picMoon_47.Image = (System.Drawing.Image) resources.GetObject("_picMoon_47.Image");
			this._picMoon_47.Location = new System.Drawing.Point(8, 16);
			this._picMoon_47.Name = "_picMoon_47";
			this._picMoon_47.Size = new System.Drawing.Size(102, 102);
			this._picMoon_47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_47.TabIndex = 88;
			this._picMoon_47.TabStop = false;
			this._picMoon_47.Visible = false;
			// 
			// _picMoon_46
			// 
			this._picMoon_46.AllowDrop = true;
			this._picMoon_46.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_46.CausesValidation = true;
			this._picMoon_46.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_46.Enabled = true;
			this._picMoon_46.Image = (System.Drawing.Image) resources.GetObject("_picMoon_46.Image");
			this._picMoon_46.Location = new System.Drawing.Point(8, 16);
			this._picMoon_46.Name = "_picMoon_46";
			this._picMoon_46.Size = new System.Drawing.Size(102, 102);
			this._picMoon_46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_46.TabIndex = 87;
			this._picMoon_46.TabStop = false;
			this._picMoon_46.Visible = false;
			// 
			// _picMoon_45
			// 
			this._picMoon_45.AllowDrop = true;
			this._picMoon_45.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_45.CausesValidation = true;
			this._picMoon_45.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_45.Enabled = true;
			this._picMoon_45.Image = (System.Drawing.Image) resources.GetObject("_picMoon_45.Image");
			this._picMoon_45.Location = new System.Drawing.Point(8, 16);
			this._picMoon_45.Name = "_picMoon_45";
			this._picMoon_45.Size = new System.Drawing.Size(102, 102);
			this._picMoon_45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_45.TabIndex = 86;
			this._picMoon_45.TabStop = false;
			this._picMoon_45.Visible = false;
			// 
			// _picMoon_44
			// 
			this._picMoon_44.AllowDrop = true;
			this._picMoon_44.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_44.CausesValidation = true;
			this._picMoon_44.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_44.Enabled = true;
			this._picMoon_44.Image = (System.Drawing.Image) resources.GetObject("_picMoon_44.Image");
			this._picMoon_44.Location = new System.Drawing.Point(8, 16);
			this._picMoon_44.Name = "_picMoon_44";
			this._picMoon_44.Size = new System.Drawing.Size(102, 102);
			this._picMoon_44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_44.TabIndex = 85;
			this._picMoon_44.TabStop = false;
			this._picMoon_44.Visible = false;
			// 
			// _picMoon_43
			// 
			this._picMoon_43.AllowDrop = true;
			this._picMoon_43.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_43.CausesValidation = true;
			this._picMoon_43.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_43.Enabled = true;
			this._picMoon_43.Image = (System.Drawing.Image) resources.GetObject("_picMoon_43.Image");
			this._picMoon_43.Location = new System.Drawing.Point(8, 16);
			this._picMoon_43.Name = "_picMoon_43";
			this._picMoon_43.Size = new System.Drawing.Size(102, 102);
			this._picMoon_43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_43.TabIndex = 84;
			this._picMoon_43.TabStop = false;
			this._picMoon_43.Visible = false;
			// 
			// _picMoon_42
			// 
			this._picMoon_42.AllowDrop = true;
			this._picMoon_42.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_42.CausesValidation = true;
			this._picMoon_42.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_42.Enabled = true;
			this._picMoon_42.Image = (System.Drawing.Image) resources.GetObject("_picMoon_42.Image");
			this._picMoon_42.Location = new System.Drawing.Point(8, 16);
			this._picMoon_42.Name = "_picMoon_42";
			this._picMoon_42.Size = new System.Drawing.Size(102, 102);
			this._picMoon_42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_42.TabIndex = 83;
			this._picMoon_42.TabStop = false;
			this._picMoon_42.Visible = false;
			// 
			// _picMoon_41
			// 
			this._picMoon_41.AllowDrop = true;
			this._picMoon_41.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_41.CausesValidation = true;
			this._picMoon_41.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_41.Enabled = true;
			this._picMoon_41.Image = (System.Drawing.Image) resources.GetObject("_picMoon_41.Image");
			this._picMoon_41.Location = new System.Drawing.Point(8, 16);
			this._picMoon_41.Name = "_picMoon_41";
			this._picMoon_41.Size = new System.Drawing.Size(102, 102);
			this._picMoon_41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_41.TabIndex = 82;
			this._picMoon_41.TabStop = false;
			this._picMoon_41.Visible = false;
			// 
			// _picMoon_40
			// 
			this._picMoon_40.AllowDrop = true;
			this._picMoon_40.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_40.CausesValidation = true;
			this._picMoon_40.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_40.Enabled = true;
			this._picMoon_40.Image = (System.Drawing.Image) resources.GetObject("_picMoon_40.Image");
			this._picMoon_40.Location = new System.Drawing.Point(8, 16);
			this._picMoon_40.Name = "_picMoon_40";
			this._picMoon_40.Size = new System.Drawing.Size(102, 102);
			this._picMoon_40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_40.TabIndex = 81;
			this._picMoon_40.TabStop = false;
			this._picMoon_40.Visible = false;
			// 
			// _picMoon_39
			// 
			this._picMoon_39.AllowDrop = true;
			this._picMoon_39.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_39.CausesValidation = true;
			this._picMoon_39.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_39.Enabled = true;
			this._picMoon_39.Image = (System.Drawing.Image) resources.GetObject("_picMoon_39.Image");
			this._picMoon_39.Location = new System.Drawing.Point(8, 16);
			this._picMoon_39.Name = "_picMoon_39";
			this._picMoon_39.Size = new System.Drawing.Size(102, 102);
			this._picMoon_39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_39.TabIndex = 80;
			this._picMoon_39.TabStop = false;
			this._picMoon_39.Visible = false;
			// 
			// _picMoon_38
			// 
			this._picMoon_38.AllowDrop = true;
			this._picMoon_38.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_38.CausesValidation = true;
			this._picMoon_38.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_38.Enabled = true;
			this._picMoon_38.Image = (System.Drawing.Image) resources.GetObject("_picMoon_38.Image");
			this._picMoon_38.Location = new System.Drawing.Point(8, 16);
			this._picMoon_38.Name = "_picMoon_38";
			this._picMoon_38.Size = new System.Drawing.Size(102, 102);
			this._picMoon_38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_38.TabIndex = 79;
			this._picMoon_38.TabStop = false;
			this._picMoon_38.Visible = false;
			// 
			// _picMoon_37
			// 
			this._picMoon_37.AllowDrop = true;
			this._picMoon_37.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_37.CausesValidation = true;
			this._picMoon_37.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_37.Enabled = true;
			this._picMoon_37.Image = (System.Drawing.Image) resources.GetObject("_picMoon_37.Image");
			this._picMoon_37.Location = new System.Drawing.Point(8, 16);
			this._picMoon_37.Name = "_picMoon_37";
			this._picMoon_37.Size = new System.Drawing.Size(102, 102);
			this._picMoon_37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_37.TabIndex = 78;
			this._picMoon_37.TabStop = false;
			this._picMoon_37.Visible = false;
			// 
			// _picMoon_36
			// 
			this._picMoon_36.AllowDrop = true;
			this._picMoon_36.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_36.CausesValidation = true;
			this._picMoon_36.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_36.Enabled = true;
			this._picMoon_36.Image = (System.Drawing.Image) resources.GetObject("_picMoon_36.Image");
			this._picMoon_36.Location = new System.Drawing.Point(8, 16);
			this._picMoon_36.Name = "_picMoon_36";
			this._picMoon_36.Size = new System.Drawing.Size(102, 102);
			this._picMoon_36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_36.TabIndex = 77;
			this._picMoon_36.TabStop = false;
			this._picMoon_36.Visible = false;
			// 
			// _picMoon_35
			// 
			this._picMoon_35.AllowDrop = true;
			this._picMoon_35.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_35.CausesValidation = true;
			this._picMoon_35.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_35.Enabled = true;
			this._picMoon_35.Image = (System.Drawing.Image) resources.GetObject("_picMoon_35.Image");
			this._picMoon_35.Location = new System.Drawing.Point(8, 16);
			this._picMoon_35.Name = "_picMoon_35";
			this._picMoon_35.Size = new System.Drawing.Size(102, 102);
			this._picMoon_35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_35.TabIndex = 76;
			this._picMoon_35.TabStop = false;
			this._picMoon_35.Visible = false;
			// 
			// _picMoon_34
			// 
			this._picMoon_34.AllowDrop = true;
			this._picMoon_34.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_34.CausesValidation = true;
			this._picMoon_34.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_34.Enabled = true;
			this._picMoon_34.Image = (System.Drawing.Image) resources.GetObject("_picMoon_34.Image");
			this._picMoon_34.Location = new System.Drawing.Point(8, 16);
			this._picMoon_34.Name = "_picMoon_34";
			this._picMoon_34.Size = new System.Drawing.Size(102, 102);
			this._picMoon_34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_34.TabIndex = 75;
			this._picMoon_34.TabStop = false;
			this._picMoon_34.Visible = false;
			// 
			// _picMoon_33
			// 
			this._picMoon_33.AllowDrop = true;
			this._picMoon_33.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_33.CausesValidation = true;
			this._picMoon_33.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_33.Enabled = true;
			this._picMoon_33.Image = (System.Drawing.Image) resources.GetObject("_picMoon_33.Image");
			this._picMoon_33.Location = new System.Drawing.Point(8, 16);
			this._picMoon_33.Name = "_picMoon_33";
			this._picMoon_33.Size = new System.Drawing.Size(102, 102);
			this._picMoon_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_33.TabIndex = 74;
			this._picMoon_33.TabStop = false;
			this._picMoon_33.Visible = false;
			// 
			// _picMoon_32
			// 
			this._picMoon_32.AllowDrop = true;
			this._picMoon_32.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_32.CausesValidation = true;
			this._picMoon_32.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_32.Enabled = true;
			this._picMoon_32.Image = (System.Drawing.Image) resources.GetObject("_picMoon_32.Image");
			this._picMoon_32.Location = new System.Drawing.Point(8, 16);
			this._picMoon_32.Name = "_picMoon_32";
			this._picMoon_32.Size = new System.Drawing.Size(102, 102);
			this._picMoon_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_32.TabIndex = 73;
			this._picMoon_32.TabStop = false;
			this._picMoon_32.Visible = false;
			// 
			// _picMoon_31
			// 
			this._picMoon_31.AllowDrop = true;
			this._picMoon_31.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_31.CausesValidation = true;
			this._picMoon_31.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_31.Enabled = true;
			this._picMoon_31.Image = (System.Drawing.Image) resources.GetObject("_picMoon_31.Image");
			this._picMoon_31.Location = new System.Drawing.Point(8, 16);
			this._picMoon_31.Name = "_picMoon_31";
			this._picMoon_31.Size = new System.Drawing.Size(102, 102);
			this._picMoon_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_31.TabIndex = 72;
			this._picMoon_31.TabStop = false;
			this._picMoon_31.Visible = false;
			// 
			// _picMoon_30
			// 
			this._picMoon_30.AllowDrop = true;
			this._picMoon_30.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_30.CausesValidation = true;
			this._picMoon_30.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_30.Enabled = true;
			this._picMoon_30.Image = (System.Drawing.Image) resources.GetObject("_picMoon_30.Image");
			this._picMoon_30.Location = new System.Drawing.Point(8, 16);
			this._picMoon_30.Name = "_picMoon_30";
			this._picMoon_30.Size = new System.Drawing.Size(102, 102);
			this._picMoon_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_30.TabIndex = 71;
			this._picMoon_30.TabStop = false;
			this._picMoon_30.Visible = false;
			// 
			// _picMoon_29
			// 
			this._picMoon_29.AllowDrop = true;
			this._picMoon_29.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_29.CausesValidation = true;
			this._picMoon_29.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_29.Enabled = true;
			this._picMoon_29.Image = (System.Drawing.Image) resources.GetObject("_picMoon_29.Image");
			this._picMoon_29.Location = new System.Drawing.Point(8, 16);
			this._picMoon_29.Name = "_picMoon_29";
			this._picMoon_29.Size = new System.Drawing.Size(102, 102);
			this._picMoon_29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_29.TabIndex = 70;
			this._picMoon_29.TabStop = false;
			this._picMoon_29.Visible = false;
			// 
			// _picMoon_28
			// 
			this._picMoon_28.AllowDrop = true;
			this._picMoon_28.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_28.CausesValidation = true;
			this._picMoon_28.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_28.Enabled = true;
			this._picMoon_28.Image = (System.Drawing.Image) resources.GetObject("_picMoon_28.Image");
			this._picMoon_28.Location = new System.Drawing.Point(8, 16);
			this._picMoon_28.Name = "_picMoon_28";
			this._picMoon_28.Size = new System.Drawing.Size(102, 102);
			this._picMoon_28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_28.TabIndex = 69;
			this._picMoon_28.TabStop = false;
			this._picMoon_28.Visible = false;
			// 
			// _picMoon_27
			// 
			this._picMoon_27.AllowDrop = true;
			this._picMoon_27.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_27.CausesValidation = true;
			this._picMoon_27.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_27.Enabled = true;
			this._picMoon_27.Image = (System.Drawing.Image) resources.GetObject("_picMoon_27.Image");
			this._picMoon_27.Location = new System.Drawing.Point(8, 16);
			this._picMoon_27.Name = "_picMoon_27";
			this._picMoon_27.Size = new System.Drawing.Size(102, 102);
			this._picMoon_27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_27.TabIndex = 68;
			this._picMoon_27.TabStop = false;
			this._picMoon_27.Visible = false;
			// 
			// _picMoon_26
			// 
			this._picMoon_26.AllowDrop = true;
			this._picMoon_26.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_26.CausesValidation = true;
			this._picMoon_26.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_26.Enabled = true;
			this._picMoon_26.Image = (System.Drawing.Image) resources.GetObject("_picMoon_26.Image");
			this._picMoon_26.Location = new System.Drawing.Point(8, 16);
			this._picMoon_26.Name = "_picMoon_26";
			this._picMoon_26.Size = new System.Drawing.Size(102, 102);
			this._picMoon_26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_26.TabIndex = 67;
			this._picMoon_26.TabStop = false;
			this._picMoon_26.Visible = false;
			// 
			// _picMoon_25
			// 
			this._picMoon_25.AllowDrop = true;
			this._picMoon_25.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_25.CausesValidation = true;
			this._picMoon_25.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_25.Enabled = true;
			this._picMoon_25.Image = (System.Drawing.Image) resources.GetObject("_picMoon_25.Image");
			this._picMoon_25.Location = new System.Drawing.Point(8, 16);
			this._picMoon_25.Name = "_picMoon_25";
			this._picMoon_25.Size = new System.Drawing.Size(102, 102);
			this._picMoon_25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_25.TabIndex = 66;
			this._picMoon_25.TabStop = false;
			this._picMoon_25.Visible = false;
			// 
			// _picMoon_24
			// 
			this._picMoon_24.AllowDrop = true;
			this._picMoon_24.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_24.CausesValidation = true;
			this._picMoon_24.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_24.Enabled = true;
			this._picMoon_24.Image = (System.Drawing.Image) resources.GetObject("_picMoon_24.Image");
			this._picMoon_24.Location = new System.Drawing.Point(8, 16);
			this._picMoon_24.Name = "_picMoon_24";
			this._picMoon_24.Size = new System.Drawing.Size(102, 102);
			this._picMoon_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_24.TabIndex = 65;
			this._picMoon_24.TabStop = false;
			this._picMoon_24.Visible = false;
			// 
			// _picMoon_23
			// 
			this._picMoon_23.AllowDrop = true;
			this._picMoon_23.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_23.CausesValidation = true;
			this._picMoon_23.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_23.Enabled = true;
			this._picMoon_23.Image = (System.Drawing.Image) resources.GetObject("_picMoon_23.Image");
			this._picMoon_23.Location = new System.Drawing.Point(8, 16);
			this._picMoon_23.Name = "_picMoon_23";
			this._picMoon_23.Size = new System.Drawing.Size(102, 102);
			this._picMoon_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_23.TabIndex = 64;
			this._picMoon_23.TabStop = false;
			this._picMoon_23.Visible = false;
			// 
			// _picMoon_22
			// 
			this._picMoon_22.AllowDrop = true;
			this._picMoon_22.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_22.CausesValidation = true;
			this._picMoon_22.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_22.Enabled = true;
			this._picMoon_22.Image = (System.Drawing.Image) resources.GetObject("_picMoon_22.Image");
			this._picMoon_22.Location = new System.Drawing.Point(8, 16);
			this._picMoon_22.Name = "_picMoon_22";
			this._picMoon_22.Size = new System.Drawing.Size(102, 102);
			this._picMoon_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_22.TabIndex = 63;
			this._picMoon_22.TabStop = false;
			this._picMoon_22.Visible = false;
			// 
			// _picMoon_21
			// 
			this._picMoon_21.AllowDrop = true;
			this._picMoon_21.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_21.CausesValidation = true;
			this._picMoon_21.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_21.Enabled = true;
			this._picMoon_21.Image = (System.Drawing.Image) resources.GetObject("_picMoon_21.Image");
			this._picMoon_21.Location = new System.Drawing.Point(8, 16);
			this._picMoon_21.Name = "_picMoon_21";
			this._picMoon_21.Size = new System.Drawing.Size(102, 102);
			this._picMoon_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_21.TabIndex = 62;
			this._picMoon_21.TabStop = false;
			this._picMoon_21.Visible = false;
			// 
			// _picMoon_20
			// 
			this._picMoon_20.AllowDrop = true;
			this._picMoon_20.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_20.CausesValidation = true;
			this._picMoon_20.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_20.Enabled = true;
			this._picMoon_20.Image = (System.Drawing.Image) resources.GetObject("_picMoon_20.Image");
			this._picMoon_20.Location = new System.Drawing.Point(8, 16);
			this._picMoon_20.Name = "_picMoon_20";
			this._picMoon_20.Size = new System.Drawing.Size(102, 102);
			this._picMoon_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_20.TabIndex = 61;
			this._picMoon_20.TabStop = false;
			this._picMoon_20.Visible = false;
			// 
			// _picMoon_19
			// 
			this._picMoon_19.AllowDrop = true;
			this._picMoon_19.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_19.CausesValidation = true;
			this._picMoon_19.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_19.Enabled = true;
			this._picMoon_19.Image = (System.Drawing.Image) resources.GetObject("_picMoon_19.Image");
			this._picMoon_19.Location = new System.Drawing.Point(8, 16);
			this._picMoon_19.Name = "_picMoon_19";
			this._picMoon_19.Size = new System.Drawing.Size(102, 102);
			this._picMoon_19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_19.TabIndex = 60;
			this._picMoon_19.TabStop = false;
			this._picMoon_19.Visible = false;
			// 
			// _picMoon_18
			// 
			this._picMoon_18.AllowDrop = true;
			this._picMoon_18.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_18.CausesValidation = true;
			this._picMoon_18.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_18.Enabled = true;
			this._picMoon_18.Image = (System.Drawing.Image) resources.GetObject("_picMoon_18.Image");
			this._picMoon_18.Location = new System.Drawing.Point(8, 16);
			this._picMoon_18.Name = "_picMoon_18";
			this._picMoon_18.Size = new System.Drawing.Size(102, 102);
			this._picMoon_18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_18.TabIndex = 59;
			this._picMoon_18.TabStop = false;
			this._picMoon_18.Visible = false;
			// 
			// _picMoon_17
			// 
			this._picMoon_17.AllowDrop = true;
			this._picMoon_17.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_17.CausesValidation = true;
			this._picMoon_17.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_17.Enabled = true;
			this._picMoon_17.Image = (System.Drawing.Image) resources.GetObject("_picMoon_17.Image");
			this._picMoon_17.Location = new System.Drawing.Point(8, 16);
			this._picMoon_17.Name = "_picMoon_17";
			this._picMoon_17.Size = new System.Drawing.Size(102, 102);
			this._picMoon_17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_17.TabIndex = 58;
			this._picMoon_17.TabStop = false;
			this._picMoon_17.Visible = false;
			// 
			// _picMoon_16
			// 
			this._picMoon_16.AllowDrop = true;
			this._picMoon_16.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_16.CausesValidation = true;
			this._picMoon_16.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_16.Enabled = true;
			this._picMoon_16.Image = (System.Drawing.Image) resources.GetObject("_picMoon_16.Image");
			this._picMoon_16.Location = new System.Drawing.Point(8, 16);
			this._picMoon_16.Name = "_picMoon_16";
			this._picMoon_16.Size = new System.Drawing.Size(102, 102);
			this._picMoon_16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_16.TabIndex = 57;
			this._picMoon_16.TabStop = false;
			this._picMoon_16.Visible = false;
			// 
			// _picMoon_15
			// 
			this._picMoon_15.AllowDrop = true;
			this._picMoon_15.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_15.CausesValidation = true;
			this._picMoon_15.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_15.Enabled = true;
			this._picMoon_15.Image = (System.Drawing.Image) resources.GetObject("_picMoon_15.Image");
			this._picMoon_15.Location = new System.Drawing.Point(8, 16);
			this._picMoon_15.Name = "_picMoon_15";
			this._picMoon_15.Size = new System.Drawing.Size(102, 102);
			this._picMoon_15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_15.TabIndex = 56;
			this._picMoon_15.TabStop = false;
			this._picMoon_15.Visible = false;
			// 
			// _picMoon_14
			// 
			this._picMoon_14.AllowDrop = true;
			this._picMoon_14.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_14.CausesValidation = true;
			this._picMoon_14.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_14.Enabled = true;
			this._picMoon_14.Image = (System.Drawing.Image) resources.GetObject("_picMoon_14.Image");
			this._picMoon_14.Location = new System.Drawing.Point(8, 16);
			this._picMoon_14.Name = "_picMoon_14";
			this._picMoon_14.Size = new System.Drawing.Size(102, 102);
			this._picMoon_14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_14.TabIndex = 55;
			this._picMoon_14.TabStop = false;
			this._picMoon_14.Visible = false;
			// 
			// _picMoon_13
			// 
			this._picMoon_13.AllowDrop = true;
			this._picMoon_13.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_13.CausesValidation = true;
			this._picMoon_13.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_13.Enabled = true;
			this._picMoon_13.Image = (System.Drawing.Image) resources.GetObject("_picMoon_13.Image");
			this._picMoon_13.Location = new System.Drawing.Point(8, 16);
			this._picMoon_13.Name = "_picMoon_13";
			this._picMoon_13.Size = new System.Drawing.Size(102, 102);
			this._picMoon_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_13.TabIndex = 54;
			this._picMoon_13.TabStop = false;
			this._picMoon_13.Visible = false;
			// 
			// _picMoon_12
			// 
			this._picMoon_12.AllowDrop = true;
			this._picMoon_12.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_12.CausesValidation = true;
			this._picMoon_12.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_12.Enabled = true;
			this._picMoon_12.Image = (System.Drawing.Image) resources.GetObject("_picMoon_12.Image");
			this._picMoon_12.Location = new System.Drawing.Point(8, 16);
			this._picMoon_12.Name = "_picMoon_12";
			this._picMoon_12.Size = new System.Drawing.Size(102, 102);
			this._picMoon_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_12.TabIndex = 53;
			this._picMoon_12.TabStop = false;
			this._picMoon_12.Visible = false;
			// 
			// _picMoon_11
			// 
			this._picMoon_11.AllowDrop = true;
			this._picMoon_11.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_11.CausesValidation = true;
			this._picMoon_11.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_11.Enabled = true;
			this._picMoon_11.Image = (System.Drawing.Image) resources.GetObject("_picMoon_11.Image");
			this._picMoon_11.Location = new System.Drawing.Point(8, 16);
			this._picMoon_11.Name = "_picMoon_11";
			this._picMoon_11.Size = new System.Drawing.Size(102, 102);
			this._picMoon_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_11.TabIndex = 52;
			this._picMoon_11.TabStop = false;
			this._picMoon_11.Visible = false;
			// 
			// _picMoon_10
			// 
			this._picMoon_10.AllowDrop = true;
			this._picMoon_10.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_10.CausesValidation = true;
			this._picMoon_10.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_10.Enabled = true;
			this._picMoon_10.Image = (System.Drawing.Image) resources.GetObject("_picMoon_10.Image");
			this._picMoon_10.Location = new System.Drawing.Point(8, 16);
			this._picMoon_10.Name = "_picMoon_10";
			this._picMoon_10.Size = new System.Drawing.Size(102, 102);
			this._picMoon_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_10.TabIndex = 51;
			this._picMoon_10.TabStop = false;
			this._picMoon_10.Visible = false;
			// 
			// _picMoon_9
			// 
			this._picMoon_9.AllowDrop = true;
			this._picMoon_9.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_9.CausesValidation = true;
			this._picMoon_9.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_9.Enabled = true;
			this._picMoon_9.Image = (System.Drawing.Image) resources.GetObject("_picMoon_9.Image");
			this._picMoon_9.Location = new System.Drawing.Point(8, 16);
			this._picMoon_9.Name = "_picMoon_9";
			this._picMoon_9.Size = new System.Drawing.Size(102, 102);
			this._picMoon_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_9.TabIndex = 50;
			this._picMoon_9.TabStop = false;
			this._picMoon_9.Visible = false;
			// 
			// _picMoon_8
			// 
			this._picMoon_8.AllowDrop = true;
			this._picMoon_8.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_8.CausesValidation = true;
			this._picMoon_8.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_8.Enabled = true;
			this._picMoon_8.Image = (System.Drawing.Image) resources.GetObject("_picMoon_8.Image");
			this._picMoon_8.Location = new System.Drawing.Point(8, 16);
			this._picMoon_8.Name = "_picMoon_8";
			this._picMoon_8.Size = new System.Drawing.Size(102, 102);
			this._picMoon_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_8.TabIndex = 49;
			this._picMoon_8.TabStop = false;
			this._picMoon_8.Visible = false;
			// 
			// _picMoon_7
			// 
			this._picMoon_7.AllowDrop = true;
			this._picMoon_7.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_7.CausesValidation = true;
			this._picMoon_7.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_7.Enabled = true;
			this._picMoon_7.Image = (System.Drawing.Image) resources.GetObject("_picMoon_7.Image");
			this._picMoon_7.Location = new System.Drawing.Point(8, 16);
			this._picMoon_7.Name = "_picMoon_7";
			this._picMoon_7.Size = new System.Drawing.Size(102, 102);
			this._picMoon_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_7.TabIndex = 48;
			this._picMoon_7.TabStop = false;
			this._picMoon_7.Visible = false;
			// 
			// _picMoon_6
			// 
			this._picMoon_6.AllowDrop = true;
			this._picMoon_6.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_6.CausesValidation = true;
			this._picMoon_6.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_6.Enabled = true;
			this._picMoon_6.Image = (System.Drawing.Image) resources.GetObject("_picMoon_6.Image");
			this._picMoon_6.Location = new System.Drawing.Point(8, 16);
			this._picMoon_6.Name = "_picMoon_6";
			this._picMoon_6.Size = new System.Drawing.Size(102, 102);
			this._picMoon_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_6.TabIndex = 47;
			this._picMoon_6.TabStop = false;
			this._picMoon_6.Visible = false;
			// 
			// _picMoon_5
			// 
			this._picMoon_5.AllowDrop = true;
			this._picMoon_5.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_5.CausesValidation = true;
			this._picMoon_5.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_5.Enabled = true;
			this._picMoon_5.Image = (System.Drawing.Image) resources.GetObject("_picMoon_5.Image");
			this._picMoon_5.Location = new System.Drawing.Point(8, 16);
			this._picMoon_5.Name = "_picMoon_5";
			this._picMoon_5.Size = new System.Drawing.Size(102, 102);
			this._picMoon_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this._picMoon_5.TabIndex = 46;
			this._picMoon_5.TabStop = false;
			this._picMoon_5.Visible = false;
			// 
			// _picMoon_4
			// 
			this._picMoon_4.AllowDrop = true;
			this._picMoon_4.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_4.CausesValidation = true;
			this._picMoon_4.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_4.Enabled = true;
			this._picMoon_4.Image = (System.Drawing.Image) resources.GetObject("_picMoon_4.Image");
			this._picMoon_4.Location = new System.Drawing.Point(8, 16);
			this._picMoon_4.Name = "_picMoon_4";
			this._picMoon_4.Size = new System.Drawing.Size(102, 102);
			this._picMoon_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_4.TabIndex = 45;
			this._picMoon_4.TabStop = false;
			this._picMoon_4.Visible = false;
			// 
			// _picMoon_3
			// 
			this._picMoon_3.AllowDrop = true;
			this._picMoon_3.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_3.CausesValidation = true;
			this._picMoon_3.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_3.Enabled = true;
			this._picMoon_3.Image = (System.Drawing.Image) resources.GetObject("_picMoon_3.Image");
			this._picMoon_3.Location = new System.Drawing.Point(8, 16);
			this._picMoon_3.Name = "_picMoon_3";
			this._picMoon_3.Size = new System.Drawing.Size(102, 102);
			this._picMoon_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_3.TabIndex = 44;
			this._picMoon_3.TabStop = false;
			this._picMoon_3.Visible = false;
			// 
			// _picMoon_2
			// 
			this._picMoon_2.AllowDrop = true;
			this._picMoon_2.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_2.CausesValidation = true;
			this._picMoon_2.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_2.Enabled = true;
			this._picMoon_2.Image = (System.Drawing.Image) resources.GetObject("_picMoon_2.Image");
			this._picMoon_2.Location = new System.Drawing.Point(8, 16);
			this._picMoon_2.Name = "_picMoon_2";
			this._picMoon_2.Size = new System.Drawing.Size(102, 102);
			this._picMoon_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_2.TabIndex = 43;
			this._picMoon_2.TabStop = false;
			this._picMoon_2.Visible = false;
			// 
			// _picMoon_1
			// 
			this._picMoon_1.AllowDrop = true;
			this._picMoon_1.BackColor = System.Drawing.SystemColors.Control;
			this._picMoon_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_1.CausesValidation = true;
			this._picMoon_1.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_1.Enabled = true;
			this._picMoon_1.Image = (System.Drawing.Image) resources.GetObject("_picMoon_1.Image");
			this._picMoon_1.Location = new System.Drawing.Point(8, 16);
			this._picMoon_1.Name = "_picMoon_1";
			this._picMoon_1.Size = new System.Drawing.Size(102, 102);
			this._picMoon_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_1.TabIndex = 100;
			this._picMoon_1.TabStop = false;
			this._picMoon_1.Visible = false;
			// 
			// _picMoon_0
			// 
			this._picMoon_0.AllowDrop = true;
			this._picMoon_0.BackColor = System.Drawing.Color.Black;
			this._picMoon_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picMoon_0.CausesValidation = true;
			this._picMoon_0.Dock = System.Windows.Forms.DockStyle.None;
			this._picMoon_0.Enabled = true;
			this._picMoon_0.Image = (System.Drawing.Image) resources.GetObject("_picMoon_0.Image");
			this._picMoon_0.Location = new System.Drawing.Point(8, 16);
			this._picMoon_0.Name = "_picMoon_0";
			this._picMoon_0.Size = new System.Drawing.Size(102, 102);
			this._picMoon_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this._picMoon_0.TabIndex = 42;
			this._picMoon_0.TabStop = false;
			this._picMoon_0.Visible = false;
			// 
			// fraJulianCal
			// 
			this.fraJulianCal.AllowDrop = true;
			this.fraJulianCal.BackColor = System.Drawing.SystemColors.Control;
			this.fraJulianCal.Controls.Add(this.cmdJCCompute);
			this.fraJulianCal.Controls.Add(this.txtJCDay);
			this.fraJulianCal.Controls.Add(this.txtJCMonth);
			this.fraJulianCal.Controls.Add(this.txtJCYear);
			this.fraJulianCal.Enabled = true;
			this.fraJulianCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraJulianCal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraJulianCal.Location = new System.Drawing.Point(208, 8);
			this.fraJulianCal.Name = "fraJulianCal";
			this.fraJulianCal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraJulianCal.Size = new System.Drawing.Size(121, 153);
			this.fraJulianCal.TabIndex = 40;
			this.fraJulianCal.Text = "Julian ";
			this.fraJulianCal.Visible = true;
			// 
			// cmdJCCompute
			// 
			this.cmdJCCompute.AllowDrop = true;
			this.cmdJCCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdJCCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdJCCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdJCCompute.Location = new System.Drawing.Point(24, 112);
			this.cmdJCCompute.Name = "cmdJCCompute";
			this.cmdJCCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdJCCompute.Size = new System.Drawing.Size(73, 25);
			this.cmdJCCompute.TabIndex = 10;
			this.cmdJCCompute.Text = "Compute";
			this.cmdJCCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdJCCompute.UseVisualStyleBackColor = false;
			this.cmdJCCompute.Click += new System.EventHandler(this.cmdJCCompute_Click);
			// 
			// txtJCDay
			// 
			this.txtJCDay.AcceptsReturn = true;
			this.txtJCDay.AllowDrop = true;
			this.txtJCDay.BackColor = System.Drawing.SystemColors.Window;
			this.txtJCDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJCDay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJCDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJCDay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJCDay.Location = new System.Drawing.Point(40, 80);
			this.txtJCDay.MaxLength = 0;
			this.txtJCDay.Name = "txtJCDay";
			this.txtJCDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJCDay.Size = new System.Drawing.Size(41, 25);
			this.txtJCDay.TabIndex = 9;
			this.txtJCDay.Text = "Day";
			this.txtJCDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJCDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJCDay_KeyDown);
			this.txtJCDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJCDay_KeyPress);
			// 
			// txtJCMonth
			// 
			this.txtJCMonth.AcceptsReturn = true;
			this.txtJCMonth.AllowDrop = true;
			this.txtJCMonth.BackColor = System.Drawing.SystemColors.Window;
			this.txtJCMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJCMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJCMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJCMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJCMonth.Location = new System.Drawing.Point(12, 48);
			this.txtJCMonth.MaxLength = 0;
			this.txtJCMonth.Name = "txtJCMonth";
			this.txtJCMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJCMonth.Size = new System.Drawing.Size(97, 28);
			this.txtJCMonth.TabIndex = 8;
			this.txtJCMonth.Text = "JCMonth";
			this.txtJCMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJCMonth.Click += new System.EventHandler(this.txtJCMonth_Click);
			this.txtJCMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJCMonth_KeyDown);
			// 
			// txtJCYear
			// 
			this.txtJCYear.AcceptsReturn = true;
			this.txtJCYear.AllowDrop = true;
			this.txtJCYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtJCYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJCYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJCYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJCYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJCYear.Location = new System.Drawing.Point(24, 16);
			this.txtJCYear.MaxLength = 0;
			this.txtJCYear.Name = "txtJCYear";
			this.txtJCYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJCYear.Size = new System.Drawing.Size(73, 25);
			this.txtJCYear.TabIndex = 7;
			this.txtJCYear.Text = "JCYear";
			this.txtJCYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJCYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJCYear_KeyDown);
			this.txtJCYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJCYear_KeyPress);
			// 
			// txtControl
			// 
			this.txtControl.AcceptsReturn = true;
			this.txtControl.AllowDrop = true;
			this.txtControl.BackColor = System.Drawing.Color.Black;
			this.txtControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtControl.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtControl.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtControl.Location = new System.Drawing.Point(544, 289);
			this.txtControl.MaxLength = 0;
			this.txtControl.Name = "txtControl";
			this.txtControl.ReadOnly = true;
			this.txtControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtControl.Size = new System.Drawing.Size(10, 15);
			this.txtControl.TabIndex = 37;
			this.txtControl.TabStop = false;
			this.txtControl.Click += new System.EventHandler(this.txtControl_Click);
			// 
			// fraBiblical
			// 
			this.fraBiblical.AllowDrop = true;
			this.fraBiblical.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
			this.fraBiblical.Controls.Add(this.lstBMonth);
			this.fraBiblical.Controls.Add(this.optDate4);
			this.fraBiblical.Controls.Add(this.optDate3);
			this.fraBiblical.Controls.Add(this.optDate2);
			this.fraBiblical.Controls.Add(this.optDate1);
			this.fraBiblical.Controls.Add(this.cmdCriteria);
			this.fraBiblical.Controls.Add(this.cmdBCompute);
			this.fraBiblical.Controls.Add(this.txtBDay);
			this.fraBiblical.Controls.Add(this.txtBYear);
			this.fraBiblical.Controls.Add(this.txtBMonth);
			this.fraBiblical.Controls.Add(this.lblBDayOfWeek);
			this.fraBiblical.Enabled = true;
			this.fraBiblical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraBiblical.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraBiblical.Location = new System.Drawing.Point(336, 8);
			this.fraBiblical.Name = "fraBiblical";
			this.fraBiblical.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraBiblical.Size = new System.Drawing.Size(153, 281);
			this.fraBiblical.TabIndex = 34;
			this.fraBiblical.Text = "Biblical-Not IDL adjusted";
			this.fraBiblical.Visible = true;
			// 
			// lstBMonth
			// 
			this.lstBMonth.AllowDrop = true;
			this.lstBMonth.BackColor = System.Drawing.SystemColors.Window;
			this.lstBMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstBMonth.CausesValidation = true;
			this.lstBMonth.Enabled = true;
			this.lstBMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstBMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstBMonth.IntegralHeight = true;
			this.lstBMonth.Location = new System.Drawing.Point(40, 8);
			this.lstBMonth.MultiColumn = false;
			this.lstBMonth.Name = "lstBMonth";
			this.lstBMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lstBMonth.Size = new System.Drawing.Size(73, 176);
			this.lstBMonth.Sorted = false;
			this.lstBMonth.TabIndex = 36;
			this.lstBMonth.TabStop = false;
			this.lstBMonth.Visible = false;
			this.lstBMonth.SelectedIndexChanged += new System.EventHandler(this.lstBMonth_SelectedIndexChanged);
			// 
			// optDate4
			// 
			this.optDate4.AllowDrop = true;
			this.optDate4.Appearance = System.Windows.Forms.Appearance.Normal;
			this.optDate4.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
			this.optDate4.CausesValidation = true;
			this.optDate4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate4.Checked = false;
			this.optDate4.Enabled = true;
			this.optDate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.optDate4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDate4.Location = new System.Drawing.Point(40, 248);
			this.optDate4.Name = "optDate4";
			this.optDate4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDate4.Size = new System.Drawing.Size(81, 20);
			this.optDate4.TabIndex = 19;
			this.optDate4.TabStop = true;
			this.optDate4.Text = "Date 4";
			this.optDate4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate4.Visible = true;
			this.optDate4.CheckedChanged += new System.EventHandler(this.optDate4_CheckedChanged);
			// 
			// optDate3
			// 
			this.optDate3.AllowDrop = true;
			this.optDate3.Appearance = System.Windows.Forms.Appearance.Normal;
			this.optDate3.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
			this.optDate3.CausesValidation = true;
			this.optDate3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate3.Checked = false;
			this.optDate3.Enabled = true;
			this.optDate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.optDate3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDate3.Location = new System.Drawing.Point(40, 224);
			this.optDate3.Name = "optDate3";
			this.optDate3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDate3.Size = new System.Drawing.Size(81, 20);
			this.optDate3.TabIndex = 18;
			this.optDate3.TabStop = true;
			this.optDate3.Text = "Date 3";
			this.optDate3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate3.Visible = true;
			this.optDate3.CheckedChanged += new System.EventHandler(this.optDate3_CheckedChanged);
			// 
			// optDate2
			// 
			this.optDate2.AllowDrop = true;
			this.optDate2.Appearance = System.Windows.Forms.Appearance.Normal;
			this.optDate2.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
			this.optDate2.CausesValidation = true;
			this.optDate2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate2.Checked = false;
			this.optDate2.Enabled = true;
			this.optDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.optDate2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDate2.Location = new System.Drawing.Point(40, 200);
			this.optDate2.Name = "optDate2";
			this.optDate2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDate2.Size = new System.Drawing.Size(81, 20);
			this.optDate2.TabIndex = 17;
			this.optDate2.TabStop = true;
			this.optDate2.Text = "Date 2";
			this.optDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate2.Visible = true;
			this.optDate2.CheckedChanged += new System.EventHandler(this.optDate2_CheckedChanged);
			// 
			// optDate1
			// 
			this.optDate1.AllowDrop = true;
			this.optDate1.Appearance = System.Windows.Forms.Appearance.Normal;
			this.optDate1.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
			this.optDate1.CausesValidation = true;
			this.optDate1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate1.Checked = false;
			this.optDate1.Enabled = true;
			this.optDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.optDate1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDate1.Location = new System.Drawing.Point(40, 176);
			this.optDate1.Name = "optDate1";
			this.optDate1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDate1.Size = new System.Drawing.Size(81, 20);
			this.optDate1.TabIndex = 16;
			this.optDate1.TabStop = true;
			this.optDate1.Text = "Date 1";
			this.optDate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.optDate1.Visible = false;
			this.optDate1.CheckedChanged += new System.EventHandler(this.optDate1_CheckedChanged);
			// 
			// cmdCriteria
			// 
			this.cmdCriteria.AllowDrop = true;
			this.cmdCriteria.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCriteria.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCriteria.Location = new System.Drawing.Point(38, 144);
			this.cmdCriteria.Name = "cmdCriteria";
			this.cmdCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCriteria.Size = new System.Drawing.Size(81, 25);
			this.cmdCriteria.TabIndex = 15;
			this.cmdCriteria.Text = "Criteria";
			this.cmdCriteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCriteria.UseVisualStyleBackColor = false;
			this.cmdCriteria.Click += new System.EventHandler(this.cmdCriteria_Click);
			// 
			// cmdBCompute
			// 
			this.cmdBCompute.AllowDrop = true;
			this.cmdBCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdBCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdBCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdBCompute.Location = new System.Drawing.Point(38, 112);
			this.cmdBCompute.Name = "cmdBCompute";
			this.cmdBCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdBCompute.Size = new System.Drawing.Size(81, 25);
			this.cmdBCompute.TabIndex = 14;
			this.cmdBCompute.Text = "Compute";
			this.cmdBCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdBCompute.UseVisualStyleBackColor = false;
			this.cmdBCompute.Click += new System.EventHandler(this.cmdBCompute_Click);
			// 
			// txtBDay
			// 
			this.txtBDay.AcceptsReturn = true;
			this.txtBDay.AllowDrop = true;
			this.txtBDay.BackColor = System.Drawing.SystemColors.Window;
			this.txtBDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBDay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBDay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBDay.Location = new System.Drawing.Point(16, 80);
			this.txtBDay.MaxLength = 0;
			this.txtBDay.Name = "txtBDay";
			this.txtBDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBDay.Size = new System.Drawing.Size(33, 28);
			this.txtBDay.TabIndex = 13;
			this.txtBDay.Text = "BD";
			this.txtBDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBDay_KeyDown);
			this.txtBDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDay_KeyPress);
			// 
			// txtBYear
			// 
			this.txtBYear.AcceptsReturn = true;
			this.txtBYear.AllowDrop = true;
			this.txtBYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtBYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBYear.Location = new System.Drawing.Point(40, 16);
			this.txtBYear.MaxLength = 0;
			this.txtBYear.Name = "txtBYear";
			this.txtBYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBYear.Size = new System.Drawing.Size(73, 25);
			this.txtBYear.TabIndex = 11;
			this.txtBYear.Text = "BYear";
			this.txtBYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBYear_KeyDown);
			this.txtBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBYear_KeyPress);
			// 
			// txtBMonth
			// 
			this.txtBMonth.AcceptsReturn = true;
			this.txtBMonth.AllowDrop = true;
			this.txtBMonth.BackColor = System.Drawing.SystemColors.Window;
			this.txtBMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtBMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBMonth.Location = new System.Drawing.Point(32, 48);
			this.txtBMonth.MaxLength = 0;
			this.txtBMonth.Name = "txtBMonth";
			this.txtBMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtBMonth.Size = new System.Drawing.Size(89, 25);
			this.txtBMonth.TabIndex = 12;
			this.txtBMonth.Text = "BMonth";
			this.txtBMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBMonth.Click += new System.EventHandler(this.txtBMonth_Click);
			this.txtBMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBMonth_KeyDown);
			// 
			// lblBDayOfWeek
			// 
			this.lblBDayOfWeek.AllowDrop = true;
			this.lblBDayOfWeek.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
			this.lblBDayOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblBDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblBDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBDayOfWeek.Location = new System.Drawing.Point(56, 80);
			this.lblBDayOfWeek.Name = "lblBDayOfWeek";
			this.lblBDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblBDayOfWeek.Size = new System.Drawing.Size(81, 25);
			this.lblBDayOfWeek.TabIndex = 39;
			this.lblBDayOfWeek.Text = "Sabbath";
			this.lblBDayOfWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// fraJulian
			// 
			this.fraJulian.AllowDrop = true;
			this.fraJulian.BackColor = System.Drawing.Color.Yellow;
			this.fraJulian.Controls.Add(this.cmdJCompute);
			this.fraJulian.Controls.Add(this.txtJDCount);
			this.fraJulian.Enabled = true;
			this.fraJulian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraJulian.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraJulian.Location = new System.Drawing.Point(8, 192);
			this.fraJulian.Name = "fraJulian";
			this.fraJulian.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraJulian.Size = new System.Drawing.Size(193, 97);
			this.fraJulian.TabIndex = 27;
			this.fraJulian.Text = "Julian Day Count";
			this.fraJulian.Visible = true;
			// 
			// cmdJCompute
			// 
			this.cmdJCompute.AllowDrop = true;
			this.cmdJCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdJCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdJCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdJCompute.Location = new System.Drawing.Point(64, 56);
			this.cmdJCompute.Name = "cmdJCompute";
			this.cmdJCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdJCompute.Size = new System.Drawing.Size(65, 25);
			this.cmdJCompute.TabIndex = 6;
			this.cmdJCompute.Text = "Compute";
			this.cmdJCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdJCompute.UseVisualStyleBackColor = false;
			this.cmdJCompute.Click += new System.EventHandler(this.cmdJCompute_Click);
			// 
			// txtJDCount
			// 
			this.txtJDCount.AcceptsReturn = true;
			this.txtJDCount.AllowDrop = true;
			this.txtJDCount.BackColor = System.Drawing.SystemColors.Window;
			this.txtJDCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtJDCount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtJDCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtJDCount.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtJDCount.Location = new System.Drawing.Point(24, 24);
			this.txtJDCount.MaxLength = 0;
			this.txtJDCount.Name = "txtJDCount";
			this.txtJDCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtJDCount.Size = new System.Drawing.Size(145, 25);
			this.txtJDCount.TabIndex = 5;
			this.txtJDCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJDCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJDCount_KeyDown);
			this.txtJDCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJDCount_KeyPress);
			// 
			// fraHebrew
			// 
			this.fraHebrew.AllowDrop = true;
			this.fraHebrew.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
			this.fraHebrew.Controls.Add(this.chkOnTop);
			this.fraHebrew.Controls.Add(this.lstHMonth);
			this.fraHebrew.Controls.Add(this.txtHMonth);
			this.fraHebrew.Controls.Add(this.cmdHCompute);
			this.fraHebrew.Controls.Add(this.txtHYear);
			this.fraHebrew.Controls.Add(this.txtHDay);
			this.fraHebrew.Controls.Add(this.lblHDay);
			this.fraHebrew.Controls.Add(this.lblTabInd);
			this.fraHebrew.Controls.Add(this.lblRules);
			this.fraHebrew.Controls.Add(this.lblMolad1);
			this.fraHebrew.Controls.Add(this.lblMolad);
			this.fraHebrew.Controls.Add(this.lblHYearType);
			this.fraHebrew.Enabled = true;
			this.fraHebrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraHebrew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraHebrew.Location = new System.Drawing.Point(496, 8);
			this.fraHebrew.Name = "fraHebrew";
			this.fraHebrew.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraHebrew.Size = new System.Drawing.Size(201, 281);
			this.fraHebrew.TabIndex = 26;
			this.fraHebrew.Text = "Hebrew - Rabbinic";
			this.fraHebrew.Visible = true;
			// 
			// chkOnTop
			// 
			this.chkOnTop.AllowDrop = true;
			this.chkOnTop.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkOnTop.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
			this.chkOnTop.CausesValidation = true;
			this.chkOnTop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkOnTop.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkOnTop.Enabled = true;
			this.chkOnTop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkOnTop.Location = new System.Drawing.Point(182, 8);
			this.chkOnTop.Name = "chkOnTop";
			this.chkOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkOnTop.Size = new System.Drawing.Size(17, 17);
			this.chkOnTop.TabIndex = 24;
			this.chkOnTop.TabStop = true;
			this.chkOnTop.Text = "";
			this.chkOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkOnTop.Visible = true;
			this.chkOnTop.CheckStateChanged += new System.EventHandler(this.chkOnTop_CheckStateChanged);
			this.chkOnTop.Enter += new System.EventHandler(this.chkOnTop_Enter);
			this.chkOnTop.Leave += new System.EventHandler(this.chkOnTop_Leave);
			// 
			// lstHMonth
			// 
			this.lstHMonth.AllowDrop = true;
			this.lstHMonth.BackColor = System.Drawing.SystemColors.Window;
			this.lstHMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstHMonth.CausesValidation = true;
			this.lstHMonth.Enabled = true;
			this.lstHMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstHMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstHMonth.IntegralHeight = true;
			this.lstHMonth.Location = new System.Drawing.Point(48, 96);
			this.lstHMonth.MultiColumn = false;
			this.lstHMonth.Name = "lstHMonth";
			this.lstHMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lstHMonth.Size = new System.Drawing.Size(97, 176);
			this.lstHMonth.Sorted = false;
			this.lstHMonth.TabIndex = 0;
			this.lstHMonth.TabStop = false;
			this.lstHMonth.Visible = false;
			this.lstHMonth.SelectedIndexChanged += new System.EventHandler(this.lstHMonth_SelectedIndexChanged);
			// 
			// txtHMonth
			// 
			this.txtHMonth.AcceptsReturn = true;
			this.txtHMonth.AllowDrop = true;
			this.txtHMonth.BackColor = System.Drawing.SystemColors.Window;
			this.txtHMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHMonth.Location = new System.Drawing.Point(45, 176);
			this.txtHMonth.MaxLength = 0;
			this.txtHMonth.Name = "txtHMonth";
			this.txtHMonth.ReadOnly = true;
			this.txtHMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHMonth.Size = new System.Drawing.Size(105, 28);
			this.txtHMonth.TabIndex = 21;
			this.txtHMonth.Text = "HMonth";
			this.txtHMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHMonth.Click += new System.EventHandler(this.txtHMonth_Click);
			this.txtHMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHMonth_KeyDown);
			// 
			// cmdHCompute
			// 
			this.cmdHCompute.AllowDrop = true;
			this.cmdHCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdHCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdHCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdHCompute.Location = new System.Drawing.Point(64, 240);
			this.cmdHCompute.Name = "cmdHCompute";
			this.cmdHCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdHCompute.Size = new System.Drawing.Size(65, 25);
			this.cmdHCompute.TabIndex = 23;
			this.cmdHCompute.Text = "Compute";
			this.cmdHCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdHCompute.UseVisualStyleBackColor = false;
			this.cmdHCompute.Click += new System.EventHandler(this.cmdHCompute_Click);
			// 
			// txtHYear
			// 
			this.txtHYear.AcceptsReturn = true;
			this.txtHYear.AllowDrop = true;
			this.txtHYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtHYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHYear.Location = new System.Drawing.Point(68, 144);
			this.txtHYear.MaxLength = 0;
			this.txtHYear.Name = "txtHYear";
			this.txtHYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHYear.Size = new System.Drawing.Size(57, 28);
			this.txtHYear.TabIndex = 20;
			this.txtHYear.Text = "HYear";
			this.txtHYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHYear_KeyDown);
			this.txtHYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHYear_KeyPress);
			// 
			// txtHDay
			// 
			this.txtHDay.AcceptsReturn = true;
			this.txtHDay.AllowDrop = true;
			this.txtHDay.BackColor = System.Drawing.SystemColors.Window;
			this.txtHDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHDay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtHDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHDay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHDay.Location = new System.Drawing.Point(45, 208);
			this.txtHDay.MaxLength = 0;
			this.txtHDay.Name = "txtHDay";
			this.txtHDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtHDay.Size = new System.Drawing.Size(33, 28);
			this.txtHDay.TabIndex = 22;
			this.txtHDay.Text = "HD";
			this.txtHDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtHDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHDay_KeyDown);
			this.txtHDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHDay_KeyPress);
			// 
			// lblHDay
			// 
			this.lblHDay.AllowDrop = true;
			this.lblHDay.BackColor = System.Drawing.Color.Lime;
			this.lblHDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblHDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblHDay.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblHDay.Location = new System.Drawing.Point(88, 208);
			this.lblHDay.Name = "lblHDay";
			this.lblHDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHDay.Size = new System.Drawing.Size(81, 25);
			this.lblHDay.TabIndex = 101;
			this.lblHDay.Text = "DOW";
			this.lblHDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblTabInd
			// 
			this.lblTabInd.AllowDrop = true;
			this.lblTabInd.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
			this.lblTabInd.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTabInd.Font = new System.Drawing.Font("Courier New", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTabInd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTabInd.Location = new System.Drawing.Point(168, 8);
			this.lblTabInd.Name = "lblTabInd";
			this.lblTabInd.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTabInd.Size = new System.Drawing.Size(17, 17);
			this.lblTabInd.TabIndex = 35;
			this.lblTabInd.Text = "*";
			this.lblTabInd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblTabInd.Visible = false;
			// 
			// lblRules
			// 
			this.lblRules.AllowDrop = true;
			this.lblRules.BackColor = System.Drawing.Color.Lime;
			this.lblRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblRules.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblRules.Location = new System.Drawing.Point(24, 104);
			this.lblRules.Name = "lblRules";
			this.lblRules.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblRules.Size = new System.Drawing.Size(137, 25);
			this.lblRules.TabIndex = 33;
			this.lblRules.Text = "Rules";
			this.lblRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblMolad1
			// 
			this.lblMolad1.AllowDrop = true;
			this.lblMolad1.BackColor = System.Drawing.Color.Lime;
			this.lblMolad1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblMolad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblMolad1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMolad1.Location = new System.Drawing.Point(24, 48);
			this.lblMolad1.Name = "lblMolad1";
			this.lblMolad1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMolad1.Size = new System.Drawing.Size(137, 25);
			this.lblMolad1.TabIndex = 32;
			this.lblMolad1.Text = "Label1";
			this.lblMolad1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblMolad
			// 
			this.lblMolad.AllowDrop = true;
			this.lblMolad.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
			this.lblMolad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblMolad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblMolad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblMolad.Location = new System.Drawing.Point(32, 72);
			this.lblMolad.Name = "lblMolad";
			this.lblMolad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMolad.Size = new System.Drawing.Size(121, 17);
			this.lblMolad.TabIndex = 31;
			this.lblMolad.Text = "Molad of Tishri";
			this.lblMolad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblHYearType
			// 
			this.lblHYearType.AllowDrop = true;
			this.lblHYearType.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
			this.lblHYearType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblHYearType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblHYearType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblHYearType.Location = new System.Drawing.Point(8, 24);
			this.lblHYearType.Name = "lblHYearType";
			this.lblHYearType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHYearType.Size = new System.Drawing.Size(185, 17);
			this.lblHYearType.TabIndex = 28;
			this.lblHYearType.Text = "Year Type";
			this.lblHYearType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// fraGregorian
			// 
			this.fraGregorian.AllowDrop = true;
			this.fraGregorian.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.fraGregorian.Controls.Add(this.lstGMonth);
			this.fraGregorian.Controls.Add(this.txtGMonth);
			this.fraGregorian.Controls.Add(this.cmdGCompute);
			this.fraGregorian.Controls.Add(this.txtGYear);
			this.fraGregorian.Controls.Add(this.txtGDay);
			this.fraGregorian.Controls.Add(this.lblGDayOfWeek);
			this.fraGregorian.Controls.Add(this.lblGYearType);
			this.fraGregorian.Enabled = true;
			this.fraGregorian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.fraGregorian.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fraGregorian.Location = new System.Drawing.Point(8, 8);
			this.fraGregorian.Name = "fraGregorian";
			this.fraGregorian.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fraGregorian.Size = new System.Drawing.Size(193, 177);
			this.fraGregorian.TabIndex = 25;
			this.fraGregorian.Text = "Gregorian";
			this.fraGregorian.Visible = true;
			// 
			// lstGMonth
			// 
			this.lstGMonth.AllowDrop = true;
			this.lstGMonth.BackColor = System.Drawing.SystemColors.Window;
			this.lstGMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstGMonth.CausesValidation = true;
			this.lstGMonth.Enabled = true;
			this.lstGMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstGMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstGMonth.IntegralHeight = true;
			this.lstGMonth.Location = new System.Drawing.Point(48, 8);
			this.lstGMonth.MultiColumn = false;
			this.lstGMonth.Name = "lstGMonth";
			this.lstGMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lstGMonth.Size = new System.Drawing.Size(89, 163);
			this.lstGMonth.Sorted = false;
			this.lstGMonth.TabIndex = 38;
			this.lstGMonth.TabStop = true;
			this.lstGMonth.Visible = true;
			this.lstGMonth.SelectedIndexChanged += new System.EventHandler(this.lstGMonth_SelectedIndexChanged);
			// 
			// txtGMonth
			// 
			this.txtGMonth.AcceptsReturn = true;
			this.txtGMonth.AllowDrop = true;
			this.txtGMonth.BackColor = System.Drawing.SystemColors.Window;
			this.txtGMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtGMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGMonth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGMonth.Location = new System.Drawing.Point(48, 72);
			this.txtGMonth.MaxLength = 0;
			this.txtGMonth.Name = "txtGMonth";
			this.txtGMonth.ReadOnly = true;
			this.txtGMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGMonth.Size = new System.Drawing.Size(97, 25);
			this.txtGMonth.TabIndex = 2;
			this.txtGMonth.Text = "January";
			this.txtGMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGMonth.Click += new System.EventHandler(this.txtGMonth_Click);
			this.txtGMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGMonth_KeyDown);
			// 
			// cmdGCompute
			// 
			this.cmdGCompute.AllowDrop = true;
			this.cmdGCompute.BackColor = System.Drawing.SystemColors.Control;
			this.cmdGCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdGCompute.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdGCompute.Location = new System.Drawing.Point(64, 136);
			this.cmdGCompute.Name = "cmdGCompute";
			this.cmdGCompute.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdGCompute.Size = new System.Drawing.Size(65, 25);
			this.cmdGCompute.TabIndex = 4;
			this.cmdGCompute.Text = "Compute";
			this.cmdGCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdGCompute.UseVisualStyleBackColor = false;
			this.cmdGCompute.Click += new System.EventHandler(this.cmdGCompute_Click);
			// 
			// txtGYear
			// 
			this.txtGYear.AcceptsReturn = true;
			this.txtGYear.AllowDrop = true;
			this.txtGYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtGYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtGYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGYear.Location = new System.Drawing.Point(68, 40);
			this.txtGYear.MaxLength = 0;
			this.txtGYear.Name = "txtGYear";
			this.txtGYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGYear.Size = new System.Drawing.Size(57, 28);
			this.txtGYear.TabIndex = 1;
			this.txtGYear.Text = "2006";
			this.txtGYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGYear_KeyDown);
			this.txtGYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGYear_KeyPress);
			// 
			// txtGDay
			// 
			this.txtGDay.AcceptsReturn = true;
			this.txtGDay.AllowDrop = true;
			this.txtGDay.BackColor = System.Drawing.SystemColors.Window;
			this.txtGDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtGDay.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGDay.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGDay.Location = new System.Drawing.Point(40, 104);
			this.txtGDay.MaxLength = 0;
			this.txtGDay.Name = "txtGDay";
			this.txtGDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGDay.Size = new System.Drawing.Size(33, 25);
			this.txtGDay.TabIndex = 3;
			this.txtGDay.Text = "1";
			this.txtGDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGDay_KeyDown);
			this.txtGDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGDay_KeyPress);
			// 
			// lblGDayOfWeek
			// 
			this.lblGDayOfWeek.AllowDrop = true;
			this.lblGDayOfWeek.BackColor = System.Drawing.Color.FromArgb(255, 192, 255);
			this.lblGDayOfWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblGDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblGDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblGDayOfWeek.Location = new System.Drawing.Point(80, 104);
			this.lblGDayOfWeek.Name = "lblGDayOfWeek";
			this.lblGDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblGDayOfWeek.Size = new System.Drawing.Size(97, 25);
			this.lblGDayOfWeek.TabIndex = 30;
			this.lblGDayOfWeek.Text = "DOW";
			this.lblGDayOfWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblGYearType
			// 
			this.lblGYearType.AllowDrop = true;
			this.lblGYearType.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
			this.lblGYearType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblGYearType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblGYearType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblGYearType.Location = new System.Drawing.Point(24, 16);
			this.lblGYearType.Name = "lblGYearType";
			this.lblGYearType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblGYearType.Size = new System.Drawing.Size(145, 17);
			this.lblGYearType.TabIndex = 29;
			this.lblGYearType.Text = "Year Type";
			this.lblGYearType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmConversion
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(703, 296);
			this.Controls.Add(this.lstJCMonth);
			this.Controls.Add(this.fraMoon);
			this.Controls.Add(this.fraJulianCal);
			this.Controls.Add(this.txtControl);
			this.Controls.Add(this.fraBiblical);
			this.Controls.Add(this.fraJulian);
			this.Controls.Add(this.fraHebrew);
			this.Controls.Add(this.fraGregorian);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmConversion.Icon");
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(3, 29);
			this.MaximizeBox = false;
			this.MinimizeBox = true;
			this.Name = "frmConversion";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Conversions   (F1 for Help)";
			this.listBoxHelper1.SetSelectionMode(this.lstJCMonth, System.Windows.Forms.SelectionMode.One);
			this.listBoxHelper1.SetSelectionMode(this.lstBMonth, System.Windows.Forms.SelectionMode.One);
			this.listBoxHelper1.SetSelectionMode(this.lstHMonth, System.Windows.Forms.SelectionMode.One);
			this.listBoxHelper1.SetSelectionMode(this.lstGMonth, System.Windows.Forms.SelectionMode.One);
			this.ToolTipMain.SetToolTip(this.txtJCDay, "Julian day number (-1000 to 1000)");
			this.ToolTipMain.SetToolTip(this.txtJCMonth, "Select Julian month name.");
			this.ToolTipMain.SetToolTip(this.txtJCYear, "Julian Year (-4500 to 29000)");
			this.ToolTipMain.SetToolTip(this.lstBMonth, "Select Biblical month name");
			this.ToolTipMain.SetToolTip(this.optDate4, "Fourth possible date");
			this.ToolTipMain.SetToolTip(this.optDate3, "Third possible date");
			this.ToolTipMain.SetToolTip(this.optDate2, "Second possible date");
			this.ToolTipMain.SetToolTip(this.optDate1, "First possible date");
			this.ToolTipMain.SetToolTip(this.cmdCriteria, "Show Visibility and Harvest Criteria");
			this.ToolTipMain.SetToolTip(this.cmdBCompute, "Compute results");
			this.ToolTipMain.SetToolTip(this.txtBDay, "Biblical day number (-1000 to 1000)");
			this.ToolTipMain.SetToolTip(this.txtBYear, "Biblical Year (-496 to 33004)");
			this.ToolTipMain.SetToolTip(this.txtBMonth, "Select Biblical month name");
			this.ToolTipMain.SetToolTip(this.lblBDayOfWeek, "Displays the Biblical Day of the Week name.");
			this.ToolTipMain.SetToolTip(this.cmdJCompute, "Compute results");
			this.ToolTipMain.SetToolTip(this.txtJDCount, "Julian Day Count  (78166.5 to 12313456.5)");
			this.ToolTipMain.SetToolTip(this.chkOnTop, "Make this window stay on top of others");
			this.ToolTipMain.SetToolTip(this.lstHMonth, "Select Hebrew month name");
			this.ToolTipMain.SetToolTip(this.txtHMonth, "Select Hebrew month name");
			this.ToolTipMain.SetToolTip(this.cmdHCompute, "Compute results");
			this.ToolTipMain.SetToolTip(this.txtHYear, "Hebrew Year (-739 to 32760) ");
			this.ToolTipMain.SetToolTip(this.txtHDay, "Hebrew Day number (-1000 to 1000)");
			this.ToolTipMain.SetToolTip(this.lblHDay, "Displays the Rabbinic Day of the Week name.");
			this.ToolTipMain.SetToolTip(this.lblRules, "Displays Postponement Rules Used");
			this.ToolTipMain.SetToolTip(this.lblMolad1, "Displays Molad of Tishri");
			this.ToolTipMain.SetToolTip(this.lblHYearType, "Type of Hebrew Year");
			this.ToolTipMain.SetToolTip(this.lstGMonth, "Select Gregorian month name");
			this.ToolTipMain.SetToolTip(this.txtGMonth, "Select Gregorian  month name");
			this.ToolTipMain.SetToolTip(this.cmdGCompute, "Compute results");
			this.ToolTipMain.SetToolTip(this.txtGYear, "Gregorian Year (-4500 to 29000)");
			this.ToolTipMain.SetToolTip(this.txtGDay, "Gregorian day number (-1000 to 1000)");
			this.ToolTipMain.SetToolTip(this.lblGDayOfWeek, "Displays the Gregorian  Day of the Week name.");
			this.Activated += new System.EventHandler(this.frmConversion_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.fraMoon.ResumeLayout(false);
			this.fraJulianCal.ResumeLayout(false);
			this.fraBiblical.ResumeLayout(false);
			this.fraJulian.ResumeLayout(false);
			this.fraHebrew.ResumeLayout(false);
			this.fraGregorian.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializepicMoon();
		}
		void InitializepicMoon()
		{
			this.picMoon = new System.Windows.Forms.PictureBox[59];
			this.picMoon[58] = _picMoon_58;
			this.picMoon[57] = _picMoon_57;
			this.picMoon[56] = _picMoon_56;
			this.picMoon[55] = _picMoon_55;
			this.picMoon[54] = _picMoon_54;
			this.picMoon[53] = _picMoon_53;
			this.picMoon[52] = _picMoon_52;
			this.picMoon[51] = _picMoon_51;
			this.picMoon[50] = _picMoon_50;
			this.picMoon[49] = _picMoon_49;
			this.picMoon[48] = _picMoon_48;
			this.picMoon[47] = _picMoon_47;
			this.picMoon[46] = _picMoon_46;
			this.picMoon[45] = _picMoon_45;
			this.picMoon[44] = _picMoon_44;
			this.picMoon[43] = _picMoon_43;
			this.picMoon[42] = _picMoon_42;
			this.picMoon[41] = _picMoon_41;
			this.picMoon[40] = _picMoon_40;
			this.picMoon[39] = _picMoon_39;
			this.picMoon[38] = _picMoon_38;
			this.picMoon[37] = _picMoon_37;
			this.picMoon[36] = _picMoon_36;
			this.picMoon[35] = _picMoon_35;
			this.picMoon[34] = _picMoon_34;
			this.picMoon[33] = _picMoon_33;
			this.picMoon[32] = _picMoon_32;
			this.picMoon[31] = _picMoon_31;
			this.picMoon[30] = _picMoon_30;
			this.picMoon[29] = _picMoon_29;
			this.picMoon[28] = _picMoon_28;
			this.picMoon[27] = _picMoon_27;
			this.picMoon[26] = _picMoon_26;
			this.picMoon[25] = _picMoon_25;
			this.picMoon[24] = _picMoon_24;
			this.picMoon[23] = _picMoon_23;
			this.picMoon[22] = _picMoon_22;
			this.picMoon[21] = _picMoon_21;
			this.picMoon[20] = _picMoon_20;
			this.picMoon[19] = _picMoon_19;
			this.picMoon[18] = _picMoon_18;
			this.picMoon[17] = _picMoon_17;
			this.picMoon[16] = _picMoon_16;
			this.picMoon[15] = _picMoon_15;
			this.picMoon[14] = _picMoon_14;
			this.picMoon[13] = _picMoon_13;
			this.picMoon[12] = _picMoon_12;
			this.picMoon[11] = _picMoon_11;
			this.picMoon[10] = _picMoon_10;
			this.picMoon[9] = _picMoon_9;
			this.picMoon[8] = _picMoon_8;
			this.picMoon[7] = _picMoon_7;
			this.picMoon[6] = _picMoon_6;
			this.picMoon[5] = _picMoon_5;
			this.picMoon[4] = _picMoon_4;
			this.picMoon[3] = _picMoon_3;
			this.picMoon[2] = _picMoon_2;
			this.picMoon[1] = _picMoon_1;
			this.picMoon[0] = _picMoon_0;
		}
		#endregion
	}
}