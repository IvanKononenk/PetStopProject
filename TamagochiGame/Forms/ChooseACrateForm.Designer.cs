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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseACrateForm));
			this.LblPetName = new System.Windows.Forms.Label();
			this.TxtPetName = new System.Windows.Forms.TextBox();
			this.BtnConfirm = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.imgListCrates = new System.Windows.Forms.ImageList(this.components);
			this.TLPCrates = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// LblPetName
			// 
			this.LblPetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblPetName.AutoSize = true;
			this.LblPetName.Location = new System.Drawing.Point(187, 225);
			this.LblPetName.Name = "LblPetName";
			this.LblPetName.Size = new System.Drawing.Size(90, 23);
			this.LblPetName.TabIndex = 3;
			this.LblPetName.Text = "Кличка:";
			this.LblPetName.Visible = false;
			// 
			// TxtPetName
			// 
			this.TxtPetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtPetName.Location = new System.Drawing.Point(283, 222);
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
			this.BtnConfirm.Location = new System.Drawing.Point(482, 265);
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
			this.BtnExit.Location = new System.Drawing.Point(544, 304);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(83, 33);
			this.BtnExit.TabIndex = 6;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// imgListCrates
			// 
			this.imgListCrates.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListCrates.ImageSize = new System.Drawing.Size(16, 16);
			this.imgListCrates.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// TLPCrates
			// 
			this.TLPCrates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TLPCrates.ColumnCount = 1;
			this.TLPCrates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLPCrates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TLPCrates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TLPCrates.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
			this.TLPCrates.Location = new System.Drawing.Point(12, 12);
			this.TLPCrates.Name = "TLPCrates";
			this.TLPCrates.RowCount = 1;
			this.TLPCrates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLPCrates.Size = new System.Drawing.Size(615, 204);
			this.TLPCrates.TabIndex = 8;
			// 
			// ChooseACrateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 349);
			this.Controls.Add(this.TLPCrates);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnConfirm);
			this.Controls.Add(this.TxtPetName);
			this.Controls.Add(this.LblPetName);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "ChooseACrateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новый питомец";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseACrateForm_FormClosing);
			this.Load += new System.EventHandler(this.ChooseACrateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LblPetName;
		private System.Windows.Forms.TextBox TxtPetName;
		private System.Windows.Forms.Button BtnConfirm;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.ImageList imgListCrates;
		private System.Windows.Forms.TableLayoutPanel TLPCrates;
	}
}