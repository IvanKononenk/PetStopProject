namespace PetStop.Forms
{
	partial class PetInfoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetInfoForm));
			this.PicBoxPet = new System.Windows.Forms.PictureBox();
			this.LblName = new System.Windows.Forms.Label();
			this.LblSpecies = new System.Windows.Forms.Label();
			this.LblGender = new System.Windows.Forms.Label();
			this.LblTrait = new System.Windows.Forms.Label();
			this.LblAge = new System.Windows.Forms.Label();
			this.LblEffects = new System.Windows.Forms.Label();
			this.BtnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).BeginInit();
			this.SuspendLayout();
			// 
			// PicBoxPet
			// 
			this.PicBoxPet.Location = new System.Drawing.Point(15, 14);
			this.PicBoxPet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.PicBoxPet.Name = "PicBoxPet";
			this.PicBoxPet.Size = new System.Drawing.Size(333, 333);
			this.PicBoxPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PicBoxPet.TabIndex = 0;
			this.PicBoxPet.TabStop = false;
			// 
			// LblName
			// 
			this.LblName.AutoSize = true;
			this.LblName.Location = new System.Drawing.Point(360, 14);
			this.LblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(64, 23);
			this.LblName.TabIndex = 1;
			this.LblName.Text = "Имя: ";
			// 
			// LblSpecies
			// 
			this.LblSpecies.AutoSize = true;
			this.LblSpecies.Location = new System.Drawing.Point(360, 37);
			this.LblSpecies.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblSpecies.Name = "LblSpecies";
			this.LblSpecies.Size = new System.Drawing.Size(63, 23);
			this.LblSpecies.TabIndex = 2;
			this.LblSpecies.Text = "Вид: ";
			// 
			// LblGender
			// 
			this.LblGender.AutoSize = true;
			this.LblGender.Location = new System.Drawing.Point(359, 60);
			this.LblGender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblGender.Name = "LblGender";
			this.LblGender.Size = new System.Drawing.Size(64, 23);
			this.LblGender.TabIndex = 3;
			this.LblGender.Text = "Пол: ";
			// 
			// LblTrait
			// 
			this.LblTrait.AutoSize = true;
			this.LblTrait.Location = new System.Drawing.Point(359, 83);
			this.LblTrait.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblTrait.Name = "LblTrait";
			this.LblTrait.Size = new System.Drawing.Size(83, 23);
			this.LblTrait.TabIndex = 4;
			this.LblTrait.Text = "Черта: ";
			// 
			// LblAge
			// 
			this.LblAge.AutoSize = true;
			this.LblAge.Location = new System.Drawing.Point(359, 106);
			this.LblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblAge.Name = "LblAge";
			this.LblAge.Size = new System.Drawing.Size(103, 23);
			this.LblAge.TabIndex = 5;
			this.LblAge.Text = "Возраст: ";
			// 
			// LblEffects
			// 
			this.LblEffects.AutoSize = true;
			this.LblEffects.Location = new System.Drawing.Point(360, 129);
			this.LblEffects.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblEffects.Name = "LblEffects";
			this.LblEffects.Size = new System.Drawing.Size(117, 23);
			this.LblEffects.TabIndex = 6;
			this.LblEffects.Text = "Эффекты: ";
			// 
			// BtnClose
			// 
			this.BtnClose.AutoSize = true;
			this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnClose.Location = new System.Drawing.Point(871, 316);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(101, 33);
			this.BtnClose.TabIndex = 0;
			this.BtnClose.Text = "Закрыть";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// PetInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnClose;
			this.ClientSize = new System.Drawing.Size(984, 361);
			this.Controls.Add(this.BtnClose);
			this.Controls.Add(this.LblEffects);
			this.Controls.Add(this.LblAge);
			this.Controls.Add(this.LblTrait);
			this.Controls.Add(this.LblGender);
			this.Controls.Add(this.LblSpecies);
			this.Controls.Add(this.LblName);
			this.Controls.Add(this.PicBoxPet);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "PetInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Карточка питомца";
			this.Load += new System.EventHandler(this.PetInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PicBoxPet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PicBoxPet;
		private System.Windows.Forms.Label LblName;
		private System.Windows.Forms.Label LblSpecies;
		private System.Windows.Forms.Label LblGender;
		private System.Windows.Forms.Label LblTrait;
		private System.Windows.Forms.Label LblAge;
		private System.Windows.Forms.Label LblEffects;
		private System.Windows.Forms.Button BtnClose;
	}
}