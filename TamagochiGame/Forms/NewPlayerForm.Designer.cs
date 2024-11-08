namespace PetStop.Forms
{
	partial class NewPlayerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayerForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.LblUsername = new System.Windows.Forms.Label();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.LblBDay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(200, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 31);
			this.textBox1.TabIndex = 0;
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
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(200, 49);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(150, 31);
			this.dateTimePicker1.TabIndex = 4;
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
			// NewPlayerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 131);
			this.Controls.Add(this.LblBDay);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.LblUsername);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "NewPlayerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Новый профиль";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewPlayerForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label LblUsername;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label LblBDay;
	}
}