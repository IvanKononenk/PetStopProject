namespace PetStop
{
	partial class EnterPromocodeForm
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
			this.LblEnterPromocode = new System.Windows.Forms.Label();
			this.TxtBxPromocode = new System.Windows.Forms.TextBox();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnCheckPromocode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblEnterPromocode
			// 
			this.LblEnterPromocode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblEnterPromocode.AutoSize = true;
			this.LblEnterPromocode.Location = new System.Drawing.Point(18, 18);
			this.LblEnterPromocode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.LblEnterPromocode.Name = "LblEnterPromocode";
			this.LblEnterPromocode.Size = new System.Drawing.Size(187, 26);
			this.LblEnterPromocode.TabIndex = 0;
			this.LblEnterPromocode.Text = "Введите промокод:";
			// 
			// TxtBxPromocode
			// 
			this.TxtBxPromocode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtBxPromocode.Location = new System.Drawing.Point(217, 15);
			this.TxtBxPromocode.Margin = new System.Windows.Forms.Padding(6);
			this.TxtBxPromocode.Name = "TxtBxPromocode";
			this.TxtBxPromocode.Size = new System.Drawing.Size(196, 34);
			this.TxtBxPromocode.TabIndex = 1;
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnExit.Location = new System.Drawing.Point(20, 76);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(6);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(150, 46);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Отмена";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnCheckPromocode
			// 
			this.BtnCheckPromocode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCheckPromocode.Location = new System.Drawing.Point(263, 76);
			this.BtnCheckPromocode.Margin = new System.Windows.Forms.Padding(6);
			this.BtnCheckPromocode.Name = "BtnCheckPromocode";
			this.BtnCheckPromocode.Size = new System.Drawing.Size(150, 46);
			this.BtnCheckPromocode.TabIndex = 3;
			this.BtnCheckPromocode.Text = "Проверить";
			this.BtnCheckPromocode.UseVisualStyleBackColor = true;
			// 
			// EnterPromocodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 137);
			this.Controls.Add(this.BtnCheckPromocode);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.TxtBxPromocode);
			this.Controls.Add(this.LblEnterPromocode);
			this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "EnterPromocodeForm";
			this.Text = "EnterPromocodeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblEnterPromocode;
		private System.Windows.Forms.TextBox TxtBxPromocode;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnCheckPromocode;
	}
}