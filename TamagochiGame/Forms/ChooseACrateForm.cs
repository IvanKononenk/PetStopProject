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
		public ChooseACrateForm()
		{
			InitializeComponent();
		}

		private void ChooseACrateForm_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox2.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox3.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			pictureBox1.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = BtnUpdateCrates.Enabled = false;
			Species.newSpecies = SpeciesFactory.speciesDictionary[SpeciesFactory.speciesDictionary.ElementAt(rnd.Next(SpeciesFactory.speciesDictionary.Count)).Key];
			chosenBox = (PictureBox)sender;
			object file = Resources.ResourceManager.GetObject(Species.newSpecies.listFile);
			string[] pictures = JsonSerializer.Deserialize<string[]>((byte[])file);
			chosenBox.Image = (Bitmap)Resources.ResourceManager.GetObject(pictures[rnd.Next(pictures.Count())]);
			BtnConfirm.Enabled = true;
			LblPetName.Visible = true;
			TxtPetName.Visible = true;
		}

		private void BtnUpdateCrates_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox2.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox3.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtPetName.Text != "")
			{
				Pet.activePet = new Pet(TxtPetName.Text, Species.newSpecies, chosenBox.ImageLocation, ДОДЕЛАТЬ КОНСТРУКТОР);
			}
			else
			{
				MessageBox.Show("Дайте питомцу кличку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtPetName.Focus();
			}
		}
	}
}
