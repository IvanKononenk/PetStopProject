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
	public partial class LoadProfileForm : Form
	{
		public LoadProfileForm()
		{
			InitializeComponent();
		}

		private void LoadProfileForm_Load(object sender, EventArgs e)
		{
			foreach (string save in Directory.GetDirectories("game\\saves"))
			{ DGVSaveFIles.Rows.Add(save, Directory.GetLastAccessTime(save)); }
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
