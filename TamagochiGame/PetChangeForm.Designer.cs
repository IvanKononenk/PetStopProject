namespace TamagochiGame
{
	partial class PetChangeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetChangeForm));
			this.DGVPets = new System.Windows.Forms.DataGridView();
			this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pet = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.DGVPets)).BeginInit();
			this.SuspendLayout();
			// 
			// DGVPets
			// 
			this.DGVPets.AllowUserToAddRows = false;
			this.DGVPets.AllowUserToDeleteRows = false;
			this.DGVPets.AllowUserToResizeColumns = false;
			this.DGVPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DGVPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVPets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVPets.ColumnHeadersVisible = false;
			this.DGVPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.pet});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGVPets.DefaultCellStyle = dataGridViewCellStyle1;
			this.DGVPets.Location = new System.Drawing.Point(12, 12);
			this.DGVPets.MultiSelect = false;
			this.DGVPets.Name = "DGVPets";
			this.DGVPets.RowHeadersVisible = false;
			this.DGVPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DGVPets.Size = new System.Drawing.Size(163, 593);
			this.DGVPets.TabIndex = 1;
			this.DGVPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPets_CellContentClick);
			// 
			// fileName
			// 
			this.fileName.HeaderText = "Имя файла";
			this.fileName.Name = "fileName";
			this.fileName.Visible = false;
			// 
			// pet
			// 
			this.pet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.pet.HeaderText = "Питомец";
			this.pet.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.pet.Name = "pet";
			this.pet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// PetChangeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 617);
			this.Controls.Add(this.DGVPets);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(203, 4000);
			this.Name = "PetChangeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Смена питомца";
			this.Load += new System.EventHandler(this.PetChangeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGVPets)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DGVPets;
		private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
		private System.Windows.Forms.DataGridViewImageColumn pet;
	}
}