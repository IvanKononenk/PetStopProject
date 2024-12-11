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
		public LoadPetForm() => InitializeComponent();
		private void LoadSaveForm_Load(object sender, EventArgs e)
		{
			foreach (string save in Directory.GetFiles("game\\saves\\" + Player.activePlayer.username, "*.json", SearchOption.TopDirectoryOnly))
			{
				if (!save.EndsWith("player.json")) 
					DGVSaveFiles.Rows.Add(Regex.Replace(Regex.Replace(save, @"game\\saves\\" + Player.activePlayer.username + @"\\", ""), @"\.json", ""), File.GetLastWriteTime(save)); 
			}

			if (DGVSaveFiles.CurrentRow != null) 
				BtnLoad.Enabled = true;
			else 
				BtnLoad.Enabled = false;

			LblSavesCount.Text = "Найдено сохранений: " + DGVSaveFiles.RowCount;
		}
		private void BtnLoad_Click(object sender, EventArgs e)
		{
			Pet.activePet = Pet.LoadAPet("game\\saves\\" + Player.activePlayer.username + "\\" + DGVSaveFiles.CurrentRow.Cells[0].Value.ToString() + ".json");
			Pet.lastPlay = DateTime.UtcNow - DateTime.Parse(File.GetLastWriteTimeUtc("game\\saves\\" + DGVSaveFiles.CurrentRow.Cells[0].Value.ToString() + ".json").ToString());
			if (Application.OpenForms["GameScreenForm"] != null)
			{
				GameScreenForm gmScrnFrm = (GameScreenForm)Application.OpenForms["GameScreenForm"];
				gmScrnFrm.UpdatePet();
				gmScrnFrm.Show();
			}
			else
			{
				GameScreenForm mainScrFrm = new GameScreenForm();
				mainScrFrm.Show();
			}
			gameLoading = true;
			Close();
		}
		private void DGVSaveFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (DGVSaveFiles.CurrentRow != null)
				BtnLoad_Click(sender, e);
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
	}
}