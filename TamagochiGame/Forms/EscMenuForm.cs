﻿using PetStop.Classes;
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
	public partial class EscMenuForm : Form
	{
		static public bool toMainMenu, switchingPlayer = false;
		public EscMenuForm()
		{
			InitializeComponent();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			toMainMenu = true;
			Close();
		}

		private void BtnLoadGame_Click(object sender, EventArgs e)
		{
			switchingPlayer = true;
			toMainMenu = false;
			if (Pet.activePet.SaveAPet(Pet.activePet) && Player.activePlayer.SaveAUser(Player.activePlayer))
			{
				MessageBox.Show("Данные сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Pet.activePet = null;
			Player.activePlayer = null;
			LoadProfileForm ldPrflFrm = new LoadProfileForm();
			Application.OpenForms["GameScreenForm"].Hide();
			ldPrflFrm.Show();
			Close();
		}

		private void BtnSaveGame_Click(object sender, EventArgs e)
		{
			if (Pet.activePet.SaveAPet(Pet.activePet) && Player.activePlayer.SaveAUser(Player.activePlayer))
			{
				MessageBox.Show("Данные сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Пока нечего настраивать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void EscMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (toMainMenu)
			{
				Application.OpenForms["GameScreenForm"].Close();
				toMainMenu = false;
			}
		}

		private void BtnPetInfo_Click(object sender, EventArgs e)
		{
			PetInfoForm ptInfFrm = new PetInfoForm();
			ptInfFrm.ShowDialog();
		}

		private void BtnContinue_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}