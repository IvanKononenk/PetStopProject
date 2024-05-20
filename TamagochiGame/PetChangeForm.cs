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
	public partial class PetChangeForm : Form
	{
		public string petFileName;
		public PetChangeForm()
		{
			InitializeComponent();
		}

		private void PetChangeForm_Load(object sender, EventArgs e)
		{
			System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo("Sprites/pets");
			foreach (System.IO.FileInfo bg in dirInfo.GetFiles())
			{
				try
				{
					DGVPets.Rows.Add("Sprites/pets/" + bg.ToString(), Image.FromFile("Sprites/pets/" + bg.ToString()));
				}
				catch
				{
					MessageBox.Show("Возникла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void DGVPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var selectedPet = (DataGridView)sender;
			if (selectedPet.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
			{
				petFileName = selectedPet.Rows[e.RowIndex].Cells[0].Value.ToString();
				DialogResult = DialogResult.OK;
				Dispose();
			}
		}
	}
}
