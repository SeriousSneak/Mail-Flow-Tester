namespace EmailTests
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textServer = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTimeOut = new System.Windows.Forms.TextBox();
            this.checkServerReachable = new System.Windows.Forms.CheckBox();
            this.checkDateAppend = new System.Windows.Forms.CheckBox();
            this.checkLog = new System.Windows.Forms.CheckBox();
            this.checkEnableAdvanced = new System.Windows.Forms.CheckBox();
            this.checkForceTLS = new System.Windows.Forms.CheckBox();
            this.rbGtube = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbEICAR = new System.Windows.Forms.RadioButton();
            this.groupBoxAttachments = new System.Windows.Forms.GroupBox();
            this.listBoxAttachment = new System.Windows.Forms.ListBox();
            this.contextMenuStripAttachment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFromP2 = new System.Windows.Forms.Label();
            this.textFromP2 = new System.Windows.Forms.TextBox();
            this.checkSpecifyP2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxHeaderValue = new System.Windows.Forms.TextBox();
            this.textBoxHeaderX = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.checkAddCustomHeader = new System.Windows.Forms.CheckBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAttachmentRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxServerName = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelReplyTo = new System.Windows.Forms.Label();
            this.checkSpecifyReplyTo = new System.Windows.Forms.CheckBox();
            this.textReplyTo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuCopyCell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.buttonExportLog = new System.Windows.Forms.Button();
            this.buttonSmtpLog = new System.Windows.Forms.Button();
            this.buttonLogLocation = new System.Windows.Forms.Button();
            this.gbOptions.SuspendLayout();
            this.groupBoxAttachments.SuspendLayout();
            this.contextMenuStripAttachment.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Enabled = false;
            this.textServer.Location = new System.Drawing.Point(48, 16);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(176, 20);
            this.textServer.TabIndex = 1;
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(68, 60);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(260, 20);
            this.textTo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textTo, "Separate multiple recipients with a comma");
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(68, 87);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(260, 20);
            this.textFrom.TabIndex = 4;
            this.textFrom.Text = "joeuser@domain.invalid";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(68, 115);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(260, 20);
            this.textSubject.TabIndex = 5;
            // 
            // textBody
            // 
            this.textBody.Location = new System.Drawing.Point(68, 141);
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(260, 20);
            this.textBody.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MailFrom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Body";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.White;
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Location = new System.Drawing.Point(119, 292);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(109, 23);
            this.buttonSend.TabIndex = 20;
            this.buttonSend.Text = "Send message";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.White;
            this.buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBrowse.Location = new System.Drawing.Point(255, 20);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(55, 23);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonAttachment_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.label6);
            this.gbOptions.Controls.Add(this.textTimeOut);
            this.gbOptions.Controls.Add(this.checkServerReachable);
            this.gbOptions.Controls.Add(this.checkDateAppend);
            this.gbOptions.Controls.Add(this.checkLog);
            this.gbOptions.Controls.Add(this.checkEnableAdvanced);
            this.gbOptions.Controls.Add(this.checkForceTLS);
            this.gbOptions.Controls.Add(this.rbGtube);
            this.gbOptions.Controls.Add(this.rbNone);
            this.gbOptions.Controls.Add(this.rbEICAR);
            this.gbOptions.Location = new System.Drawing.Point(12, 171);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(316, 113);
            this.gbOptions.TabIndex = 7;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time out in seconds";
            // 
            // textTimeOut
            // 
            this.textTimeOut.Location = new System.Drawing.Point(273, 63);
            this.textTimeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTimeOut.Name = "textTimeOut";
            this.textTimeOut.Size = new System.Drawing.Size(32, 20);
            this.textTimeOut.TabIndex = 28;
            this.textTimeOut.TabStop = false;
            this.textTimeOut.Text = "10";
            // 
            // checkServerReachable
            // 
            this.checkServerReachable.AutoSize = true;
            this.checkServerReachable.Checked = true;
            this.checkServerReachable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkServerReachable.Location = new System.Drawing.Point(9, 65);
            this.checkServerReachable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkServerReachable.Name = "checkServerReachable";
            this.checkServerReachable.Size = new System.Drawing.Size(157, 17);
            this.checkServerReachable.TabIndex = 27;
            this.checkServerReachable.TabStop = false;
            this.checkServerReachable.Text = "Check if server is reachable";
            this.checkServerReachable.UseVisualStyleBackColor = true;
            // 
            // checkDateAppend
            // 
            this.checkDateAppend.AutoSize = true;
            this.checkDateAppend.Location = new System.Drawing.Point(98, 42);
            this.checkDateAppend.Name = "checkDateAppend";
            this.checkDateAppend.Size = new System.Drawing.Size(136, 17);
            this.checkDateAppend.TabIndex = 26;
            this.checkDateAppend.TabStop = false;
            this.checkDateAppend.Text = "Append date to subject";
            this.checkDateAppend.UseVisualStyleBackColor = true;
            // 
            // checkLog
            // 
            this.checkLog.AutoSize = true;
            this.checkLog.Location = new System.Drawing.Point(242, 42);
            this.checkLog.Name = "checkLog";
            this.checkLog.Size = new System.Drawing.Size(66, 17);
            this.checkLog.TabIndex = 25;
            this.checkLog.TabStop = false;
            this.checkLog.Text = "View log";
            this.checkLog.UseVisualStyleBackColor = true;
            this.checkLog.CheckedChanged += new System.EventHandler(this.checkLog_CheckedChanged);
            // 
            // checkEnableAdvanced
            // 
            this.checkEnableAdvanced.AutoSize = true;
            this.checkEnableAdvanced.Location = new System.Drawing.Point(9, 88);
            this.checkEnableAdvanced.Name = "checkEnableAdvanced";
            this.checkEnableAdvanced.Size = new System.Drawing.Size(112, 17);
            this.checkEnableAdvanced.TabIndex = 24;
            this.checkEnableAdvanced.TabStop = false;
            this.checkEnableAdvanced.Text = "Advanced options";
            this.checkEnableAdvanced.UseVisualStyleBackColor = true;
            this.checkEnableAdvanced.CheckedChanged += new System.EventHandler(this.checkEnableAdvanced_CheckedChanged);
            // 
            // checkForceTLS
            // 
            this.checkForceTLS.AutoSize = true;
            this.checkForceTLS.Location = new System.Drawing.Point(9, 42);
            this.checkForceTLS.Name = "checkForceTLS";
            this.checkForceTLS.Size = new System.Drawing.Size(76, 17);
            this.checkForceTLS.TabIndex = 23;
            this.checkForceTLS.TabStop = false;
            this.checkForceTLS.Text = "Force TLS";
            this.checkForceTLS.UseVisualStyleBackColor = true;
            // 
            // rbGtube
            // 
            this.rbGtube.AutoSize = true;
            this.rbGtube.Location = new System.Drawing.Point(98, 19);
            this.rbGtube.Name = "rbGtube";
            this.rbGtube.Size = new System.Drawing.Size(58, 17);
            this.rbGtube.TabIndex = 21;
            this.rbGtube.Text = "GTube";
            this.rbGtube.UseVisualStyleBackColor = true;
            this.rbGtube.CheckedChanged += new System.EventHandler(this.rbGtube_CheckedChanged_1);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(9, 19);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 7;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbEICAR
            // 
            this.rbEICAR.AutoSize = true;
            this.rbEICAR.Location = new System.Drawing.Point(186, 19);
            this.rbEICAR.Name = "rbEICAR";
            this.rbEICAR.Size = new System.Drawing.Size(57, 17);
            this.rbEICAR.TabIndex = 22;
            this.rbEICAR.Text = "EICAR";
            this.rbEICAR.UseVisualStyleBackColor = true;
            this.rbEICAR.CheckedChanged += new System.EventHandler(this.rbEICAR_CheckedChanged);
            // 
            // groupBoxAttachments
            // 
            this.groupBoxAttachments.Controls.Add(this.buttonBrowse);
            this.groupBoxAttachments.Controls.Add(this.listBoxAttachment);
            this.groupBoxAttachments.Location = new System.Drawing.Point(14, 219);
            this.groupBoxAttachments.Name = "groupBoxAttachments";
            this.groupBoxAttachments.Size = new System.Drawing.Size(316, 137);
            this.groupBoxAttachments.TabIndex = 15;
            this.groupBoxAttachments.TabStop = false;
            this.groupBoxAttachments.Text = "Attachments (select and then right click to remove)";
            // 
            // listBoxAttachment
            // 
            this.listBoxAttachment.ContextMenuStrip = this.contextMenuStripAttachment;
            this.listBoxAttachment.FormattingEnabled = true;
            this.listBoxAttachment.HorizontalScrollbar = true;
            this.listBoxAttachment.Location = new System.Drawing.Point(8, 20);
            this.listBoxAttachment.Name = "listBoxAttachment";
            this.listBoxAttachment.Size = new System.Drawing.Size(241, 108);
            this.listBoxAttachment.TabIndex = 22;
            this.listBoxAttachment.TabStop = false;
            // 
            // contextMenuStripAttachment
            // 
            this.contextMenuStripAttachment.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripAttachment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuStripAttachment.Name = "contextMenuStripAttachment";
            this.contextMenuStripAttachment.Size = new System.Drawing.Size(133, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.removeAllToolStripMenuItem.Text = "Remove all";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(270, 16);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(33, 20);
            this.textPort.TabIndex = 2;
            this.textPort.Text = "25";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFromP2);
            this.groupBox2.Controls.Add(this.textFromP2);
            this.groupBox2.Controls.Add(this.checkSpecifyP2);
            this.groupBox2.Location = new System.Drawing.Point(14, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // labelFromP2
            // 
            this.labelFromP2.AutoSize = true;
            this.labelFromP2.Enabled = false;
            this.labelFromP2.Location = new System.Drawing.Point(5, 22);
            this.labelFromP2.Name = "labelFromP2";
            this.labelFromP2.Size = new System.Drawing.Size(52, 13);
            this.labelFromP2.TabIndex = 20;
            this.labelFromP2.Text = "From (P2)";
            // 
            // textFromP2
            // 
            this.textFromP2.Enabled = false;
            this.textFromP2.Location = new System.Drawing.Point(63, 19);
            this.textFromP2.Name = "textFromP2";
            this.textFromP2.Size = new System.Drawing.Size(240, 20);
            this.textFromP2.TabIndex = 9;
            // 
            // checkSpecifyP2
            // 
            this.checkSpecifyP2.AutoSize = true;
            this.checkSpecifyP2.Location = new System.Drawing.Point(9, 0);
            this.checkSpecifyP2.Name = "checkSpecifyP2";
            this.checkSpecifyP2.Size = new System.Drawing.Size(149, 17);
            this.checkSpecifyP2.TabIndex = 8;
            this.checkSpecifyP2.Text = "Specify a P2 from address";
            this.checkSpecifyP2.UseVisualStyleBackColor = true;
            this.checkSpecifyP2.CheckedChanged += new System.EventHandler(this.checkSpecifyP2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxHeaderValue);
            this.groupBox3.Controls.Add(this.textBoxHeaderX);
            this.groupBox3.Controls.Add(this.labelValue);
            this.groupBox3.Controls.Add(this.labelHeader);
            this.groupBox3.Controls.Add(this.checkAddCustomHeader);
            this.groupBox3.Location = new System.Drawing.Point(14, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 87);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // textBoxHeaderValue
            // 
            this.textBoxHeaderValue.Enabled = false;
            this.textBoxHeaderValue.Location = new System.Drawing.Point(141, 32);
            this.textBoxHeaderValue.Multiline = true;
            this.textBoxHeaderValue.Name = "textBoxHeaderValue";
            this.textBoxHeaderValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHeaderValue.Size = new System.Drawing.Size(162, 46);
            this.textBoxHeaderValue.TabIndex = 14;
            this.textBoxHeaderValue.WordWrap = false;
            // 
            // textBoxHeaderX
            // 
            this.textBoxHeaderX.Enabled = false;
            this.textBoxHeaderX.Location = new System.Drawing.Point(9, 32);
            this.textBoxHeaderX.Multiline = true;
            this.textBoxHeaderX.Name = "textBoxHeaderX";
            this.textBoxHeaderX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHeaderX.Size = new System.Drawing.Size(126, 46);
            this.textBoxHeaderX.TabIndex = 13;
            this.textBoxHeaderX.Text = "X-";
            this.textBoxHeaderX.WordWrap = false;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Enabled = false;
            this.labelValue.Location = new System.Drawing.Point(138, 16);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Enabled = false;
            this.labelHeader.Location = new System.Drawing.Point(6, 16);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(42, 13);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Header";
            // 
            // checkAddCustomHeader
            // 
            this.checkAddCustomHeader.AutoSize = true;
            this.checkAddCustomHeader.Location = new System.Drawing.Point(9, 0);
            this.checkAddCustomHeader.Name = "checkAddCustomHeader";
            this.checkAddCustomHeader.Size = new System.Drawing.Size(191, 17);
            this.checkAddCustomHeader.TabIndex = 12;
            this.checkAddCustomHeader.Text = "Add a custom header (one per line)";
            this.checkAddCustomHeader.UseVisualStyleBackColor = true;
            this.checkAddCustomHeader.CheckedChanged += new System.EventHandler(this.checkAddCustomHeader_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Remove";
            // 
            // toolStripMenuItemAttachmentRemove
            // 
            this.toolStripMenuItemAttachmentRemove.Name = "toolStripMenuItemAttachmentRemove";
            this.toolStripMenuItemAttachmentRemove.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxServerName);
            this.groupBox1.Controls.Add(this.textServer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxServerName
            // 
            this.checkBoxServerName.AutoSize = true;
            this.checkBoxServerName.Location = new System.Drawing.Point(9, -1);
            this.checkBoxServerName.Name = "checkBoxServerName";
            this.checkBoxServerName.Size = new System.Drawing.Size(179, 17);
            this.checkBoxServerName.TabIndex = 0;
            this.checkBoxServerName.Text = "Manually specify recipient server";
            this.checkBoxServerName.UseVisualStyleBackColor = true;
            this.checkBoxServerName.CheckedChanged += new System.EventHandler(this.checkBoxServerName_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBoxAttachments);
            this.panel1.Location = new System.Drawing.Point(-2, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 364);
            this.panel1.TabIndex = 9;
            this.panel1.TabStop = true;
            this.panel1.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelReplyTo);
            this.groupBox4.Controls.Add(this.checkSpecifyReplyTo);
            this.groupBox4.Controls.Add(this.textReplyTo);
            this.groupBox4.Location = new System.Drawing.Point(14, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 57);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // labelReplyTo
            // 
            this.labelReplyTo.AutoSize = true;
            this.labelReplyTo.Enabled = false;
            this.labelReplyTo.Location = new System.Drawing.Point(6, 27);
            this.labelReplyTo.Name = "labelReplyTo";
            this.labelReplyTo.Size = new System.Drawing.Size(50, 13);
            this.labelReplyTo.TabIndex = 1;
            this.labelReplyTo.Text = "Reply-To";
            // 
            // checkSpecifyReplyTo
            // 
            this.checkSpecifyReplyTo.AutoSize = true;
            this.checkSpecifyReplyTo.Location = new System.Drawing.Point(8, 0);
            this.checkSpecifyReplyTo.Name = "checkSpecifyReplyTo";
            this.checkSpecifyReplyTo.Size = new System.Drawing.Size(156, 17);
            this.checkSpecifyReplyTo.TabIndex = 10;
            this.checkSpecifyReplyTo.Text = "Specify a Reply-To address";
            this.checkSpecifyReplyTo.UseVisualStyleBackColor = true;
            this.checkSpecifyReplyTo.CheckedChanged += new System.EventHandler(this.checkSpecifyReplyTo_CheckedChanged);
            // 
            // textReplyTo
            // 
            this.textReplyTo.Enabled = false;
            this.textReplyTo.Location = new System.Drawing.Point(63, 24);
            this.textReplyTo.Name = "textReplyTo";
            this.textReplyTo.Size = new System.Drawing.Size(240, 20);
            this.textReplyTo.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.From,
            this.To,
            this.Subject,
            this.Options,
            this.Result,
            this.Server,
            this.messageid});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripLog;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(344, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(630, 271);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "Date / Time (local)";
            this.Date.MinimumWidth = 125;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 50;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Width = 55;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 50;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 50;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 50;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 68;
            // 
            // Options
            // 
            this.Options.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Options.HeaderText = "Options";
            this.Options.MinimumWidth = 50;
            this.Options.Name = "Options";
            this.Options.ReadOnly = true;
            this.Options.Width = 68;
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 50;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 62;
            // 
            // Server
            // 
            this.Server.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Server.HeaderText = "Recipient server";
            this.Server.MinimumWidth = 110;
            this.Server.Name = "Server";
            this.Server.ReadOnly = true;
            this.Server.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Server.Width = 110;
            // 
            // messageid
            // 
            this.messageid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.messageid.HeaderText = "Message-ID";
            this.messageid.MinimumWidth = 6;
            this.messageid.Name = "messageid";
            this.messageid.ReadOnly = true;
            this.messageid.Width = 89;
            // 
            // contextMenuStripLog
            // 
            this.contextMenuStripLog.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCopyCell,
            this.toolStripMenuDeleteRow});
            this.contextMenuStripLog.Name = "contextMenuStripAttachment";
            this.contextMenuStripLog.Size = new System.Drawing.Size(131, 48);
            // 
            // toolStripMenuCopyCell
            // 
            this.toolStripMenuCopyCell.Name = "toolStripMenuCopyCell";
            this.toolStripMenuCopyCell.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuCopyCell.Text = "Copy cell";
            this.toolStripMenuCopyCell.Click += new System.EventHandler(this.toolStripMenuCopyCell_Click);
            // 
            // toolStripMenuDeleteRow
            // 
            this.toolStripMenuDeleteRow.Name = "toolStripMenuDeleteRow";
            this.toolStripMenuDeleteRow.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuDeleteRow.Text = "Delete row";
            this.toolStripMenuDeleteRow.Click += new System.EventHandler(this.toolStripMenuDeleteRow_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLog.Location = new System.Drawing.Point(344, 292);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(75, 23);
            this.buttonClearLog.TabIndex = 23;
            this.buttonClearLog.TabStop = false;
            this.buttonClearLog.Text = "Clear log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // buttonExportLog
            // 
            this.buttonExportLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonExportLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportLog.Location = new System.Drawing.Point(434, 292);
            this.buttonExportLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExportLog.Name = "buttonExportLog";
            this.buttonExportLog.Size = new System.Drawing.Size(74, 23);
            this.buttonExportLog.TabIndex = 24;
            this.buttonExportLog.TabStop = false;
            this.buttonExportLog.Text = "Export log";
            this.buttonExportLog.UseVisualStyleBackColor = true;
            this.buttonExportLog.Click += new System.EventHandler(this.buttonExportLog_Click);
            // 
            // buttonSmtpLog
            // 
            this.buttonSmtpLog.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSmtpLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSmtpLog.Location = new System.Drawing.Point(876, 292);
            this.buttonSmtpLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSmtpLog.Name = "buttonSmtpLog";
            this.buttonSmtpLog.Size = new System.Drawing.Size(98, 23);
            this.buttonSmtpLog.TabIndex = 25;
            this.buttonSmtpLog.TabStop = false;
            this.buttonSmtpLog.Text = "Open SMTP log";
            this.buttonSmtpLog.UseVisualStyleBackColor = true;
            this.buttonSmtpLog.Click += new System.EventHandler(this.ButtonSmtpLog_Click);
            // 
            // buttonLogLocation
            // 
            this.buttonLogLocation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonLogLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogLocation.Location = new System.Drawing.Point(761, 292);
            this.buttonLogLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogLocation.Name = "buttonLogLocation";
            this.buttonLogLocation.Size = new System.Drawing.Size(103, 23);
            this.buttonLogLocation.TabIndex = 26;
            this.buttonLogLocation.TabStop = false;
            this.buttonLogLocation.Text = "Open log location";
            this.buttonLogLocation.UseVisualStyleBackColor = true;
            this.buttonLogLocation.Click += new System.EventHandler(this.buttonLogLocation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 323);
            this.Controls.Add(this.buttonLogLocation);
            this.Controls.Add(this.buttonSmtpLog);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonExportLog);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supa Awesome Mail Flow Tester v3.1 Dev";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBoxAttachments.ResumeLayout(false);
            this.contextMenuStripAttachment.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textTo;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox textBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbEICAR;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbGtube;
        private System.Windows.Forms.GroupBox groupBoxAttachments;
        private System.Windows.Forms.CheckBox checkForceTLS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFromP2;
        private System.Windows.Forms.TextBox textFromP2;
        private System.Windows.Forms.CheckBox checkSpecifyP2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkAddCustomHeader;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAttachment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox listBoxAttachment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAttachmentRemove;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxServerName;
        private System.Windows.Forms.CheckBox checkEnableAdvanced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.TextBox textBoxHeaderValue;
        private System.Windows.Forms.TextBox textBoxHeaderX;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCopyCell;
        private System.Windows.Forms.Button buttonExportLog;
        private System.Windows.Forms.CheckBox checkDateAppend;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textReplyTo;
        private System.Windows.Forms.Label labelReplyTo;
        private System.Windows.Forms.CheckBox checkSpecifyReplyTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Options;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageid;
        private System.Windows.Forms.CheckBox checkServerReachable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTimeOut;
        private System.Windows.Forms.Button buttonSmtpLog;
        private System.Windows.Forms.Button buttonLogLocation;
    }
}

