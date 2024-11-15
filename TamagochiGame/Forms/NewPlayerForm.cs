using PetStop.Classes;
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
	public partial class NewPlayerForm : Form
	{
		public string closingReason;
		public NewPlayerForm()
		{
			InitializeComponent();
		}
		public NewPlayerForm(LoadingScreen ldngScrn)
		{
			InitializeComponent();
			closingReason = "startupCancel";
		}
		public NewPlayerForm(string NOTIMPLEMENTED)
		{
			InitializeComponent();
			closingReason = "newPLayer";
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void NewPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			switch (closingReason)
			{
				case "startupCancel":
					Application.Exit();
					break;
				case "newPLayer":
					MessageBox.Show("NOT IMPLEMENTED");
					break;
				case "startupConfirm":
					break;
			}
		}

		private void BtnConfirm_Click(object sender, EventArgs e)
		{
			if (TxtProfileName.Text != "" && DTPBDay.Value > DTPBDay.MinDate)
			{
				List<Pet> petList = new List<Pet>();
				Player activePLayer = new Player(TxtProfileName.Text, 0, DTPBDay.Value, petList);
				//ChooseACrateForm chsACrtFrm = new ChooseACrateForm();
				//chsACrtFrm.Show();
				//Hide();
				activePLayer.SaveAUser(activePLayer);
				Close();
			}
			else
			{
				MessageBox.Show("Введите имя и дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtProfileName.Focus();
			}
		}
	}
}
