﻿namespace FruitClassifierCNN
{
    partial class MainForm
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
            this.topText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.bgText_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.enterImage_button = new Guna.UI.WinForms.GunaGradiantButton();
            this.description_gunaLabel = new Guna.UI.WinForms.GunaLabel();
            this.bg_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradiantButton1 = new Guna.UI.WinForms.GunaGradiantButton();
            this.esc_button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.fruitPicture_gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.fruitImage_gunaPanel = new Guna.UI.WinForms.GunaPanel();
            this.cornClassified1 = new FruitClassifierCNN.UserControls.CornClassified();
            this.ripeCucumberClassified1 = new FruitClassifierCNN.UserControls.RipeCucumberClassified();
            this.bananaClassified1 = new FruitClassifierCNN.UserControls.BananaClassified();
            this.mangoClassified1 = new FruitClassifierCNN.UserControls.MangoClassified();
            this.fruitClassified1 = new FruitClassifierCNN.UserControls.FruitClassified();
            this.tomatoClassified1 = new FruitClassifierCNN.UserControls.TomatoClassified();
            this.bg_gunaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture_gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topText_gunaLabel
            // 
            this.topText_gunaLabel.AutoSize = true;
            this.topText_gunaLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topText_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.topText_gunaLabel.Location = new System.Drawing.Point(111, 31);
            this.topText_gunaLabel.Name = "topText_gunaLabel";
            this.topText_gunaLabel.Size = new System.Drawing.Size(353, 41);
            this.topText_gunaLabel.TabIndex = 1;
            this.topText_gunaLabel.Text = "CNN FRUIT CLASSIFIER";
            // 
            // bgText_gunaLabel
            // 
            this.bgText_gunaLabel.AutoSize = true;
            this.bgText_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgText_gunaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.bgText_gunaLabel.Location = new System.Drawing.Point(84, 140);
            this.bgText_gunaLabel.Name = "bgText_gunaLabel";
            this.bgText_gunaLabel.Size = new System.Drawing.Size(825, 246);
            this.bgText_gunaLabel.TabIndex = 2;
            this.bgText_gunaLabel.Text = "ENTER A PICTURE\r\nOF A FRUIT ";
            // 
            // enterImage_button
            // 
            this.enterImage_button.AnimationHoverSpeed = 0.07F;
            this.enterImage_button.AnimationSpeed = 0.03F;
            this.enterImage_button.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.enterImage_button.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            this.enterImage_button.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterImage_button.ForeColor = System.Drawing.Color.White;
            this.enterImage_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.enterImage_button.Image = null;
            this.enterImage_button.ImageSize = new System.Drawing.Size(20, 20);
            this.enterImage_button.Location = new System.Drawing.Point(105, 649);
            this.enterImage_button.Name = "enterImage_button";
            this.enterImage_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(208)))), ((int)(((byte)(103)))));
            this.enterImage_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(187)))), ((int)(((byte)(55)))));
            this.enterImage_button.OnHoverForeColor = System.Drawing.Color.White;
            this.enterImage_button.OnHoverImage = null;
            this.enterImage_button.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(165)))), ((int)(((byte)(24)))));
            this.enterImage_button.OnPressedDepth = 70;
            this.enterImage_button.Radius = 30;
            this.enterImage_button.Size = new System.Drawing.Size(302, 76);
            this.enterImage_button.TabIndex = 3;
            this.enterImage_button.Text = "SELECT IMAGE";
            this.enterImage_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterImage_button.Click += new System.EventHandler(this.enterImage_button_Click);
            // 
            // description_gunaLabel
            // 
            this.description_gunaLabel.AutoSize = true;
            this.description_gunaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F);
            this.description_gunaLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.description_gunaLabel.Location = new System.Drawing.Point(101, 430);
            this.description_gunaLabel.Name = "description_gunaLabel";
            this.description_gunaLabel.Size = new System.Drawing.Size(720, 152);
            this.description_gunaLabel.TabIndex = 5;
            this.description_gunaLabel.Text = "This software is a Fruit Classifier software that utilizes a \r\nConvolutional Neur" +
    "al Network to accurately identify and \r\ncategorize different types of fruits bas" +
    "ed on their visual \r\ncharacteristics.";
            // 
            // bg_gunaPanel
            // 
            this.bg_gunaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.bg_gunaPanel.Controls.Add(this.gunaGradiantButton1);
            this.bg_gunaPanel.Controls.Add(this.fruitPicture_gunaPictureBox);
            this.bg_gunaPanel.Controls.Add(this.description_gunaLabel);
            this.bg_gunaPanel.Controls.Add(this.fruitImage_gunaPanel);
            this.bg_gunaPanel.Controls.Add(this.enterImage_button);
            this.bg_gunaPanel.Controls.Add(this.bgText_gunaLabel);
            this.bg_gunaPanel.Location = new System.Drawing.Point(70, 100);
            this.bg_gunaPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bg_gunaPanel.Name = "bg_gunaPanel";
            this.bg_gunaPanel.Size = new System.Drawing.Size(1910, 897);
            this.bg_gunaPanel.TabIndex = 0;
            // 
            // gunaGradiantButton1
            // 
            this.gunaGradiantButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradiantButton1.AnimationSpeed = 0.03F;
            this.gunaGradiantButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(128)))));
            this.gunaGradiantButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(62)))));
            this.gunaGradiantButton1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradiantButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradiantButton1.Image = null;
            this.gunaGradiantButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradiantButton1.Location = new System.Drawing.Point(105, 741);
            this.gunaGradiantButton1.Name = "gunaGradiantButton1";
            this.gunaGradiantButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(208)))), ((int)(((byte)(103)))));
            this.gunaGradiantButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(187)))), ((int)(((byte)(55)))));
            this.gunaGradiantButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradiantButton1.OnHoverImage = null;
            this.gunaGradiantButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(165)))), ((int)(((byte)(24)))));
            this.gunaGradiantButton1.OnPressedDepth = 70;
            this.gunaGradiantButton1.Radius = 30;
            this.gunaGradiantButton1.Size = new System.Drawing.Size(302, 76);
            this.gunaGradiantButton1.TabIndex = 7;
            this.gunaGradiantButton1.Text = "ENTER";
            this.gunaGradiantButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradiantButton1.Click += new System.EventHandler(this.gunaGradiantButton1_Click);
            // 
            // esc_button
            // 
            this.esc_button.AnimationHoverSpeed = 0.07F;
            this.esc_button.AnimationSpeed = 0.03F;
            this.esc_button.BaseColor = System.Drawing.Color.White;
            this.esc_button.BorderColor = System.Drawing.Color.Black;
            this.esc_button.CheckedBaseColor = System.Drawing.Color.Gray;
            this.esc_button.CheckedBorderColor = System.Drawing.Color.Black;
            this.esc_button.CheckedForeColor = System.Drawing.Color.White;
            this.esc_button.CheckedImage = null;
            this.esc_button.CheckedLineColor = System.Drawing.Color.DimGray;
            this.esc_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.esc_button.ForeColor = System.Drawing.Color.White;
            this.esc_button.Image = global::FruitClassifierCNN.Properties.Resources.close;
            this.esc_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.esc_button.ImageSize = new System.Drawing.Size(20, 20);
            this.esc_button.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.esc_button.Location = new System.Drawing.Point(1950, 31);
            this.esc_button.Name = "esc_button";
            this.esc_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.esc_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.esc_button.OnHoverForeColor = System.Drawing.Color.White;
            this.esc_button.OnHoverImage = null;
            this.esc_button.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.esc_button.OnPressedColor = System.Drawing.Color.Black;
            this.esc_button.Size = new System.Drawing.Size(47, 43);
            this.esc_button.TabIndex = 3;
            this.esc_button.Click += new System.EventHandler(this.esc_button_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1.BackgroundImage = global::FruitClassifierCNN.Properties.Resources.mango;
            this.gunaLinePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(485, 29);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(40, 41);
            this.gunaLinePanel1.TabIndex = 2;
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
            this.fruitPicture_gunaPictureBox.TabIndex = 6;
            this.fruitPicture_gunaPictureBox.TabStop = false;
            // 
            // fruitImage_gunaPanel
            // 
            this.fruitImage_gunaPanel.BackColor = System.Drawing.Color.Transparent;
            this.fruitImage_gunaPanel.BackgroundImage = global::FruitClassifierCNN.Properties.Resources.PngItem_1945310;
            this.fruitImage_gunaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fruitImage_gunaPanel.Location = new System.Drawing.Point(1034, 3);
            this.fruitImage_gunaPanel.Name = "fruitImage_gunaPanel";
            this.fruitImage_gunaPanel.Size = new System.Drawing.Size(873, 894);
            this.fruitImage_gunaPanel.TabIndex = 4;
            // 
            // cornClassified1
            // 
            this.cornClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.cornClassified1.Location = new System.Drawing.Point(70, 100);
            this.cornClassified1.Name = "cornClassified1";
            this.cornClassified1.Size = new System.Drawing.Size(1910, 897);
            this.cornClassified1.TabIndex = 8;
            // 
            // ripeCucumberClassified1
            // 
            this.ripeCucumberClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.ripeCucumberClassified1.Location = new System.Drawing.Point(70, 100);
            this.ripeCucumberClassified1.Name = "ripeCucumberClassified1";
            this.ripeCucumberClassified1.Size = new System.Drawing.Size(1910, 897);
            this.ripeCucumberClassified1.TabIndex = 7;
            // 
            // bananaClassified1
            // 
            this.bananaClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.bananaClassified1.Location = new System.Drawing.Point(70, 100);
            this.bananaClassified1.Name = "bananaClassified1";
            this.bananaClassified1.Size = new System.Drawing.Size(1910, 897);
            this.bananaClassified1.TabIndex = 6;
            // 
            // mangoClassified1
            // 
            this.mangoClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.mangoClassified1.Location = new System.Drawing.Point(70, 100);
            this.mangoClassified1.Name = "mangoClassified1";
            this.mangoClassified1.Size = new System.Drawing.Size(1910, 897);
            this.mangoClassified1.TabIndex = 5;
            // 
            // fruitClassified1
            // 
            this.fruitClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.fruitClassified1.Location = new System.Drawing.Point(70, 100);
            this.fruitClassified1.Name = "fruitClassified1";
            this.fruitClassified1.Size = new System.Drawing.Size(1910, 897);
            this.fruitClassified1.TabIndex = 4;
            // 
            // tomatoClassified1
            // 
            this.tomatoClassified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
            this.tomatoClassified1.Location = new System.Drawing.Point(70, 100);
            this.tomatoClassified1.Name = "tomatoClassified1";
            this.tomatoClassified1.Size = new System.Drawing.Size(1910, 897);
            this.tomatoClassified1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1980, 1020);
            this.Controls.Add(this.tomatoClassified1);
            this.Controls.Add(this.cornClassified1);
            this.Controls.Add(this.ripeCucumberClassified1);
            this.Controls.Add(this.bananaClassified1);
            this.Controls.Add(this.mangoClassified1);
            this.Controls.Add(this.fruitClassified1);
            this.Controls.Add(this.esc_button);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.topText_gunaLabel);
            this.Controls.Add(this.bg_gunaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "FruitClassifer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bg_gunaPanel.ResumeLayout(false);
            this.bg_gunaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPicture_gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel topText_gunaLabel;
        private Guna.UI.WinForms.GunaLabel bgText_gunaLabel;
        private Guna.UI.WinForms.GunaGradiantButton enterImage_button;
        private Guna.UI.WinForms.GunaPanel fruitImage_gunaPanel;
        private Guna.UI.WinForms.GunaLabel description_gunaLabel;
        private Guna.UI.WinForms.GunaPanel bg_gunaPanel;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaAdvenceButton esc_button;
        private Guna.UI.WinForms.GunaPictureBox fruitPicture_gunaPictureBox;
        private Guna.UI.WinForms.GunaGradiantButton gunaGradiantButton1;
        private UserControls.FruitClassified fruitClassified1;
        private UserControls.MangoClassified mangoClassified1;
        private UserControls.BananaClassified bananaClassified1;
        private UserControls.RipeCucumberClassified ripeCucumberClassified1;
        private UserControls.CornClassified cornClassified1;
        private UserControls.TomatoClassified tomatoClassified1;
    }
}

