using PetStop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class PetInfoForm : Form
	{
		public PetInfoForm()
		{
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void PetInfoForm_Load(object sender, EventArgs e)
		{
			PicBoxPet.Image = (Bitmap)Resources.ResourceManager.GetObject(Pet.activePet.petPic);
			LblName.Text += Pet.activePet.name;
			LblSpecies.Text += Pet.activePet.species.speciesName;
			LblGender.Text += Pet.activePet.gender;
			LblTrait.Text += Pet.activePet.trait.trait;
			LblAge.Text += Pet.activePet.ageMinutes.ToString() + " минут";
			if (Pet.activePet.effects.Count > 0)
			{
				for (int i = 0; i <= Pet.activePet.effects.Count-1; i++)
				{
					LblEffects.Text += Pet.activePet.effects[i].effect;
					if (i < Pet.activePet.effects.Count - 1)
						LblEffects.Text += ", ";
				}
			}
			else LblEffects.Text += "остутсвуют";
		}
	}
}
