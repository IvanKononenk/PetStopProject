namespace PetStop
{
	partial class MainScreenForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
			this.LblHunger = new System.Windows.Forms.Label();
			this.LblThirst = new System.Windows.Forms.Label();
			this.LblHappy = new System.Windows.Forms.Label();
			this.LblAge = new System.Windows.Forms.Label();
			this.LblMoney = new System.Windows.Forms.Label();
			this.PrBarHydration = new System.Windows.Forms.ProgressBar();
			this.PrBarSatiety = new System.Windows.Forms.ProgressBar();
			this.PrBarHappiness = new System.Windows.Forms.ProgressBar();
			this.PicBoxPet = new System.Windows.Forms.PictureBox();
			this.PrBarCommunication = new System.Windows.Forms.ProgressBar();
			this.PrBarVigor = new System.Windows.Forms.ProgressBar();
			this.PrBarCleanliness = new System.Windows.Forms.ProgressBar();
			this.LblCommunication = new System.Windows.Forms.Label();
			this.LblVigor = new System.Windows.Forms.Label();
			this.LblCleanliness = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.SuspendLayout();
			// 
			// LblHunger
			// 
			this.LblHunger.AutoSize = true;
			this.LblHunger.BackColor = System.Drawing.Color.Transparent;
			this.LblHunger.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHunger.Location = new System.Drawing.Point(35, 41);
			this.LblHunger.Name = "LblHunger";
			this.LblHunger.Size = new System.Drawing.Size(62, 23);
			this.LblHunger.TabIndex = 4;
			this.LblHunger.Text = "Голод:";
			// 
			// LblThirst
			// 
			this.LblThirst.AutoSize = true;
			this.LblThirst.BackColor = System.Drawing.Color.Transparent;
			this.LblThirst.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblThirst.Location = new System.Drawing.Point(32, 70);
			this.LblThirst.Name = "LblThirst";
			this.LblThirst.Size = new System.Drawing.Size(65, 23);
			this.LblThirst.TabIndex = 5;
			this.LblThirst.Text = "Жажда:";
			// 
			// LblHappy
			// 
			this.LblHappy.AutoSize = true;
			this.LblHappy.BackColor = System.Drawing.Color.Transparent;
			this.LblHappy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblHappy.Location = new System.Drawing.Point(23, 12);
			this.LblHappy.Name = "LblHappy";
			this.LblHappy.Size = new System.Drawing.Size(74, 23);
			this.LblHappy.TabIndex = 6;
			this.LblHappy.Text = "Счастье:";
			// 
			// LblAge
			// 
			this.LblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblAge.AutoSize = true;
			this.LblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAge.Location = new System.Drawing.Point(1058, 596);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(20, 23);
			this.LblAge.TabIndex = 11;
			this.LblAge.Text = "0";
			// 
			// LblMoney
			// 
			this.LblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblMoney.AutoSize = true;
			this.LblMoney.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblMoney.Location = new System.Drawing.Point(1046, 9);
			this.LblMoney.Name = "LblMoney";
			this.LblMoney.Size = new System.Drawing.Size(65, 23);
			this.LblMoney.TabIndex = 12;
			this.LblMoney.Text = "Деньги";
			// 
			// PrBarHydration
			// 
			this.PrBarHydration.Location = new System.Drawing.Point(103, 70);
			this.PrBarHydration.Maximum = 10000;
			this.PrBarHydration.Name = "PrBarHydration";
			this.PrBarHydration.Size = new System.Drawing.Size(150, 23);
			this.PrBarHydration.TabIndex = 2;
			this.PrBarHydration.Value = 10000;
			// 
			// PrBarSatiety
			// 
			this.PrBarSatiety.Location = new System.Drawing.Point(103, 41);
			this.PrBarSatiety.Maximum = 10000;
			this.PrBarSatiety.Name = "PrBarSatiety";
			this.PrBarSatiety.Size = new System.Drawing.Size(150, 23);
			this.PrBarSatiety.TabIndex = 1;
			this.PrBarSatiety.Value = 10000;
			// 
			// PrBarHappiness
			// 
			this.PrBarHappiness.Location = new System.Drawing.Point(103, 12);
			this.PrBarHappiness.Maximum = 50000;
			this.PrBarHappiness.Name = "PrBarHappiness";
			this.PrBarHappiness.Size = new System.Drawing.Size(150, 23);
			this.PrBarHappiness.TabIndex = 0;
			this.PrBarHappiness.Value = 50000;
			// 
			// PicBoxPet
			// 
			this.PicBoxPet.BackgroundImage = global::PetStop.Properties.Resources.bgRoom;
			this.PicBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PicBoxPet.Cursor = System.Windows.Forms.Cursors.Default;
			this.PicBoxPet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicBoxPet.Image = global::PetStop.Properties.Resources.petPlatypus;
			this.PicBoxPet.InitialImage = null;
			this.PicBoxPet.Location = new System.Drawing.Point(0, 0);
			this.PicBoxPet.Name = "PicBoxPet";
			this.PicBoxPet.Size = new System.Drawing.Size(1123, 628);
			this.PicBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBoxPet.TabIndex = 3;
			this.PicBoxPet.TabStop = false;
			// 
			// PrBarCommunication
			// 
			this.PrBarCommunication.Location = new System.Drawing.Point(103, 99);
			this.PrBarCommunication.Maximum = 10000;
			this.PrBarCommunication.Name = "PrBarCommunication";
			this.PrBarCommunication.Size = new System.Drawing.Size(150, 23);
			this.PrBarCommunication.TabIndex = 16;
			this.PrBarCommunication.Value = 10000;
			// 
			// PrBarVigor
			// 
			this.PrBarVigor.Location = new System.Drawing.Point(103, 128);
			this.PrBarVigor.Maximum = 10000;
			this.PrBarVigor.Name = "PrBarVigor";
			this.PrBarVigor.Size = new System.Drawing.Size(150, 23);
			this.PrBarVigor.TabIndex = 17;
			this.PrBarVigor.Value = 10000;
			// 
			// PrBarCleanliness
			// 
			this.PrBarCleanliness.Location = new System.Drawing.Point(103, 157);
			this.PrBarCleanliness.Maximum = 10000;
			this.PrBarCleanliness.Name = "PrBarCleanliness";
			this.PrBarCleanliness.Size = new System.Drawing.Size(150, 23);
			this.PrBarCleanliness.TabIndex = 18;
			this.PrBarCleanliness.Value = 10000;
			// 
			// LblCommunication
			// 
			this.LblCommunication.AutoSize = true;
			this.LblCommunication.BackColor = System.Drawing.Color.Transparent;
			this.LblCommunication.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCommunication.Location = new System.Drawing.Point(13, 99);
			this.LblCommunication.Name = "LblCommunication";
			this.LblCommunication.Size = new System.Drawing.Size(84, 23);
			this.LblCommunication.TabIndex = 19;
			this.LblCommunication.Text = "Общение:";
			// 
			// LblVigor
			// 
			this.LblVigor.AutoSize = true;
			this.LblVigor.BackColor = System.Drawing.Color.Transparent;
			this.LblVigor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblVigor.Location = new System.Drawing.Point(12, 128);
			this.LblVigor.Name = "LblVigor";
			this.LblVigor.Size = new System.Drawing.Size(85, 23);
			this.LblVigor.TabIndex = 20;
			this.LblVigor.Text = "Бодрость:";
			// 
			// LblCleanliness
			// 
			this.LblCleanliness.AutoSize = true;
			this.LblCleanliness.BackColor = System.Drawing.Color.Transparent;
			this.LblCleanliness.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblCleanliness.Location = new System.Drawing.Point(21, 157);
			this.LblCleanliness.Name = "LblCleanliness";
			this.LblCleanliness.Size = new System.Drawing.Size(76, 23);
			this.LblCleanliness.TabIndex = 21;
			this.LblCleanliness.Text = "Чистота:";
			// 
			// MainScreenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 628);
			this.Controls.Add(this.LblCleanliness);
			this.Controls.Add(this.LblVigor);
			this.Controls.Add(this.LblCommunication);
			this.Controls.Add(this.PrBarCleanliness);
			this.Controls.Add(this.PrBarVigor);
			this.Controls.Add(this.PrBarCommunication);
			this.Controls.Add(this.LblMoney);
			this.Controls.Add(this.LblAge);
			this.Controls.Add(this.LblHappy);
			this.Controls.Add(this.LblThirst);
			this.Controls.Add(this.LblHunger);
			this.Controls.Add(this.PrBarHydration);
			this.Controls.Add(this.PrBarSatiety);
			this.Controls.Add(this.PrBarHappiness);
			this.Controls.Add(this.PicBoxPet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(759, 394);
			this.Name = "MainScreenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PetStop";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreenForm_FormClosing);
			this.Load += new System.EventHandler(this.MainScreenForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar PrBarHappiness;
		private System.Windows.Forms.ProgressBar PrBarSatiety;
		private System.Windows.Forms.ProgressBar PrBarHydration;
		private System.Windows.Forms.PictureBox PicBoxPet;
		private System.Windows.Forms.Label LblHunger;
		private System.Windows.Forms.Label LblThirst;
		private System.Windows.Forms.Label LblHappy;
		private System.Windows.Forms.Label LblAge;
		private System.Windows.Forms.Label LblMoney;
		private System.Windows.Forms.ProgressBar PrBarCommunication;
		private System.Windows.Forms.ProgressBar PrBarVigor;
		private System.Windows.Forms.ProgressBar PrBarCleanliness;
		private System.Windows.Forms.Label LblCommunication;
		private System.Windows.Forms.Label LblVigor;
		private System.Windows.Forms.Label LblCleanliness;
	}
}

