
namespace L2ARAutomationSerialPort
{
    partial class FormSerialPortAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPortAutomation));
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBoundRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.buttonOpenDrawer = new System.Windows.Forms.Button();
            this.buttonCloseDrawer = new System.Windows.Forms.Button();
            this.buttonUpClip = new System.Windows.Forms.Button();
            this.buttonDownClip = new System.Windows.Forms.Button();
            this.buttonUSBIn = new System.Windows.Forms.Button();
            this.buttonUSBOut = new System.Windows.Forms.Button();
            this.buttonP3In = new System.Windows.Forms.Button();
            this.buttonP3Out = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelL2ARCommands = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageL2AR = new System.Windows.Forms.TabPage();
            this.grBxPower = new System.Windows.Forms.GroupBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.comboBoxVolt = new System.Windows.Forms.ComboBox();
            this.btnPowerSupply = new System.Windows.Forms.Button();
            this.comboBoxCurr = new System.Windows.Forms.ComboBox();
            this.grBxAction = new System.Windows.Forms.GroupBox();
            this.btnSenEnd = new System.Windows.Forms.Button();
            this.LckClose = new System.Windows.Forms.Button();
            this.LckOpen = new System.Windows.Forms.Button();
            this.grBxConfig = new System.Windows.Forms.GroupBox();
            this.btnUSBOff = new System.Windows.Forms.Button();
            this.btnUSBOn = new System.Windows.Forms.Button();
            this.buttonHeadSetOn = new System.Windows.Forms.Button();
            this.buttonHeadSetOff = new System.Windows.Forms.Button();
            this.tabPageDepth = new System.Windows.Forms.TabPage();
            this.labelDepthCommands = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonDistance30 = new System.Windows.Forms.Button();
            this.buttonDistance25 = new System.Windows.Forms.Button();
            this.buttonOrigin = new System.Windows.Forms.Button();
            this.tabPageL2Vision = new System.Windows.Forms.TabPage();
            this.groupBoxLightSourceConfig = new System.Windows.Forms.GroupBox();
            this.labelFreq = new System.Windows.Forms.Label();
            this.textBoxBrightnessSet = new System.Windows.Forms.TextBox();
            this.comboBoxSetLightSource = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxColorSet = new System.Windows.Forms.TextBox();
            this.btnSendLightSource = new System.Windows.Forms.Button();
            this.btnGetLightModel = new System.Windows.Forms.Button();
            this.btnGetLigthVendor = new System.Windows.Forms.Button();
            this.btnStopLightSource01 = new System.Windows.Forms.Button();
            this.btnStartLightSourceFreq01 = new System.Windows.Forms.Button();
            this.btnGetLightSource01 = new System.Windows.Forms.Button();
            this.btnGetLightSourceFreq01 = new System.Windows.Forms.Button();
            this.btnGetLightSourceSerialNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSqt = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDrStatus = new System.Windows.Forms.Button();
            this.buttonUnlockDr = new System.Windows.Forms.Button();
            this.buttonLockDr = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.tabPageRGB = new System.Windows.Forms.TabPage();
            this.buttonFetl = new System.Windows.Forms.Button();
            this.buttonLightOff = new System.Windows.Forms.Button();
            this.buttonLightOn = new System.Windows.Forms.Button();
            this.buttonDownRGB = new System.Windows.Forms.Button();
            this.buttonUpRGB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageL2AR.SuspendLayout();
            this.grBxPower.SuspendLayout();
            this.grBxAction.SuspendLayout();
            this.grBxConfig.SuspendLayout();
            this.tabPageDepth.SuspendLayout();
            this.tabPageL2Vision.SuspendLayout();
            this.groupBoxLightSourceConfig.SuspendLayout();
            this.tabPageSqt.SuspendLayout();
            this.tabPageRGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(64, 45);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(59, 20);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Portas:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(30, 95);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(94, 20);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate: ";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(40, 152);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(79, 20);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(40, 209);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(82, 20);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits: ";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(160, 45);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts.TabIndex = 6;
            this.comboBoxPorts.Text = "COM2";
            // 
            // comboBoxBoundRate
            // 
            this.comboBoxBoundRate.FormattingEnabled = true;
            this.comboBoxBoundRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBoundRate.Location = new System.Drawing.Point(160, 92);
            this.comboBoxBoundRate.Name = "comboBoxBoundRate";
            this.comboBoxBoundRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBoundRate.TabIndex = 7;
            this.comboBoxBoundRate.Text = "9600";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(160, 152);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataBits.TabIndex = 8;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(160, 209);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStopBits.TabIndex = 9;
            this.comboBoxStopBits.Text = "One";
            // 
            // buttonOpenDrawer
            // 
            this.buttonOpenDrawer.Location = new System.Drawing.Point(27, 112);
            this.buttonOpenDrawer.Name = "buttonOpenDrawer";
            this.buttonOpenDrawer.Size = new System.Drawing.Size(105, 62);
            this.buttonOpenDrawer.TabIndex = 12;
            this.buttonOpenDrawer.Text = "Open";
            this.buttonOpenDrawer.UseVisualStyleBackColor = true;
            this.buttonOpenDrawer.Click += new System.EventHandler(this.buttonOpenDrawer_Click);
            // 
            // buttonCloseDrawer
            // 
            this.buttonCloseDrawer.Location = new System.Drawing.Point(138, 112);
            this.buttonCloseDrawer.Name = "buttonCloseDrawer";
            this.buttonCloseDrawer.Size = new System.Drawing.Size(105, 62);
            this.buttonCloseDrawer.TabIndex = 13;
            this.buttonCloseDrawer.Text = "Close";
            this.buttonCloseDrawer.UseVisualStyleBackColor = true;
            this.buttonCloseDrawer.Click += new System.EventHandler(this.buttonCloseDrawer_Click);
            // 
            // buttonUpClip
            // 
            this.buttonUpClip.Location = new System.Drawing.Point(27, 180);
            this.buttonUpClip.Name = "buttonUpClip";
            this.buttonUpClip.Size = new System.Drawing.Size(105, 62);
            this.buttonUpClip.TabIndex = 14;
            this.buttonUpClip.Text = "Up Clip";
            this.buttonUpClip.UseVisualStyleBackColor = true;
            this.buttonUpClip.Click += new System.EventHandler(this.buttonUpClip_Click);
            // 
            // buttonDownClip
            // 
            this.buttonDownClip.Location = new System.Drawing.Point(138, 180);
            this.buttonDownClip.Name = "buttonDownClip";
            this.buttonDownClip.Size = new System.Drawing.Size(105, 62);
            this.buttonDownClip.TabIndex = 15;
            this.buttonDownClip.Text = "Down Clip";
            this.buttonDownClip.UseVisualStyleBackColor = true;
            this.buttonDownClip.Click += new System.EventHandler(this.buttonDownClip_Click);
            // 
            // buttonUSBIn
            // 
            this.buttonUSBIn.Location = new System.Drawing.Point(27, 251);
            this.buttonUSBIn.Name = "buttonUSBIn";
            this.buttonUSBIn.Size = new System.Drawing.Size(105, 62);
            this.buttonUSBIn.TabIndex = 16;
            this.buttonUSBIn.Text = "USB IN";
            this.buttonUSBIn.UseVisualStyleBackColor = true;
            this.buttonUSBIn.Click += new System.EventHandler(this.buttonUSBIn_Click);
            // 
            // buttonUSBOut
            // 
            this.buttonUSBOut.Location = new System.Drawing.Point(138, 251);
            this.buttonUSBOut.Name = "buttonUSBOut";
            this.buttonUSBOut.Size = new System.Drawing.Size(105, 62);
            this.buttonUSBOut.TabIndex = 17;
            this.buttonUSBOut.Text = "USB OUT";
            this.buttonUSBOut.UseVisualStyleBackColor = true;
            this.buttonUSBOut.Click += new System.EventHandler(this.buttonUSBOut_Click);
            // 
            // buttonP3In
            // 
            this.buttonP3In.Location = new System.Drawing.Point(27, 320);
            this.buttonP3In.Name = "buttonP3In";
            this.buttonP3In.Size = new System.Drawing.Size(105, 62);
            this.buttonP3In.TabIndex = 18;
            this.buttonP3In.Text = "P3 IN";
            this.buttonP3In.UseVisualStyleBackColor = true;
            this.buttonP3In.Click += new System.EventHandler(this.buttonP3In_Click);
            // 
            // buttonP3Out
            // 
            this.buttonP3Out.Location = new System.Drawing.Point(138, 320);
            this.buttonP3Out.Name = "buttonP3Out";
            this.buttonP3Out.Size = new System.Drawing.Size(105, 62);
            this.buttonP3Out.TabIndex = 19;
            this.buttonP3Out.Text = "P3 OUT";
            this.buttonP3Out.UseVisualStyleBackColor = true;
            this.buttonP3Out.Click += new System.EventHandler(this.buttonP3Out_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(14, 345);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(355, 233);
            this.textBoxResult.TabIndex = 22;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(272, 589);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 31);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.Location = new System.Drawing.Point(21, 43);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(105, 62);
            this.buttonAudio.TabIndex = 25;
            this.buttonAudio.Text = "AUDIO";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(132, 43);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(105, 62);
            this.buttonRadio.TabIndex = 26;
            this.buttonRadio.Text = "RADIO";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 286);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(106, 52);
            this.buttonSend.TabIndex = 27;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(126, 309);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(242, 26);
            this.textBoxSend.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(297, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 40);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelName.Location = new System.Drawing.Point(9, 595);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 17);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Developed by Matheus.Paiva";
            // 
            // labelL2ARCommands
            // 
            this.labelL2ARCommands.AutoSize = true;
            this.labelL2ARCommands.BackColor = System.Drawing.Color.SteelBlue;
            this.labelL2ARCommands.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelL2ARCommands.Location = new System.Drawing.Point(62, 0);
            this.labelL2ARCommands.Name = "labelL2ARCommands";
            this.labelL2ARCommands.Size = new System.Drawing.Size(344, 20);
            this.labelL2ARCommands.TabIndex = 31;
            this.labelL2ARCommands.Text = "                        L2AR COMMANDS                         ";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageL2AR);
            this.tabControlMain.Controls.Add(this.tabPageDepth);
            this.tabControlMain.Controls.Add(this.tabPageL2Vision);
            this.tabControlMain.Controls.Add(this.tabPageSqt);
            this.tabControlMain.Controls.Add(this.tabPageRGB);
            this.tabControlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMain.ItemSize = new System.Drawing.Size(54, 25);
            this.tabControlMain.Location = new System.Drawing.Point(398, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(584, 608);
            this.tabControlMain.TabIndex = 32;
            // 
            // tabPageL2AR
            // 
            this.tabPageL2AR.BackColor = System.Drawing.Color.Transparent;
            this.tabPageL2AR.Controls.Add(this.grBxPower);
            this.tabPageL2AR.Controls.Add(this.grBxAction);
            this.tabPageL2AR.Controls.Add(this.grBxConfig);
            this.tabPageL2AR.Controls.Add(this.labelL2ARCommands);
            this.tabPageL2AR.ForeColor = System.Drawing.Color.Black;
            this.tabPageL2AR.Location = new System.Drawing.Point(4, 29);
            this.tabPageL2AR.Name = "tabPageL2AR";
            this.tabPageL2AR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageL2AR.Size = new System.Drawing.Size(576, 575);
            this.tabPageL2AR.TabIndex = 0;
            this.tabPageL2AR.Text = "L2AR";
            // 
            // grBxPower
            // 
            this.grBxPower.Controls.Add(this.textBoxAddress);
            this.grBxPower.Controls.Add(this.labelAddress);
            this.grBxPower.Controls.Add(this.labelC);
            this.grBxPower.Controls.Add(this.labelV);
            this.grBxPower.Controls.Add(this.comboBoxVolt);
            this.grBxPower.Controls.Add(this.btnPowerSupply);
            this.grBxPower.Controls.Add(this.comboBoxCurr);
            this.grBxPower.Location = new System.Drawing.Point(294, 298);
            this.grBxPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxPower.Name = "grBxPower";
            this.grBxPower.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxPower.Size = new System.Drawing.Size(254, 245);
            this.grBxPower.TabIndex = 40;
            this.grBxPower.TabStop = false;
            this.grBxPower.Text = "Accessory Power Supply";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(16, 57);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(214, 26);
            this.textBoxAddress.TabIndex = 6;
            this.textBoxAddress.Text = "GPIB0::9::INSTR";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 28);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(172, 20);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address Power Supply:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(124, 105);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(66, 20);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Current:";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(15, 105);
            this.labelV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(68, 20);
            this.labelV.TabIndex = 3;
            this.labelV.Text = "Voltage:";
            // 
            // comboBoxVolt
            // 
            this.comboBoxVolt.FormattingEnabled = true;
            this.comboBoxVolt.Items.AddRange(new object[] {
            "5.0",
            "5.2",
            "5.4",
            "5.6",
            "5.8"});
            this.comboBoxVolt.Location = new System.Drawing.Point(14, 134);
            this.comboBoxVolt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxVolt.Name = "comboBoxVolt";
            this.comboBoxVolt.Size = new System.Drawing.Size(103, 28);
            this.comboBoxVolt.TabIndex = 2;
            this.comboBoxVolt.Text = "5.0";
            // 
            // btnPowerSupply
            // 
            this.btnPowerSupply.Location = new System.Drawing.Point(40, 183);
            this.btnPowerSupply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPowerSupply.Name = "btnPowerSupply";
            this.btnPowerSupply.Size = new System.Drawing.Size(154, 43);
            this.btnPowerSupply.TabIndex = 1;
            this.btnPowerSupply.Text = "Set Power Supply";
            this.btnPowerSupply.UseVisualStyleBackColor = true;
            this.btnPowerSupply.Click += new System.EventHandler(this.btnPowerSupply_Click);
            // 
            // comboBoxCurr
            // 
            this.comboBoxCurr.FormattingEnabled = true;
            this.comboBoxCurr.Items.AddRange(new object[] {
            "1.0",
            "1.2",
            "1.4",
            "1.6"});
            this.comboBoxCurr.Location = new System.Drawing.Point(129, 134);
            this.comboBoxCurr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCurr.Name = "comboBoxCurr";
            this.comboBoxCurr.Size = new System.Drawing.Size(103, 28);
            this.comboBoxCurr.TabIndex = 0;
            this.comboBoxCurr.Text = "1.0";
            // 
            // grBxAction
            // 
            this.grBxAction.Controls.Add(this.btnSenEnd);
            this.grBxAction.Controls.Add(this.LckClose);
            this.grBxAction.Controls.Add(this.buttonUSBIn);
            this.grBxAction.Controls.Add(this.buttonUSBOut);
            this.grBxAction.Controls.Add(this.LckOpen);
            this.grBxAction.Controls.Add(this.buttonDownClip);
            this.grBxAction.Controls.Add(this.buttonOpenDrawer);
            this.grBxAction.Controls.Add(this.buttonP3In);
            this.grBxAction.Controls.Add(this.buttonUpClip);
            this.grBxAction.Controls.Add(this.buttonCloseDrawer);
            this.grBxAction.Controls.Add(this.buttonP3Out);
            this.grBxAction.Location = new System.Drawing.Point(8, 25);
            this.grBxAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxAction.Name = "grBxAction";
            this.grBxAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxAction.Size = new System.Drawing.Size(273, 468);
            this.grBxAction.TabIndex = 39;
            this.grBxAction.TabStop = false;
            this.grBxAction.Text = "Action commands";
            // 
            // btnSenEnd
            // 
            this.btnSenEnd.Location = new System.Drawing.Point(27, 388);
            this.btnSenEnd.Name = "btnSenEnd";
            this.btnSenEnd.Size = new System.Drawing.Size(216, 62);
            this.btnSenEnd.TabIndex = 38;
            this.btnSenEnd.Text = "HEADSET SEND/END";
            this.btnSenEnd.UseVisualStyleBackColor = true;
            this.btnSenEnd.Click += new System.EventHandler(this.btnSenEnd_Click);
            // 
            // LckClose
            // 
            this.LckClose.Location = new System.Drawing.Point(138, 45);
            this.LckClose.Name = "LckClose";
            this.LckClose.Size = new System.Drawing.Size(105, 62);
            this.LckClose.TabIndex = 35;
            this.LckClose.Text = "Locker Close";
            this.LckClose.UseVisualStyleBackColor = true;
            this.LckClose.Click += new System.EventHandler(this.LckClose_Click);
            // 
            // LckOpen
            // 
            this.LckOpen.Location = new System.Drawing.Point(27, 45);
            this.LckOpen.Name = "LckOpen";
            this.LckOpen.Size = new System.Drawing.Size(105, 62);
            this.LckOpen.TabIndex = 34;
            this.LckOpen.Text = "Locker Open";
            this.LckOpen.UseVisualStyleBackColor = true;
            this.LckOpen.Click += new System.EventHandler(this.LckOpen_Click);
            // 
            // grBxConfig
            // 
            this.grBxConfig.Controls.Add(this.buttonAudio);
            this.grBxConfig.Controls.Add(this.btnUSBOff);
            this.grBxConfig.Controls.Add(this.buttonRadio);
            this.grBxConfig.Controls.Add(this.btnUSBOn);
            this.grBxConfig.Controls.Add(this.buttonHeadSetOn);
            this.grBxConfig.Controls.Add(this.buttonHeadSetOff);
            this.grBxConfig.Location = new System.Drawing.Point(290, 25);
            this.grBxConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxConfig.Name = "grBxConfig";
            this.grBxConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBxConfig.Size = new System.Drawing.Size(261, 266);
            this.grBxConfig.TabIndex = 38;
            this.grBxConfig.TabStop = false;
            this.grBxConfig.Text = "Configuration commands";
            // 
            // btnUSBOff
            // 
            this.btnUSBOff.Location = new System.Drawing.Point(132, 177);
            this.btnUSBOff.Name = "btnUSBOff";
            this.btnUSBOff.Size = new System.Drawing.Size(105, 62);
            this.btnUSBOff.TabIndex = 37;
            this.btnUSBOff.Text = "USB OFF";
            this.btnUSBOff.UseVisualStyleBackColor = true;
            this.btnUSBOff.Click += new System.EventHandler(this.btnUSBOff_Click);
            // 
            // btnUSBOn
            // 
            this.btnUSBOn.Location = new System.Drawing.Point(21, 177);
            this.btnUSBOn.Name = "btnUSBOn";
            this.btnUSBOn.Size = new System.Drawing.Size(105, 62);
            this.btnUSBOn.TabIndex = 36;
            this.btnUSBOn.Text = "USB ON";
            this.btnUSBOn.UseVisualStyleBackColor = true;
            this.btnUSBOn.Click += new System.EventHandler(this.btnUSBOn_Click);
            // 
            // buttonHeadSetOn
            // 
            this.buttonHeadSetOn.Location = new System.Drawing.Point(21, 112);
            this.buttonHeadSetOn.Name = "buttonHeadSetOn";
            this.buttonHeadSetOn.Size = new System.Drawing.Size(105, 62);
            this.buttonHeadSetOn.TabIndex = 32;
            this.buttonHeadSetOn.Text = "HEADSET ON";
            this.buttonHeadSetOn.UseVisualStyleBackColor = true;
            this.buttonHeadSetOn.Click += new System.EventHandler(this.buttonHeadSetOn_Click);
            // 
            // buttonHeadSetOff
            // 
            this.buttonHeadSetOff.Location = new System.Drawing.Point(132, 112);
            this.buttonHeadSetOff.Name = "buttonHeadSetOff";
            this.buttonHeadSetOff.Size = new System.Drawing.Size(105, 62);
            this.buttonHeadSetOff.TabIndex = 33;
            this.buttonHeadSetOff.Text = "HEADSET OFF";
            this.buttonHeadSetOff.UseVisualStyleBackColor = true;
            this.buttonHeadSetOff.Click += new System.EventHandler(this.buttonHeadSetOff_Click);
            // 
            // tabPageDepth
            // 
            this.tabPageDepth.Controls.Add(this.labelDepthCommands);
            this.tabPageDepth.Controls.Add(this.buttonDown);
            this.tabPageDepth.Controls.Add(this.buttonUP);
            this.tabPageDepth.Controls.Add(this.buttonStatus);
            this.tabPageDepth.Controls.Add(this.buttonDistance30);
            this.tabPageDepth.Controls.Add(this.buttonDistance25);
            this.tabPageDepth.Controls.Add(this.buttonOrigin);
            this.tabPageDepth.ForeColor = System.Drawing.Color.Black;
            this.tabPageDepth.Location = new System.Drawing.Point(4, 29);
            this.tabPageDepth.Name = "tabPageDepth";
            this.tabPageDepth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepth.Size = new System.Drawing.Size(576, 575);
            this.tabPageDepth.TabIndex = 1;
            this.tabPageDepth.Text = "DEPTH";
            this.tabPageDepth.UseVisualStyleBackColor = true;
            // 
            // labelDepthCommands
            // 
            this.labelDepthCommands.AutoSize = true;
            this.labelDepthCommands.BackColor = System.Drawing.Color.SteelBlue;
            this.labelDepthCommands.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelDepthCommands.Location = new System.Drawing.Point(58, 0);
            this.labelDepthCommands.Name = "labelDepthCommands";
            this.labelDepthCommands.Size = new System.Drawing.Size(357, 20);
            this.labelDepthCommands.TabIndex = 49;
            this.labelDepthCommands.Text = "                        DEPTH COMMANDS                         ";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(292, 197);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(114, 62);
            this.buttonDown.TabIndex = 48;
            this.buttonDown.Text = "Chart_down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(171, 197);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(114, 62);
            this.buttonUP.TabIndex = 47;
            this.buttonUP.Text = "Chart_up";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(50, 197);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(114, 62);
            this.buttonStatus.TabIndex = 46;
            this.buttonStatus.Text = "STATUS";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonDistance30
            // 
            this.buttonDistance30.Location = new System.Drawing.Point(292, 131);
            this.buttonDistance30.Name = "buttonDistance30";
            this.buttonDistance30.Size = new System.Drawing.Size(114, 62);
            this.buttonDistance30.TabIndex = 45;
            this.buttonDistance30.Text = "Distance_30";
            this.buttonDistance30.UseVisualStyleBackColor = true;
            this.buttonDistance30.Click += new System.EventHandler(this.buttonDistance30_Click);
            // 
            // buttonDistance25
            // 
            this.buttonDistance25.Location = new System.Drawing.Point(171, 131);
            this.buttonDistance25.Name = "buttonDistance25";
            this.buttonDistance25.Size = new System.Drawing.Size(114, 62);
            this.buttonDistance25.TabIndex = 44;
            this.buttonDistance25.Text = "Distance_25";
            this.buttonDistance25.UseVisualStyleBackColor = true;
            this.buttonDistance25.Click += new System.EventHandler(this.buttonDistance25_Click);
            // 
            // buttonOrigin
            // 
            this.buttonOrigin.Location = new System.Drawing.Point(50, 131);
            this.buttonOrigin.Name = "buttonOrigin";
            this.buttonOrigin.Size = new System.Drawing.Size(114, 62);
            this.buttonOrigin.TabIndex = 43;
            this.buttonOrigin.Text = "ORIGEM";
            this.buttonOrigin.UseVisualStyleBackColor = true;
            this.buttonOrigin.Click += new System.EventHandler(this.buttonOrigin_Click);
            // 
            // tabPageL2Vision
            // 
            this.tabPageL2Vision.Controls.Add(this.groupBoxLightSourceConfig);
            this.tabPageL2Vision.Controls.Add(this.btnGetLightModel);
            this.tabPageL2Vision.Controls.Add(this.btnGetLigthVendor);
            this.tabPageL2Vision.Controls.Add(this.btnStopLightSource01);
            this.tabPageL2Vision.Controls.Add(this.btnStartLightSourceFreq01);
            this.tabPageL2Vision.Controls.Add(this.btnGetLightSource01);
            this.tabPageL2Vision.Controls.Add(this.btnGetLightSourceFreq01);
            this.tabPageL2Vision.Controls.Add(this.btnGetLightSourceSerialNum);
            this.tabPageL2Vision.Controls.Add(this.label1);
            this.tabPageL2Vision.ForeColor = System.Drawing.Color.Black;
            this.tabPageL2Vision.Location = new System.Drawing.Point(4, 29);
            this.tabPageL2Vision.Name = "tabPageL2Vision";
            this.tabPageL2Vision.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageL2Vision.Size = new System.Drawing.Size(576, 575);
            this.tabPageL2Vision.TabIndex = 2;
            this.tabPageL2Vision.Text = "L2VISION";
            this.tabPageL2Vision.UseVisualStyleBackColor = true;
            // 
            // groupBoxLightSourceConfig
            // 
            this.groupBoxLightSourceConfig.Controls.Add(this.labelFreq);
            this.groupBoxLightSourceConfig.Controls.Add(this.textBoxBrightnessSet);
            this.groupBoxLightSourceConfig.Controls.Add(this.comboBoxSetLightSource);
            this.groupBoxLightSourceConfig.Controls.Add(this.label6);
            this.groupBoxLightSourceConfig.Controls.Add(this.textBoxFrequency);
            this.groupBoxLightSourceConfig.Controls.Add(this.label4);
            this.groupBoxLightSourceConfig.Controls.Add(this.label5);
            this.groupBoxLightSourceConfig.Controls.Add(this.textBoxColorSet);
            this.groupBoxLightSourceConfig.Controls.Add(this.btnSendLightSource);
            this.groupBoxLightSourceConfig.Location = new System.Drawing.Point(6, 280);
            this.groupBoxLightSourceConfig.Name = "groupBoxLightSourceConfig";
            this.groupBoxLightSourceConfig.Size = new System.Drawing.Size(564, 289);
            this.groupBoxLightSourceConfig.TabIndex = 68;
            this.groupBoxLightSourceConfig.TabStop = false;
            this.groupBoxLightSourceConfig.Text = "LightSource Config";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFreq.Location = new System.Drawing.Point(309, 96);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(84, 20);
            this.labelFreq.TabIndex = 68;
            this.labelFreq.Text = "Frequency";
            // 
            // textBoxBrightnessSet
            // 
            this.textBoxBrightnessSet.Location = new System.Drawing.Point(313, 56);
            this.textBoxBrightnessSet.Name = "textBoxBrightnessSet";
            this.textBoxBrightnessSet.Size = new System.Drawing.Size(100, 26);
            this.textBoxBrightnessSet.TabIndex = 61;
            // 
            // comboBoxSetLightSource
            // 
            this.comboBoxSetLightSource.FormattingEnabled = true;
            this.comboBoxSetLightSource.Items.AddRange(new object[] {
            "Set_LightSource_01_",
            "Set_LightSource_FREQ_01_"});
            this.comboBoxSetLightSource.Location = new System.Drawing.Point(1, 54);
            this.comboBoxSetLightSource.Name = "comboBoxSetLightSource";
            this.comboBoxSetLightSource.Size = new System.Drawing.Size(309, 28);
            this.comboBoxSetLightSource.TabIndex = 66;
            this.comboBoxSetLightSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetLightSource_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(-2, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "SetLightSource";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(313, 119);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(206, 26);
            this.textBoxFrequency.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(309, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "BRIGHT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(419, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "COLOR";
            // 
            // textBoxColorSet
            // 
            this.textBoxColorSet.Location = new System.Drawing.Point(419, 56);
            this.textBoxColorSet.Name = "textBoxColorSet";
            this.textBoxColorSet.Size = new System.Drawing.Size(100, 26);
            this.textBoxColorSet.TabIndex = 62;
            // 
            // btnSendLightSource
            // 
            this.btnSendLightSource.Location = new System.Drawing.Point(418, 161);
            this.btnSendLightSource.Name = "btnSendLightSource";
            this.btnSendLightSource.Size = new System.Drawing.Size(106, 39);
            this.btnSendLightSource.TabIndex = 63;
            this.btnSendLightSource.Text = "SEND";
            this.btnSendLightSource.UseVisualStyleBackColor = true;
            this.btnSendLightSource.Click += new System.EventHandler(this.btnSendLightSource_Click);
            // 
            // btnGetLightModel
            // 
            this.btnGetLightModel.Location = new System.Drawing.Point(20, 130);
            this.btnGetLightModel.Name = "btnGetLightModel";
            this.btnGetLightModel.Size = new System.Drawing.Size(162, 58);
            this.btnGetLightModel.TabIndex = 57;
            this.btnGetLightModel.Text = "Get-LightSource Model";
            this.btnGetLightModel.UseVisualStyleBackColor = true;
            this.btnGetLightModel.Click += new System.EventHandler(this.btnGetLightModel_Click);
            // 
            // btnGetLigthVendor
            // 
            this.btnGetLigthVendor.Location = new System.Drawing.Point(21, 51);
            this.btnGetLigthVendor.Name = "btnGetLigthVendor";
            this.btnGetLigthVendor.Size = new System.Drawing.Size(162, 58);
            this.btnGetLigthVendor.TabIndex = 56;
            this.btnGetLigthVendor.Text = "Get-LightSource Vendor";
            this.btnGetLigthVendor.UseVisualStyleBackColor = true;
            this.btnGetLigthVendor.Click += new System.EventHandler(this.btnGetLigthVendor_Click);
            // 
            // btnStopLightSource01
            // 
            this.btnStopLightSource01.Location = new System.Drawing.Point(200, 202);
            this.btnStopLightSource01.Name = "btnStopLightSource01";
            this.btnStopLightSource01.Size = new System.Drawing.Size(162, 58);
            this.btnStopLightSource01.TabIndex = 55;
            this.btnStopLightSource01.Text = "Stop-LightSource Freq-01";
            this.btnStopLightSource01.UseVisualStyleBackColor = true;
            this.btnStopLightSource01.Click += new System.EventHandler(this.btnStopLightSource01_Click);
            // 
            // btnStartLightSourceFreq01
            // 
            this.btnStartLightSourceFreq01.Location = new System.Drawing.Point(20, 202);
            this.btnStartLightSourceFreq01.Name = "btnStartLightSourceFreq01";
            this.btnStartLightSourceFreq01.Size = new System.Drawing.Size(162, 58);
            this.btnStartLightSourceFreq01.TabIndex = 54;
            this.btnStartLightSourceFreq01.Text = "Start-LigthSource Freq-01";
            this.btnStartLightSourceFreq01.UseVisualStyleBackColor = true;
            this.btnStartLightSourceFreq01.Click += new System.EventHandler(this.btnStartLightSourceFreq01_Click);
            // 
            // btnGetLightSource01
            // 
            this.btnGetLightSource01.Location = new System.Drawing.Point(200, 51);
            this.btnGetLightSource01.Name = "btnGetLightSource01";
            this.btnGetLightSource01.Size = new System.Drawing.Size(162, 62);
            this.btnGetLightSource01.TabIndex = 53;
            this.btnGetLightSource01.Text = "Get-LightSource_01";
            this.btnGetLightSource01.UseVisualStyleBackColor = true;
            this.btnGetLightSource01.Click += new System.EventHandler(this.btnGetLightSource01_Click);
            // 
            // btnGetLightSourceFreq01
            // 
            this.btnGetLightSourceFreq01.Location = new System.Drawing.Point(379, 51);
            this.btnGetLightSourceFreq01.Name = "btnGetLightSourceFreq01";
            this.btnGetLightSourceFreq01.Size = new System.Drawing.Size(162, 58);
            this.btnGetLightSourceFreq01.TabIndex = 52;
            this.btnGetLightSourceFreq01.Text = "Get-LightSource Freq-01";
            this.btnGetLightSourceFreq01.UseVisualStyleBackColor = true;
            this.btnGetLightSourceFreq01.Click += new System.EventHandler(this.btnGetLightSourceFreq01_Click);
            // 
            // btnGetLightSourceSerialNum
            // 
            this.btnGetLightSourceSerialNum.Location = new System.Drawing.Point(199, 130);
            this.btnGetLightSourceSerialNum.Name = "btnGetLightSourceSerialNum";
            this.btnGetLightSourceSerialNum.Size = new System.Drawing.Size(163, 58);
            this.btnGetLightSourceSerialNum.TabIndex = 51;
            this.btnGetLightSourceSerialNum.Text = "Get-LightSource SerialNum";
            this.btnGetLightSourceSerialNum.UseVisualStyleBackColor = true;
            this.btnGetLightSourceSerialNum.Click += new System.EventHandler(this.btnGetLightSourceSerialNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "                        L2VISION LIGHT PANEL COMMANDS                         ";
            // 
            // tabPageSqt
            // 
            this.tabPageSqt.Controls.Add(this.label2);
            this.tabPageSqt.Controls.Add(this.buttonDrStatus);
            this.tabPageSqt.Controls.Add(this.buttonUnlockDr);
            this.tabPageSqt.Controls.Add(this.buttonLockDr);
            this.tabPageSqt.Controls.Add(this.buttonMoveDown);
            this.tabPageSqt.Controls.Add(this.buttonMoveUp);
            this.tabPageSqt.ForeColor = System.Drawing.Color.Black;
            this.tabPageSqt.Location = new System.Drawing.Point(4, 29);
            this.tabPageSqt.Name = "tabPageSqt";
            this.tabPageSqt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSqt.Size = new System.Drawing.Size(576, 575);
            this.tabPageSqt.TabIndex = 3;
            this.tabPageSqt.Text = "SQT";
            this.tabPageSqt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(102, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "                           SQT COMMANDS                           ";
            // 
            // buttonDrStatus
            // 
            this.buttonDrStatus.Location = new System.Drawing.Point(211, 268);
            this.buttonDrStatus.Name = "buttonDrStatus";
            this.buttonDrStatus.Size = new System.Drawing.Size(114, 62);
            this.buttonDrStatus.TabIndex = 52;
            this.buttonDrStatus.Text = "DRAWER STATUS";
            this.buttonDrStatus.UseVisualStyleBackColor = true;
            this.buttonDrStatus.Click += new System.EventHandler(this.buttonDrStatus_Click);
            // 
            // buttonUnlockDr
            // 
            this.buttonUnlockDr.Location = new System.Drawing.Point(303, 169);
            this.buttonUnlockDr.Name = "buttonUnlockDr";
            this.buttonUnlockDr.Size = new System.Drawing.Size(114, 62);
            this.buttonUnlockDr.TabIndex = 51;
            this.buttonUnlockDr.Text = "UNLOCK DRAWER";
            this.buttonUnlockDr.UseVisualStyleBackColor = true;
            this.buttonUnlockDr.Click += new System.EventHandler(this.buttonUnlockDr_Click);
            // 
            // buttonLockDr
            // 
            this.buttonLockDr.Location = new System.Drawing.Point(127, 169);
            this.buttonLockDr.Name = "buttonLockDr";
            this.buttonLockDr.Size = new System.Drawing.Size(114, 62);
            this.buttonLockDr.TabIndex = 50;
            this.buttonLockDr.Text = "LOCK DRAWER";
            this.buttonLockDr.UseVisualStyleBackColor = true;
            this.buttonLockDr.Click += new System.EventHandler(this.buttonLockDr_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(303, 89);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(114, 62);
            this.buttonMoveDown.TabIndex = 49;
            this.buttonMoveDown.Text = "MOVE DOWN";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(127, 89);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(114, 62);
            this.buttonMoveUp.TabIndex = 48;
            this.buttonMoveUp.Text = "MOVE UP";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // tabPageRGB
            // 
            this.tabPageRGB.Controls.Add(this.buttonFetl);
            this.tabPageRGB.Controls.Add(this.buttonLightOff);
            this.tabPageRGB.Controls.Add(this.buttonLightOn);
            this.tabPageRGB.Controls.Add(this.buttonDownRGB);
            this.tabPageRGB.Controls.Add(this.buttonUpRGB);
            this.tabPageRGB.Controls.Add(this.label3);
            this.tabPageRGB.ForeColor = System.Drawing.Color.Black;
            this.tabPageRGB.Location = new System.Drawing.Point(4, 29);
            this.tabPageRGB.Name = "tabPageRGB";
            this.tabPageRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRGB.Size = new System.Drawing.Size(576, 575);
            this.tabPageRGB.TabIndex = 4;
            this.tabPageRGB.Text = "RGB";
            this.tabPageRGB.UseVisualStyleBackColor = true;
            // 
            // buttonFetl
            // 
            this.buttonFetl.Location = new System.Drawing.Point(185, 235);
            this.buttonFetl.Name = "buttonFetl";
            this.buttonFetl.Size = new System.Drawing.Size(116, 58);
            this.buttonFetl.TabIndex = 59;
            this.buttonFetl.Text = "LuxRead";
            this.buttonFetl.UseVisualStyleBackColor = true;
            this.buttonFetl.Click += new System.EventHandler(this.ButtonFetl_Click);
            // 
            // buttonLightOff
            // 
            this.buttonLightOff.Location = new System.Drawing.Point(252, 152);
            this.buttonLightOff.Name = "buttonLightOff";
            this.buttonLightOff.Size = new System.Drawing.Size(116, 58);
            this.buttonLightOff.TabIndex = 58;
            this.buttonLightOff.Text = "LIGHT_OFF";
            this.buttonLightOff.UseVisualStyleBackColor = true;
            this.buttonLightOff.Click += new System.EventHandler(this.buttonLightOff_Click);
            // 
            // buttonLightOn
            // 
            this.buttonLightOn.Location = new System.Drawing.Point(104, 152);
            this.buttonLightOn.Name = "buttonLightOn";
            this.buttonLightOn.Size = new System.Drawing.Size(116, 58);
            this.buttonLightOn.TabIndex = 57;
            this.buttonLightOn.Text = "LIGHT_ON";
            this.buttonLightOn.UseVisualStyleBackColor = true;
            this.buttonLightOn.Click += new System.EventHandler(this.buttonLightOn_Click);
            // 
            // buttonDownRGB
            // 
            this.buttonDownRGB.Location = new System.Drawing.Point(252, 74);
            this.buttonDownRGB.Name = "buttonDownRGB";
            this.buttonDownRGB.Size = new System.Drawing.Size(116, 58);
            this.buttonDownRGB.TabIndex = 56;
            this.buttonDownRGB.Text = "CLOSE";
            this.buttonDownRGB.UseVisualStyleBackColor = true;
            // 
            // buttonUpRGB
            // 
            this.buttonUpRGB.Location = new System.Drawing.Point(104, 74);
            this.buttonUpRGB.Name = "buttonUpRGB";
            this.buttonUpRGB.Size = new System.Drawing.Size(116, 58);
            this.buttonUpRGB.TabIndex = 55;
            this.buttonUpRGB.Text = "OPEN";
            this.buttonUpRGB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(57, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "                           RGB COMMANDS                           ";
            // 
            // FormSerialPortAutomation
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 643);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.comboBoxBoundRate);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormSerialPortAutomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Ports Automation v1.1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageL2AR.ResumeLayout(false);
            this.tabPageL2AR.PerformLayout();
            this.grBxPower.ResumeLayout(false);
            this.grBxPower.PerformLayout();
            this.grBxAction.ResumeLayout(false);
            this.grBxConfig.ResumeLayout(false);
            this.tabPageDepth.ResumeLayout(false);
            this.tabPageDepth.PerformLayout();
            this.tabPageL2Vision.ResumeLayout(false);
            this.tabPageL2Vision.PerformLayout();
            this.groupBoxLightSourceConfig.ResumeLayout(false);
            this.groupBoxLightSourceConfig.PerformLayout();
            this.tabPageSqt.ResumeLayout(false);
            this.tabPageSqt.PerformLayout();
            this.tabPageRGB.ResumeLayout(false);
            this.tabPageRGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        public System.Windows.Forms.ComboBox comboBoxPorts;
        public System.Windows.Forms.ComboBox comboBoxBoundRate;
        public System.Windows.Forms.ComboBox comboBoxDataBits;
        public System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button buttonOpenDrawer;
        private System.Windows.Forms.Button buttonCloseDrawer;
        private System.Windows.Forms.Button buttonUpClip;
        private System.Windows.Forms.Button buttonDownClip;
        private System.Windows.Forms.Button buttonUSBIn;
        private System.Windows.Forms.Button buttonUSBOut;
        private System.Windows.Forms.Button buttonP3In;
        private System.Windows.Forms.Button buttonP3Out;
        public System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelL2ARCommands;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageL2AR;
        private System.Windows.Forms.TabPage tabPageDepth;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonDistance30;
        private System.Windows.Forms.Button buttonDistance25;
        private System.Windows.Forms.Button buttonOrigin;
        private System.Windows.Forms.Label labelDepthCommands;
        private System.Windows.Forms.TabPage tabPageL2Vision;
        private System.Windows.Forms.TabPage tabPageSqt;
        private System.Windows.Forms.Button buttonHeadSetOff;
        private System.Windows.Forms.Button buttonHeadSetOn;
  
        private System.Windows.Forms.Button buttonDrStatus;
        private System.Windows.Forms.Button buttonUnlockDr;
        private System.Windows.Forms.Button buttonLockDr;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageRGB;
        private System.Windows.Forms.Button buttonLightOff;
        private System.Windows.Forms.Button buttonLightOn;
        private System.Windows.Forms.Button buttonDownRGB;
        private System.Windows.Forms.Button buttonUpRGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFetl;
        private System.Windows.Forms.Button LckClose;
        private System.Windows.Forms.Button LckOpen;
        private System.Windows.Forms.Button btnUSBOff;
        private System.Windows.Forms.Button btnUSBOn;
        private System.Windows.Forms.GroupBox grBxAction;
        private System.Windows.Forms.GroupBox grBxConfig;
        private System.Windows.Forms.Button btnSenEnd;
        private System.Windows.Forms.GroupBox grBxPower;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Button btnPowerSupply;
        private System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.ComboBox comboBoxCurr;
        public System.Windows.Forms.ComboBox comboBoxVolt;
        public System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button btnStopLightSource01;
        private System.Windows.Forms.Button btnStartLightSourceFreq01;
        private System.Windows.Forms.Button btnGetLightSource01;
        private System.Windows.Forms.Button btnGetLightSourceFreq01;
        private System.Windows.Forms.Button btnGetLightSourceSerialNum;
        private System.Windows.Forms.Button btnGetLightModel;
        private System.Windows.Forms.Button btnGetLigthVendor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendLightSource;
        private System.Windows.Forms.TextBox textBoxColorSet;
        private System.Windows.Forms.TextBox textBoxBrightnessSet;
        private System.Windows.Forms.ComboBox comboBoxSetLightSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxLightSourceConfig;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.Label labelFreq;
    }
}