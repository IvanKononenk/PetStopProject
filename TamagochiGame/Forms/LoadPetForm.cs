using PetStop.Classes;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class LoadPetForm : Form
	{
		bool gameLoading = false;
		public LoadPetForm()
		{
			InitializeComponent();
		}

		private void LoadSaveForm_Load(object sender, EventArgs e)
		{
			foreach (string save in Directory.GetFiles("game\\saves\\" + Player.activePlayer.username, "*.json", SearchOption.TopDirectoryOnly))
			{
				if (!save.EndsWith("player.json")) 
					DGVSaveFIles.Rows.Add(Regex.Replace(Regex.Replace(save, @"game\\saves\\" + Player.activePlayer.username + @"\\", ""), @"\.json", ""), File.GetLastWriteTime(save)); 
			}

			if (DGVSaveFIles.SelectedRows != null) BtnLoad.Enabled = true;
			else BtnLoad.Enabled = false;

			LblSavesCount.Text = "Найдено сохранений: " + DGVSaveFIles.RowCount;
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			gameLoading = false;
			Close();
		}

		private void LoadSaveForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!gameLoading)
				Application.OpenForms["MainMenuForm"].Show();
		}

		private void BtnLoad_Click(object sender, EventArgs e)
		{
			Pet.activePet = Pet.LoadAPet("game\\saves\\" + Player.activePlayer.username + "\\" + DGVSaveFIles.CurrentRow.Cells[0].Value.ToString() + ".json");
			Pet.lastPlay = DateTime.UtcNow - DateTime.Parse(File.GetLastWriteTimeUtc("game\\saves\\" + DGVSaveFIles.CurrentRow.Cells[0].Value.ToString() + ".json").ToString());
			GameScreenForm mainScrFrm = new GameScreenForm();
			mainScrFrm.Show();
			PetInfoForm ptInfFrm = new PetInfoForm();
			ptInfFrm.Show();
			gameLoading = true;
			Close();
		}
	}
}