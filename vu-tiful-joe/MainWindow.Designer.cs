namespace vu_tiful_joe
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.UpdateVU1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.UpdateFreq_VU1 = new Int32TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.VAR_VU1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.LED_VU1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Max_VU1 = new Int32TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Min_VU1 = new Int32TextBox();
			this.React_VU1 = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.UpdateVU2 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.VAR_VU2 = new System.Windows.Forms.Label();
			this.UpdateFreq_VU2 = new Int32TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LED_VU2 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Max_VU2 = new Int32TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Min_VU2 = new Int32TextBox();
			this.React_VU2 = new System.Windows.Forms.ComboBox();
			this.HideWindow = new System.Windows.Forms.Button();
			this.Quit = new System.Windows.Forms.Button();
			this.SaveCFG = new System.Windows.Forms.Button();
			this.LoadCFG = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.SystemTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.SystemTrayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuStrip_VU1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_VU2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuStrip_ShowApp = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip_QuitApp = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.Timer_VU1 = new System.Windows.Forms.Timer(this.components);
			this.Timer_VU2 = new System.Windows.Forms.Timer(this.components);
			this.ArduinoInterface = new System.IO.Ports.SerialPort(this.components);
			this.label14 = new System.Windows.Forms.Label();
			this.ComPort = new System.Windows.Forms.TextBox();
			this.ComStatus = new System.Windows.Forms.Label();
			this.StartHidden = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SystemTrayContext.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.UpdateVU1);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.UpdateFreq_VU1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.VAR_VU1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.LED_VU1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.Max_VU1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Min_VU1);
			this.groupBox1.Controls.Add(this.React_VU1);
			this.groupBox1.Location = new System.Drawing.Point(164, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(215, 165);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Meter 1";
			// 
			// UpdateVU1
			// 
			this.UpdateVU1.Location = new System.Drawing.Point(136, 96);
			this.UpdateVU1.Name = "UpdateVU1";
			this.UpdateVU1.Size = new System.Drawing.Size(60, 23);
			this.UpdateVU1.TabIndex = 19;
			this.UpdateVU1.Text = "Update";
			this.UpdateVU1.UseVisualStyleBackColor = true;
			this.UpdateVU1.Click += new System.EventHandler(this.UpdateVU1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(133, 124);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 16;
			this.label10.Text = "msecs";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// UpdateFreq_VU1
			// 
			this.UpdateFreq_VU1.Location = new System.Drawing.Point(86, 121);
			this.UpdateFreq_VU1.Name = "UpdateFreq_VU1";
			this.UpdateFreq_VU1.Size = new System.Drawing.Size(41, 20);
			this.UpdateFreq_VU1.TabIndex = 15;
			this.UpdateFreq_VU1.Text = "25";
			this.UpdateFreq_VU1.TextChanged += new System.EventHandler(this.UpdateFreq_VU1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Update every:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// VAR_VU1
			// 
			this.VAR_VU1.AutoSize = true;
			this.VAR_VU1.Location = new System.Drawing.Point(86, 101);
			this.VAR_VU1.Name = "VAR_VU1";
			this.VAR_VU1.Size = new System.Drawing.Size(29, 13);
			this.VAR_VU1.TabIndex = 12;
			this.VAR_VU1.Text = "VAR";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Current Value:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LED_VU1
			// 
			this.LED_VU1.AutoSize = true;
			this.LED_VU1.Checked = true;
			this.LED_VU1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LED_VU1.Location = new System.Drawing.Point(86, 75);
			this.LED_VU1.Name = "LED_VU1";
			this.LED_VU1.Size = new System.Drawing.Size(64, 17);
			this.LED_VU1.TabIndex = 9;
			this.LED_VU1.Text = "LED On";
			this.LED_VU1.UseVisualStyleBackColor = true;
			this.LED_VU1.CheckedChanged += new System.EventHandler(this.LED_VU1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "React To:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Max_VU1
			// 
			this.Max_VU1.Location = new System.Drawing.Point(155, 19);
			this.Max_VU1.Name = "Max_VU1";
			this.Max_VU1.Size = new System.Drawing.Size(41, 20);
			this.Max_VU1.TabIndex = 5;
			this.Max_VU1.Text = "60";
			this.Max_VU1.TextChanged += new System.EventHandler(this.Max_VU1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "to";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Output Range:";
			// 
			// Min_VU1
			// 
			this.Min_VU1.Location = new System.Drawing.Point(86, 19);
			this.Min_VU1.Name = "Min_VU1";
			this.Min_VU1.Size = new System.Drawing.Size(41, 20);
			this.Min_VU1.TabIndex = 2;
			this.Min_VU1.Text = "0";
			this.Min_VU1.TextChanged += new System.EventHandler(this.Min_VU1_TextChanged);
			// 
			// React_VU1
			// 
			this.React_VU1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.React_VU1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.React_VU1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.React_VU1.FormattingEnabled = true;
			this.React_VU1.Items.AddRange(new object[] {
            "CPU",
            "RAM",
            "GPU_TEMP",
            "GPU_LOAD",
            "SOUND_LVL",
            "SOUND_VOL"});
			this.React_VU1.Location = new System.Drawing.Point(86, 45);
			this.React_VU1.Name = "React_VU1";
			this.React_VU1.Size = new System.Drawing.Size(110, 21);
			this.React_VU1.TabIndex = 1;
			this.React_VU1.SelectedIndexChanged += new System.EventHandler(this.React_VU1_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.UpdateVU2);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.VAR_VU2);
			this.groupBox2.Controls.Add(this.UpdateFreq_VU2);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.LED_VU2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.Max_VU2);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.Min_VU2);
			this.groupBox2.Controls.Add(this.React_VU2);
			this.groupBox2.Location = new System.Drawing.Point(385, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(215, 165);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Meter 2";
			// 
			// UpdateVU2
			// 
			this.UpdateVU2.Location = new System.Drawing.Point(136, 96);
			this.UpdateVU2.Name = "UpdateVU2";
			this.UpdateVU2.Size = new System.Drawing.Size(60, 23);
			this.UpdateVU2.TabIndex = 20;
			this.UpdateVU2.Text = "Update";
			this.UpdateVU2.UseVisualStyleBackColor = true;
			this.UpdateVU2.Click += new System.EventHandler(this.UpdateVU2_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(133, 127);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "msecs";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// VAR_VU2
			// 
			this.VAR_VU2.AutoSize = true;
			this.VAR_VU2.Location = new System.Drawing.Point(86, 101);
			this.VAR_VU2.Name = "VAR_VU2";
			this.VAR_VU2.Size = new System.Drawing.Size(29, 13);
			this.VAR_VU2.TabIndex = 12;
			this.VAR_VU2.Text = "VAR";
			// 
			// UpdateFreq_VU2
			// 
			this.UpdateFreq_VU2.Location = new System.Drawing.Point(86, 124);
			this.UpdateFreq_VU2.Name = "UpdateFreq_VU2";
			this.UpdateFreq_VU2.Size = new System.Drawing.Size(41, 20);
			this.UpdateFreq_VU2.TabIndex = 18;
			this.UpdateFreq_VU2.Text = "25";
			this.UpdateFreq_VU2.TextChanged += new System.EventHandler(this.UpdateFreq_VU2_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 127);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(74, 13);
			this.label12.TabIndex = 17;
			this.label12.Text = "Update every:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Current Value:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// LED_VU2
			// 
			this.LED_VU2.AutoSize = true;
			this.LED_VU2.Checked = true;
			this.LED_VU2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LED_VU2.Location = new System.Drawing.Point(86, 75);
			this.LED_VU2.Name = "LED_VU2";
			this.LED_VU2.Size = new System.Drawing.Size(64, 17);
			this.LED_VU2.TabIndex = 9;
			this.LED_VU2.Text = "LED On";
			this.LED_VU2.UseVisualStyleBackColor = true;
			this.LED_VU2.CheckedChanged += new System.EventHandler(this.LED_VU2_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "React To:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Max_VU2
			// 
			this.Max_VU2.Location = new System.Drawing.Point(155, 19);
			this.Max_VU2.Name = "Max_VU2";
			this.Max_VU2.Size = new System.Drawing.Size(41, 20);
			this.Max_VU2.TabIndex = 5;
			this.Max_VU2.Text = "60";
			this.Max_VU2.TextChanged += new System.EventHandler(this.Max_VU2_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(133, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "to";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Output Range:";
			// 
			// Min_VU2
			// 
			this.Min_VU2.Location = new System.Drawing.Point(86, 19);
			this.Min_VU2.Name = "Min_VU2";
			this.Min_VU2.Size = new System.Drawing.Size(41, 20);
			this.Min_VU2.TabIndex = 2;
			this.Min_VU2.Text = "0";
			this.Min_VU2.TextChanged += new System.EventHandler(this.Min_VU2_TextChanged);
			// 
			// React_VU2
			// 
			this.React_VU2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.React_VU2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.React_VU2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.React_VU2.FormattingEnabled = true;
			this.React_VU2.Items.AddRange(new object[] {
            "CPU",
            "RAM",
            "GPU_TEMP",
            "GPU_LOAD",
            "SOUND_LVL",
            "SOUND_VOL"});
			this.React_VU2.Location = new System.Drawing.Point(86, 45);
			this.React_VU2.Name = "React_VU2";
			this.React_VU2.Size = new System.Drawing.Size(110, 21);
			this.React_VU2.TabIndex = 1;
			this.React_VU2.SelectedIndexChanged += new System.EventHandler(this.React_VU2_SelectedIndexChanged);
			// 
			// HideWindow
			// 
			this.HideWindow.Location = new System.Drawing.Point(385, 183);
			this.HideWindow.Name = "HideWindow";
			this.HideWindow.Size = new System.Drawing.Size(60, 23);
			this.HideWindow.TabIndex = 14;
			this.HideWindow.Text = "Hide";
			this.HideWindow.UseVisualStyleBackColor = true;
			this.HideWindow.Click += new System.EventHandler(this.HideWindow_Click);
			// 
			// Quit
			// 
			this.Quit.Location = new System.Drawing.Point(540, 183);
			this.Quit.Name = "Quit";
			this.Quit.Size = new System.Drawing.Size(60, 23);
			this.Quit.TabIndex = 15;
			this.Quit.Text = "Quit";
			this.Quit.UseVisualStyleBackColor = true;
			this.Quit.Click += new System.EventHandler(this.Quit_Click);
			// 
			// SaveCFG
			// 
			this.SaveCFG.Location = new System.Drawing.Point(268, 183);
			this.SaveCFG.Name = "SaveCFG";
			this.SaveCFG.Size = new System.Drawing.Size(61, 23);
			this.SaveCFG.TabIndex = 17;
			this.SaveCFG.Text = "Save";
			this.SaveCFG.UseVisualStyleBackColor = true;
			this.SaveCFG.Click += new System.EventHandler(this.SaveCFG_Click);
			// 
			// LoadCFG
			// 
			this.LoadCFG.Location = new System.Drawing.Point(201, 183);
			this.LoadCFG.Name = "LoadCFG";
			this.LoadCFG.Size = new System.Drawing.Size(61, 23);
			this.LoadCFG.TabIndex = 18;
			this.LoadCFG.Text = "Load";
			this.LoadCFG.UseVisualStyleBackColor = true;
			this.LoadCFG.Click += new System.EventHandler(this.LoadCFG_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(167, 188);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(31, 13);
			this.label13.TabIndex = 17;
			this.label13.Text = "CFG:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// SystemTray
			// 
			this.SystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.SystemTray.BalloonTipText = "Hello!";
			this.SystemTray.BalloonTipTitle = "VUtiful Joe";
			this.SystemTray.ContextMenuStrip = this.SystemTrayContext;
			this.SystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTray.Icon")));
			this.SystemTray.Text = "VUtiful Joe";
			this.SystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTray_MouseDoubleClick);
			// 
			// SystemTrayContext
			// 
			this.SystemTrayContext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SystemTrayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_VU1,
            this.MenuStrip_VU2,
            this.toolStripSeparator1,
            this.MenuStrip_ShowApp,
            this.MenuStrip_QuitApp});
			this.SystemTrayContext.Name = "SystemTrayContext";
			this.SystemTrayContext.Size = new System.Drawing.Size(151, 98);
			// 
			// MenuStrip_VU1
			// 
			this.MenuStrip_VU1.Enabled = false;
			this.MenuStrip_VU1.Name = "MenuStrip_VU1";
			this.MenuStrip_VU1.Size = new System.Drawing.Size(150, 22);
			this.MenuStrip_VU1.Text = "VU1:";
			// 
			// MenuStrip_VU2
			// 
			this.MenuStrip_VU2.Enabled = false;
			this.MenuStrip_VU2.Name = "MenuStrip_VU2";
			this.MenuStrip_VU2.Size = new System.Drawing.Size(150, 22);
			this.MenuStrip_VU2.Text = "VU2: ";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
			// 
			// MenuStrip_ShowApp
			// 
			this.MenuStrip_ShowApp.Name = "MenuStrip_ShowApp";
			this.MenuStrip_ShowApp.Size = new System.Drawing.Size(150, 22);
			this.MenuStrip_ShowApp.Text = "Show Window";
			this.MenuStrip_ShowApp.Click += new System.EventHandler(this.ShowWindow_Click);
			// 
			// MenuStrip_QuitApp
			// 
			this.MenuStrip_QuitApp.Name = "MenuStrip_QuitApp";
			this.MenuStrip_QuitApp.Size = new System.Drawing.Size(150, 22);
			this.MenuStrip_QuitApp.Text = "Quit";
			this.MenuStrip_QuitApp.Click += new System.EventHandler(this.Quit_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(146, 165);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "VUtiful Joe";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 114);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(2, 136);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(138, 26);
			this.label20.TabIndex = 3;
			this.label20.Text = "VUtiful Joe by Sam Morris\r\nArduino VU Meter Controller\r\n";
			// 
			// Timer_VU1
			// 
			this.Timer_VU1.Tick += new System.EventHandler(this.Timer_VU1_Tick);
			// 
			// Timer_VU2
			// 
			this.Timer_VU2.Tick += new System.EventHandler(this.Timer_VU2_Tick);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(15, 186);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 13);
			this.label14.TabIndex = 20;
			this.label14.Text = "Port:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ComPort
			// 
			this.ComPort.Location = new System.Drawing.Point(50, 183);
			this.ComPort.Name = "ComPort";
			this.ComPort.Size = new System.Drawing.Size(39, 20);
			this.ComPort.TabIndex = 20;
			this.ComPort.Text = "COM1";
			this.ComPort.TextChanged += new System.EventHandler(this.ComPort_TextChanged);
			// 
			// ComStatus
			// 
			this.ComStatus.AutoSize = true;
			this.ComStatus.Location = new System.Drawing.Point(95, 186);
			this.ComStatus.Name = "ComStatus";
			this.ComStatus.Size = new System.Drawing.Size(0, 13);
			this.ComStatus.TabIndex = 21;
			this.ComStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// StartHidden
			// 
			this.StartHidden.AutoSize = true;
			this.StartHidden.Location = new System.Drawing.Point(448, 187);
			this.StartHidden.Name = "StartHidden";
			this.StartHidden.Size = new System.Drawing.Size(85, 17);
			this.StartHidden.TabIndex = 20;
			this.StartHidden.Text = "Start Hidden";
			this.StartHidden.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 212);
			this.Controls.Add(this.StartHidden);
			this.Controls.Add(this.ComStatus);
			this.Controls.Add(this.ComPort);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.LoadCFG);
			this.Controls.Add(this.SaveCFG);
			this.Controls.Add(this.Quit);
			this.Controls.Add(this.HideWindow);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "VUtiful Joe";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.SystemTrayContext.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
		private Int32TextBox UpdateFreq_VU1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VAR_VU1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox LED_VU1;
        private System.Windows.Forms.Label label3;
		private Int32TextBox Max_VU1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private Int32TextBox Min_VU1;
        private System.Windows.Forms.ComboBox React_VU1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label VAR_VU2;
		private Int32TextBox UpdateFreq_VU2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox LED_VU2;
        private System.Windows.Forms.Label label7;
		private Int32TextBox Max_VU2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Int32TextBox Min_VU2;
        private System.Windows.Forms.ComboBox React_VU2;
        private System.Windows.Forms.Button HideWindow;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button SaveCFG;
        private System.Windows.Forms.Button LoadCFG;
        private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button UpdateVU1;
		private System.Windows.Forms.NotifyIcon SystemTray;
		private System.Windows.Forms.Button UpdateVU2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ContextMenuStrip SystemTrayContext;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_ShowApp;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_QuitApp;
		private System.Windows.Forms.Timer Timer_VU1;
		private System.Windows.Forms.Timer Timer_VU2;
		private System.IO.Ports.SerialPort ArduinoInterface;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox ComPort;
		private System.Windows.Forms.Label ComStatus;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_VU1;
		private System.Windows.Forms.ToolStripMenuItem MenuStrip_VU2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.CheckBox StartHidden;


    }
}