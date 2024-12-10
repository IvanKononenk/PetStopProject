namespace PetStop.Forms
{
	partial class MainMenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
			this.BtnNewProfile = new System.Windows.Forms.Button();
			this.BtnLoadProfile = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.picBoxMascot = new System.Windows.Forms.PictureBox();
			this.picBoxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxMascot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnNewProfile
			// 
			this.BtnNewProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnNewProfile.AutoSize = true;
			this.BtnNewProfile.Location = new System.Drawing.Point(55, 165);
			this.BtnNewProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnNewProfile.Name = "BtnNewProfile";
			this.BtnNewProfile.Size = new System.Drawing.Size(211, 41);
			this.BtnNewProfile.TabIndex = 0;
			this.BtnNewProfile.Text = "Новая игра";
			this.BtnNewProfile.UseVisualStyleBackColor = true;
			this.BtnNewProfile.Click += new System.EventHandler(this.BtnNewProfile_Click);
			// 
			// BtnLoadProfile
			// 
			this.BtnLoadProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnLoadProfile.AutoSize = true;
			this.BtnLoadProfile.Location = new System.Drawing.Point(55, 216);
			this.BtnLoadProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnLoadProfile.Name = "BtnLoadProfile";
			this.BtnLoadProfile.Size = new System.Drawing.Size(211, 41);
			this.BtnLoadProfile.TabIndex = 1;
			this.BtnLoadProfile.Text = "Загрузить игру";
			this.BtnLoadProfile.UseVisualStyleBackColor = true;
			this.BtnLoadProfile.Click += new System.EventHandler(this.BtnLoadProfile_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnExit.AutoSize = true;
			this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnExit.Location = new System.Drawing.Point(55, 318);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(211, 41);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// picBoxMascot
			// 
			this.picBoxMascot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picBoxMascot.BackColor = System.Drawing.Color.Transparent;
			this.picBoxMascot.Image = global::PetStop.Properties.Resources.mascot;
			this.picBoxMascot.Location = new System.Drawing.Point(340, 145);
			this.picBoxMascot.Name = "picBoxMascot";
			this.picBoxMascot.Size = new System.Drawing.Size(282, 262);
			this.picBoxMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxMascot.TabIndex = 5;
			this.picBoxMascot.TabStop = false;
			// 
			// picBoxLogo
			// 
			this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
			this.picBoxLogo.BackgroundImage = global::PetStop.Properties.Resources.logoPetStop;
			this.picBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picBoxLogo.Location = new System.Drawing.Point(55, 31);
			this.picBoxLogo.Name = "picBoxLogo";
			this.picBoxLogo.Size = new System.Drawing.Size(211, 93);
			this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxLogo.TabIndex = 4;
			this.picBoxLogo.TabStop = false;
			// 
			// MainMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PetStop.Properties.Resources.bgMainMenu;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(634, 419);
			this.Controls.Add(this.picBoxMascot);
			this.Controls.Add(this.picBoxLogo);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnLoadProfile);
			this.Controls.Add(this.BtnNewProfile);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(650, 458);
			this.MinimumSize = new System.Drawing.Size(650, 458);
			this.Name = "MainMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главное меню";
			this.Shown += new System.EventHandler(this.MainMenuForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.picBoxMascot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnNewProfile;
		private System.Windows.Forms.Button BtnLoadProfile;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.PictureBox picBoxLogo;
		private System.Windows.Forms.PictureBox picBoxMascot;
	}
}