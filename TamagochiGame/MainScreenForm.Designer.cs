namespace TamagochiGame
{
	partial class FrmMainScreen
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
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
			this.LblDirty = new System.Windows.Forms.Label();
			this.BtnClean = new System.Windows.Forms.Button();
			this.PrBarDirty = new System.Windows.Forms.ProgressBar();
			this.LblMoney = new System.Windows.Forms.Label();
			this.PrBarHappy = new System.Windows.Forms.ProgressBar();
			this.PrBarThirst = new System.Windows.Forms.ProgressBar();
			this.PrBarHunger = new System.Windows.Forms.ProgressBar();
			this.CMSFeed = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.FoodOne = new System.Windows.Forms.ToolStripMenuItem();
			this.FoodTwo = new System.Windows.Forms.ToolStripMenuItem();
			this.FoodThree = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.MenuStrip.SuspendLayout();
			this.CMSFeed.SuspendLayout();
			this.SuspendLayout();
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
			this.PicBoxPet.Size = new System.Drawing.Size(912, 486);
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
			this.BtnFeed.Location = new System.Drawing.Point(288, 465);
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
			this.BtnDrink.Location = new System.Drawing.Point(402, 465);
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
			this.BtnPlay.Location = new System.Drawing.Point(516, 465);
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
			this.MenuStrip.Size = new System.Drawing.Size(912, 24);
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
			this.LblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblAge.AutoSize = true;
			this.LblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblAge.Location = new System.Drawing.Point(847, 478);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(20, 23);
			this.LblAge.TabIndex = 11;
			this.LblAge.Text = "0";
			// 
			// LblDirty
			// 
			this.LblDirty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblDirty.AutoSize = true;
			this.LblDirty.BackColor = System.Drawing.Color.Transparent;
			this.LblDirty.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblDirty.Location = new System.Drawing.Point(29, 436);
			this.LblDirty.Name = "LblDirty";
			this.LblDirty.Size = new System.Drawing.Size(57, 23);
			this.LblDirty.TabIndex = 14;
			this.LblDirty.Text = "Грязь:";
			// 
			// BtnClean
			// 
			this.BtnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnClean.AutoSize = true;
			this.BtnClean.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnClean.Location = new System.Drawing.Point(92, 465);
			this.BtnClean.Name = "BtnClean";
			this.BtnClean.Size = new System.Drawing.Size(100, 33);
			this.BtnClean.TabIndex = 15;
			this.BtnClean.Text = "Помыть";
			this.BtnClean.UseVisualStyleBackColor = true;
			this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
			// 
			// PrBarDirty
			// 
			this.PrBarDirty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PrBarDirty.Location = new System.Drawing.Point(92, 436);
			this.PrBarDirty.MarqueeAnimationSpeed = 10;
			this.PrBarDirty.Name = "PrBarDirty";
			this.PrBarDirty.Size = new System.Drawing.Size(100, 23);
			this.PrBarDirty.Step = 1;
			this.PrBarDirty.TabIndex = 13;
			// 
			// LblMoney
			// 
			this.LblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblMoney.AutoSize = true;
			this.LblMoney.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblMoney.Location = new System.Drawing.Point(847, 27);
			this.LblMoney.Name = "LblMoney";
			this.LblMoney.Size = new System.Drawing.Size(65, 23);
			this.LblMoney.TabIndex = 12;
			this.LblMoney.Text = "Деньги";
			// 
			// PrBarHappy
			// 
			this.PrBarHappy.Location = new System.Drawing.Point(92, 85);
			this.PrBarHappy.Maximum = 10000;
			this.PrBarHappy.Name = "PrBarHappy";
			this.PrBarHappy.Size = new System.Drawing.Size(100, 23);
			this.PrBarHappy.TabIndex = 2;
			this.PrBarHappy.Value = 10000;
			// 
			// PrBarThirst
			// 
			this.PrBarThirst.Location = new System.Drawing.Point(92, 56);
			this.PrBarThirst.Maximum = 10000;
			this.PrBarThirst.Name = "PrBarThirst";
			this.PrBarThirst.Size = new System.Drawing.Size(100, 23);
			this.PrBarThirst.TabIndex = 1;
			this.PrBarThirst.Value = 10000;
			// 
			// PrBarHunger
			// 
			this.PrBarHunger.Location = new System.Drawing.Point(92, 27);
			this.PrBarHunger.Maximum = 10000;
			this.PrBarHunger.Name = "PrBarHunger";
			this.PrBarHunger.Size = new System.Drawing.Size(100, 23);
			this.PrBarHunger.TabIndex = 0;
			this.PrBarHunger.Value = 10000;
			// 
			// CMSFeed
			// 
			this.CMSFeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoodOne,
            this.FoodTwo,
            this.FoodThree});
			this.CMSFeed.Name = "CMSFeed";
			this.CMSFeed.Size = new System.Drawing.Size(114, 70);
			// 
			// FoodOne
			// 
			this.FoodOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FoodOne.Name = "FoodOne";
			this.FoodOne.Size = new System.Drawing.Size(113, 22);
			this.FoodOne.Text = "Корм 1";
			this.FoodOne.Click += new System.EventHandler(this.FoodOne_Click);
			// 
			// FoodTwo
			// 
			this.FoodTwo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FoodTwo.Name = "FoodTwo";
			this.FoodTwo.Size = new System.Drawing.Size(113, 22);
			this.FoodTwo.Text = "Корм 2";
			this.FoodTwo.Click += new System.EventHandler(this.FoodTwo_Click);
			// 
			// FoodThree
			// 
			this.FoodThree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.FoodThree.Name = "FoodThree";
			this.FoodThree.Size = new System.Drawing.Size(113, 22);
			this.FoodThree.Text = "Корм 3";
			this.FoodThree.Click += new System.EventHandler(this.FoodThree_Click);
			// 
			// FrmMainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 510);
			this.Controls.Add(this.BtnClean);
			this.Controls.Add(this.LblDirty);
			this.Controls.Add(this.PrBarDirty);
			this.Controls.Add(this.LblMoney);
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
			this.MinimumSize = new System.Drawing.Size(759, 394);
			this.Name = "FrmMainScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PetStop";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.CMSFeed.ResumeLayout(false);
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
		private System.Windows.Forms.Label LblMoney;
		private System.Windows.Forms.Label LblDirty;
		private System.Windows.Forms.ProgressBar PrBarDirty;
		private System.Windows.Forms.Button BtnClean;
		private System.Windows.Forms.ContextMenuStrip CMSFeed;
		private System.Windows.Forms.ToolStripMenuItem FoodOne;
		private System.Windows.Forms.ToolStripMenuItem FoodTwo;
		private System.Windows.Forms.ToolStripMenuItem FoodThree;
	}
}

