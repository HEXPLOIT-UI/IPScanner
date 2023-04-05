using IPScanner.Properties;

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
            this.PORTCounter = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::IPScanner.Properties.Resources.icons8_close_15;
            this.button1.Location = new System.Drawing.Point(777, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPBox
            // 
            this.IPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IPBox.CustomBackground = true;
            this.IPBox.CustomForeColor = true;
            this.IPBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.IPBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.IPBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IPBox.Location = new System.Drawing.Point(294, 171);
            this.IPBox.MaxLength = 36;
            this.IPBox.Name = "IPBox";
            this.IPBox.PromptText = "Enter IP";
            this.IPBox.Size = new System.Drawing.Size(208, 23);
            this.IPBox.Style = MetroFramework.MetroColorStyle.Lime;
            this.IPBox.TabIndex = 1;
            this.IPBox.Text = "192.168.1.1";
            this.IPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IPBox.UseStyleColors = true;
            // 
            // PORTCounter
            // 
            this.PORTCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PORTCounter.CustomBackground = true;
            this.PORTCounter.CustomForeColor = true;
            this.PORTCounter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PORTCounter.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.PORTCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PORTCounter.Location = new System.Drawing.Point(294, 210);
            this.PORTCounter.MaxLength = 36;
            this.PORTCounter.Name = "PORTCounter";
            this.PORTCounter.PromptText = "Enter port count";
            this.PORTCounter.Size = new System.Drawing.Size(208, 23);
            this.PORTCounter.Style = MetroFramework.MetroColorStyle.Lime;
            this.PORTCounter.TabIndex = 2;
            this.PORTCounter.Text = "30000";
            this.PORTCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORTCounter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PORTCounter.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(341, 255);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Run";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PORTCounter);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.button1);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "IPScanner";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox IPBox;
        private MetroFramework.Controls.MetroTextBox PORTCounter;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

