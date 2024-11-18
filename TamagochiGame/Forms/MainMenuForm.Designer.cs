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
			this.SuspendLayout();
			// 
			// BtnNewProfile
			// 
			this.BtnNewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnNewProfile.AutoSize = true;
			this.BtnNewProfile.Location = new System.Drawing.Point(205, 91);
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
			this.BtnLoadProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnLoadProfile.AutoSize = true;
			this.BtnLoadProfile.Location = new System.Drawing.Point(205, 142);
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
			this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnExit.AutoSize = true;
			this.BtnExit.Location = new System.Drawing.Point(205, 244);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(211, 41);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// MainMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 377);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnLoadProfile);
			this.Controls.Add(this.BtnNewProfile);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "MainMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главное меню";
			this.Load += new System.EventHandler(this.MainMenuForm_Load);
			this.Shown += new System.EventHandler(this.MainMenuForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnNewProfile;
		private System.Windows.Forms.Button BtnLoadProfile;
		private System.Windows.Forms.Button BtnExit;
	}
}