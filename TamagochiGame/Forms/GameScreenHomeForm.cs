using PetStop.Classes;
using PetStop.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Resources;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Windows.Media;

namespace PetStop
{

	public partial class GameScreenHomeForm : Form
	{
		bool outside = false; 
		Random chance = new Random();
		MediaPlayer music = new MediaPlayer();
		public GameScreenHomeForm()
		{
			InitializeComponent();
		}

		private void MainScreenForm_Load(object sender, EventArgs e)
		{
			PicBoxPet.Image = (Bitmap)Resources.ResourceManager.GetObject(Pet.activePet.petPic);
			music.Play();
			LblMoney.Parent = PicBoxMoneyBG;
			LblMoney.Text = Player.activePlayer.money.ToString() + " $";
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

		private void BtnSettings_MouseDown(object sender, MouseEventArgs e) => BtnSettings.BackgroundImage = Resources.settingsClick;
		private void BtnSettings_MouseEnter(object sender, EventArgs e) => BtnSettings.BackgroundImage = Resources.settingsHover;
		private void BtnSettings_MouseLeave(object sender, EventArgs e) => BtnSettings.BackgroundImage = Resources.settings;
		private void BtnSettings_MouseUp(object sender, MouseEventArgs e) => BtnSettings.BackgroundImage = Resources.settingsHover;
		private void BtnFeed_MouseEnter(object sender, EventArgs e) => BtnFeed.BackgroundImage = Resources.btnFeedHover;
		private void BtnFeed_MouseLeave(object sender, EventArgs e) => BtnFeed.BackgroundImage = Resources.btnFeed;
		private void BtnDrink_MouseEnter(object sender, EventArgs e) => BtnDrink.BackgroundImage = Resources.btnDrinkHover;
		private void BtnDrink_MouseLeave(object sender, EventArgs e) => BtnDrink.BackgroundImage = Resources.btnDrink;
		private void BtnPlay_MouseEnter(object sender, EventArgs e) => BtnPlay.BackgroundImage = Resources.btnBlankHover;
		private void BtnPlay_MouseLeave(object sender, EventArgs e) => BtnPlay.BackgroundImage = Resources.btnBlank;
		private void BtnWash_MouseEnter(object sender, EventArgs e) => BtnWash.BackgroundImage = Resources.btnWashHover;
		private void BtnWash_MouseLeave(object sender, EventArgs e) => BtnWash.BackgroundImage = Resources.btnWash;
		private void panelHome_MouseEnter(object sender, EventArgs e) => panelHome.BackgroundImage = Resources.btnRIghtHover;
		private void panelHome_MouseLeave(object sender, EventArgs e) => panelHome.BackgroundImage = Resources.btnRIght;
		private void BtnFeed_MouseDown(object sender, MouseEventArgs e)
		{
			DoDragDrop(Resources.ball, DragDropEffects.Move);
			PictureBox PicBoxBall = new PictureBox()
			{
				BackgroundImage = Resources.ball,
				Location = new Point(Cursor.Position.X - BackgroundImage.Width/2, Cursor.Position.Y - BackgroundImage.Height/2),
			};
			Controls.Add(PicBoxBall);
		}
		private void ChangePlace()
		{
			Control[] elements = { BtnFeed, BtnDrink, BtnWash, BtnPlay, PicBoxBedding, panelOutside };
			if (!outside) //Выходим на улицу
			{
				foreach (Control element in elements)
				{
					element.Visible = false;
				}
				BackgroundImage = Resources.bgOutside;
				panelHome.Visible = true;
				outside = true;
			}
			else //Возвращаемся домой
			{
				foreach (Control element in elements)
				{
					element.Visible = true;
				}
				BackgroundImage = Resources.bgRoom;
				panelHome.Visible = false;
				outside = false;
			}
		}

		private void panelChangePlace_Click(object sender, EventArgs e) => ChangePlace();

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			MessageBox.Show("");
		}
	}
}