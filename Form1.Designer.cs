namespace Actiity_15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fullDateLabel = new System.Windows.Forms.Label();
            this.HoroscopeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullDateLabel
            // 
            this.fullDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.fullDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullDateLabel.Location = new System.Drawing.Point(77, 351);
            this.fullDateLabel.Name = "fullDateLabel";
            this.fullDateLabel.Size = new System.Drawing.Size(608, 63);
            this.fullDateLabel.TabIndex = 0;
            this.fullDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoroscopeButton
            // 
            this.HoroscopeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HoroscopeButton.Location = new System.Drawing.Point(51, 437);
            this.HoroscopeButton.Name = "HoroscopeButton";
            this.HoroscopeButton.Size = new System.Drawing.Size(277, 125);
            this.HoroscopeButton.TabIndex = 1;
            this.HoroscopeButton.Text = "Get Horoscope";
            this.HoroscopeButton.UseVisualStyleBackColor = false;
            this.HoroscopeButton.Click += new System.EventHandler(this.HoroscopeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Location = new System.Drawing.Point(422, 437);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(276, 125);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 574);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HoroscopeButton);
            this.Controls.Add(this.fullDateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Birthday";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fullDateLabel;
        private System.Windows.Forms.Button HoroscopeButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

