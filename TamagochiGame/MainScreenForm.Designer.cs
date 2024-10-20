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
			this.LblHunger = new System.Windows.Forms.Label();
			this.LblThirst = new System.Windows.Forms.Label();
			this.LblHappy = new System.Windows.Forms.Label();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.TSMIChangeBG = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIFieldBG = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIHouseBG = new System.Windows.Forms.ToolStripMenuItem();
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
			this.BtnPlay = new System.Windows.Forms.Button();
			this.BtnDrink = new System.Windows.Forms.Button();
			this.BtnFeed = new System.Windows.Forms.Button();
			this.PicBoxPet = new System.Windows.Forms.PictureBox();
			this.MenuStrip.SuspendLayout();
			this.CMSFeed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.SuspendLayout();
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
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIChangeBG});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.MenuStrip.Size = new System.Drawing.Size(912, 24);
			this.MenuStrip.TabIndex = 10;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// TSMIChangeBG
			// 
			this.TSMIChangeBG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFieldBG,
            this.TSMIHouseBG});
			this.TSMIChangeBG.Name = "TSMIChangeBG";
			this.TSMIChangeBG.Size = new System.Drawing.Size(93, 22);
			this.TSMIChangeBG.Text = "Сменить фон";
			// 
			// TSMIFieldBG
			// 
			this.TSMIFieldBG.Name = "TSMIFieldBG";
			this.TSMIFieldBG.Size = new System.Drawing.Size(103, 22);
			this.TSMIFieldBG.Text = "Поле";
			this.TSMIFieldBG.Click += new System.EventHandler(this.TSMIFieldBG_Click);
			// 
			// TSMIHouseBG
			// 
			this.TSMIHouseBG.Name = "TSMIHouseBG";
			this.TSMIHouseBG.Size = new System.Drawing.Size(103, 22);
			this.TSMIHouseBG.Text = "Дом";
			this.TSMIHouseBG.Click += new System.EventHandler(this.TSMIHouseBG_Click);
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
			// BtnPlay
			// 
			this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnPlay.BackgroundImage = global::PetStop.Properties.Resources.btnWash;
			this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnPlay.Location = new System.Drawing.Point(506, 436);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(72, 62);
			this.BtnPlay.TabIndex = 9;
			this.BtnPlay.UseVisualStyleBackColor = true;
			this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
			this.BtnPlay.MouseEnter += new System.EventHandler(this.BtnPlay_MouseEnter);
			this.BtnPlay.MouseLeave += new System.EventHandler(this.BtnPlay_MouseLeave);
			// 
			// BtnDrink
			// 
			this.BtnDrink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnDrink.BackgroundImage = global::PetStop.Properties.Resources.btnDrink;
			this.BtnDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnDrink.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnDrink.Location = new System.Drawing.Point(428, 436);
			this.BtnDrink.Name = "BtnDrink";
			this.BtnDrink.Size = new System.Drawing.Size(72, 62);
			this.BtnDrink.TabIndex = 8;
			this.BtnDrink.UseVisualStyleBackColor = true;
			this.BtnDrink.Click += new System.EventHandler(this.BtnDrink_Click);
			this.BtnDrink.MouseEnter += new System.EventHandler(this.BtnDrink_MouseEnter);
			this.BtnDrink.MouseLeave += new System.EventHandler(this.BtnDrink_MouseLeave);
			// 
			// BtnFeed
			// 
			this.BtnFeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnFeed.BackgroundImage = global::PetStop.Properties.Resources.btnFeed;
			this.BtnFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnFeed.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnFeed.Location = new System.Drawing.Point(350, 436);
			this.BtnFeed.Name = "BtnFeed";
			this.BtnFeed.Size = new System.Drawing.Size(72, 62);
			this.BtnFeed.TabIndex = 7;
			this.BtnFeed.UseVisualStyleBackColor = true;
			this.BtnFeed.Click += new System.EventHandler(this.BtnFeed_Click);
			this.BtnFeed.MouseEnter += new System.EventHandler(this.BtnFeed_MouseEnter);
			this.BtnFeed.MouseLeave += new System.EventHandler(this.BtnFeed_MouseLeave);
			// 
			// PicBoxPet
			// 
			this.PicBoxPet.BackgroundImage = global::PetStop.Properties.Resources.bgRoom;
			this.PicBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PicBoxPet.Cursor = System.Windows.Forms.Cursors.Default;
			this.PicBoxPet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PicBoxPet.Image = global::PetStop.Properties.Resources.petPlatypus;
			this.PicBoxPet.InitialImage = null;
			this.PicBoxPet.Location = new System.Drawing.Point(0, 24);
			this.PicBoxPet.Name = "PicBoxPet";
			this.PicBoxPet.Size = new System.Drawing.Size(912, 486);
			this.PicBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBoxPet.TabIndex = 3;
			this.PicBoxPet.TabStop = false;
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
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.CMSFeed.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
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
		private System.Windows.Forms.Label LblAge;
		private System.Windows.Forms.Label LblMoney;
		private System.Windows.Forms.Label LblDirty;
		private System.Windows.Forms.ProgressBar PrBarDirty;
		private System.Windows.Forms.Button BtnClean;
		private System.Windows.Forms.ContextMenuStrip CMSFeed;
		private System.Windows.Forms.ToolStripMenuItem FoodOne;
		private System.Windows.Forms.ToolStripMenuItem FoodTwo;
		private System.Windows.Forms.ToolStripMenuItem FoodThree;
		private System.Windows.Forms.ToolStripMenuItem TSMIChangeBG;
		private System.Windows.Forms.ToolStripMenuItem TSMIFieldBG;
		private System.Windows.Forms.ToolStripMenuItem TSMIHouseBG;
	}
}

