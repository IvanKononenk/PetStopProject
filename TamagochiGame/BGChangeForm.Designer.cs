﻿namespace TamagochiGame
{
	partial class BGChangeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BGChangeForm));
			this.DGVBGs = new System.Windows.Forms.DataGridView();
			this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.background = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.DGVBGs)).BeginInit();
			this.SuspendLayout();
			// 
			// DGVBGs
			// 
			this.DGVBGs.AllowUserToAddRows = false;
			this.DGVBGs.AllowUserToDeleteRows = false;
			this.DGVBGs.AllowUserToResizeColumns = false;
			this.DGVBGs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGVBGs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVBGs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVBGs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVBGs.ColumnHeadersVisible = false;
			this.DGVBGs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.background});
			this.DGVBGs.Location = new System.Drawing.Point(12, 12);
			this.DGVBGs.Name = "DGVBGs";
			this.DGVBGs.RowHeadersVisible = false;
			this.DGVBGs.Size = new System.Drawing.Size(776, 426);
			this.DGVBGs.TabIndex = 0;
			this.DGVBGs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBGs_CellContentClick);
			// 
			// fileName
			// 
			this.fileName.HeaderText = "Имя файла";
			this.fileName.Name = "fileName";
			this.fileName.Visible = false;
			// 
			// background
			// 
			this.background.HeaderText = "Фон";
			this.background.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.background.Name = "background";
			// 
			// BGChangeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DGVBGs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BGChangeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Смена фона";
			this.Load += new System.EventHandler(this.BGChangeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGVBGs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DGVBGs;
		private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
		private System.Windows.Forms.DataGridViewImageColumn background;
	}
}