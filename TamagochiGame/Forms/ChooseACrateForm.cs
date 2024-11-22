using PetStop.Classes;
using PetStop.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class ChooseACrateForm : Form
	{
		Random rnd = new Random();
		PictureBox chosenBox;
		string[] crates = JsonSerializer.Deserialize<string[]>(Resources.CratesList);
		bool petCreated = false;
		public ChooseACrateForm()
		{
			InitializeComponent();
		}

		private void ChooseACrateForm_Load(object sender, EventArgs e)
		{
			PictureBox[] picBoxCrates = new PictureBox[CratesClasses.LoadCrates().Count()];
			for (int i = 0; i < picBoxCrates.Length; i++)
			{
				picBoxCrates[i] = new PictureBox
				{
					Image = (Bitmap)Resources.ResourceManager.GetObject(CratesClasses.LoadCrates()[i].crateName),
					SizeMode = PictureBoxSizeMode.Zoom,
					Parent = TLPCrates,
					Dock = DockStyle.Fill,
					Tag = i
				};
				picBoxCrates[i].Click += picBoxCrate_CLick;
				TLPCrates.Controls.Add(picBoxCrates[i]);
				TLPCrates.ColumnStyles[i].SizeType = SizeType.Percent;
				TLPCrates.ColumnStyles[i].Width = 100 / picBoxCrates.Length;
			}
		}

		private void picBoxCrate_CLick(object sender, EventArgs e)
		{
			TLPCrates.Enabled = false;
			chosenBox = (PictureBox)sender;
			Species.newSpecies = CratesClasses.RandomSpecies(int.Parse(chosenBox.Tag.ToString()));
			chosenBox.Image = (Bitmap)Resources.ResourceManager.GetObject(Species.newSpecies.possiblePics[rnd.Next(Species.newSpecies.possiblePics.Length)]);
			BtnConfirm.Enabled = true;
			LblPetName.Visible = true;
			TxtPetName.Visible = true;
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtPetName.Text != "")
			{
				petCreated = true;
			}
			else
			{
				MessageBox.Show("Дайте питомцу кличку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtPetName.Focus();
			}
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			petCreated = false;
			Close();
		}

		private void ChooseACrateForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!petCreated)
				Application.OpenForms["MainMenuForm"].Show();
		}
	}
}
