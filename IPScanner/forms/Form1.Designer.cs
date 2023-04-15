using IPScanner.Properties;
using System;
using System.Windows.Forms;

namespace IPScanner
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
            this.button1 = new System.Windows.Forms.Button();
            this.IPBox = new MetroFramework.Controls.MetroTextBox();
            this.RunButton = new MetroFramework.Controls.MetroButton();
            this.GetFullInfo = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.TargetPortBox = new MetroFramework.Controls.MetroTextBox();
            this.console = new MetroFramework.Controls.MetroTextBox();
            this.ShowClosedPorts = new MetroFramework.Controls.MetroCheckBox();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.PortRangeScanCheck = new MetroFramework.Controls.MetroCheckBox();
            this.TimeoutBox = new MetroFramework.Controls.MetroTextBox();
            this.TimeoutLabel = new MetroFramework.Controls.MetroLabel();
            this.PortRangeBox = new MetroFramework.Controls.MetroTextBox();
            this.PortRangeLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::IPScanner.Properties.Resources.icons8_close_15;
            this.button1.Location = new System.Drawing.Point(874, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPBox
            // 
            this.IPBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IPBox.CustomBackground = true;
            this.IPBox.CustomForeColor = true;
            this.IPBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.IPBox.ForeColor = System.Drawing.Color.White;
            this.IPBox.Location = new System.Drawing.Point(85, 45);
            this.IPBox.MaxLength = 36;
            this.IPBox.Name = "IPBox";
            this.IPBox.PromptText = "Enter IP";
            this.IPBox.Size = new System.Drawing.Size(208, 23);
            this.IPBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.IPBox.TabIndex = 1;
            this.IPBox.Text = "192.168.1.1";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IPBox.UseStyleColors = true;
            // 
            // RunButton
            // 
            this.RunButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunButton.Highlight = true;
            this.RunButton.Location = new System.Drawing.Point(645, 45);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(121, 23);
            this.RunButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "Run";
            this.RunButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RunButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // GetFullInfo
            // 
            this.GetFullInfo.AutoSize = true;
            this.GetFullInfo.Location = new System.Drawing.Point(512, 45);
            this.GetFullInfo.Name = "GetFullInfo";
            this.GetFullInfo.Size = new System.Drawing.Size(127, 15);
            this.GetFullInfo.Style = MetroFramework.MetroColorStyle.Pink;
            this.GetFullInfo.TabIndex = 4;
            this.GetFullInfo.Text = "Get full information";
            this.GetFullInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GetFullInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GetFullInfo.UseStyleColors = true;
            this.GetFullInfo.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(85, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "IP address";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(299, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Ports";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(658, 21);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(96, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLink1.TabIndex = 7;
            this.metroLink1.Text = "Documentation";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // TargetPortBox
            // 
            this.TargetPortBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TargetPortBox.CustomBackground = true;
            this.TargetPortBox.CustomForeColor = true;
            this.TargetPortBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TargetPortBox.ForeColor = System.Drawing.Color.White;
            this.TargetPortBox.Location = new System.Drawing.Point(299, 45);
            this.TargetPortBox.MaxLength = 36;
            this.TargetPortBox.Name = "TargetPortBox";
            this.TargetPortBox.PromptText = "Enter port count";
            this.TargetPortBox.Size = new System.Drawing.Size(208, 23);
            this.TargetPortBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.TargetPortBox.TabIndex = 8;
            this.TargetPortBox.Text = "80, 443, 8090";
            this.TargetPortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TargetPortBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TargetPortBox.UseStyleColors = true;
            // 
            // console
            // 
            this.console.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.console.Location = new System.Drawing.Point(85, 138);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(681, 404);
            this.console.Style = MetroFramework.MetroColorStyle.Pink;
            this.console.TabIndex = 9;
            this.console.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ShowClosedPorts
            // 
            this.ShowClosedPorts.AutoSize = true;
            this.ShowClosedPorts.Location = new System.Drawing.Point(512, 66);
            this.ShowClosedPorts.Name = "ShowClosedPorts";
            this.ShowClosedPorts.Size = new System.Drawing.Size(119, 15);
            this.ShowClosedPorts.Style = MetroFramework.MetroColorStyle.Pink;
            this.ShowClosedPorts.TabIndex = 10;
            this.ShowClosedPorts.Text = "Show closed ports";
            this.ShowClosedPorts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowClosedPorts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowClosedPorts.UseStyleColors = true;
            this.ShowClosedPorts.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(645, 74);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(121, 23);
            this.ProgressBar.Style = MetroFramework.MetroColorStyle.Green;
            this.ProgressBar.TabIndex = 11;
            this.ProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PortRangeScanCheck
            // 
            this.PortRangeScanCheck.AutoSize = true;
            this.PortRangeScanCheck.Location = new System.Drawing.Point(512, 87);
            this.PortRangeScanCheck.Name = "PortRangeScanCheck";
            this.PortRangeScanCheck.Size = new System.Drawing.Size(93, 15);
            this.PortRangeScanCheck.Style = MetroFramework.MetroColorStyle.Pink;
            this.PortRangeScanCheck.TabIndex = 12;
            this.PortRangeScanCheck.Text = "Scan all ports";
            this.PortRangeScanCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PortRangeScanCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PortRangeScanCheck.UseStyleColors = true;
            this.PortRangeScanCheck.UseVisualStyleBackColor = true;
            this.PortRangeScanCheck.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // TimeoutBox
            // 
            this.TimeoutBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeoutBox.CustomBackground = true;
            this.TimeoutBox.CustomForeColor = true;
            this.TimeoutBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TimeoutBox.ForeColor = System.Drawing.Color.White;
            this.TimeoutBox.Location = new System.Drawing.Point(299, 87);
            this.TimeoutBox.MaxLength = 36;
            this.TimeoutBox.Name = "TimeoutBox";
            this.TimeoutBox.PromptText = "Enter a timeout in ms(Example: 500)";
            this.TimeoutBox.Size = new System.Drawing.Size(208, 23);
            this.TimeoutBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.TimeoutBox.TabIndex = 13;
            this.TimeoutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeoutBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeoutBox.UseStyleColors = true;
            this.TimeoutBox.Visible = false;
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.TimeoutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeoutLabel.Location = new System.Drawing.Point(296, 71);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(51, 15);
            this.TimeoutLabel.Style = MetroFramework.MetroColorStyle.White;
            this.TimeoutLabel.TabIndex = 14;
            this.TimeoutLabel.Text = "Timeout";
            this.TimeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeoutLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TimeoutLabel.UseStyleColors = true;
            this.TimeoutLabel.Visible = false;
            // 
            // PortRangeBox
            // 
            this.PortRangeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PortRangeBox.CustomBackground = true;
            this.PortRangeBox.CustomForeColor = true;
            this.PortRangeBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PortRangeBox.ForeColor = System.Drawing.Color.White;
            this.PortRangeBox.Location = new System.Drawing.Point(85, 87);
            this.PortRangeBox.MaxLength = 36;
            this.PortRangeBox.Name = "PortRangeBox";
            this.PortRangeBox.PromptText = "Example: 1-30000";
            this.PortRangeBox.Size = new System.Drawing.Size(208, 23);
            this.PortRangeBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.PortRangeBox.TabIndex = 15;
            this.PortRangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortRangeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PortRangeBox.UseStyleColors = true;
            this.PortRangeBox.Visible = false;
            // 
            // PortRangeLabel
            // 
            this.PortRangeLabel.AutoSize = true;
            this.PortRangeLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.PortRangeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PortRangeLabel.Location = new System.Drawing.Point(85, 69);
            this.PortRangeLabel.Name = "PortRangeLabel";
            this.PortRangeLabel.Size = new System.Drawing.Size(62, 15);
            this.PortRangeLabel.Style = MetroFramework.MetroColorStyle.White;
            this.PortRangeLabel.TabIndex = 16;
            this.PortRangeLabel.Text = "Port range";
            this.PortRangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortRangeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PortRangeLabel.UseStyleColors = true;
            this.PortRangeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.PortRangeLabel);
            this.Controls.Add(this.PortRangeBox);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.TimeoutBox);
            this.Controls.Add(this.PortRangeScanCheck);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ShowClosedPorts);
            this.Controls.Add(this.console);
            this.Controls.Add(this.TargetPortBox);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.GetFullInfo);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.button1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "IPScanner";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox IPBox;
        private MetroFramework.Controls.MetroButton RunButton;
        public MetroFramework.Controls.MetroCheckBox GetFullInfo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox TargetPortBox;
        public MetroFramework.Controls.MetroTextBox console;
        public MetroFramework.Controls.MetroCheckBox ShowClosedPorts;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        public MetroFramework.Controls.MetroCheckBox PortRangeScanCheck;
        private MetroFramework.Controls.MetroTextBox TimeoutBox;
        private MetroFramework.Controls.MetroLabel TimeoutLabel;
        private MetroFramework.Controls.MetroTextBox PortRangeBox;
        private MetroFramework.Controls.MetroLabel PortRangeLabel;
    }
}

