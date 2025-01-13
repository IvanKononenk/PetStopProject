using PetStop.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class BioMonForm : Form
	{
		public BioMonForm() => InitializeComponent();
		private void BioMonForm_Load(object sender, EventArgs e)
		{
			UpdateBioMon();
		}
		public void UpdateBioMon()
		{
			PrBarHappiness.Value = Pet.activePet.happiness;
			PrBarSatiety.Value = Pet.activePet.satiety;
			PrBarHydration.Value = Pet.activePet.hydration;
			PrBarCommunication.Value = Pet.activePet.communication;
			PrBarVigor.Value = Pet.activePet.vigor;
			PrBarCleanliness.Value = Pet.activePet.cleanliness;
			LblAgeText.Text = Pet.activePet.ageMinutes.ToString();
			PicBoxPet.Image = (Bitmap)Resources.ResourceManager.GetObject(Pet.activePet.petPic);
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}