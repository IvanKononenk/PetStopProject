using PetStop.Classes;
using PetStop.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Media;

namespace PetStop
{

	public partial class GameScreenForm : Form
	{
		Random chance = new Random();
		MediaPlayer music = new MediaPlayer();
		public GameScreenForm()
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
			music.Play();
			BtnSettings.Parent = PicBoxPet;
		}

		private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Pet.activePet.SaveAPet(Pet.activePet) && Player.activePlayer.SaveAUser(Player.activePlayer))
			{
				MessageBox.Show("Данные сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Pet.activePet = null;
				Player.activePlayer = null;
				Application.OpenForms["MainMenuForm"].Show();
			}
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnSettings_MouseDown(object sender, MouseEventArgs e)
		{
			BtnSettings.BackgroundImage = Resources.settingsClick;
		}

		private void BtnSettings_MouseEnter(object sender, EventArgs e)
		{
			BtnSettings.BackgroundImage = Resources.settingsHover;
		}

		private void BtnSettings_MouseLeave(object sender, EventArgs e)
		{
			BtnSettings.BackgroundImage = Resources.settings;
		}

		private void BtnSettings_MouseUp(object sender, MouseEventArgs e)
		{
			BtnSettings.BackgroundImage = Resources.settingsHover;
		}
	}
}