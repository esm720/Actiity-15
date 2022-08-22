namespace Actiity_15
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.astroPlaceHolderLabel = new System.Windows.Forms.Label();
            this.PHLabel = new System.Windows.Forms.Label();
            this.AstroPicBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SignLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AstroPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // astroPlaceHolderLabel
            // 
            this.astroPlaceHolderLabel.AutoSize = true;
            this.astroPlaceHolderLabel.Location = new System.Drawing.Point(0, 0);
            this.astroPlaceHolderLabel.Name = "astroPlaceHolderLabel";
            this.astroPlaceHolderLabel.Size = new System.Drawing.Size(0, 25);
            this.astroPlaceHolderLabel.TabIndex = 0;
            this.astroPlaceHolderLabel.Visible = false;
            // 
            // PHLabel
            // 
            this.PHLabel.AutoSize = true;
            this.PHLabel.Location = new System.Drawing.Point(0, 0);
            this.PHLabel.Name = "PHLabel";
            this.PHLabel.Size = new System.Drawing.Size(18, 25);
            this.PHLabel.TabIndex = 1;
            this.PHLabel.Text = " ";
            // 
            // AstroPicBox
            // 
            this.AstroPicBox.Location = new System.Drawing.Point(0, 0);
            this.AstroPicBox.Name = "AstroPicBox";
            this.AstroPicBox.Size = new System.Drawing.Size(592, 529);
            this.AstroPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AstroPicBox.TabIndex = 2;
            this.AstroPicBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Location = new System.Drawing.Point(181, 429);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(191, 77);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SignLabel
            // 
            this.SignLabel.BackColor = System.Drawing.Color.DimGray;
            this.SignLabel.Font = new System.Drawing.Font("MS PGothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(140, 352);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(292, 56);
            this.SignLabel.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 538);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AstroPicBox);
            this.Controls.Add(this.PHLabel);
            this.Controls.Add(this.astroPlaceHolderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Horoscope";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AstroPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label astroPlaceHolderLabel;
        private System.Windows.Forms.Label PHLabel;
        private System.Windows.Forms.PictureBox AstroPicBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SignLabel;
    }
}