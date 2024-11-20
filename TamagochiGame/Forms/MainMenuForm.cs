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
		public MainMenuForm()
		{
			InitializeComponent();
			picBoxLogo.Parent = picBoxBackground;
			picBoxMascot.Parent = picBoxBackground;
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BtnLoadProfile_Click(object sender, EventArgs e)
		{
			LoadProfileForm ldPrflFrm = new LoadProfileForm();
			ldPrflFrm.Show();
			Hide();
		}

		private void BtnNewProfile_Click(object sender, EventArgs e)
		{
			NewProfileForm nwPrflFrm = new NewProfileForm();
			nwPrflFrm.Show();
			Hide();
		}

		private void MainMenuForm_Load(object sender, EventArgs e)
		{
			
		}

		private void MainMenuForm_Shown(object sender, EventArgs e)
		{
			Hide();
			LoadingScreen ldngScrn = new LoadingScreen();
			ldngScrn.Show();
		}
	}
}
