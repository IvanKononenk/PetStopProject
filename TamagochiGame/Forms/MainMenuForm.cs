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
	public partial class MainMenuForm : Form
	{
		public MainMenuForm() => InitializeComponent();
		private void MainMenuForm_Shown(object sender, EventArgs e)
		{
			Hide();
			LoadingScreen ldngScrn = new LoadingScreen();
			ldngScrn.Show();
		}
		private void BtnNewProfile_Click(object sender, EventArgs e)
		{
			NewProfileForm nwPrflFrm = new NewProfileForm();
			nwPrflFrm.Show();
			Hide();
		}
		private void BtnLoadProfile_Click(object sender, EventArgs e)
		{
			LoadProfileForm ldPrflFrm = new LoadProfileForm();
			ldPrflFrm.Show();
			Hide();
		}
		private void BtnExit_Click(object sender, EventArgs e) => Close();
		private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите выйти из игры?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				e.Cancel = true;
		}
	}
}
