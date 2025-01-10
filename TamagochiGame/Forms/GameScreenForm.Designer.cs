namespace PetStop
{
	partial class GameScreenForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreenForm));
			this.LblMoney = new System.Windows.Forms.Label();
			this.BtnSettings = new System.Windows.Forms.Button();
			this.BtnFeed = new System.Windows.Forms.Button();
			this.BtnDrink = new System.Windows.Forms.Button();
			this.BtnPlay = new System.Windows.Forms.Button();
			this.BtnWash = new System.Windows.Forms.Button();
			this.PicBoxMoneyBG = new System.Windows.Forms.PictureBox();
			this.PicBoxBedding = new System.Windows.Forms.PictureBox();
			this.panelOutside = new System.Windows.Forms.Panel();
			this.panelHome = new System.Windows.Forms.Panel();
			this.PanelPet = new System.Windows.Forms.Panel();
			this.BtnBioMon = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxMoneyBG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxBedding)).BeginInit();
			this.SuspendLayout();
			// 
			// LblMoney
			// 
			this.LblMoney.AutoSize = true;
			this.LblMoney.BackColor = System.Drawing.Color.Transparent;
			this.LblMoney.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.LblMoney.Location = new System.Drawing.Point(12, 27);
			this.LblMoney.Name = "LblMoney";
			this.LblMoney.Size = new System.Drawing.Size(65, 23);
			this.LblMoney.TabIndex = 8;
			this.LblMoney.Text = "Деньги";
			this.LblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnSettings
			// 
			this.BtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
			this.BtnSettings.BackgroundImage = global::PetStop.Properties.Resources.settings;
			this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnSettings.FlatAppearance.BorderSize = 0;
			this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSettings.Location = new System.Drawing.Point(865, 9);
			this.BtnSettings.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.Size = new System.Drawing.Size(75, 75);
			this.BtnSettings.TabIndex = 0;
			this.BtnSettings.UseVisualStyleBackColor = true;
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
			this.BtnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSettings_MouseDown);
			this.BtnSettings.MouseEnter += new System.EventHandler(this.BtnSettings_MouseEnter);
			this.BtnSettings.MouseLeave += new System.EventHandler(this.BtnSettings_MouseLeave);
			this.BtnSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSettings_MouseUp);
			// 
			// BtnFeed
			// 
			this.BtnFeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnFeed.BackColor = System.Drawing.Color.Transparent;
			this.BtnFeed.BackgroundImage = global::PetStop.Properties.Resources.btnFeed;
			this.BtnFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnFeed.FlatAppearance.BorderSize = 0;
			this.BtnFeed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.BtnFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnFeed.Location = new System.Drawing.Point(344, 518);
			this.BtnFeed.Name = "BtnFeed";
			this.BtnFeed.Size = new System.Drawing.Size(60, 60);
			this.BtnFeed.TabIndex = 1;
			this.BtnFeed.UseVisualStyleBackColor = false;
			this.BtnFeed.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.BtnFeed_GiveFeedback);
			this.BtnFeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFeed_MouseDown);
			this.BtnFeed.MouseEnter += new System.EventHandler(this.BtnFeed_MouseEnter);
			this.BtnFeed.MouseLeave += new System.EventHandler(this.BtnFeed_MouseLeave);
			// 
			// BtnDrink
			// 
			this.BtnDrink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnDrink.BackColor = System.Drawing.Color.Transparent;
			this.BtnDrink.BackgroundImage = global::PetStop.Properties.Resources.btnDrink;
			this.BtnDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnDrink.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnDrink.FlatAppearance.BorderSize = 0;
			this.BtnDrink.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.BtnDrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnDrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDrink.Location = new System.Drawing.Point(410, 518);
			this.BtnDrink.Name = "BtnDrink";
			this.BtnDrink.Size = new System.Drawing.Size(60, 60);
			this.BtnDrink.TabIndex = 2;
			this.BtnDrink.UseVisualStyleBackColor = false;
			this.BtnDrink.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.BtnDrink_GiveFeedback);
			this.BtnDrink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnDrink_MouseDown);
			this.BtnDrink.MouseEnter += new System.EventHandler(this.BtnDrink_MouseEnter);
			this.BtnDrink.MouseLeave += new System.EventHandler(this.BtnDrink_MouseLeave);
			// 
			// BtnPlay
			// 
			this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
			this.BtnPlay.BackgroundImage = global::PetStop.Properties.Resources.btnPlay;
			this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnPlay.FlatAppearance.BorderSize = 0;
			this.BtnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPlay.Location = new System.Drawing.Point(476, 518);
			this.BtnPlay.Name = "BtnPlay";
			this.BtnPlay.Size = new System.Drawing.Size(60, 60);
			this.BtnPlay.TabIndex = 3;
			this.BtnPlay.UseVisualStyleBackColor = false;
			this.BtnPlay.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.BtnPlay_GiveFeedback);
			this.BtnPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnPlay_MouseDown);
			this.BtnPlay.MouseEnter += new System.EventHandler(this.BtnPlay_MouseEnter);
			this.BtnPlay.MouseLeave += new System.EventHandler(this.BtnPlay_MouseLeave);
			// 
			// BtnWash
			// 
			this.BtnWash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnWash.BackColor = System.Drawing.Color.Transparent;
			this.BtnWash.BackgroundImage = global::PetStop.Properties.Resources.btnWash;
			this.BtnWash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnWash.FlatAppearance.BorderSize = 0;
			this.BtnWash.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.BtnWash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnWash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnWash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWash.Location = new System.Drawing.Point(542, 518);
			this.BtnWash.Name = "BtnWash";
			this.BtnWash.Size = new System.Drawing.Size(60, 60);
			this.BtnWash.TabIndex = 4;
			this.BtnWash.UseVisualStyleBackColor = false;
			this.BtnWash.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.BtnWash_GiveFeedback);
			this.BtnWash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnWash_MouseDown);
			this.BtnWash.MouseEnter += new System.EventHandler(this.BtnWash_MouseEnter);
			this.BtnWash.MouseLeave += new System.EventHandler(this.BtnWash_MouseLeave);
			// 
			// PicBoxMoneyBG
			// 
			this.PicBoxMoneyBG.BackColor = System.Drawing.Color.Transparent;
			this.PicBoxMoneyBG.Image = global::PetStop.Properties.Resources.interfaceMoney;
			this.PicBoxMoneyBG.Location = new System.Drawing.Point(0, 12);
			this.PicBoxMoneyBG.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.PicBoxMoneyBG.Name = "PicBoxMoneyBG";
			this.PicBoxMoneyBG.Size = new System.Drawing.Size(219, 60);
			this.PicBoxMoneyBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicBoxMoneyBG.TabIndex = 30;
			this.PicBoxMoneyBG.TabStop = false;
			// 
			// PicBoxBedding
			// 
			this.PicBoxBedding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.PicBoxBedding.BackColor = System.Drawing.Color.Transparent;
			this.PicBoxBedding.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PicBoxBedding.Image = global::PetStop.Properties.Resources.bedding;
			this.PicBoxBedding.Location = new System.Drawing.Point(399, 397);
			this.PicBoxBedding.Name = "PicBoxBedding";
			this.PicBoxBedding.Size = new System.Drawing.Size(152, 73);
			this.PicBoxBedding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicBoxBedding.TabIndex = 31;
			this.PicBoxBedding.TabStop = false;
			// 
			// panelOutside
			// 
			this.panelOutside.BackColor = System.Drawing.Color.Transparent;
			this.panelOutside.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelOutside.Location = new System.Drawing.Point(0, 138);
			this.panelOutside.Name = "panelOutside";
			this.panelOutside.Size = new System.Drawing.Size(49, 359);
			this.panelOutside.TabIndex = 6;
			this.panelOutside.Click += new System.EventHandler(this.panelChangePlace_Click);
			// 
			// panelHome
			// 
			this.panelHome.BackColor = System.Drawing.Color.Transparent;
			this.panelHome.BackgroundImage = global::PetStop.Properties.Resources.btnRIght;
			this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelHome.Location = new System.Drawing.Point(901, 138);
			this.panelHome.Name = "panelHome";
			this.panelHome.Size = new System.Drawing.Size(49, 359);
			this.panelHome.TabIndex = 7;
			this.panelHome.Visible = false;
			this.panelHome.Click += new System.EventHandler(this.panelChangePlace_Click);
			this.panelHome.MouseEnter += new System.EventHandler(this.panelHome_MouseEnter);
			this.panelHome.MouseLeave += new System.EventHandler(this.panelHome_MouseLeave);
			// 
			// PanelPet
			// 
			this.PanelPet.AllowDrop = true;
			this.PanelPet.BackColor = System.Drawing.Color.Transparent;
			this.PanelPet.BackgroundImage = global::PetStop.Properties.Resources.petGS1;
			this.PanelPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PanelPet.Location = new System.Drawing.Point(622, 337);
			this.PanelPet.Name = "PanelPet";
			this.PanelPet.Size = new System.Drawing.Size(172, 142);
			this.PanelPet.TabIndex = 5;
			this.PanelPet.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelPet_DragDrop);
			this.PanelPet.DragOver += new System.Windows.Forms.DragEventHandler(this.PanelPet_DragOver);
			// 
			// BtnBioMon
			// 
			this.BtnBioMon.BackColor = System.Drawing.Color.Transparent;
			this.BtnBioMon.BackgroundImage = global::PetStop.Properties.Resources.btnBioMon;
			this.BtnBioMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnBioMon.FlatAppearance.BorderSize = 0;
			this.BtnBioMon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.BtnBioMon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.BtnBioMon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.BtnBioMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBioMon.Location = new System.Drawing.Point(225, 12);
			this.BtnBioMon.Name = "BtnBioMon";
			this.BtnBioMon.Size = new System.Drawing.Size(60, 60);
			this.BtnBioMon.TabIndex = 3;
			this.BtnBioMon.UseVisualStyleBackColor = false;
			this.BtnBioMon.Click += new System.EventHandler(this.BtnBioMon_Click);
			this.BtnBioMon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBioMon_MouseDown);
			this.BtnBioMon.MouseEnter += new System.EventHandler(this.BtnBioMon_MouseEnter);
			this.BtnBioMon.MouseLeave += new System.EventHandler(this.BtnBioMon_MouseLeave);
			this.BtnBioMon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBioMon_MouseUp);
			// 
			// GameScreenForm
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::PetStop.Properties.Resources.bgRoom;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.BtnSettings;
			this.ClientSize = new System.Drawing.Size(949, 590);
			this.Controls.Add(this.PanelPet);
			this.Controls.Add(this.panelHome);
			this.Controls.Add(this.panelOutside);
			this.Controls.Add(this.PicBoxBedding);
			this.Controls.Add(this.LblMoney);
			this.Controls.Add(this.PicBoxMoneyBG);
			this.Controls.Add(this.BtnWash);
			this.Controls.Add(this.BtnBioMon);
			this.Controls.Add(this.BtnPlay);
			this.Controls.Add(this.BtnDrink);
			this.Controls.Add(this.BtnFeed);
			this.Controls.Add(this.BtnSettings);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(965, 629);
			this.MinimumSize = new System.Drawing.Size(965, 629);
			this.Name = "GameScreenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PetStop";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreenForm_FormClosing);
			this.Load += new System.EventHandler(this.MainScreenForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxMoneyBG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxBedding)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblMoney;
		private System.Windows.Forms.Button BtnSettings;
		private System.Windows.Forms.Button BtnFeed;
		private System.Windows.Forms.Button BtnDrink;
		private System.Windows.Forms.Button BtnPlay;
		private System.Windows.Forms.Button BtnWash;
		private System.Windows.Forms.PictureBox PicBoxMoneyBG;
		private System.Windows.Forms.PictureBox PicBoxBedding;
		private System.Windows.Forms.Panel panelOutside;
		private System.Windows.Forms.Panel panelHome;
		private System.Windows.Forms.Panel PanelPet;
		private System.Windows.Forms.Button BtnBioMon;
	}
}

