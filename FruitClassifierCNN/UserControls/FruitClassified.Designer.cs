namespace FruitClassifierCNN.UserControls
{
    partial class FruitClassified
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fruitClassifyLabel_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.fruitDescription_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.enterAgain_gunaGradiantButton = new Guna.UI.WinForms.GunaGradiantButton();
            this.fruitPicture_gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture_gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitClassifyLabel_gunaLabel
            // 
            this.fruitClassifyLabel_gunaLabel.AutoSize = true;
            this.fruitClassifyLabel_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitClassifyLabel_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.fruitClassifyLabel_gunaLabel.Location = new System.Drawing.Point(84, 140);
            this.fruitClassifyLabel_gunaLabel.Name = "fruitClassifyLabel_gunaLabel";
            this.fruitClassifyLabel_gunaLabel.Size = new System.Drawing.Size(766, 246);
            this.fruitClassifyLabel_gunaLabel.TabIndex = 3;
            this.fruitClassifyLabel_gunaLabel.Text = "RE-ENTER FRUIT\r\nIMAGE";
            // 
            // fruitDescription_gunaLabel
            // 
            this.fruitDescription_gunaLabel.AutoSize = true;
            this.fruitDescription_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitDescription_gunaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fruitDescription_gunaLabel.Location = new System.Drawing.Point(101, 430);
            this.fruitDescription_gunaLabel.Name = "fruitDescription_gunaLabel";
            this.fruitDescription_gunaLabel.Size = new System.Drawing.Size(25, 38);
            this.fruitDescription_gunaLabel.TabIndex = 6;
            this.fruitDescription_gunaLabel.Text = " ";
            // 
            // enterAgain_gunaGradiantButton
            // 
            this.enterAgain_gunaGradiantButton.AnimationHoverSpeed = 0.07F;
            this.enterAgain_gunaGradiantButton.AnimationSpeed = 0.03F;
            this.enterAgain_gunaGradiantButton.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.enterAgain_gunaGradiantButton.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            this.enterAgain_gunaGradiantButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterAgain_gunaGradiantButton.ForeColor = System.Drawing.Color.White;
            this.enterAgain_gunaGradiantButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.enterAgain_gunaGradiantButton.Image = null;
            this.enterAgain_gunaGradiantButton.ImageSize = new System.Drawing.Size(20, 20);
            this.enterAgain_gunaGradiantButton.Location = new System.Drawing.Point(105, 741);
            this.enterAgain_gunaGradiantButton.Name = "enterAgain_gunaGradiantButton";
            this.enterAgain_gunaGradiantButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(208)))), ((int)(((byte)(103)))));
            this.enterAgain_gunaGradiantButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(187)))), ((int)(((byte)(55)))));
            this.enterAgain_gunaGradiantButton.OnHoverForeColor = System.Drawing.Color.White;
            this.enterAgain_gunaGradiantButton.OnHoverImage = null;
            this.enterAgain_gunaGradiantButton.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(165)))), ((int)(((byte)(24)))));
            this.enterAgain_gunaGradiantButton.OnPressedDepth = 70;
            this.enterAgain_gunaGradiantButton.Radius = 30;
            this.enterAgain_gunaGradiantButton.Size = new System.Drawing.Size(302, 76);
            this.enterAgain_gunaGradiantButton.TabIndex = 8;
            this.enterAgain_gunaGradiantButton.Text = "ENTER AGAIN";
            this.enterAgain_gunaGradiantButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterAgain_gunaGradiantButton.Click += new System.EventHandler(this.enterAgain_gunaGradiantButton_Click);
            // 
            // fruitPicture_gunaPictureBox
            // 
            this.fruitPicture_gunaPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.fruitPicture_gunaPictureBox.BaseColor = System.Drawing.Color.Transparent;
            this.fruitPicture_gunaPictureBox.Location = new System.Drawing.Point(1016, 52);
            this.fruitPicture_gunaPictureBox.Name = "fruitPicture_gunaPictureBox";
            this.fruitPicture_gunaPictureBox.Radius = 20;
            this.fruitPicture_gunaPictureBox.Size = new System.Drawing.Size(850, 800);
            this.fruitPicture_gunaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fruitPicture_gunaPictureBox.TabIndex = 7;
            this.fruitPicture_gunaPictureBox.TabStop = false;
            // 
            // FruitClassified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.enterAgain_gunaGradiantButton);
            this.Controls.Add(this.fruitPicture_gunaPictureBox);
            this.Controls.Add(this.fruitDescription_gunaLabel);
            this.Controls.Add(this.fruitClassifyLabel_gunaLabel);
            this.Name = "FruitClassified";
            this.Size = new System.Drawing.Size(1910, 897);
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture_gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel fruitDescription_gunaLabel;
        private Guna.UI.WinForms.GunaPictureBox fruitPicture_gunaPictureBox;
        private Guna.UI.WinForms.GunaGradiantButton enterAgain_gunaGradiantButton;
        public Guna.UI.WinForms.GunaLabel fruitClassifyLabel_gunaLabel;
    }
}
