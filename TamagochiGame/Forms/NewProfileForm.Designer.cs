namespace PetStop.Forms
{
	partial class NewProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProfileForm));
			this.TxtProfileName = new System.Windows.Forms.TextBox();
			this.LblUsername = new System.Windows.Forms.Label();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.DTPBDay = new System.Windows.Forms.DateTimePicker();
			this.LblBDay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtProfileName
			// 
			this.TxtProfileName.Location = new System.Drawing.Point(200, 12);
			this.TxtProfileName.Name = "TxtProfileName";
			this.TxtProfileName.Size = new System.Drawing.Size(150, 31);
			this.TxtProfileName.TabIndex = 0;
			// 
			// LblUsername
			// 
			this.LblUsername.AutoSize = true;
			this.LblUsername.Location = new System.Drawing.Point(43, 15);
			this.LblUsername.Name = "LblUsername";
			this.LblUsername.Size = new System.Drawing.Size(151, 23);
			this.LblUsername.TabIndex = 1;
			this.LblUsername.Text = "Имя профиля:";
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnExit.AutoSize = true;
			this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnExit.Location = new System.Drawing.Point(12, 86);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(94, 33);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnConfirm.AutoSize = true;
			this.BtnConfirm.Location = new System.Drawing.Point(254, 86);
			this.BtnConfirm.Name = "BtnConfirm";
			this.BtnConfirm.Size = new System.Drawing.Size(123, 33);
			this.BtnConfirm.TabIndex = 3;
			this.BtnConfirm.Text = "Сохранить";
			this.BtnConfirm.UseVisualStyleBackColor = true;
			this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// DTPBDay
			// 
			this.DTPBDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTPBDay.Location = new System.Drawing.Point(200, 49);
			this.DTPBDay.Name = "DTPBDay";
			this.DTPBDay.Size = new System.Drawing.Size(150, 31);
			this.DTPBDay.TabIndex = 4;
			// 
			// LblBDay
			// 
			this.LblBDay.AutoSize = true;
			this.LblBDay.Location = new System.Drawing.Point(26, 55);
			this.LblBDay.Name = "LblBDay";
			this.LblBDay.Size = new System.Drawing.Size(168, 23);
			this.LblBDay.TabIndex = 5;
			this.LblBDay.Text = "Дата рождения:";
			// 
			// NewProfileForm
			// 
			this.AcceptButton = this.BtnConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(389, 131);
			this.Controls.Add(this.LblBDay);
			this.Controls.Add(this.DTPBDay);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.LblUsername);
			this.Controls.Add(this.TxtProfileName);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MaximumSize = new System.Drawing.Size(405, 170);
			this.MinimumSize = new System.Drawing.Size(405, 170);
			this.Name = "NewProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Новый профиль";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPlayerForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtProfileName;
		private System.Windows.Forms.Label LblUsername;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.DateTimePicker DTPBDay;
		private System.Windows.Forms.Label LblBDay;
	}
}