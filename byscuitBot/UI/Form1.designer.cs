﻿namespace byscuitBot
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
            this.serversCBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tokenTxt = new MetroFramework.Controls.MetroTextBox();
            this.statsTxt = new MetroFramework.Controls.MetroTextBox();
            this.applyBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.prefixTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.afkChanCBox = new MetroFramework.Controls.MetroComboBox();
            this.afkTimeCBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new MetroFramework.Controls.MetroButton();
            this.colorPrev = new System.Windows.Forms.PictureBox();
            this.tsToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.adToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.veriToggle = new MetroFramework.Controls.MetroToggle();
            this.verRoleCBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.spamThresholdTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.spamTimeTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.spamWarnTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.footerTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.applyConfigBtn = new MetroFramework.Controls.MetroButton();
            this.sendMsgBtn = new MetroFramework.Controls.MetroButton();
            this.messageTxt = new MetroFramework.Controls.MetroTextBox();
            this.embedChk = new MetroFramework.Controls.MetroCheckBox();
            this.textChannelCBox = new MetroFramework.Controls.MetroComboBox();
            this.configGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // serversCBox
            // 
            this.serversCBox.FormattingEnabled = true;
            this.serversCBox.ItemHeight = 23;
            this.serversCBox.Location = new System.Drawing.Point(23, 86);
            this.serversCBox.Name = "serversCBox";
            this.serversCBox.Size = new System.Drawing.Size(300, 29);
            this.serversCBox.TabIndex = 0;
            this.serversCBox.SelectedIndexChanged += new System.EventHandler(this.serversCBox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Connected Servers:";
            // 
            // configGroup
            // 
            this.configGroup.Controls.Add(this.applyConfigBtn);
            this.configGroup.Controls.Add(this.footerTxt);
            this.configGroup.Controls.Add(this.metroLabel13);
            this.configGroup.Controls.Add(this.spamWarnTxt);
            this.configGroup.Controls.Add(this.metroLabel12);
            this.configGroup.Controls.Add(this.spamTimeTxt);
            this.configGroup.Controls.Add(this.metroLabel11);
            this.configGroup.Controls.Add(this.spamThresholdTxt);
            this.configGroup.Controls.Add(this.metroLabel10);
            this.configGroup.Controls.Add(this.verRoleCBox);
            this.configGroup.Controls.Add(this.metroLabel9);
            this.configGroup.Controls.Add(this.metroLabel8);
            this.configGroup.Controls.Add(this.veriToggle);
            this.configGroup.Controls.Add(this.metroLabel7);
            this.configGroup.Controls.Add(this.adToggle);
            this.configGroup.Controls.Add(this.metroLabel6);
            this.configGroup.Controls.Add(this.tsToggle);
            this.configGroup.Controls.Add(this.colorPrev);
            this.configGroup.Controls.Add(this.colorBtn);
            this.configGroup.Controls.Add(this.afkTimeCBox);
            this.configGroup.Controls.Add(this.metroLabel5);
            this.configGroup.Controls.Add(this.afkChanCBox);
            this.configGroup.Controls.Add(this.metroLabel4);
            this.configGroup.Controls.Add(this.prefixTxt);
            this.configGroup.Controls.Add(this.metroLabel3);
            this.configGroup.Location = new System.Drawing.Point(340, 63);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(384, 383);
            this.configGroup.TabIndex = 2;
            this.configGroup.TabStop = false;
            this.configGroup.Text = "Server Config";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Token:";
            // 
            // tokenTxt
            // 
            this.tokenTxt.Location = new System.Drawing.Point(23, 145);
            this.tokenTxt.Name = "tokenTxt";
            this.tokenTxt.Size = new System.Drawing.Size(300, 23);
            this.tokenTxt.TabIndex = 4;
            // 
            // statsTxt
            // 
            this.statsTxt.Location = new System.Drawing.Point(24, 204);
            this.statsTxt.Multiline = true;
            this.statsTxt.Name = "statsTxt";
            this.statsTxt.ReadOnly = true;
            this.statsTxt.Size = new System.Drawing.Size(299, 242);
            this.statsTxt.TabIndex = 5;
            this.statsTxt.Text = "Stats:";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(24, 175);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 6;
            this.applyBtn.Text = "Apply";
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Prefix:";
            // 
            // prefixTxt
            // 
            this.prefixTxt.Location = new System.Drawing.Point(89, 19);
            this.prefixTxt.Name = "prefixTxt";
            this.prefixTxt.Size = new System.Drawing.Size(28, 23);
            this.prefixTxt.TabIndex = 1;
            this.prefixTxt.Text = "-";
            this.prefixTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 45);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "AFK Channel:";
            // 
            // afkChanCBox
            // 
            this.afkChanCBox.FormattingEnabled = true;
            this.afkChanCBox.ItemHeight = 23;
            this.afkChanCBox.Location = new System.Drawing.Point(89, 45);
            this.afkChanCBox.Name = "afkChanCBox";
            this.afkChanCBox.Size = new System.Drawing.Size(164, 29);
            this.afkChanCBox.TabIndex = 3;
            // 
            // afkTimeCBox
            // 
            this.afkTimeCBox.FormattingEnabled = true;
            this.afkTimeCBox.ItemHeight = 23;
            this.afkTimeCBox.Items.AddRange(new object[] {
            "1",
            "5",
            "15",
            "30",
            "60"});
            this.afkTimeCBox.Location = new System.Drawing.Point(89, 77);
            this.afkTimeCBox.Name = "afkTimeCBox";
            this.afkTimeCBox.Size = new System.Drawing.Size(164, 29);
            this.afkTimeCBox.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "AFK Timeout:";
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(7, 111);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(151, 23);
            this.colorBtn.TabIndex = 6;
            this.colorBtn.Text = "Color: 100,150,255";
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // colorPrev
            // 
            this.colorPrev.BackColor = System.Drawing.SystemColors.Window;
            this.colorPrev.Location = new System.Drawing.Point(162, 111);
            this.colorPrev.Name = "colorPrev";
            this.colorPrev.Size = new System.Drawing.Size(91, 23);
            this.colorPrev.TabIndex = 7;
            this.colorPrev.TabStop = false;
            // 
            // tsToggle
            // 
            this.tsToggle.AutoSize = true;
            this.tsToggle.Location = new System.Drawing.Point(89, 143);
            this.tsToggle.Name = "tsToggle";
            this.tsToggle.Size = new System.Drawing.Size(80, 17);
            this.tsToggle.TabIndex = 8;
            this.tsToggle.Text = "Off";
            this.tsToggle.UseVisualStyleBackColor = true;
            this.tsToggle.CheckedChanged += new System.EventHandler(this.tsToggle_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 141);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Timestamp:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Advertising:";
            // 
            // adToggle
            // 
            this.adToggle.AutoSize = true;
            this.adToggle.Location = new System.Drawing.Point(89, 165);
            this.adToggle.Name = "adToggle";
            this.adToggle.Size = new System.Drawing.Size(80, 17);
            this.adToggle.TabIndex = 10;
            this.adToggle.Text = "Off";
            this.adToggle.UseVisualStyleBackColor = true;
            this.adToggle.CheckedChanged += new System.EventHandler(this.adToggle_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 185);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Verification:";
            // 
            // veriToggle
            // 
            this.veriToggle.AutoSize = true;
            this.veriToggle.Location = new System.Drawing.Point(90, 187);
            this.veriToggle.Name = "veriToggle";
            this.veriToggle.Size = new System.Drawing.Size(80, 17);
            this.veriToggle.TabIndex = 12;
            this.veriToggle.Text = "Off";
            this.veriToggle.UseVisualStyleBackColor = true;
            this.veriToggle.CheckedChanged += new System.EventHandler(this.veriToggle_CheckedChanged);
            // 
            // verRoleCBox
            // 
            this.verRoleCBox.FormattingEnabled = true;
            this.verRoleCBox.ItemHeight = 23;
            this.verRoleCBox.Location = new System.Drawing.Point(109, 207);
            this.verRoleCBox.Name = "verRoleCBox";
            this.verRoleCBox.Size = new System.Drawing.Size(144, 29);
            this.verRoleCBox.TabIndex = 15;
            this.verRoleCBox.SelectedIndexChanged += new System.EventHandler(this.verRoleCBox_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 207);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(106, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Verification Role:";
            // 
            // spamThresholdTxt
            // 
            this.spamThresholdTxt.Location = new System.Drawing.Point(110, 264);
            this.spamThresholdTxt.Name = "spamThresholdTxt";
            this.spamThresholdTxt.Size = new System.Drawing.Size(26, 23);
            this.spamThresholdTxt.TabIndex = 17;
            this.spamThresholdTxt.Text = "5";
            this.spamThresholdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 264);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Spam Threshold:";
            // 
            // spamTimeTxt
            // 
            this.spamTimeTxt.Location = new System.Drawing.Point(116, 289);
            this.spamTimeTxt.Name = "spamTimeTxt";
            this.spamTimeTxt.Size = new System.Drawing.Size(26, 23);
            this.spamTimeTxt.TabIndex = 19;
            this.spamTimeTxt.Text = "10";
            this.spamTimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 290);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(113, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Spam Mute Time:";
            // 
            // spamWarnTxt
            // 
            this.spamWarnTxt.Location = new System.Drawing.Point(117, 239);
            this.spamWarnTxt.Name = "spamWarnTxt";
            this.spamWarnTxt.Size = new System.Drawing.Size(26, 23);
            this.spamWarnTxt.TabIndex = 21;
            this.spamWarnTxt.Text = "3";
            this.spamWarnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(7, 239);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(110, 19);
            this.metroLabel12.TabIndex = 20;
            this.metroLabel12.Text = "Spam Msg Warn:";
            // 
            // footerTxt
            // 
            this.footerTxt.Location = new System.Drawing.Point(86, 318);
            this.footerTxt.Name = "footerTxt";
            this.footerTxt.Size = new System.Drawing.Size(292, 23);
            this.footerTxt.TabIndex = 23;
            this.footerTxt.Text = "Created By Abyscuit";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(7, 318);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(77, 19);
            this.metroLabel13.TabIndex = 22;
            this.metroLabel13.Text = "Footer Text:";
            // 
            // applyConfigBtn
            // 
            this.applyConfigBtn.Location = new System.Drawing.Point(7, 354);
            this.applyConfigBtn.Name = "applyConfigBtn";
            this.applyConfigBtn.Size = new System.Drawing.Size(86, 23);
            this.applyConfigBtn.TabIndex = 24;
            this.applyConfigBtn.Text = "Apply Config";
            this.applyConfigBtn.Click += new System.EventHandler(this.applyConfigBtn_Click);
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(632, 601);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(96, 23);
            this.sendMsgBtn.TabIndex = 7;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.Click += new System.EventHandler(this.sendMsgBtn_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(24, 453);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(700, 142);
            this.messageTxt.TabIndex = 8;
            this.messageTxt.Text = "Send a Message.";
            // 
            // embedChk
            // 
            this.embedChk.AutoSize = true;
            this.embedChk.Location = new System.Drawing.Point(566, 605);
            this.embedChk.Name = "embedChk";
            this.embedChk.Size = new System.Drawing.Size(60, 15);
            this.embedChk.TabIndex = 9;
            this.embedChk.Text = "Embed";
            this.embedChk.UseVisualStyleBackColor = true;
            // 
            // textChannelCBox
            // 
            this.textChannelCBox.FormattingEnabled = true;
            this.textChannelCBox.ItemHeight = 23;
            this.textChannelCBox.Location = new System.Drawing.Point(294, 597);
            this.textChannelCBox.Name = "textChannelCBox";
            this.textChannelCBox.Size = new System.Drawing.Size(266, 29);
            this.textChannelCBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 630);
            this.Controls.Add(this.textChannelCBox);
            this.Controls.Add(this.embedChk);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.sendMsgBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.statsTxt);
            this.Controls.Add(this.tokenTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.configGroup);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.serversCBox);
            this.Name = "Form1";
            this.Text = "ByscuitBot UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox serversCBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox configGroup;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tokenTxt;
        private MetroFramework.Controls.MetroTextBox statsTxt;
        private MetroFramework.Controls.MetroButton applyBtn;
        private MetroFramework.Controls.MetroTextBox prefixTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox afkTimeCBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox afkChanCBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton colorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox colorPrev;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle tsToggle;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle adToggle;
        private MetroFramework.Controls.MetroTextBox footerTxt;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox spamWarnTxt;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox spamTimeTxt;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox spamThresholdTxt;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox verRoleCBox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle veriToggle;
        private MetroFramework.Controls.MetroButton applyConfigBtn;
        private MetroFramework.Controls.MetroButton sendMsgBtn;
        private MetroFramework.Controls.MetroTextBox messageTxt;
        private MetroFramework.Controls.MetroCheckBox embedChk;
        private MetroFramework.Controls.MetroComboBox textChannelCBox;
    }
}

