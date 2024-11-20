namespace PetStop.Forms
{
	partial class ChooseACrateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseACrateForm));
			this.LblPetName = new System.Windows.Forms.Label();
			this.TxtPetName = new System.Windows.Forms.TextBox();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnUpdateCrates = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LblPetName
			// 
			this.LblPetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblPetName.AutoSize = true;
			this.LblPetName.Location = new System.Drawing.Point(202, 225);
			this.LblPetName.Name = "LblPetName";
			this.LblPetName.Size = new System.Drawing.Size(90, 23);
			this.LblPetName.TabIndex = 3;
			this.LblPetName.Text = "Кличка:";
			this.LblPetName.Visible = false;
			// 
			// TxtPetName
			// 
			this.TxtPetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtPetName.Location = new System.Drawing.Point(298, 222);
			this.TxtPetName.Name = "TxtPetName";
			this.TxtPetName.Size = new System.Drawing.Size(145, 31);
			this.TxtPetName.TabIndex = 4;
			this.TxtPetName.Visible = false;
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnConfirm.AutoSize = true;
			this.BtnConfirm.Enabled = false;
			this.BtnConfirm.Location = new System.Drawing.Point(497, 265);
			this.BtnConfirm.Name = "BtnConfirm";
			this.BtnConfirm.Size = new System.Drawing.Size(145, 33);
			this.BtnConfirm.TabIndex = 5;
			this.BtnConfirm.Text = "Подтвердить";
			this.BtnConfirm.UseVisualStyleBackColor = true;
			this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExit.AutoSize = true;
			this.BtnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtnExit.Location = new System.Drawing.Point(559, 304);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(83, 33);
			this.BtnExit.TabIndex = 6;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.Location = new System.Drawing.Point(439, 14);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 200);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox2.Location = new System.Drawing.Point(227, 14);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 200);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(15, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// BtnUpdateCrates
			// 
			this.BtnUpdateCrates.AutoSize = true;
			this.BtnUpdateCrates.Location = new System.Drawing.Point(12, 304);
			this.BtnUpdateCrates.Name = "BtnUpdateCrates";
			this.BtnUpdateCrates.Size = new System.Drawing.Size(201, 33);
			this.BtnUpdateCrates.TabIndex = 7;
			this.BtnUpdateCrates.Text = "Изменить коробки";
			this.BtnUpdateCrates.UseVisualStyleBackColor = true;
			this.BtnUpdateCrates.Click += new System.EventHandler(this.BtnUpdateCrates_Click);
			// 
			// ChooseACrateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 349);
			this.Controls.Add(this.BtnUpdateCrates);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.TxtPetName);
			this.Controls.Add(this.LblPetName);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "ChooseACrateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новый питомец";
			this.Load += new System.EventHandler(this.ChooseACrateForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label LblPetName;
		private System.Windows.Forms.TextBox TxtPetName;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnUpdateCrates;
	}
}