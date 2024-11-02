using PetStop.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetStop
{

	public partial class MainScreenForm : Form
	{
		Random chance = new Random();
		public MainScreenForm()
		{
			InitializeComponent();
		}

		private void MainScreenForm_Load(object sender, EventArgs e)
		{
			PrBarHappiness.Value = Pet.activePet.happiness;
			PrBarSatiety.Value = Pet.activePet.satiety;
			PrBarHydration.Value = Pet.activePet.hydration;
			PrBarCommunication.Value = Pet.activePet.communication;
			PrBarVigor.Value = Pet.activePet.vigor;
			PrBarCleanliness.Value = Pet.activePet.cleanliness;
			LblMoney.Text = "Не имплементировано";
			LblAge.Text = Pet.activePet.ageMinutes.ToString();
			PicBoxPet.Image = (Bitmap)Resources.ResourceManager.GetObject(Pet.activePet.petPic);
		}

		private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e) => Application.OpenForms[0].Close();
	}
}