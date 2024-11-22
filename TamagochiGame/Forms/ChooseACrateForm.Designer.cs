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
			this.PanelTrait = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.LblTrait = new System.Windows.Forms.Label();
			this.PanelGender = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PanelName.SuspendLayout();
			this.PanelSpecies.SuspendLayout();
			this.PanelTrait.SuspendLayout();
			this.PanelGender.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LblPetName
			// 
			this.LblPetName.AutoSize = true;
			this.LblPetName.Location = new System.Drawing.Point(0, 3);
			this.LblPetName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblPetName.Name = "LblPetName";
			this.LblPetName.Size = new System.Drawing.Size(90, 23);
			this.LblPetName.TabIndex = 3;
			this.LblPetName.Text = "Кличка:";
			this.LblPetName.Visible = false;
			// 
			// TxtPetName
			// 
			this.TxtPetName.Location = new System.Drawing.Point(96, 0);
			this.TxtPetName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
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
			this.BtnConfirm.Location = new System.Drawing.Point(466, 494);
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
			this.BtnExit.Location = new System.Drawing.Point(528, 533);
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
			this.TLPCrates.Size = new System.Drawing.Size(599, 241);
			this.TLPCrates.TabIndex = 8;
			// 
			// PanelName
			// 
			this.PanelName.Controls.Add(this.TxtPetName);
			this.PanelName.Controls.Add(this.LblPetName);
			this.PanelName.Location = new System.Drawing.Point(3, 0);
			this.PanelName.Name = "PanelName";
			this.PanelName.Size = new System.Drawing.Size(241, 31);
			this.PanelName.TabIndex = 10;
			// 
			// PanelSpecies
			// 
			this.PanelSpecies.Controls.Add(this.TxtSpecies);
			this.PanelSpecies.Controls.Add(this.LblSpecies);
			this.PanelSpecies.Location = new System.Drawing.Point(3, 34);
			this.PanelSpecies.Name = "PanelSpecies";
			this.PanelSpecies.Size = new System.Drawing.Size(241, 31);
			this.PanelSpecies.TabIndex = 10;
			// 
			// TxtSpecies
			// 
			this.TxtSpecies.Location = new System.Drawing.Point(96, 0);
			this.TxtSpecies.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.TxtSpecies.Name = "TxtSpecies";
			this.TxtSpecies.ReadOnly = true;
			this.TxtSpecies.Size = new System.Drawing.Size(145, 31);
			this.TxtSpecies.TabIndex = 4;
			this.TxtSpecies.Visible = false;
			// 
			// LblSpecies
			// 
			this.LblSpecies.AutoSize = true;
			this.LblSpecies.Location = new System.Drawing.Point(0, 3);
			this.LblSpecies.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblSpecies.Name = "LblSpecies";
			this.LblSpecies.Size = new System.Drawing.Size(92, 23);
			this.LblSpecies.TabIndex = 3;
			this.LblSpecies.Text = "Порода:";
			this.LblSpecies.Visible = false;
			// 
			// PanelTrait
			// 
			this.PanelTrait.Controls.Add(this.textBox1);
			this.PanelTrait.Controls.Add(this.LblTrait);
			this.PanelTrait.Location = new System.Drawing.Point(17, 102);
			this.PanelTrait.Name = "PanelTrait";
			this.PanelTrait.Size = new System.Drawing.Size(227, 31);
			this.PanelTrait.TabIndex = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(82, 0);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(145, 31);
			this.textBox1.TabIndex = 4;
			this.textBox1.Visible = false;
			// 
			// LblTrait
			// 
			this.LblTrait.AutoSize = true;
			this.LblTrait.Location = new System.Drawing.Point(0, 3);
			this.LblTrait.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.LblTrait.Name = "LblTrait";
			this.LblTrait.Size = new System.Drawing.Size(76, 23);
			this.LblTrait.TabIndex = 3;
			this.LblTrait.Text = "Черта:";
			this.LblTrait.Visible = false;
			// 
			// PanelGender
			// 
			this.PanelGender.Controls.Add(this.textBox2);
			this.PanelGender.Controls.Add(this.label1);
			this.PanelGender.Location = new System.Drawing.Point(36, 68);
			this.PanelGender.Name = "PanelGender";
			this.PanelGender.Size = new System.Drawing.Size(208, 31);
			this.PanelGender.TabIndex = 10;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 0);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(145, 31);
			this.textBox2.TabIndex = 4;
			this.textBox2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Пол:";
			this.label1.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 259);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 139);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.PanelSpecies);
			this.panel1.Controls.Add(this.PanelName);
			this.panel1.Controls.Add(this.PanelTrait);
			this.panel1.Controls.Add(this.PanelGender);
			this.panel1.Location = new System.Drawing.Point(86, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 133);
			this.panel1.TabIndex = 11;
			// 
			// ChooseACrateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 578);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.TLPCrates);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnConfirm);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "ChooseACrateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Новый питомец";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseACrateForm_FormClosing);
			this.Load += new System.EventHandler(this.ChooseACrateForm_Load);
			this.PanelName.ResumeLayout(false);
			this.PanelName.PerformLayout();
			this.PanelSpecies.ResumeLayout(false);
			this.PanelSpecies.PerformLayout();
			this.PanelTrait.ResumeLayout(false);
			this.PanelTrait.PerformLayout();
			this.PanelGender.ResumeLayout(false);
			this.PanelGender.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
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
		private System.Windows.Forms.TextBox TxtSpecies;
		private System.Windows.Forms.Label LblSpecies;
		private System.Windows.Forms.Panel PanelTrait;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label LblTrait;
		private System.Windows.Forms.Panel PanelGender;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
	}
}