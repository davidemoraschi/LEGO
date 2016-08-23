namespace NXT2EV3ControlApplication
{
    partial class NXT2EV3ControlApplicationForm
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
            this.ComPortPanel = new System.Windows.Forms.Panel();
            this.NXTComPortLabel = new System.Windows.Forms.Label();
            this.EV3ComPortLabel = new System.Windows.Forms.Label();
            this.NXTComPortText = new System.Windows.Forms.TextBox();
            this.EV3ComPortText = new System.Windows.Forms.TextBox();
            this.NXTComPortButton = new System.Windows.Forms.Button();
            this.EV3ComPortButton = new System.Windows.Forms.Button();
            this.NXTComPortConnected = new System.Windows.Forms.CheckBox();
            this.EV3ComPortConnected = new System.Windows.Forms.CheckBox();
            this.MailboxPanel = new System.Windows.Forms.Panel();
            this.Mailbox1Label = new System.Windows.Forms.Label();
            this.Mailbox1Active = new System.Windows.Forms.CheckBox();
            this.Mailbox1Type = new System.Windows.Forms.ComboBox();
            this.Mailbox2Label = new System.Windows.Forms.Label();
            this.Mailbox2Active = new System.Windows.Forms.CheckBox();
            this.Mailbox2Type = new System.Windows.Forms.ComboBox();
            this.Mailbox3Label = new System.Windows.Forms.Label();
            this.Mailbox3Active = new System.Windows.Forms.CheckBox();
            this.Mailbox3Type = new System.Windows.Forms.ComboBox();
            this.Mailbox4Label = new System.Windows.Forms.Label();
            this.Mailbox4Active = new System.Windows.Forms.CheckBox();
            this.Mailbox4Type = new System.Windows.Forms.ComboBox();
            this.Mailbox5Label = new System.Windows.Forms.Label();
            this.Mailbox5Active = new System.Windows.Forms.CheckBox();
            this.Mailbox5Type = new System.Windows.Forms.ComboBox();
            this.Mailbox6Label = new System.Windows.Forms.Label();
            this.Mailbox6Active = new System.Windows.Forms.CheckBox();
            this.Mailbox6Type = new System.Windows.Forms.ComboBox();
            this.Mailbox7Label = new System.Windows.Forms.Label();
            this.Mailbox7Active = new System.Windows.Forms.CheckBox();
            this.Mailbox7Type = new System.Windows.Forms.ComboBox();
            this.Mailbox8Label = new System.Windows.Forms.Label();
            this.Mailbox8Active = new System.Windows.Forms.CheckBox();
            this.Mailbox8Type = new System.Windows.Forms.ComboBox();
            this.Mailbox9Label = new System.Windows.Forms.Label();
            this.Mailbox9Active = new System.Windows.Forms.CheckBox();
            this.Mailbox9Type = new System.Windows.Forms.ComboBox();
            this.Mailbox10Label = new System.Windows.Forms.Label();
            this.Mailbox10Active = new System.Windows.Forms.CheckBox();
            this.Mailbox10Type = new System.Windows.Forms.ComboBox();
            this.ComPortPanelLabel = new System.Windows.Forms.Label();
            this.MailboxPanelLabel = new System.Windows.Forms.Label();
            this.ComPortPanel.SuspendLayout();
            this.MailboxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortPanel
            // 
            this.ComPortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComPortPanel.Controls.Add(this.NXTComPortLabel);
            this.ComPortPanel.Controls.Add(this.EV3ComPortLabel);
            this.ComPortPanel.Controls.Add(this.NXTComPortText);
            this.ComPortPanel.Controls.Add(this.EV3ComPortText);
            this.ComPortPanel.Controls.Add(this.NXTComPortButton);
            this.ComPortPanel.Controls.Add(this.EV3ComPortButton);
            this.ComPortPanel.Controls.Add(this.NXTComPortConnected);
            this.ComPortPanel.Controls.Add(this.EV3ComPortConnected);
            this.ComPortPanel.Location = new System.Drawing.Point(12, 14);
            this.ComPortPanel.Name = "ComPortPanel";
            this.ComPortPanel.Size = new System.Drawing.Size(468, 76);
            this.ComPortPanel.TabIndex = 0;
            // 
            // NXTComPortLabel
            // 
            this.NXTComPortLabel.AutoSize = true;
            this.NXTComPortLabel.Location = new System.Drawing.Point(13, 12);
            this.NXTComPortLabel.Name = "NXTComPortLabel";
            this.NXTComPortLabel.Size = new System.Drawing.Size(80, 13);
            this.NXTComPortLabel.TabIndex = 4;
            this.NXTComPortLabel.Text = "NXT COM port:";
            // 
            // EV3ComPortLabel
            // 
            this.EV3ComPortLabel.AutoSize = true;
            this.EV3ComPortLabel.Location = new System.Drawing.Point(13, 47);
            this.EV3ComPortLabel.Name = "EV3ComPortLabel";
            this.EV3ComPortLabel.Size = new System.Drawing.Size(78, 13);
            this.EV3ComPortLabel.TabIndex = 8;
            this.EV3ComPortLabel.Text = "EV3 COM port:";
            // 
            // NXTComPortText
            // 
            this.NXTComPortText.Location = new System.Drawing.Point(101, 9);
            this.NXTComPortText.Name = "NXTComPortText";
            this.NXTComPortText.Size = new System.Drawing.Size(88, 20);
            this.NXTComPortText.TabIndex = 5;
            this.NXTComPortText.Text = "COM5";
            // 
            // EV3ComPortText
            // 
            this.EV3ComPortText.Location = new System.Drawing.Point(101, 44);
            this.EV3ComPortText.Name = "EV3ComPortText";
            this.EV3ComPortText.Size = new System.Drawing.Size(88, 20);
            this.EV3ComPortText.TabIndex = 9;
            this.EV3ComPortText.Text = "COM6";
            // 
            // NXTComPortButton
            // 
            this.NXTComPortButton.Location = new System.Drawing.Point(252, 8);
            this.NXTComPortButton.Name = "NXTComPortButton";
            this.NXTComPortButton.Size = new System.Drawing.Size(110, 22);
            this.NXTComPortButton.TabIndex = 6;
            this.NXTComPortButton.Text = "Connect";
            this.NXTComPortButton.UseVisualStyleBackColor = true;
            this.NXTComPortButton.Click += new System.EventHandler(this.NXTComPortButton_Click);
            // 
            // EV3ComPortButton
            // 
            this.EV3ComPortButton.Location = new System.Drawing.Point(252, 43);
            this.EV3ComPortButton.Name = "EV3ComPortButton";
            this.EV3ComPortButton.Size = new System.Drawing.Size(110, 22);
            this.EV3ComPortButton.TabIndex = 10;
            this.EV3ComPortButton.Text = "Connect";
            this.EV3ComPortButton.UseVisualStyleBackColor = true;
            this.EV3ComPortButton.Click += new System.EventHandler(this.EV3ComPortButton_Click);
            // 
            // NXTComPortConnected
            // 
            this.NXTComPortConnected.AutoSize = true;
            this.NXTComPortConnected.Enabled = false;
            this.NXTComPortConnected.Location = new System.Drawing.Point(419, 12);
            this.NXTComPortConnected.Name = "NXTComPortConnected";
            this.NXTComPortConnected.Size = new System.Drawing.Size(15, 14);
            this.NXTComPortConnected.TabIndex = 7;
            this.NXTComPortConnected.UseVisualStyleBackColor = true;
            // 
            // EV3ComPortConnected
            // 
            this.EV3ComPortConnected.AutoSize = true;
            this.EV3ComPortConnected.Enabled = false;
            this.EV3ComPortConnected.Location = new System.Drawing.Point(419, 47);
            this.EV3ComPortConnected.Name = "EV3ComPortConnected";
            this.EV3ComPortConnected.Size = new System.Drawing.Size(15, 14);
            this.EV3ComPortConnected.TabIndex = 11;
            this.EV3ComPortConnected.UseVisualStyleBackColor = true;
            // 
            // MailboxPanel
            // 
            this.MailboxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailboxPanel.Controls.Add(this.Mailbox1Label);
            this.MailboxPanel.Controls.Add(this.Mailbox1Active);
            this.MailboxPanel.Controls.Add(this.Mailbox1Type);
            this.MailboxPanel.Controls.Add(this.Mailbox2Label);
            this.MailboxPanel.Controls.Add(this.Mailbox2Active);
            this.MailboxPanel.Controls.Add(this.Mailbox2Type);
            this.MailboxPanel.Controls.Add(this.Mailbox3Label);
            this.MailboxPanel.Controls.Add(this.Mailbox3Active);
            this.MailboxPanel.Controls.Add(this.Mailbox3Type);
            this.MailboxPanel.Controls.Add(this.Mailbox4Label);
            this.MailboxPanel.Controls.Add(this.Mailbox4Active);
            this.MailboxPanel.Controls.Add(this.Mailbox4Type);
            this.MailboxPanel.Controls.Add(this.Mailbox5Label);
            this.MailboxPanel.Controls.Add(this.Mailbox5Active);
            this.MailboxPanel.Controls.Add(this.Mailbox5Type);
            this.MailboxPanel.Controls.Add(this.Mailbox6Label);
            this.MailboxPanel.Controls.Add(this.Mailbox6Active);
            this.MailboxPanel.Controls.Add(this.Mailbox6Type);
            this.MailboxPanel.Controls.Add(this.Mailbox7Label);
            this.MailboxPanel.Controls.Add(this.Mailbox7Active);
            this.MailboxPanel.Controls.Add(this.Mailbox7Type);
            this.MailboxPanel.Controls.Add(this.Mailbox8Label);
            this.MailboxPanel.Controls.Add(this.Mailbox8Active);
            this.MailboxPanel.Controls.Add(this.Mailbox8Type);
            this.MailboxPanel.Controls.Add(this.Mailbox9Label);
            this.MailboxPanel.Controls.Add(this.Mailbox9Active);
            this.MailboxPanel.Controls.Add(this.Mailbox9Type);
            this.MailboxPanel.Controls.Add(this.Mailbox10Label);
            this.MailboxPanel.Controls.Add(this.Mailbox10Active);
            this.MailboxPanel.Controls.Add(this.Mailbox10Type);
            this.MailboxPanel.Location = new System.Drawing.Point(12, 111);
            this.MailboxPanel.Name = "MailboxPanel";
            this.MailboxPanel.Size = new System.Drawing.Size(468, 169);
            this.MailboxPanel.TabIndex = 1;
            // 
            // Mailbox1Label
            // 
            this.Mailbox1Label.AutoSize = true;
            this.Mailbox1Label.Location = new System.Drawing.Point(13, 19);
            this.Mailbox1Label.Name = "Mailbox1Label";
            this.Mailbox1Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox1Label.TabIndex = 12;
            this.Mailbox1Label.Text = "Mailbox 1";
            // 
            // Mailbox1Active
            // 
            this.Mailbox1Active.AutoSize = true;
            this.Mailbox1Active.Enabled = false;
            this.Mailbox1Active.Location = new System.Drawing.Point(71, 18);
            this.Mailbox1Active.Name = "Mailbox1Active";
            this.Mailbox1Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox1Active.TabIndex = 13;
            this.Mailbox1Active.Text = "=> M1";
            this.Mailbox1Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox1Type
            // 
            this.Mailbox1Type.Enabled = false;
            this.Mailbox1Type.FormattingEnabled = true;
            this.Mailbox1Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox1Type.Location = new System.Drawing.Point(126, 16);
            this.Mailbox1Type.Name = "Mailbox1Type";
            this.Mailbox1Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox1Type.TabIndex = 14;
            this.Mailbox1Type.SelectedIndex = 0;
            this.Mailbox1Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox1Type_SelectedIndexChanged);
            // 
            // Mailbox2Label
            // 
            this.Mailbox2Label.AutoSize = true;
            this.Mailbox2Label.Location = new System.Drawing.Point(13, 49);
            this.Mailbox2Label.Name = "Mailbox2Label";
            this.Mailbox2Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox2Label.TabIndex = 15;
            this.Mailbox2Label.Text = "Mailbox 2";
            // 
            // Mailbox2Active
            // 
            this.Mailbox2Active.AutoSize = true;
            this.Mailbox2Active.Enabled = false;
            this.Mailbox2Active.Location = new System.Drawing.Point(71, 48);
            this.Mailbox2Active.Name = "Mailbox2Active";
            this.Mailbox2Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox2Active.TabIndex = 16;
            this.Mailbox2Active.Text = "=> M2";
            this.Mailbox2Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox2Type
            // 
            this.Mailbox2Type.Enabled = false;
            this.Mailbox2Type.FormattingEnabled = true;
            this.Mailbox2Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox2Type.Location = new System.Drawing.Point(126, 46);
            this.Mailbox2Type.Name = "Mailbox2Type";
            this.Mailbox2Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox2Type.TabIndex = 17;
            this.Mailbox2Type.SelectedIndex = 0;
            this.Mailbox2Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox2Type_SelectedIndexChanged);
            // 
            // Mailbox3Label
            // 
            this.Mailbox3Label.AutoSize = true;
            this.Mailbox3Label.Location = new System.Drawing.Point(13, 79);
            this.Mailbox3Label.Name = "Mailbox3Label";
            this.Mailbox3Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox3Label.TabIndex = 18;
            this.Mailbox3Label.Text = "Mailbox 3";
            // 
            // Mailbox3Active
            // 
            this.Mailbox3Active.AutoSize = true;
            this.Mailbox3Active.Enabled = false;
            this.Mailbox3Active.Location = new System.Drawing.Point(71, 78);
            this.Mailbox3Active.Name = "Mailbox3Active";
            this.Mailbox3Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox3Active.TabIndex = 19;
            this.Mailbox3Active.Text = "=> M3";
            this.Mailbox3Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox3Type
            // 
            this.Mailbox3Type.Enabled = false;
            this.Mailbox3Type.FormattingEnabled = true;
            this.Mailbox3Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox3Type.Location = new System.Drawing.Point(126, 76);
            this.Mailbox3Type.Name = "Mailbox3Type";
            this.Mailbox3Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox3Type.TabIndex = 20;
            this.Mailbox3Type.SelectedIndex = 0;
            this.Mailbox3Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox3Type_SelectedIndexChanged);
            // 
            // Mailbox4Label
            // 
            this.Mailbox4Label.AutoSize = true;
            this.Mailbox4Label.Location = new System.Drawing.Point(13, 109);
            this.Mailbox4Label.Name = "Mailbox4Label";
            this.Mailbox4Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox4Label.TabIndex = 21;
            this.Mailbox4Label.Text = "Mailbox 4";
            // 
            // Mailbox4Active
            // 
            this.Mailbox4Active.AutoSize = true;
            this.Mailbox4Active.Enabled = false;
            this.Mailbox4Active.Location = new System.Drawing.Point(71, 108);
            this.Mailbox4Active.Name = "Mailbox4Active";
            this.Mailbox4Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox4Active.TabIndex = 22;
            this.Mailbox4Active.Text = "=> M4";
            this.Mailbox4Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox4Type
            // 
            this.Mailbox4Type.Enabled = false;
            this.Mailbox4Type.FormattingEnabled = true;
            this.Mailbox4Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox4Type.Location = new System.Drawing.Point(126, 106);
            this.Mailbox4Type.Name = "Mailbox4Type";
            this.Mailbox4Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox4Type.TabIndex = 23;
            this.Mailbox4Type.SelectedIndex = 0;
            this.Mailbox4Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox4Type_SelectedIndexChanged);
            // 
            // Mailbox5Label
            // 
            this.Mailbox5Label.AutoSize = true;
            this.Mailbox5Label.Location = new System.Drawing.Point(13, 139);
            this.Mailbox5Label.Name = "Mailbox5Label";
            this.Mailbox5Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox5Label.TabIndex = 24;
            this.Mailbox5Label.Text = "Mailbox 5";
            // 
            // Mailbox5Active
            // 
            this.Mailbox5Active.AutoSize = true;
            this.Mailbox5Active.Enabled = false;
            this.Mailbox5Active.Location = new System.Drawing.Point(71, 138);
            this.Mailbox5Active.Name = "Mailbox5Active";
            this.Mailbox5Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox5Active.TabIndex = 25;
            this.Mailbox5Active.Text = "=> M5";
            this.Mailbox5Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox5Type
            // 
            this.Mailbox5Type.Enabled = false;
            this.Mailbox5Type.FormattingEnabled = true;
            this.Mailbox5Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox5Type.Location = new System.Drawing.Point(126, 136);
            this.Mailbox5Type.Name = "Mailbox5Type";
            this.Mailbox5Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox5Type.TabIndex = 26;
            this.Mailbox5Type.SelectedIndex = 0;
            this.Mailbox5Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox5Type_SelectedIndexChanged);
            // 
            // Mailbox6Label
            // 
            this.Mailbox6Label.AutoSize = true;
            this.Mailbox6Label.Location = new System.Drawing.Point(249, 19);
            this.Mailbox6Label.Name = "Mailbox6Label";
            this.Mailbox6Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox6Label.TabIndex = 27;
            this.Mailbox6Label.Text = "Mailbox 6";
            // 
            // Mailbox6Active
            // 
            this.Mailbox6Active.AutoSize = true;
            this.Mailbox6Active.Enabled = false;
            this.Mailbox6Active.Location = new System.Drawing.Point(307, 18);
            this.Mailbox6Active.Name = "Mailbox6Active";
            this.Mailbox6Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox6Active.TabIndex = 28;
            this.Mailbox6Active.Text = "=> M6";
            this.Mailbox6Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox6Type
            // 
            this.Mailbox6Type.Enabled = false;
            this.Mailbox6Type.FormattingEnabled = true;
            this.Mailbox6Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox6Type.Location = new System.Drawing.Point(371, 16);
            this.Mailbox6Type.Name = "Mailbox6Type";
            this.Mailbox6Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox6Type.TabIndex = 29;
            this.Mailbox6Type.SelectedIndex = 0;
            this.Mailbox6Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox6Type_SelectedIndexChanged);
            // 
            // Mailbox7Label
            // 
            this.Mailbox7Label.AutoSize = true;
            this.Mailbox7Label.Location = new System.Drawing.Point(249, 49);
            this.Mailbox7Label.Name = "Mailbox7Label";
            this.Mailbox7Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox7Label.TabIndex = 30;
            this.Mailbox7Label.Text = "Mailbox 7";
            // 
            // Mailbox7Active
            // 
            this.Mailbox7Active.AutoSize = true;
            this.Mailbox7Active.Enabled = false;
            this.Mailbox7Active.Location = new System.Drawing.Point(307, 48);
            this.Mailbox7Active.Name = "Mailbox7Active";
            this.Mailbox7Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox7Active.TabIndex = 31;
            this.Mailbox7Active.Text = "=> M7";
            this.Mailbox7Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox7Type
            // 
            this.Mailbox7Type.Enabled = false;
            this.Mailbox7Type.FormattingEnabled = true;
            this.Mailbox7Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox7Type.Location = new System.Drawing.Point(371, 46);
            this.Mailbox7Type.Name = "Mailbox7Type";
            this.Mailbox7Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox7Type.TabIndex = 32;
            this.Mailbox7Type.SelectedIndex = 0;
            this.Mailbox7Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox7Type_SelectedIndexChanged);
            // 
            // Mailbox8Label
            // 
            this.Mailbox8Label.AutoSize = true;
            this.Mailbox8Label.Location = new System.Drawing.Point(249, 79);
            this.Mailbox8Label.Name = "Mailbox8Label";
            this.Mailbox8Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox8Label.TabIndex = 33;
            this.Mailbox8Label.Text = "Mailbox 8";
            // 
            // Mailbox8Active
            // 
            this.Mailbox8Active.AutoSize = true;
            this.Mailbox8Active.Enabled = false;
            this.Mailbox8Active.Location = new System.Drawing.Point(307, 78);
            this.Mailbox8Active.Name = "Mailbox8Active";
            this.Mailbox8Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox8Active.TabIndex = 34;
            this.Mailbox8Active.Text = "=> M8";
            this.Mailbox8Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox8Type
            // 
            this.Mailbox8Type.Enabled = false;
            this.Mailbox8Type.FormattingEnabled = true;
            this.Mailbox8Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox8Type.Location = new System.Drawing.Point(371, 76);
            this.Mailbox8Type.Name = "Mailbox8Type";
            this.Mailbox8Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox8Type.TabIndex = 35;
            this.Mailbox8Type.SelectedIndex = 0;
            this.Mailbox8Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox8Type_SelectedIndexChanged);
            // 
            // Mailbox9Label
            // 
            this.Mailbox9Label.AutoSize = true;
            this.Mailbox9Label.Location = new System.Drawing.Point(249, 109);
            this.Mailbox9Label.Name = "Mailbox9Label";
            this.Mailbox9Label.Size = new System.Drawing.Size(52, 13);
            this.Mailbox9Label.TabIndex = 36;
            this.Mailbox9Label.Text = "Mailbox 9";
            // 
            // Mailbox9Active
            // 
            this.Mailbox9Active.AutoSize = true;
            this.Mailbox9Active.Enabled = false;
            this.Mailbox9Active.Location = new System.Drawing.Point(307, 108);
            this.Mailbox9Active.Name = "Mailbox9Active";
            this.Mailbox9Active.Size = new System.Drawing.Size(56, 17);
            this.Mailbox9Active.TabIndex = 37;
            this.Mailbox9Active.Text = "=> M9";
            this.Mailbox9Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox9Type
            // 
            this.Mailbox9Type.Enabled = false;
            this.Mailbox9Type.FormattingEnabled = true;
            this.Mailbox9Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox9Type.Location = new System.Drawing.Point(371, 106);
            this.Mailbox9Type.Name = "Mailbox9Type";
            this.Mailbox9Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox9Type.TabIndex = 38;
            this.Mailbox9Type.SelectedIndex = 0;
            this.Mailbox9Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox9Type_SelectedIndexChanged);
            // 
            // Mailbox10Label
            // 
            this.Mailbox10Label.AutoSize = true;
            this.Mailbox10Label.Location = new System.Drawing.Point(249, 139);
            this.Mailbox10Label.Name = "Mailbox10Label";
            this.Mailbox10Label.Size = new System.Drawing.Size(58, 13);
            this.Mailbox10Label.TabIndex = 39;
            this.Mailbox10Label.Text = "Mailbox 10";
            // 
            // Mailbox10Active
            // 
            this.Mailbox10Active.AutoSize = true;
            this.Mailbox10Active.Enabled = false;
            this.Mailbox10Active.Location = new System.Drawing.Point(307, 138);
            this.Mailbox10Active.Name = "Mailbox10Active";
            this.Mailbox10Active.Size = new System.Drawing.Size(62, 17);
            this.Mailbox10Active.TabIndex = 40;
            this.Mailbox10Active.Text = "=> M10";
            this.Mailbox10Active.UseVisualStyleBackColor = true;
            // 
            // Mailbox10Type
            // 
            this.Mailbox10Type.Enabled = false;
            this.Mailbox10Type.FormattingEnabled = true;
            this.Mailbox10Type.Items.AddRange(new object[] {
            "Choose...",
            "String",
            "Number",
            "Boolean"});
            this.Mailbox10Type.Location = new System.Drawing.Point(371, 136);
            this.Mailbox10Type.Name = "Mailbox10Type";
            this.Mailbox10Type.Size = new System.Drawing.Size(77, 21);
            this.Mailbox10Type.TabIndex = 41;
            this.Mailbox10Type.SelectedIndex = 0;
            this.Mailbox10Type.SelectedIndexChanged += new System.EventHandler(this.Mailbox10Type_SelectedIndexChanged);
            // 
            // ComPortPanelLabel
            // 
            this.ComPortPanelLabel.AutoSize = true;
            this.ComPortPanelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ComPortPanelLabel.Location = new System.Drawing.Point(26, 8);
            this.ComPortPanelLabel.Name = "ComPortPanelLabel";
            this.ComPortPanelLabel.Size = new System.Drawing.Size(91, 13);
            this.ComPortPanelLabel.TabIndex = 2;
            this.ComPortPanelLabel.Text = "COM port settings";
            // 
            // MailboxPanelLabel
            // 
            this.MailboxPanelLabel.AutoSize = true;
            this.MailboxPanelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MailboxPanelLabel.Location = new System.Drawing.Point(26, 104);
            this.MailboxPanelLabel.Name = "MailboxPanelLabel";
            this.MailboxPanelLabel.Size = new System.Drawing.Size(140, 13);
            this.MailboxPanelLabel.TabIndex = 3;
            this.MailboxPanelLabel.Text = "NXT mailbox to EV3 mailbox";
            // 
            // NXT2EV3ControlApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 292);
            this.Controls.Add(this.ComPortPanelLabel);
            this.Controls.Add(this.MailboxPanelLabel);
            this.Controls.Add(this.ComPortPanel);
            this.Controls.Add(this.MailboxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NXT2EV3ControlApplicationForm";
            this.Text = "NXT to EV3 Connection Hub";
            this.Load += new System.EventHandler(this.NXT2EV3ControlApplicationForm_Load);
            this.ComPortPanel.ResumeLayout(false);
            this.ComPortPanel.PerformLayout();
            this.MailboxPanel.ResumeLayout(false);
            this.MailboxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ComPortPanel;
        private System.Windows.Forms.Panel MailboxPanel;

        private System.Windows.Forms.Label ComPortPanelLabel;
        private System.Windows.Forms.Label MailboxPanelLabel;

        private System.Windows.Forms.Label NXTComPortLabel;
        private System.Windows.Forms.TextBox NXTComPortText;
        private System.Windows.Forms.Button NXTComPortButton;
        private System.Windows.Forms.CheckBox NXTComPortConnected;

        private System.Windows.Forms.Label EV3ComPortLabel;
        private System.Windows.Forms.TextBox EV3ComPortText;
        private System.Windows.Forms.Button EV3ComPortButton;
        private System.Windows.Forms.CheckBox EV3ComPortConnected;

        private System.Windows.Forms.Label Mailbox1Label;
        private System.Windows.Forms.CheckBox Mailbox1Active;
        private System.Windows.Forms.ComboBox Mailbox1Type;

        private System.Windows.Forms.Label Mailbox2Label;
        private System.Windows.Forms.CheckBox Mailbox2Active;
        private System.Windows.Forms.ComboBox Mailbox2Type;

        private System.Windows.Forms.Label Mailbox3Label;
        private System.Windows.Forms.CheckBox Mailbox3Active;
        private System.Windows.Forms.ComboBox Mailbox3Type;

        private System.Windows.Forms.Label Mailbox4Label;
        private System.Windows.Forms.CheckBox Mailbox4Active;
        private System.Windows.Forms.ComboBox Mailbox4Type;

        private System.Windows.Forms.Label Mailbox5Label;
        private System.Windows.Forms.CheckBox Mailbox5Active;
        private System.Windows.Forms.ComboBox Mailbox5Type;

        private System.Windows.Forms.Label Mailbox6Label;
        private System.Windows.Forms.CheckBox Mailbox6Active;
        private System.Windows.Forms.ComboBox Mailbox6Type;

        private System.Windows.Forms.Label Mailbox7Label;
        private System.Windows.Forms.CheckBox Mailbox7Active;
        private System.Windows.Forms.ComboBox Mailbox7Type;

        private System.Windows.Forms.Label Mailbox8Label;
        private System.Windows.Forms.CheckBox Mailbox8Active;
        private System.Windows.Forms.ComboBox Mailbox8Type;

        private System.Windows.Forms.Label Mailbox9Label;
        private System.Windows.Forms.CheckBox Mailbox9Active;
        private System.Windows.Forms.ComboBox Mailbox9Type;

        private System.Windows.Forms.Label Mailbox10Label;
        private System.Windows.Forms.CheckBox Mailbox10Active;
        private System.Windows.Forms.ComboBox Mailbox10Type;
    }
}

