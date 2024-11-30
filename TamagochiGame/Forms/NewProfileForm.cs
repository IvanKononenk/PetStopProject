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
		bool creatingPet = false;
		public NewProfileForm()
		{
			InitializeComponent();
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			creatingPet = false;
			Close();
		}
		private void NewPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!creatingPet)
				Application.OpenForms["MainMenuForm"].Show();
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtProfileName.Text != "")
			{ 
				if (DTPBDay.Value > DTPBDay.MinDate && DTPBDay.Value.Date != DateTime.Today.Date && DTPBDay.Value.Date < DateTime.Today.Date)
					{
					if (!Directory.Exists("game\\saves\\" + TxtProfileName.Text))
					{
						Player.activePlayer = new Player(TxtProfileName.Text, 0, DTPBDay.Value.Date);
						ChooseACrateForm chsACrtFrm = new ChooseACrateForm();
						creatingPet = true;
						chsACrtFrm.Show();
						Close();
					}
					else
					{
						MessageBox.Show("Данное имя пользователя занято!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						TxtProfileName.Focus();
					}
				}
				else
				{
					MessageBox.Show("Введите корректную дату рождения пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					DTPBDay.Focus();
				}
			}
			else
			{
				MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtProfileName.Focus();
			}
		}
	}
}