﻿namespace PetStop.Forms
{
	partial class BioMonForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BioMonForm));
			this.LblCleanliness = new System.Windows.Forms.Label();
			this.LblVigor = new System.Windows.Forms.Label();
			this.LblCommunication = new System.Windows.Forms.Label();
			this.PrBarCleanliness = new System.Windows.Forms.ProgressBar();
			this.PrBarVigor = new System.Windows.Forms.ProgressBar();
			this.PrBarCommunication = new System.Windows.Forms.ProgressBar();
			this.LblHappy = new System.Windows.Forms.Label();
			this.LblThirst = new System.Windows.Forms.Label();
			this.LblHunger = new System.Windows.Forms.Label();
			this.PrBarHydration = new System.Windows.Forms.ProgressBar();
			this.PrBarSatiety = new System.Windows.Forms.ProgressBar();
			this.PrBarHappiness = new System.Windows.Forms.ProgressBar();
			this.LblAgeText = new System.Windows.Forms.Label();
			this.LblAge = new System.Windows.Forms.Label();
			this.BtnExit = new System.Windows.Forms.Button();
			this.PicBoxPet = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.SuspendLayout();
			// 
			// LblCleanliness
			// 
			this.LblCleanliness.AutoSize = true;
			this.LblCleanliness.BackColor = System.Drawing.Color.Transparent;
			this.LblCleanliness.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCleanliness.ForeColor = System.Drawing.Color.White;
			this.LblCleanliness.Location = new System.Drawing.Point(21, 157);
			this.LblCleanliness.Name = "LblCleanliness";
			this.LblCleanliness.Size = new System.Drawing.Size(76, 23);
			this.LblCleanliness.TabIndex = 11;
			this.LblCleanliness.Text = "Чистота:";
			// 
			// LblVigor
			// 
			this.LblVigor.AutoSize = true;
			this.LblVigor.BackColor = System.Drawing.Color.Transparent;
			this.LblVigor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblVigor.ForeColor = System.Drawing.Color.White;
			this.LblVigor.Location = new System.Drawing.Point(12, 128);
			this.LblVigor.Name = "LblVigor";
			this.LblVigor.Size = new System.Drawing.Size(85, 23);
			this.LblVigor.TabIndex = 9;
			this.LblVigor.Text = "Бодрость:";
			// 
			// LblCommunication
			// 
			this.LblCommunication.AutoSize = true;
			this.LblCommunication.BackColor = System.Drawing.Color.Transparent;
			this.LblCommunication.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCommunication.ForeColor = System.Drawing.Color.White;
			this.LblCommunication.Location = new System.Drawing.Point(13, 99);
			this.LblCommunication.Name = "LblCommunication";
			this.LblCommunication.Size = new System.Drawing.Size(84, 23);
			this.LblCommunication.TabIndex = 7;
			this.LblCommunication.Text = "Общение:";
			// 
			// PrBarCleanliness
			// 
			this.PrBarCleanliness.Location = new System.Drawing.Point(103, 157);
			this.PrBarCleanliness.Maximum = 10000;
			this.PrBarCleanliness.Name = "PrBarCleanliness";
			this.PrBarCleanliness.Size = new System.Drawing.Size(150, 23);
			this.PrBarCleanliness.TabIndex = 12;
			this.PrBarCleanliness.Value = 10000;
			// 
			// PrBarVigor
			// 
			this.PrBarVigor.Location = new System.Drawing.Point(103, 128);
			this.PrBarVigor.Maximum = 10000;
			this.PrBarVigor.Name = "PrBarVigor";
			this.PrBarVigor.Size = new System.Drawing.Size(150, 23);
			this.PrBarVigor.TabIndex = 10;
			this.PrBarVigor.Value = 10000;
			// 
			// PrBarCommunication
			// 
			this.PrBarCommunication.Location = new System.Drawing.Point(103, 99);
			this.PrBarCommunication.Maximum = 10000;
			this.PrBarCommunication.Name = "PrBarCommunication";
			this.PrBarCommunication.Size = new System.Drawing.Size(150, 23);
			this.PrBarCommunication.TabIndex = 8;
			this.PrBarCommunication.Value = 10000;
			// 
			// LblHappy
			// 
			this.LblHappy.AutoSize = true;
			this.LblHappy.BackColor = System.Drawing.Color.Black;
			this.LblHappy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblHappy.ForeColor = System.Drawing.Color.White;
			this.LblHappy.Location = new System.Drawing.Point(23, 9);
			this.LblHappy.Name = "LblHappy";
			this.LblHappy.Size = new System.Drawing.Size(74, 23);
			this.LblHappy.TabIndex = 1;
			this.LblHappy.Text = "Счастье:";
			// 
			// LblThirst
			// 
			this.LblThirst.AutoSize = true;
			this.LblThirst.BackColor = System.Drawing.Color.Transparent;
			this.LblThirst.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblThirst.ForeColor = System.Drawing.Color.White;
			this.LblThirst.Location = new System.Drawing.Point(32, 70);
			this.LblThirst.Name = "LblThirst";
			this.LblThirst.Size = new System.Drawing.Size(65, 23);
			this.LblThirst.TabIndex = 5;
			this.LblThirst.Text = "Жажда:";
			// 
			// LblHunger
			// 
			this.LblHunger.AutoSize = true;
			this.LblHunger.BackColor = System.Drawing.Color.Transparent;
			this.LblHunger.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHunger.ForeColor = System.Drawing.Color.White;
			this.LblHunger.Location = new System.Drawing.Point(35, 41);
			this.LblHunger.Name = "LblHunger";
			this.LblHunger.Size = new System.Drawing.Size(62, 23);
			this.LblHunger.TabIndex = 3;
			this.LblHunger.Text = "Голод:";
			// 
			// PrBarHydration
			// 
			this.PrBarHydration.Location = new System.Drawing.Point(103, 70);
			this.PrBarHydration.Maximum = 10000;
			this.PrBarHydration.Name = "PrBarHydration";
			this.PrBarHydration.Size = new System.Drawing.Size(150, 23);
			this.PrBarHydration.TabIndex = 6;
			this.PrBarHydration.Value = 10000;
			// 
			// PrBarSatiety
			// 
			this.PrBarSatiety.Location = new System.Drawing.Point(103, 41);
			this.PrBarSatiety.Maximum = 10000;
			this.PrBarSatiety.Name = "PrBarSatiety";
			this.PrBarSatiety.Size = new System.Drawing.Size(150, 23);
			this.PrBarSatiety.TabIndex = 4;
			this.PrBarSatiety.Value = 10000;
			// 
			// PrBarHappiness
			// 
			this.PrBarHappiness.Location = new System.Drawing.Point(103, 12);
			this.PrBarHappiness.Maximum = 50000;
			this.PrBarHappiness.Name = "PrBarHappiness";
			this.PrBarHappiness.Size = new System.Drawing.Size(150, 23);
			this.PrBarHappiness.TabIndex = 2;
			this.PrBarHappiness.Value = 50000;
			// 
			// LblAgeText
			// 
			this.LblAgeText.AutoSize = true;
			this.LblAgeText.BackColor = System.Drawing.Color.Transparent;
			this.LblAgeText.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAgeText.ForeColor = System.Drawing.Color.White;
			this.LblAgeText.Location = new System.Drawing.Point(103, 186);
			this.LblAgeText.Name = "LblAgeText";
			this.LblAgeText.Size = new System.Drawing.Size(20, 23);
			this.LblAgeText.TabIndex = 14;
			this.LblAgeText.Text = "0";
			this.LblAgeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblAge
			// 
			this.LblAge.AutoSize = true;
			this.LblAge.BackColor = System.Drawing.Color.Transparent;
			this.LblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAge.ForeColor = System.Drawing.Color.White;
			this.LblAge.Location = new System.Drawing.Point(23, 186);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(74, 23);
			this.LblAge.TabIndex = 13;
			this.LblAge.Text = "Возраст:";
			this.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BtnExit
			// 
			this.BtnExit.AutoSize = true;
			this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnExit.Location = new System.Drawing.Point(578, 238);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(101, 33);
			this.BtnExit.TabIndex = 0;
			this.BtnExit.Text = "Закрыть";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// PicBoxPet
			// 
			this.PicBoxPet.BackColor = System.Drawing.Color.Transparent;
			this.PicBoxPet.Image = global::PetStop.Properties.Resources.petGS1;
			this.PicBoxPet.Location = new System.Drawing.Point(449, 42);
			this.PicBoxPet.Name = "PicBoxPet";
			this.PicBoxPet.Size = new System.Drawing.Size(230, 167);
			this.PicBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBoxPet.TabIndex = 36;
			this.PicBoxPet.TabStop = false;
			// 
			// BioMonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PetStop.Properties.Resources.bgBioMon;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(691, 283);
			this.Controls.Add(this.PicBoxPet);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.LblAge);
			this.Controls.Add(this.LblAgeText);
			this.Controls.Add(this.LblCleanliness);
			this.Controls.Add(this.LblVigor);
			this.Controls.Add(this.LblCommunication);
			this.Controls.Add(this.PrBarCleanliness);
			this.Controls.Add(this.PrBarVigor);
			this.Controls.Add(this.PrBarCommunication);
			this.Controls.Add(this.LblHappy);
			this.Controls.Add(this.LblThirst);
			this.Controls.Add(this.LblHunger);
			this.Controls.Add(this.PrBarHydration);
			this.Controls.Add(this.PrBarSatiety);
			this.Controls.Add(this.PrBarHappiness);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(707, 322);
			this.MinimumSize = new System.Drawing.Size(707, 322);
			this.Name = "BioMonForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Биомон";
			this.Load += new System.EventHandler(this.BioMonForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblCleanliness;
		private System.Windows.Forms.Label LblVigor;
		private System.Windows.Forms.Label LblCommunication;
		private System.Windows.Forms.ProgressBar PrBarCleanliness;
		private System.Windows.Forms.ProgressBar PrBarVigor;
		private System.Windows.Forms.ProgressBar PrBarCommunication;
		private System.Windows.Forms.Label LblHappy;
		private System.Windows.Forms.Label LblThirst;
		private System.Windows.Forms.Label LblHunger;
		private System.Windows.Forms.ProgressBar PrBarHydration;
		private System.Windows.Forms.ProgressBar PrBarSatiety;
		private System.Windows.Forms.ProgressBar PrBarHappiness;
		private System.Windows.Forms.Label LblAgeText;
		private System.Windows.Forms.Label LblAge;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.PictureBox PicBoxPet;
	}
}