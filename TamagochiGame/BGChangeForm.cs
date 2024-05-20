using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamagochiGame
{
	public partial class BGChangeForm : Form
	{
		public string bgFileName;
		public BGChangeForm()
		{
			InitializeComponent();
		}

		private void BGChangeForm_Load(object sender, EventArgs e)
		{
			System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo("Sprites/backgrounds");
			foreach (System.IO.FileInfo bg in dirInfo.GetFiles())
			{
				try
				{
					DGVBGs.Rows.Add("Sprites/backgrounds/" + bg.ToString(), Image.FromFile("Sprites/backgrounds/" + bg.ToString()));
				}
				catch 
				{
					MessageBox.Show("Возникла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DGVBGs_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedBG = (DataGridView)sender;
			if (selectedBG.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0) 
			{ 
				bgFileName = selectedBG.Rows[e.RowIndex].Cells[0].Value.ToString();
				DialogResult = DialogResult.OK;
				Dispose();
			}
		}
	}
}
