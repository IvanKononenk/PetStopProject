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
			this.PanelName = new System.Windows.Forms.Panel();
			this.PanelSpecies = new System.Windows.Forms.Panel();
			this.TxtSpecies = new System.Windows.Forms.TextBox();
			this.LblSpecies = new System.Windows.Forms.Label();
			this.PanelGender = new System.Windows.Forms.Panel();
			this.TxtSex = new System.Windows.Forms.TextBox();
			this.LblSex = new System.Windows.Forms.Label();
			this.TLPPet = new System.Windows.Forms.TableLayoutPanel();
			this.PanelInfo = new System.Windows.Forms.Panel();
			this.PanelBig = new System.Windows.Forms.Panel();
			this.PanelName.SuspendLayout();
			this.PanelSpecies.SuspendLayout();
			this.PanelGender.SuspendLayout();
			this.TLPPet.SuspendLayout();
			this.PanelInfo.SuspendLayout();
			this.PanelBig.SuspendLayout();
			this.SuspendLayout();
			// 
			// LblPetName
			// 
			this.LblPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LblPetName.AutoSize = true;
			this.LblPetName.Location = new System.Drawing.Point(0, 3);
			this.LblPetName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblPetName.Name = "LblPetName";
			this.LblPetName.Size = new System.Drawing.Size(90, 23);
			this.LblPetName.TabIndex = 3;
			this.LblPetName.Text = "Кличка:";
			// 
			// TxtPetName
			// 
			this.TxtPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TxtPetName.Location = new System.Drawing.Point(96, 0);
			this.TxtPetName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.TxtPetName.Name = "TxtPetName";
			this.TxtPetName.Size = new System.Drawing.Size(145, 31);
			this.TxtPetName.TabIndex = 4;
			// 
			// BtnConfirm
			// 
			this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnConfirm.AutoSize = true;
			this.BtnConfirm.Enabled = false;
			this.BtnConfirm.Location = new System.Drawing.Point(451, 356);
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
			this.BtnExit.Location = new System.Drawing.Point(513, 395);
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
			this.TLPCrates.Location = new System.Drawing.Point(3, 3);
			this.TLPCrates.Name = "TLPCrates";
			this.TLPCrates.RowCount = 1;
			this.TLPCrates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLPCrates.Size = new System.Drawing.Size(578, 218);
			this.TLPCrates.TabIndex = 8;
			// 
			// PanelName
			// 
			this.PanelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PanelName.Controls.Add(this.TxtPetName);
			this.PanelName.Controls.Add(this.LblPetName);
			this.PanelName.Location = new System.Drawing.Point(50, 0);
			this.PanelName.Name = "PanelName";
			this.PanelName.Size = new System.Drawing.Size(241, 31);
			this.PanelName.TabIndex = 10;
			// 
			// PanelSpecies
			// 
			this.PanelSpecies.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PanelSpecies.Controls.Add(this.TxtSpecies);
			this.PanelSpecies.Controls.Add(this.LblSpecies);
			this.PanelSpecies.Location = new System.Drawing.Point(50, 34);
			this.PanelSpecies.Name = "PanelSpecies";
			this.PanelSpecies.Size = new System.Drawing.Size(241, 31);
			this.PanelSpecies.TabIndex = 10;
			// 
			// TxtSpecies
			// 
			this.TxtSpecies.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TxtSpecies.Location = new System.Drawing.Point(96, 0);
			this.TxtSpecies.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.TxtSpecies.Name = "TxtSpecies";
			this.TxtSpecies.ReadOnly = true;
			this.TxtSpecies.Size = new System.Drawing.Size(145, 31);
			this.TxtSpecies.TabIndex = 4;
			// 
			// LblSpecies
			// 
			this.LblSpecies.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LblSpecies.AutoSize = true;
			this.LblSpecies.Location = new System.Drawing.Point(0, 3);
			this.LblSpecies.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblSpecies.Name = "LblSpecies";
			this.LblSpecies.Size = new System.Drawing.Size(92, 23);
			this.LblSpecies.TabIndex = 3;
			this.LblSpecies.Text = "Порода:";
			// 
			// PanelGender
			// 
			this.PanelGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PanelGender.Controls.Add(this.TxtSex);
			this.PanelGender.Controls.Add(this.LblSex);
			this.PanelGender.Location = new System.Drawing.Point(83, 68);
			this.PanelGender.Name = "PanelGender";
			this.PanelGender.Size = new System.Drawing.Size(208, 31);
			this.PanelGender.TabIndex = 10;
			// 
			// TxtSex
			// 
			this.TxtSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TxtSex.Location = new System.Drawing.Point(63, 0);
			this.TxtSex.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.TxtSex.Name = "TxtSex";
			this.TxtSex.ReadOnly = true;
			this.TxtSex.Size = new System.Drawing.Size(145, 31);
			this.TxtSex.TabIndex = 4;
			// 
			// LblSex
			// 
			this.LblSex.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LblSex.AutoSize = true;
			this.LblSex.Location = new System.Drawing.Point(0, 3);
			this.LblSex.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblSex.Name = "LblSex";
			this.LblSex.Size = new System.Drawing.Size(57, 23);
			this.LblSex.TabIndex = 3;
			this.LblSex.Text = "Пол:";
			// 
			// TLPPet
			// 
			this.TLPPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TLPPet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TLPPet.ColumnCount = 3;
			this.TLPPet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TLPPet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.TLPPet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TLPPet.Controls.Add(this.PanelInfo, 1, 0);
			this.TLPPet.Location = new System.Drawing.Point(3, 227);
			this.TLPPet.Name = "TLPPet";
			this.TLPPet.RowCount = 1;
			this.TLPPet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TLPPet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
			this.TLPPet.Size = new System.Drawing.Size(578, 108);
			this.TLPPet.TabIndex = 10;
			this.TLPPet.Visible = false;
			// 
			// PanelInfo
			// 
			this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelInfo.Controls.Add(this.PanelSpecies);
			this.PanelInfo.Controls.Add(this.PanelName);
			this.PanelInfo.Controls.Add(this.PanelGender);
			this.PanelInfo.Location = new System.Drawing.Point(118, 3);
			this.PanelInfo.Name = "PanelInfo";
			this.PanelInfo.Size = new System.Drawing.Size(340, 102);
			this.PanelInfo.TabIndex = 11;
			// 
			// PanelBig
			// 
			this.PanelBig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelBig.Controls.Add(this.TLPCrates);
			this.PanelBig.Controls.Add(this.TLPPet);
			this.PanelBig.Location = new System.Drawing.Point(12, 12);
			this.PanelBig.Name = "PanelBig";
			this.PanelBig.Size = new System.Drawing.Size(584, 338);
			this.PanelBig.TabIndex = 11;
			// 
			// ChooseACrateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 440);
			this.Controls.Add(this.PanelBig);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnConfirm);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.MinimumSize = new System.Drawing.Size(624, 479);
			this.Name = "ChooseACrateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новый питомец";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseACrateForm_FormClosing);
			this.Load += new System.EventHandler(this.ChooseACrateForm_Load);
			this.PanelName.ResumeLayout(false);
			this.PanelName.PerformLayout();
			this.PanelSpecies.ResumeLayout(false);
			this.PanelSpecies.PerformLayout();
			this.PanelGender.ResumeLayout(false);
			this.PanelGender.PerformLayout();
			this.TLPPet.ResumeLayout(false);
			this.PanelInfo.ResumeLayout(false);
			this.PanelBig.ResumeLayout(false);
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
		private System.Windows.Forms.Panel PanelName;
		private System.Windows.Forms.Panel PanelSpecies;
		private System.Windows.Forms.Label LblSpecies;
		private System.Windows.Forms.Panel PanelGender;
		private System.Windows.Forms.Label LblSex;
		private System.Windows.Forms.TableLayoutPanel TLPPet;
		private System.Windows.Forms.Panel PanelInfo;
		private System.Windows.Forms.Panel PanelBig;
		private System.Windows.Forms.TextBox TxtSpecies;
		private System.Windows.Forms.TextBox TxtSex;
	}
}