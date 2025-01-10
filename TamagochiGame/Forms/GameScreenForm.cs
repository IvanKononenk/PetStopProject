using PetStop.Classes;
using PetStop.Forms;
using PetStop.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Resources;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Windows.Media;

namespace PetStop
{

	public partial class GameScreenForm : Form
	{
		bool outside = false;
		Random chance = new Random();
		MediaPlayer music = new MediaPlayer();
		public GameScreenForm()
		{
			InitializeComponent();
		}
		//Реакции кнопок на наведение и нажатия курсора
		private void BtnSettings_MouseDown(object sender, MouseEventArgs e) => BtnSettings.BackgroundImage = Resources.settingsClick;
		private void BtnSettings_MouseEnter(object sender, EventArgs e) => BtnSettings.BackgroundImage = Resources.settingsHover;
		private void BtnSettings_MouseLeave(object sender, EventArgs e) => BtnSettings.BackgroundImage = Resources.settings;
		private void BtnSettings_MouseUp(object sender, MouseEventArgs e) => BtnSettings.BackgroundImage = Resources.settingsHover;
		private void BtnFeed_MouseEnter(object sender, EventArgs e) => BtnFeed.BackgroundImage = Resources.btnFeedHover;
		private void BtnFeed_MouseLeave(object sender, EventArgs e) => BtnFeed.BackgroundImage = Resources.btnFeed;
		private void BtnDrink_MouseEnter(object sender, EventArgs e) => BtnDrink.BackgroundImage = Resources.btnDrinkHover;
		private void BtnDrink_MouseLeave(object sender, EventArgs e) => BtnDrink.BackgroundImage = Resources.btnDrink;
		private void BtnPlay_MouseEnter(object sender, EventArgs e) => BtnPlay.BackgroundImage = Resources.btnPlayHover;
		private void BtnPlay_MouseLeave(object sender, EventArgs e) => BtnPlay.BackgroundImage = Resources.btnPlay;
		private void BtnWash_MouseEnter(object sender, EventArgs e) => BtnWash.BackgroundImage = Resources.btnWashHover;
		private void BtnWash_MouseLeave(object sender, EventArgs e) => BtnWash.BackgroundImage = Resources.btnWash;
		private void panelHome_MouseEnter(object sender, EventArgs e) => panelHome.BackgroundImage = Resources.btnRIghtHover;
		private void panelHome_MouseLeave(object sender, EventArgs e) => panelHome.BackgroundImage = Resources.btnRIght;
		private void BtnBioMon_MouseDown(object sender, MouseEventArgs e) => BtnBioMon.BackgroundImage = Resources.btnBioMonClick;
		private void BtnBioMon_MouseEnter(object sender, EventArgs e) => BtnBioMon.BackgroundImage = Resources.btnBioMonHover;
		private void BtnBioMon_MouseLeave(object sender, EventArgs e) => BtnBioMon.BackgroundImage = Resources.btnBioMon;
		private void BtnBioMon_MouseUp(object sender, MouseEventArgs e) => BtnBioMon.BackgroundImage = Resources.btnBioMonHover;
		//Конец секции реакций кнопок на наведение и нажатия


		public void MainScreenForm_Load(object sender, EventArgs e)
		{
			
			UpdatePet();
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
		private void ChangePlace()
		{
			Control[] elements = { BtnFeed, BtnDrink, BtnWash, BtnPlay, PicBoxBedding, panelOutside };
			if (!outside) //Выходим на улицу
			{
				foreach (Control element in elements)
					element.Visible = false;
				BackgroundImage = Resources.bgOutside;
				panelHome.Visible = true;
				outside = true;
			}
			else //Возвращаемся домой
			{
				foreach (Control element in elements)
					element.Visible = true;
				BackgroundImage = Resources.bgRoom;
				panelHome.Visible = false;
				outside = false;
			}
		}
		public void UpdatePet()
		{
			music.Play();
			PanelPet.BackgroundImage = (Bitmap)Resources.ResourceManager.GetObject(Pet.activePet.petPic);
			LblMoney.Parent = PicBoxMoneyBG;
			LblMoney.Text = Player.activePlayer.money.ToString() + " $";
			MessageBox.Show("С момента последней игры прошло " + TimerClasses.CheckPeriods().ToString() + " тиков.");
			TimerClasses.DoTicks();
		}
		private void panelChangePlace_Click(object sender, EventArgs e) => ChangePlace();

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			EscMenuForm escMnFrm = new EscMenuForm();
			escMnFrm.ShowDialog();
		}


		//Начало секции Drag-n-Drop операций
		private void BtnFeed_MouseDown(object sender, MouseEventArgs e) => BtnFeed.DoDragDrop("feed", DragDropEffects.Move);
		private void BtnFeed_GiveFeedback(object sender, GiveFeedbackEventArgs e)
		{
			e.UseDefaultCursors = false;
			Cursor.Current = new Cursor((Resources.chicken).GetHicon());
		}
		private void BtnDrink_MouseDown(object sender, MouseEventArgs e) => BtnDrink.DoDragDrop("drink", DragDropEffects.Move);
		private void BtnDrink_GiveFeedback(object sender, GiveFeedbackEventArgs e)
		{
			e.UseDefaultCursors = false;
			Cursor.Current = new Cursor((Resources.waterBowl).GetHicon());
		}
		private void BtnPlay_MouseDown(object sender, MouseEventArgs e) => BtnPlay.DoDragDrop("play", DragDropEffects.Move);
		private void BtnPlay_GiveFeedback(object sender, GiveFeedbackEventArgs e)
		{
			e.UseDefaultCursors = false;
			Cursor.Current = new Cursor((Resources.cursorBall).GetHicon());
		}
		private void BtnWash_MouseDown(object sender, MouseEventArgs e) => BtnWash.DoDragDrop("wash", DragDropEffects.Move);
		private void BtnWash_GiveFeedback(object sender, GiveFeedbackEventArgs e)
		{
			e.UseDefaultCursors = false;
			Cursor.Current = new Cursor((Resources.soap).GetHicon());
		}
		//Конец секции Drag-n-Drop операций

		//Реакция пета на Drag-n-Drop
		private void PanelPet_DragOver(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Move;
			}
		}
		private void PanelPet_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				MessageBox.Show(e.Data.GetData("Text").ToString());
			}
		}



		private void BtnBioMon_Click(object sender, EventArgs e)
		{
			BioMonForm bioMnFrm = new BioMonForm();
			bioMnFrm.ShowDialog();
		}
	}
}