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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.fullScan = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.PortBox = new MetroFramework.Controls.MetroTextBox();
            this.console = new MetroFramework.Controls.MetroTextBox();
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
            this.IPBox.Location = new System.Drawing.Point(85, 60);
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
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(645, 60);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Run";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroCheckBox1
            // 
            this.fullScan.AutoSize = true;
            this.fullScan.Location = new System.Drawing.Point(513, 64);
            this.fullScan.Name = "metroCheckBox1";
            this.fullScan.Size = new System.Drawing.Size(126, 15);
            this.fullScan.Style = MetroFramework.MetroColorStyle.Pink;
            this.fullScan.TabIndex = 4;
            this.fullScan.Text = "get full information";
            this.fullScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fullScan.UseStyleColors = true;
            this.fullScan.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(85, 39);
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
            this.metroLabel2.Location = new System.Drawing.Point(299, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Port count";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(658, 34);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(96, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLink1.TabIndex = 7;
            this.metroLink1.Text = "Documentation";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // PortBox
            // 
            this.PortBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PortBox.CustomBackground = true;
            this.PortBox.CustomForeColor = true;
            this.PortBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PortBox.ForeColor = System.Drawing.Color.White;
            this.PortBox.Location = new System.Drawing.Point(299, 60);
            this.PortBox.MaxLength = 36;
            this.PortBox.Name = "PortBox";
            this.PortBox.PromptText = "Enter port count";
            this.PortBox.Size = new System.Drawing.Size(208, 23);
            this.PortBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.PortBox.TabIndex = 8;
            this.PortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PortBox.UseStyleColors = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.console);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.fullScan);
            this.Controls.Add(this.metroButton1);
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
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroCheckBox fullScan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox PortBox;
        public MetroFramework.Controls.MetroTextBox console;
    }
}

