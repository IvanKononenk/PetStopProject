namespace PetStop.Forms
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
			this.LblExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblCleanliness
			// 
			this.LblCleanliness.AutoSize = true;
			this.LblCleanliness.BackColor = System.Drawing.SystemColors.Control;
			this.LblCleanliness.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCleanliness.Location = new System.Drawing.Point(21, 157);
			this.LblCleanliness.Name = "LblCleanliness";
			this.LblCleanliness.Size = new System.Drawing.Size(76, 23);
			this.LblCleanliness.TabIndex = 33;
			this.LblCleanliness.Text = "Чистота:";
			// 
			// LblVigor
			// 
			this.LblVigor.AutoSize = true;
			this.LblVigor.BackColor = System.Drawing.SystemColors.Control;
			this.LblVigor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblVigor.Location = new System.Drawing.Point(12, 128);
			this.LblVigor.Name = "LblVigor";
			this.LblVigor.Size = new System.Drawing.Size(85, 23);
			this.LblVigor.TabIndex = 32;
			this.LblVigor.Text = "Бодрость:";
			// 
			// LblCommunication
			// 
			this.LblCommunication.AutoSize = true;
			this.LblCommunication.BackColor = System.Drawing.SystemColors.Control;
			this.LblCommunication.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCommunication.Location = new System.Drawing.Point(13, 99);
			this.LblCommunication.Name = "LblCommunication";
			this.LblCommunication.Size = new System.Drawing.Size(84, 23);
			this.LblCommunication.TabIndex = 31;
			this.LblCommunication.Text = "Общение:";
			// 
			// PrBarCleanliness
			// 
			this.PrBarCleanliness.Location = new System.Drawing.Point(103, 157);
			this.PrBarCleanliness.Maximum = 10000;
			this.PrBarCleanliness.Name = "PrBarCleanliness";
			this.PrBarCleanliness.Size = new System.Drawing.Size(150, 23);
			this.PrBarCleanliness.TabIndex = 30;
			this.PrBarCleanliness.Value = 10000;
			// 
			// PrBarVigor
			// 
			this.PrBarVigor.Location = new System.Drawing.Point(103, 128);
			this.PrBarVigor.Maximum = 10000;
			this.PrBarVigor.Name = "PrBarVigor";
			this.PrBarVigor.Size = new System.Drawing.Size(150, 23);
			this.PrBarVigor.TabIndex = 29;
			this.PrBarVigor.Value = 10000;
			// 
			// PrBarCommunication
			// 
			this.PrBarCommunication.Location = new System.Drawing.Point(103, 99);
			this.PrBarCommunication.Maximum = 10000;
			this.PrBarCommunication.Name = "PrBarCommunication";
			this.PrBarCommunication.Size = new System.Drawing.Size(150, 23);
			this.PrBarCommunication.TabIndex = 28;
			this.PrBarCommunication.Value = 10000;
			// 
			// LblHappy
			// 
			this.LblHappy.AutoSize = true;
			this.LblHappy.BackColor = System.Drawing.SystemColors.Control;
			this.LblHappy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblHappy.Location = new System.Drawing.Point(23, 9);
			this.LblHappy.Name = "LblHappy";
			this.LblHappy.Size = new System.Drawing.Size(74, 23);
			this.LblHappy.TabIndex = 27;
			this.LblHappy.Text = "Счастье:";
			// 
			// LblThirst
			// 
			this.LblThirst.AutoSize = true;
			this.LblThirst.BackColor = System.Drawing.SystemColors.Control;
			this.LblThirst.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblThirst.Location = new System.Drawing.Point(32, 70);
			this.LblThirst.Name = "LblThirst";
			this.LblThirst.Size = new System.Drawing.Size(65, 23);
			this.LblThirst.TabIndex = 26;
			this.LblThirst.Text = "Жажда:";
			// 
			// LblHunger
			// 
			this.LblHunger.AutoSize = true;
			this.LblHunger.BackColor = System.Drawing.SystemColors.Control;
			this.LblHunger.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHunger.Location = new System.Drawing.Point(35, 41);
			this.LblHunger.Name = "LblHunger";
			this.LblHunger.Size = new System.Drawing.Size(62, 23);
			this.LblHunger.TabIndex = 25;
			this.LblHunger.Text = "Голод:";
			// 
			// PrBarHydration
			// 
			this.PrBarHydration.Location = new System.Drawing.Point(103, 70);
			this.PrBarHydration.Maximum = 10000;
			this.PrBarHydration.Name = "PrBarHydration";
			this.PrBarHydration.Size = new System.Drawing.Size(150, 23);
			this.PrBarHydration.TabIndex = 24;
			this.PrBarHydration.Value = 10000;
			// 
			// PrBarSatiety
			// 
			this.PrBarSatiety.Location = new System.Drawing.Point(103, 41);
			this.PrBarSatiety.Maximum = 10000;
			this.PrBarSatiety.Name = "PrBarSatiety";
			this.PrBarSatiety.Size = new System.Drawing.Size(150, 23);
			this.PrBarSatiety.TabIndex = 23;
			this.PrBarSatiety.Value = 10000;
			// 
			// PrBarHappiness
			// 
			this.PrBarHappiness.Location = new System.Drawing.Point(103, 12);
			this.PrBarHappiness.Maximum = 50000;
			this.PrBarHappiness.Name = "PrBarHappiness";
			this.PrBarHappiness.Size = new System.Drawing.Size(150, 23);
			this.PrBarHappiness.TabIndex = 22;
			this.PrBarHappiness.Value = 50000;
			// 
			// LblAgeText
			// 
			this.LblAgeText.AutoSize = true;
			this.LblAgeText.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAgeText.Location = new System.Drawing.Point(103, 186);
			this.LblAgeText.Name = "LblAgeText";
			this.LblAgeText.Size = new System.Drawing.Size(20, 23);
			this.LblAgeText.TabIndex = 34;
			this.LblAgeText.Text = "0";
			this.LblAgeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblAge
			// 
			this.LblAge.AutoSize = true;
			this.LblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAge.Location = new System.Drawing.Point(23, 186);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(74, 23);
			this.LblAge.TabIndex = 34;
			this.LblAge.Text = "Возраст:";
			this.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblExit
			// 
			this.LblExit.AutoSize = true;
			this.LblExit.Location = new System.Drawing.Point(257, 238);
			this.LblExit.Name = "LblExit";
			this.LblExit.Size = new System.Drawing.Size(101, 33);
			this.LblExit.TabIndex = 35;
			this.LblExit.Text = "Закрыть";
			this.LblExit.UseVisualStyleBackColor = true;
			// 
			// BioMonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 283);
			this.Controls.Add(this.LblExit);
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
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "BioMonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Биомон";
			this.Load += new System.EventHandler(this.BioMonForm_Load);
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
		private System.Windows.Forms.Button LblExit;
	}
}