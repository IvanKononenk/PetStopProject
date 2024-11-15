using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class LoadPetForm : Form
	{
		public LoadPetForm()
		{
			InitializeComponent();
		}

		private void LoadSaveForm_Load(object sender, EventArgs e)
		{
			foreach (string save in Directory.GetFiles("game\\saves", "*.json", SearchOption.TopDirectoryOnly))
			{ DGVSaveFIles.Rows.Add(Regex.Replace(Regex.Replace(save, @"game\\saves\\", ""), @"\.json", ""), File.GetLastWriteTime(save)); }

			if (DGVSaveFIles.SelectedRows != null) BtnLoad.Enabled = true;
			else BtnLoad.Enabled = false;

			LblSavesCount.Text = "Найдено сохранений: " + Directory.GetFiles("game\\saves", "*.json", SearchOption.TopDirectoryOnly).Length;
		}

		private void BtnExit_Click(object sender, EventArgs e) => Close();

		private void LoadSaveForm_FormClosing(object sender, FormClosingEventArgs e) => Application.OpenForms[0].Close();

		private void BtnLoad_Click(object sender, EventArgs e)
		{
			Pet.activePet = Pet.LoadAPet("game\\saves\\" + DGVSaveFIles.CurrentRow.Cells[0].Value.ToString() + ".json");
			Pet.lastPlay = DateTime.UtcNow - DateTime.Parse(File.GetLastWriteTimeUtc("game\\saves\\" + DGVSaveFIles.CurrentRow.Cells[0].Value.ToString() + ".json").ToString());
			MainScreenForm mainScrFrm = new MainScreenForm();
			mainScrFrm.Show();
			PetInfoForm ptInfFrm = new PetInfoForm();
			ptInfFrm.Show();
			Hide();
		}
	}
}