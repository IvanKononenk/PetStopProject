using PetStop.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PetStop.Forms
{
	public partial class ChooseACrateForm : Form
	{
		public ChooseACrateForm()
		{
			InitializeComponent();
		}

		private void ChooseACrateForm_Load(object sender, EventArgs e)
		{
			Random rnd = new Random();
			string[] crates = JsonSerializer.Deserialize<string[]>(Resources.CratesList);
			pictureBox1.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox2.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
			pictureBox3.Image = (Bitmap)Resources.ResourceManager.GetObject(crates[rnd.Next(crates.Count())]);
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			
		}
	}
}
