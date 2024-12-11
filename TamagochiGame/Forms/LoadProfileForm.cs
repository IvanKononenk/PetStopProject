using PetStop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class LoadProfileForm : Form
	{
		bool petLoading = false;
		public LoadProfileForm() => InitializeComponent();
		private void LoadProfileForm_Load(object sender, EventArgs e)
		{
			foreach (string save in Directory.GetDirectories("game\\saves"))
			{ DGVSaveFiles.Rows.Add(Regex.Replace(save, @"game\\saves\\", ""), Directory.GetLastAccessTime(save)); }
			LblSavesCount.Text = "Найдено сохранений: " + DGVSaveFiles.RowCount;
			EscMenuForm.switchingPlayer = false;
		}
		private void BtnLoad_Click(object sender, EventArgs e)
		{
			Player.activePlayer = Player.LoadAPlayer("game\\saves\\" + DGVSaveFiles.CurrentRow.Cells[0].Value.ToString() + "\\player.json");
			LoadPetForm ldPtFrm = new LoadPetForm();
			petLoading = true;
			ldPtFrm.Show();
			Close();
		}
		private void DGVSaveFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(DGVSaveFiles.CurrentRow != null)
				BtnLoad_Click(sender, e);
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			petLoading = false;
			Close();
		}
		private void LoadProfileForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!petLoading)
				Application.OpenForms["MainMenuForm"].Show();
		}
	}
}