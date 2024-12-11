namespace PetStop.Forms
{
	partial class LoadPetForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadPetForm));
			this.DGVSaveFiles = new System.Windows.Forms.DataGridView();
			this.SaveFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnLoad = new System.Windows.Forms.Button();
			this.LblSavesCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DGVSaveFiles)).BeginInit();
			this.SuspendLayout();
			// 
			// DGVSaveFiles
			// 
			this.DGVSaveFiles.AllowUserToAddRows = false;
			this.DGVSaveFiles.AllowUserToDeleteRows = false;
			this.DGVSaveFiles.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DGVSaveFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGVSaveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGVSaveFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVSaveFiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVSaveFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.DGVSaveFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSaveFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaveFile,
            this.SaveDate});
			this.DGVSaveFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGVSaveFiles.Location = new System.Drawing.Point(12, 12);
			this.DGVSaveFiles.MultiSelect = false;
			this.DGVSaveFiles.Name = "DGVSaveFiles";
			this.DGVSaveFiles.ReadOnly = true;
			this.DGVSaveFiles.RowHeadersVisible = false;
			this.DGVSaveFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGVSaveFiles.Size = new System.Drawing.Size(573, 157);
			this.DGVSaveFiles.TabIndex = 0;
			this.DGVSaveFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSaveFiles_CellDoubleClick);
			// 
			// SaveFile
			// 
			this.SaveFile.HeaderText = "Имя профиля";
			this.SaveFile.Name = "SaveFile";
			this.SaveFile.ReadOnly = true;
			// 
			// SaveDate
			// 
			this.SaveDate.HeaderText = "Последний запуск";
			this.SaveDate.Name = "SaveDate";
			this.SaveDate.ReadOnly = true;
			// 
			// BtnExit
			// 
			this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnExit.Location = new System.Drawing.Point(468, 214);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(117, 33);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Выход";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnLoad
			// 
			this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLoad.AutoSize = true;
			this.BtnLoad.Location = new System.Drawing.Point(468, 175);
			this.BtnLoad.Name = "BtnLoad";
			this.BtnLoad.Size = new System.Drawing.Size(117, 33);
			this.BtnLoad.TabIndex = 1;
			this.BtnLoad.Text = "Загрузить";
			this.BtnLoad.UseVisualStyleBackColor = true;
			this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
			// 
			// LblSavesCount
			// 
			this.LblSavesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblSavesCount.AutoSize = true;
			this.LblSavesCount.Location = new System.Drawing.Point(12, 172);
			this.LblSavesCount.Name = "LblSavesCount";
			this.LblSavesCount.Size = new System.Drawing.Size(245, 23);
			this.LblSavesCount.TabIndex = 3;
			this.LblSavesCount.Text = "Сохранений найдено: 0";
			// 
			// LoadPetForm
			// 
			this.AcceptButton = this.BtnLoad;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(597, 259);
			this.Controls.Add(this.LblSavesCount);
			this.Controls.Add(this.BtnLoad);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.DGVSaveFiles);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(613, 298);
			this.Name = "LoadPetForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Список сохранений";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadSaveForm_FormClosing);
			this.Load += new System.EventHandler(this.LoadSaveForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGVSaveFiles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGVSaveFiles;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnLoad;
		private System.Windows.Forms.Label LblSavesCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaveFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn SaveDate;
	}
}