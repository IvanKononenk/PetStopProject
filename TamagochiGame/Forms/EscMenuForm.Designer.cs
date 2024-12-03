namespace PetStop.Forms
{
	partial class EscMenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscMenuForm));
			this.BtnContinue = new System.Windows.Forms.Button();
			this.BtnSaveGame = new System.Windows.Forms.Button();
			this.BtnLoadGame = new System.Windows.Forms.Button();
			this.BtnPetInfo = new System.Windows.Forms.Button();
			this.BtnSettings = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnContinue
			// 
			this.BtnContinue.AutoSize = true;
			this.BtnContinue.Location = new System.Drawing.Point(237, 14);
			this.BtnContinue.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnContinue.Name = "BtnContinue";
			this.BtnContinue.Size = new System.Drawing.Size(192, 41);
			this.BtnContinue.TabIndex = 0;
			this.BtnContinue.Text = "Продолжить игру";
			this.BtnContinue.UseVisualStyleBackColor = true;
			this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
			// 
			// BtnSaveGame
			// 
			this.BtnSaveGame.AutoSize = true;
			this.BtnSaveGame.Location = new System.Drawing.Point(238, 65);
			this.BtnSaveGame.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnSaveGame.Name = "BtnSaveGame";
			this.BtnSaveGame.Size = new System.Drawing.Size(191, 41);
			this.BtnSaveGame.TabIndex = 1;
			this.BtnSaveGame.Text = "Сохранить игру";
			this.BtnSaveGame.UseVisualStyleBackColor = true;
			this.BtnSaveGame.Click += new System.EventHandler(this.BtnSaveGame_Click);
			// 
			// BtnLoadGame
			// 
			this.BtnLoadGame.AutoSize = true;
			this.BtnLoadGame.Location = new System.Drawing.Point(238, 116);
			this.BtnLoadGame.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnLoadGame.Name = "BtnLoadGame";
			this.BtnLoadGame.Size = new System.Drawing.Size(191, 41);
			this.BtnLoadGame.TabIndex = 2;
			this.BtnLoadGame.Text = "Загрузить игру";
			this.BtnLoadGame.UseVisualStyleBackColor = true;
			this.BtnLoadGame.Click += new System.EventHandler(this.BtnLoadGame_Click);
			// 
			// BtnPetInfo
			// 
			this.BtnPetInfo.AutoSize = true;
			this.BtnPetInfo.Location = new System.Drawing.Point(237, 167);
			this.BtnPetInfo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnPetInfo.Name = "BtnPetInfo";
			this.BtnPetInfo.Size = new System.Drawing.Size(192, 41);
			this.BtnPetInfo.TabIndex = 3;
			this.BtnPetInfo.Text = "О питомце";
			this.BtnPetInfo.UseVisualStyleBackColor = true;
			this.BtnPetInfo.Click += new System.EventHandler(this.BtnPetInfo_Click);
			// 
			// BtnSettings
			// 
			this.BtnSettings.AutoSize = true;
			this.BtnSettings.Location = new System.Drawing.Point(237, 218);
			this.BtnSettings.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnSettings.Name = "BtnSettings";
			this.BtnSettings.Size = new System.Drawing.Size(192, 41);
			this.BtnSettings.TabIndex = 4;
			this.BtnSettings.Text = "Параметры";
			this.BtnSettings.UseVisualStyleBackColor = true;
			this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.AutoSize = true;
			this.BtnExit.Location = new System.Drawing.Point(238, 269);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(191, 41);
			this.BtnExit.TabIndex = 5;
			this.BtnExit.Text = "В главное меню";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// EscMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 343);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnSettings);
			this.Controls.Add(this.BtnPetInfo);
			this.Controls.Add(this.BtnLoadGame);
			this.Controls.Add(this.BtnSaveGame);
			this.Controls.Add(this.BtnContinue);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "EscMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Меню";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EscMenuForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnContinue;
		private System.Windows.Forms.Button BtnSaveGame;
		private System.Windows.Forms.Button BtnLoadGame;
		private System.Windows.Forms.Button BtnPetInfo;
		private System.Windows.Forms.Button BtnSettings;
		private System.Windows.Forms.Button BtnExit;
	}
}