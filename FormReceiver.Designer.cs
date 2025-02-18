using System.Windows.Forms;
using System;

namespace _04_serialportnet
{
    partial class FormReceiver
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiver));
            this.TextBoxReceiver = new System.Windows.Forms.TextBox();
            this.LabelReceivedPort = new System.Windows.Forms.Label();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.groupBoxReceivingPort = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.comboBoxHandShake = new System.Windows.Forms.ComboBox();
            this.labelHandShake = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxDataSize = new System.Windows.Forms.ComboBox();
            this.labelDataSize = new System.Windows.Forms.Label();
            this.comboBoxBaund = new System.Windows.Forms.ComboBox();
            this.labelBaund = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxNameReceiverPort = new System.Windows.Forms.ComboBox();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxLogFile = new System.Windows.Forms.TextBox();
            this.groupBoxML = new System.Windows.Forms.GroupBox();
            this.checkBox2RTS = new System.Windows.Forms.CheckBox();
            this.checkBox2DTR = new System.Windows.Forms.CheckBox();
            this.customCheckBox21CTS = new _04_serialportnet.CustomCheckBox2();
            this.customCheckBox21DSR = new _04_serialportnet.CustomCheckBox2();
            this.customCheckBox21RI = new _04_serialportnet.CustomCheckBox2();
            this.customCheckBox21CD = new _04_serialportnet.CustomCheckBox2();
            this.customCheckBox21TX = new _04_serialportnet.CustomCheckBox2();
            this.groupBoxReceivingPort.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxML.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxReceiver
            // 
            this.TextBoxReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxReceiver.Location = new System.Drawing.Point(14, 23);
            this.TextBoxReceiver.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxReceiver.Multiline = true;
            this.TextBoxReceiver.Name = "TextBoxReceiver";
            this.TextBoxReceiver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxReceiver.Size = new System.Drawing.Size(446, 295);
            this.TextBoxReceiver.TabIndex = 1;
            // 
            // LabelReceivedPort
            // 
            this.LabelReceivedPort.AutoSize = true;
            this.LabelReceivedPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelReceivedPort.Location = new System.Drawing.Point(16, -2);
            this.LabelReceivedPort.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelReceivedPort.Name = "LabelReceivedPort";
            this.LabelReceivedPort.Size = new System.Drawing.Size(291, 20);
            this.LabelReceivedPort.TabIndex = 2;
            this.LabelReceivedPort.Text = "Receiving data from the COM4 port";
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.AutoSize = true;
            this.checkBoxRTS.Enabled = false;
            this.checkBoxRTS.Location = new System.Drawing.Point(319, 19);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(63, 24);
            this.checkBoxRTS.TabIndex = 5;
            this.checkBoxRTS.Text = "RTS";
            this.checkBoxRTS.UseVisualStyleBackColor = true;
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.AutoSize = true;
            this.checkBoxDTR.Enabled = false;
            this.checkBoxDTR.Location = new System.Drawing.Point(249, 19);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(64, 24);
            this.checkBoxDTR.TabIndex = 4;
            this.checkBoxDTR.Text = "DTR";
            this.checkBoxDTR.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceivingPort
            // 
            this.groupBoxReceivingPort.Controls.Add(this.buttonOpen);
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxMode);
            this.groupBoxReceivingPort.Controls.Add(this.labelMode);
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxHandShake);
            this.groupBoxReceivingPort.Controls.Add(this.labelHandShake);
            this.groupBoxReceivingPort.Controls.Add(this.comboBox1);
            this.groupBoxReceivingPort.Controls.Add(this.labelParity);
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxDataSize);
            this.groupBoxReceivingPort.Controls.Add(this.labelDataSize);
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxBaund);
            this.groupBoxReceivingPort.Controls.Add(this.labelBaund);
            this.groupBoxReceivingPort.Controls.Add(this.labelName);
            this.groupBoxReceivingPort.Controls.Add(this.comboBoxNameReceiverPort);
            this.groupBoxReceivingPort.Location = new System.Drawing.Point(458, 25);
            this.groupBoxReceivingPort.Name = "groupBoxReceivingPort";
            this.groupBoxReceivingPort.Size = new System.Drawing.Size(258, 295);
            this.groupBoxReceivingPort.TabIndex = 3;
            this.groupBoxReceivingPort.TabStop = false;
            this.groupBoxReceivingPort.Text = "Receiving port";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(10, 240);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(245, 38);
            this.buttonOpen.TabIndex = 12;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpenClick);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Free",
            "PortStore test",
            "Data",
            "Setup"});
            this.comboBoxMode.Location = new System.Drawing.Point(131, 208);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMode.TabIndex = 11;
            this.comboBoxMode.Text = "Free";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(7, 212);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(53, 20);
            this.labelMode.TabIndex = 10;
            this.labelMode.Text = "Mode";
            // 
            // comboBoxHandShake
            // 
            this.comboBoxHandShake.FormattingEnabled = true;
            this.comboBoxHandShake.Items.AddRange(new object[] {
            "OFF",
            "RTS/CTS",
            "Xon/Xoff"});
            this.comboBoxHandShake.Location = new System.Drawing.Point(131, 176);
            this.comboBoxHandShake.Name = "comboBoxHandShake";
            this.comboBoxHandShake.Size = new System.Drawing.Size(121, 28);
            this.comboBoxHandShake.TabIndex = 9;
            this.comboBoxHandShake.Text = "OFF";
            // 
            // labelHandShake
            // 
            this.labelHandShake.AutoSize = true;
            this.labelHandShake.Location = new System.Drawing.Point(7, 176);
            this.labelHandShake.Name = "labelHandShake";
            this.labelHandShake.Size = new System.Drawing.Size(100, 20);
            this.labelHandShake.TabIndex = 8;
            this.labelHandShake.Text = "Handshake";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "none",
            "even",
            "odd",
            "mark"});
            this.comboBox1.Location = new System.Drawing.Point(131, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "none";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(7, 133);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(54, 20);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity";
            // 
            // comboBoxDataSize
            // 
            this.comboBoxDataSize.FormattingEnabled = true;
            this.comboBoxDataSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBoxDataSize.Location = new System.Drawing.Point(131, 101);
            this.comboBoxDataSize.Name = "comboBoxDataSize";
            this.comboBoxDataSize.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataSize.TabIndex = 5;
            this.comboBoxDataSize.Text = "8";
            // 
            // labelDataSize
            // 
            this.labelDataSize.AutoSize = true;
            this.labelDataSize.Location = new System.Drawing.Point(7, 101);
            this.labelDataSize.Name = "labelDataSize";
            this.labelDataSize.Size = new System.Drawing.Size(85, 20);
            this.labelDataSize.TabIndex = 4;
            this.labelDataSize.Text = "Data size";
            // 
            // comboBoxBaund
            // 
            this.comboBoxBaund.FormattingEnabled = true;
            this.comboBoxBaund.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.comboBoxBaund.Location = new System.Drawing.Point(131, 58);
            this.comboBoxBaund.Name = "comboBoxBaund";
            this.comboBoxBaund.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaund.TabIndex = 3;
            this.comboBoxBaund.Text = "9600";
            // 
            // labelBaund
            // 
            this.labelBaund.AutoSize = true;
            this.labelBaund.Location = new System.Drawing.Point(7, 61);
            this.labelBaund.Name = "labelBaund";
            this.labelBaund.Size = new System.Drawing.Size(61, 20);
            this.labelBaund.TabIndex = 2;
            this.labelBaund.Text = "Baund";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // comboBoxNameReceiverPort
            // 
            this.comboBoxNameReceiverPort.FormattingEnabled = true;
            this.comboBoxNameReceiverPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxNameReceiverPort.Location = new System.Drawing.Point(131, 23);
            this.comboBoxNameReceiverPort.Name = "comboBoxNameReceiverPort";
            this.comboBoxNameReceiverPort.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNameReceiverPort.TabIndex = 0;
            this.comboBoxNameReceiverPort.Text = "COM3";
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.textBoxMessages);
            this.groupBoxMessages.Location = new System.Drawing.Point(12, 387);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(698, 172);
            this.groupBoxMessages.TabIndex = 8;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMessages.Location = new System.Drawing.Point(4, 21);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessages.Size = new System.Drawing.Size(687, 145);
            this.textBoxMessages.TabIndex = 0;
            this.textBoxMessages.Text = "Messages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBoxLogFile);
            this.groupBox2.Location = new System.Drawing.Point(458, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 54);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LogFile name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxLogFile
            // 
            this.textBoxLogFile.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogFile.Name = "textBoxLogFile";
            this.textBoxLogFile.Size = new System.Drawing.Size(239, 26);
            this.textBoxLogFile.TabIndex = 0;
            this.textBoxLogFile.Text = "LogFile.txt";
            // 
            // groupBoxML
            // 
            this.groupBoxML.Controls.Add(this.checkBox2RTS);
            this.groupBoxML.Controls.Add(this.checkBox2DTR);
            this.groupBoxML.Controls.Add(this.customCheckBox21CTS);
            this.groupBoxML.Controls.Add(this.customCheckBox21DSR);
            this.groupBoxML.Controls.Add(this.customCheckBox21RI);
            this.groupBoxML.Controls.Add(this.customCheckBox21CD);
            this.groupBoxML.Controls.Add(this.customCheckBox21TX);
            this.groupBoxML.Location = new System.Drawing.Point(16, 326);
            this.groupBoxML.Name = "groupBoxML";
            this.groupBoxML.Size = new System.Drawing.Size(442, 54);
            this.groupBoxML.TabIndex = 10;
            this.groupBoxML.TabStop = false;
            this.groupBoxML.Text = "Modem lines";
            // 
            // checkBox2RTS
            // 
            this.checkBox2RTS.AutoSize = true;
            this.checkBox2RTS.Enabled = false;
            this.checkBox2RTS.Location = new System.Drawing.Point(319, 26);
            this.checkBox2RTS.Name = "checkBox2RTS";
            this.checkBox2RTS.Size = new System.Drawing.Size(63, 24);
            this.checkBox2RTS.TabIndex = 6;
            this.checkBox2RTS.Text = "RTS";
            this.checkBox2RTS.UseVisualStyleBackColor = true;
            // 
            // checkBox2DTR
            // 
            this.checkBox2DTR.AutoSize = true;
            this.checkBox2DTR.Enabled = false;
            this.checkBox2DTR.Location = new System.Drawing.Point(251, 26);
            this.checkBox2DTR.Name = "checkBox2DTR";
            this.checkBox2DTR.Size = new System.Drawing.Size(64, 24);
            this.checkBox2DTR.TabIndex = 5;
            this.checkBox2DTR.Text = "DTR";
            this.checkBox2DTR.UseVisualStyleBackColor = true;
            // 
            // customCheckBox21CTS
            // 
            this.customCheckBox21CTS.AutoSize = true;
            this.customCheckBox21CTS.CircleColor = System.Drawing.Color.Black;
            this.customCheckBox21CTS.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBox21CTS.InnerCircleSize = 10;
            this.customCheckBox21CTS.Location = new System.Drawing.Point(185, 26);
            this.customCheckBox21CTS.Name = "customCheckBox21CTS";
            this.customCheckBox21CTS.Size = new System.Drawing.Size(62, 24);
            this.customCheckBox21CTS.TabIndex = 4;
            this.customCheckBox21CTS.Text = "CTS";
            this.customCheckBox21CTS.TextWidth = 130;
            this.customCheckBox21CTS.UseVisualStyleBackColor = true;
            // 
            // customCheckBox21DSR
            // 
            this.customCheckBox21DSR.AutoSize = true;
            this.customCheckBox21DSR.CircleColor = System.Drawing.Color.Black;
            this.customCheckBox21DSR.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBox21DSR.InnerCircleSize = 10;
            this.customCheckBox21DSR.Location = new System.Drawing.Point(115, 26);
            this.customCheckBox21DSR.Name = "customCheckBox21DSR";
            this.customCheckBox21DSR.Size = new System.Drawing.Size(66, 24);
            this.customCheckBox21DSR.TabIndex = 3;
            this.customCheckBox21DSR.Text = "DSR";
            this.customCheckBox21DSR.TextWidth = 130;
            this.customCheckBox21DSR.UseVisualStyleBackColor = true;
            // 
            // customCheckBox21RI
            // 
            this.customCheckBox21RI.AutoSize = true;
            this.customCheckBox21RI.CircleColor = System.Drawing.Color.Black;
            this.customCheckBox21RI.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBox21RI.InnerCircleSize = 10;
            this.customCheckBox21RI.Location = new System.Drawing.Point(64, 26);
            this.customCheckBox21RI.Name = "customCheckBox21RI";
            this.customCheckBox21RI.Size = new System.Drawing.Size(47, 24);
            this.customCheckBox21RI.TabIndex = 2;
            this.customCheckBox21RI.Text = "RI";
            this.customCheckBox21RI.TextWidth = 130;
            this.customCheckBox21RI.UseVisualStyleBackColor = true;
            // 
            // customCheckBox21CD
            // 
            this.customCheckBox21CD.AutoSize = true;
            this.customCheckBox21CD.CircleColor = System.Drawing.Color.Black;
            this.customCheckBox21CD.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBox21CD.InnerCircleSize = 10;
            this.customCheckBox21CD.Location = new System.Drawing.Point(7, 26);
            this.customCheckBox21CD.Name = "customCheckBox21CD";
            this.customCheckBox21CD.Size = new System.Drawing.Size(53, 24);
            this.customCheckBox21CD.TabIndex = 1;
            this.customCheckBox21CD.Text = "CD";
            this.customCheckBox21CD.TextWidth = 130;
            this.customCheckBox21CD.UseVisualStyleBackColor = true;
            // 
            // customCheckBox21TX
            // 
            this.customCheckBox21TX.AutoSize = true;
            this.customCheckBox21TX.CircleColor = System.Drawing.Color.Black;
            this.customCheckBox21TX.InnerCircleColor = System.Drawing.Color.Red;
            this.customCheckBox21TX.InnerCircleSize = 10;
            this.customCheckBox21TX.Location = new System.Drawing.Point(386, 26);
            this.customCheckBox21TX.Name = "customCheckBox21TX";
            this.customCheckBox21TX.Size = new System.Drawing.Size(50, 24);
            this.customCheckBox21TX.TabIndex = 0;
            this.customCheckBox21TX.Text = "TX";
            this.customCheckBox21TX.TextWidth = 130;
            this.customCheckBox21TX.UseVisualStyleBackColor = true;
            // 
            // FormReceiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(728, 571);
            this.Controls.Add(this.groupBoxML);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.groupBoxReceivingPort);
            this.Controls.Add(this.LabelReceivedPort);
            this.Controls.Add(this.TextBoxReceiver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormReceiver";
            this.Text = "Receiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormReceiver_Load);
            this.groupBoxReceivingPort.ResumeLayout(false);
            this.groupBoxReceivingPort.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxML.ResumeLayout(false);
            this.groupBoxML.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxReceiver;
        private System.Windows.Forms.Label LabelReceivedPort;
        private CheckBox checkBoxRTS;
        private CheckBox checkBoxDTR;
        private GroupBox groupBoxReceivingPort;
        private Button buttonOpen;
        private ComboBox comboBoxMode;
        private Label labelMode;
        private ComboBox comboBoxHandShake;
        private Label labelHandShake;
        private ComboBox comboBox1;
        private Label labelParity;
        private ComboBox comboBoxDataSize;
        private Label labelDataSize;
        private ComboBox comboBoxBaund;
        private Label labelBaund;
        private Label labelName;
        private ComboBox comboBoxNameReceiverPort;
        private GroupBox groupBoxMessages;
        private TextBox textBoxMessages;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private TextBox textBoxLogFile;
        private GroupBox groupBoxML;
        private CustomCheckBox2 customCheckBox21TX;
        private CheckBox checkBox2RTS;
        private CheckBox checkBox2DTR;
        private CustomCheckBox2 customCheckBox21CTS;
        private CustomCheckBox2 customCheckBox21DSR;
        private CustomCheckBox2 customCheckBox21RI;
        private CustomCheckBox2 customCheckBox21CD;
    }
}

