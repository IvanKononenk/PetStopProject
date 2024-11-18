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
	public partial class NewProfileForm : Form
	{
		public Player outerPlayer;
		public NewProfileForm()
		{
			InitializeComponent();
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void NewPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Owner == Application.OpenForms["LoadingScreen"] && outerPlayer == null)
			{
				Application.Exit();
			}
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtProfileName.Text != "" && DTPBDay.Value > DTPBDay.MinDate)
			{
				if (!Directory.Exists("game\\saves\\" + TxtProfileName.Text))
				{
					List<Pet> petList = new List<Pet>();
					Player.activePlayer = new Player(TxtProfileName.Text, 0, DTPBDay.Value.Date, petList);
					Player.activePlayer.SaveAUser(Player.activePlayer);
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
