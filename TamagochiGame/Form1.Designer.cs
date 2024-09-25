namespace TamagochiGame
{
	partial class FrmGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
			this.PrBarHunger = new System.Windows.Forms.ProgressBar();
			this.PrBarThirst = new System.Windows.Forms.ProgressBar();
			this.PrBarHappy = new System.Windows.Forms.ProgressBar();
			this.PicBoxPet = new System.Windows.Forms.PictureBox();
			this.LblHunger = new System.Windows.Forms.Label();
			this.LblThirst = new System.Windows.Forms.Label();
			this.LblHappy = new System.Windows.Forms.Label();
			this.BtnFeed = new System.Windows.Forms.Button();
			this.BtnDrink = new System.Windows.Forms.Button();
			this.BtnPlay = new System.Windows.Forms.Button();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.TSMIDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIChangeBG = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIChangePet = new System.Windows.Forms.ToolStripMenuItem();
			this.LblAge = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// PrBarHunger
			// 
			this.PrBarHunger.Location = new System.Drawing.Point(92, 27);
			this.PrBarHunger.MarqueeAnimationSpeed = 10;
			this.PrBarHunger.Maximum = 1000;
			this.PrBarHunger.Name = "PrBarHunger";
			this.PrBarHunger.Size = new System.Drawing.Size(100, 23);
			this.PrBarHunger.TabIndex = 0;
			this.PrBarHunger.Value = 1000;
			// 
			// PrBarThirst
			// 
			this.PrBarThirst.Location = new System.Drawing.Point(92, 56);
			this.PrBarThirst.MarqueeAnimationSpeed = 10;
			this.PrBarThirst.Maximum = 1000;
			this.PrBarThirst.Name = "PrBarThirst";
			this.PrBarThirst.Size = new System.Drawing.Size(100, 23);
			this.PrBarThirst.TabIndex = 1;
			this.PrBarThirst.Value = 1000;
			// 
			// PrBarHappy
			// 
			this.PrBarHappy.Location = new System.Drawing.Point(92, 85);
			this.PrBarHappy.MarqueeAnimationSpeed = 10;
			this.PrBarHappy.Maximum = 1000;
			this.PrBarHappy.Name = "PrBarHappy";
			this.PrBarHappy.Size = new System.Drawing.Size(100, 23);
			this.PrBarHappy.TabIndex = 2;
			this.PrBarHappy.Value = 1000;
			// 
			// PicBoxPet
			// 
			this.PicBoxPet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBoxPet.BackgroundImage")));
			this.PicBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PicBoxPet.Cursor = System.Windows.Forms.Cursors.Default;
			this.PicBoxPet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicBoxPet.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxPet.Image")));
			this.PicBoxPet.InitialImage = null;
			this.PicBoxPet.Location = new System.Drawing.Point(0, 24);
			this.PicBoxPet.Name = "PicBoxPet";
			this.PicBoxPet.Size = new System.Drawing.Size(1034, 481);
			this.PicBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBoxPet.TabIndex = 3;
			this.PicBoxPet.TabStop = false;
			// 
			// LblHunger
			// 
			this.LblHunger.AutoSize = true;
			this.LblHunger.BackColor = System.Drawing.Color.Transparent;
			this.LblHunger.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHunger.Location = new System.Drawing.Point(24, 27);
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
			this.LblThirst.Location = new System.Drawing.Point(24, 56);
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
			this.LblHappy.Location = new System.Drawing.Point(15, 85);
			this.LblHappy.Name = "LblHappy";
			this.LblHappy.Size = new System.Drawing.Size(74, 23);
			this.LblHappy.TabIndex = 6;
			this.LblHappy.Text = "Счастье:";
			// 
			// BtnFeed
			// 
			this.BtnFeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnFeed.AutoSize = true;
			this.BtnFeed.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnFeed.Location = new System.Drawing.Point(349, 460);
			this.BtnFeed.Name = "BtnFeed";
			this.BtnFeed.Size = new System.Drawing.Size(108, 33);
			this.BtnFeed.TabIndex = 7;
			this.BtnFeed.Text = "Покормить";
			this.BtnFeed.UseVisualStyleBackColor = true;
			this.BtnFeed.Click += new System.EventHandler(this.BtnFeed_Click);
			// 
			// BtnDrink
			// 
			this.BtnDrink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnDrink.AutoSize = true;
			this.BtnDrink.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnDrink.Location = new System.Drawing.Point(463, 460);
			this.BtnDrink.Name = "BtnDrink";
			this.BtnDrink.Size = new System.Drawing.Size(108, 33);
			this.BtnDrink.TabIndex = 8;
			this.BtnDrink.Text = "Напоить";
			this.BtnDrink.UseVisualStyleBackColor = true;
			this.BtnDrink.Click += new System.EventHandler(this.BtnDrink_Click);
			// 
			// BtnPlay
			// 
			this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnPlay.AutoSize = true;
			this.BtnPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnPlay.Location = new System.Drawing.Point(577, 460);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(108, 33);
			this.BtnPlay.TabIndex = 9;
			this.BtnPlay.Text = "Поиграть";
			this.BtnPlay.UseVisualStyleBackColor = true;
			this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIDebug});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.MenuStrip.Size = new System.Drawing.Size(1034, 24);
			this.MenuStrip.TabIndex = 10;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// TSMIDebug
			// 
			this.TSMIDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIChangeBG,
            this.TSMIChangePet});
			this.TSMIDebug.Name = "TSMIDebug";
			this.TSMIDebug.Size = new System.Drawing.Size(64, 22);
			this.TSMIDebug.Text = "Отладка";
			// 
			// TSMIChangeBG
			// 
			this.TSMIChangeBG.Name = "TSMIChangeBG";
			this.TSMIChangeBG.Size = new System.Drawing.Size(173, 22);
			this.TSMIChangeBG.Text = "Сменить фон";
			this.TSMIChangeBG.Click += new System.EventHandler(this.tsmiChangeBG_Click);
			// 
			// TSMIChangePet
			// 
			this.TSMIChangePet.Name = "TSMIChangePet";
			this.TSMIChangePet.Size = new System.Drawing.Size(173, 22);
			this.TSMIChangePet.Text = "Сменить питомца";
			this.TSMIChangePet.Click += new System.EventHandler(this.TSMIChangePet_Click);
			// 
			// LblAge
			// 
			this.LblAge.AutoSize = true;
			this.LblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAge.Location = new System.Drawing.Point(969, 27);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(53, 23);
			this.LblAge.TabIndex = 11;
			this.LblAge.Text = "label1";
			// 
			// FrmGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 505);
			this.Controls.Add(this.LblAge);
			this.Controls.Add(this.BtnPlay);
			this.Controls.Add(this.BtnDrink);
			this.Controls.Add(this.BtnFeed);
			this.Controls.Add(this.LblHappy);
			this.Controls.Add(this.LblThirst);
			this.Controls.Add(this.LblHunger);
			this.Controls.Add(this.PrBarHappy);
			this.Controls.Add(this.PrBarThirst);
			this.Controls.Add(this.PrBarHunger);
			this.Controls.Add(this.PicBoxPet);
			this.Controls.Add(this.MenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.MinimumSize = new System.Drawing.Size(374, 394);
			this.Name = "FrmGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Игра";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar PrBarHunger;
		private System.Windows.Forms.ProgressBar PrBarThirst;
		private System.Windows.Forms.ProgressBar PrBarHappy;
		private System.Windows.Forms.PictureBox PicBoxPet;
		private System.Windows.Forms.Label LblHunger;
		private System.Windows.Forms.Label LblThirst;
		private System.Windows.Forms.Label LblHappy;
		private System.Windows.Forms.Button BtnFeed;
		private System.Windows.Forms.Button BtnDrink;
		private System.Windows.Forms.Button BtnPlay;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem TSMIDebug;
		private System.Windows.Forms.ToolStripMenuItem TSMIChangeBG;
		private System.Windows.Forms.ToolStripMenuItem TSMIChangePet;
		private System.Windows.Forms.Label LblAge;
	}
}

