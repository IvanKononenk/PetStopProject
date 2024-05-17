namespace TamagochiGame
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.prBarHunger = new System.Windows.Forms.ProgressBar();
			this.prBarThirst = new System.Windows.Forms.ProgressBar();
			this.prBarHappy = new System.Windows.Forms.ProgressBar();
			this.picBoxPet = new System.Windows.Forms.PictureBox();
			this.lblHunger = new System.Windows.Forms.Label();
			this.lblThirst = new System.Windows.Forms.Label();
			this.lblHappy = new System.Windows.Forms.Label();
			this.btnFeed = new System.Windows.Forms.Button();
			this.btnDrink = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picBoxPet)).BeginInit();
			this.SuspendLayout();
			// 
			// prBarHunger
			// 
			this.prBarHunger.Location = new System.Drawing.Point(92, 14);
			this.prBarHunger.MarqueeAnimationSpeed = 10;
			this.prBarHunger.Maximum = 1000;
			this.prBarHunger.Name = "prBarHunger";
			this.prBarHunger.Size = new System.Drawing.Size(100, 23);
			this.prBarHunger.TabIndex = 0;
			this.prBarHunger.Value = 1000;
			// 
			// prBarThirst
			// 
			this.prBarThirst.Location = new System.Drawing.Point(92, 43);
			this.prBarThirst.MarqueeAnimationSpeed = 10;
			this.prBarThirst.Maximum = 1000;
			this.prBarThirst.Name = "prBarThirst";
			this.prBarThirst.Size = new System.Drawing.Size(100, 23);
			this.prBarThirst.TabIndex = 1;
			this.prBarThirst.Value = 1000;
			// 
			// prBarHappy
			// 
			this.prBarHappy.Location = new System.Drawing.Point(92, 72);
			this.prBarHappy.MarqueeAnimationSpeed = 10;
			this.prBarHappy.Maximum = 1000;
			this.prBarHappy.Name = "prBarHappy";
			this.prBarHappy.Size = new System.Drawing.Size(100, 23);
			this.prBarHappy.TabIndex = 2;
			this.prBarHappy.Value = 1000;
			// 
			// picBoxPet
			// 
			this.picBoxPet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxPet.BackgroundImage")));
			this.picBoxPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picBoxPet.Cursor = System.Windows.Forms.Cursors.Default;
			this.picBoxPet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBoxPet.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPet.Image")));
			this.picBoxPet.InitialImage = null;
			this.picBoxPet.Location = new System.Drawing.Point(0, 0);
			this.picBoxPet.Name = "picBoxPet";
			this.picBoxPet.Size = new System.Drawing.Size(1298, 559);
			this.picBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxPet.TabIndex = 3;
			this.picBoxPet.TabStop = false;
			// 
			// lblHunger
			// 
			this.lblHunger.AutoSize = true;
			this.lblHunger.BackColor = System.Drawing.Color.Transparent;
			this.lblHunger.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHunger.Location = new System.Drawing.Point(24, 14);
			this.lblHunger.Name = "lblHunger";
			this.lblHunger.Size = new System.Drawing.Size(62, 23);
			this.lblHunger.TabIndex = 4;
			this.lblHunger.Text = "Голод:";
			// 
			// lblThirst
			// 
			this.lblThirst.AutoSize = true;
			this.lblThirst.BackColor = System.Drawing.Color.Transparent;
			this.lblThirst.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblThirst.Location = new System.Drawing.Point(21, 43);
			this.lblThirst.Name = "lblThirst";
			this.lblThirst.Size = new System.Drawing.Size(65, 23);
			this.lblThirst.TabIndex = 5;
			this.lblThirst.Text = "Жажда:";
			// 
			// lblHappy
			// 
			this.lblHappy.AutoSize = true;
			this.lblHappy.BackColor = System.Drawing.Color.Transparent;
			this.lblHappy.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.lblHappy.Location = new System.Drawing.Point(12, 72);
			this.lblHappy.Name = "lblHappy";
			this.lblHappy.Size = new System.Drawing.Size(74, 23);
			this.lblHappy.TabIndex = 6;
			this.lblHappy.Text = "Счастье:";
			// 
			// btnFeed
			// 
			this.btnFeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnFeed.AutoSize = true;
			this.btnFeed.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnFeed.Location = new System.Drawing.Point(481, 514);
			this.btnFeed.Name = "btnFeed";
			this.btnFeed.Size = new System.Drawing.Size(108, 33);
			this.btnFeed.TabIndex = 7;
			this.btnFeed.Text = "Покормить";
			this.btnFeed.UseVisualStyleBackColor = true;
			this.btnFeed.Click += new System.EventHandler(this.BtnFeed_Click);
			// 
			// btnDrink
			// 
			this.btnDrink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDrink.AutoSize = true;
			this.btnDrink.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnDrink.Location = new System.Drawing.Point(595, 514);
			this.btnDrink.Name = "btnDrink";
			this.btnDrink.Size = new System.Drawing.Size(108, 33);
			this.btnDrink.TabIndex = 8;
			this.btnDrink.Text = "Напоить";
			this.btnDrink.UseVisualStyleBackColor = true;
			this.btnDrink.Click += new System.EventHandler(this.BtnDrink_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnPlay.AutoSize = true;
			this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.btnPlay.Location = new System.Drawing.Point(709, 514);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(108, 33);
			this.btnPlay.TabIndex = 9;
			this.btnPlay.Text = "Поиграть";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1298, 559);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnDrink);
			this.Controls.Add(this.btnFeed);
			this.Controls.Add(this.lblHappy);
			this.Controls.Add(this.lblThirst);
			this.Controls.Add(this.lblHunger);
			this.Controls.Add(this.prBarHappy);
			this.Controls.Add(this.prBarThirst);
			this.Controls.Add(this.prBarHunger);
			this.Controls.Add(this.picBoxPet);
			this.MinimumSize = new System.Drawing.Size(376, 400);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxPet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar prBarHunger;
		private System.Windows.Forms.ProgressBar prBarThirst;
		private System.Windows.Forms.ProgressBar prBarHappy;
		private System.Windows.Forms.PictureBox picBoxPet;
		private System.Windows.Forms.Label lblHunger;
		private System.Windows.Forms.Label lblThirst;
		private System.Windows.Forms.Label lblHappy;
		private System.Windows.Forms.Button btnFeed;
		private System.Windows.Forms.Button btnDrink;
		private System.Windows.Forms.Button btnPlay;
	}
}

