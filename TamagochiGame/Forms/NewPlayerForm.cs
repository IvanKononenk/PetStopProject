using PetStop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class NewPlayerForm : Form
	{
		public Player activePlayer;
		public NewPlayerForm()
		{
			InitializeComponent();
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void NewPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Owner == LoadingScreen && activePlayer != null)
			{

			}
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtProfileName.Text != "" && DTPBDay.Value > DTPBDay.MinDate)
			{
				if (!Directory.Exists("game\\saves\\" + TxtProfileName.Text))
				{
					List<Pet> petList = new List<Pet>();
					Player activePLayer = new Player(TxtProfileName.Text, 0, DTPBDay.Value, petList);
					activePLayer.SaveAUser(activePLayer);
				}
				else
				{
					MessageBox.Show("Данное имя пользователя занято!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					TxtProfileName.Focus();
				}
			}
			else
			{
				MessageBox.Show("Введите имя и дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtProfileName.Focus();
			}
		}
	}
}
