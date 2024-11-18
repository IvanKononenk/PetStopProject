namespace PetStop.Forms
{
	partial class LoadProfileForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadProfileForm));
			this.DGVSaveFIles = new System.Windows.Forms.DataGridView();
			this.SaveFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LblSavesCount = new System.Windows.Forms.Label();
			this.BtnLoad = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DGVSaveFIles)).BeginInit();
			this.SuspendLayout();
			// 
			// DGVSaveFIles
			// 
			this.DGVSaveFIles.AllowUserToAddRows = false;
			this.DGVSaveFIles.AllowUserToDeleteRows = false;
			this.DGVSaveFIles.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DGVSaveFIles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGVSaveFIles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGVSaveFIles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVSaveFIles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVSaveFIles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.DGVSaveFIles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSaveFIles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaveFile,
            this.SaveDate});
			this.DGVSaveFIles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGVSaveFIles.Location = new System.Drawing.Point(12, 12);
			this.DGVSaveFIles.MultiSelect = false;
			this.DGVSaveFIles.Name = "DGVSaveFIles";
			this.DGVSaveFIles.ReadOnly = true;
			this.DGVSaveFIles.RowHeadersVisible = false;
			this.DGVSaveFIles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGVSaveFIles.Size = new System.Drawing.Size(816, 315);
			this.DGVSaveFIles.TabIndex = 4;
			// 
			// SaveFile
			// 
			this.SaveFile.HeaderText = "Название сохранения";
			this.SaveFile.Name = "SaveFile";
			this.SaveFile.ReadOnly = true;
			// 
			// SaveDate
			// 
			this.SaveDate.HeaderText = "Последний запуск";
			this.SaveDate.Name = "SaveDate";
			this.SaveDate.ReadOnly = true;
			// 
			// LblSavesCount
			// 
			this.LblSavesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblSavesCount.AutoSize = true;
			this.LblSavesCount.Location = new System.Drawing.Point(12, 330);
			this.LblSavesCount.Name = "LblSavesCount";
			this.LblSavesCount.Size = new System.Drawing.Size(245, 23);
			this.LblSavesCount.TabIndex = 7;
			this.LblSavesCount.Text = "Сохранений найдено: 0";
			// 
			// BtnLoad
			// 
			this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLoad.AutoSize = true;
			this.BtnLoad.Location = new System.Drawing.Point(711, 333);
			this.BtnLoad.Name = "BtnLoad";
			this.BtnLoad.Size = new System.Drawing.Size(117, 33);
			this.BtnLoad.TabIndex = 6;
			this.BtnLoad.Text = "Загрузить";
			this.BtnLoad.UseVisualStyleBackColor = true;
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExit.Location = new System.Drawing.Point(711, 372);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(117, 33);
			this.BtnExit.TabIndex = 5;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// LoadProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 417);
			this.Controls.Add(this.DGVSaveFIles);
			this.Controls.Add(this.LblSavesCount);
			this.Controls.Add(this.BtnLoad);
			this.Controls.Add(this.BtnExit);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "LoadProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор профиля";
			this.Load += new System.EventHandler(this.LoadProfileForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGVSaveFIles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGVSaveFIles;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaveFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaveDate;
		private System.Windows.Forms.Label LblSavesCount;
		private System.Windows.Forms.Button BtnLoad;
		private System.Windows.Forms.Button BtnExit;
	}
}