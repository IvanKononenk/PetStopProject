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

namespace PetStop
{
	public partial class LoadingScreen : Form
	{
		Timer timer = new Timer();
		Timer load = new Timer();
		public LoadingScreen()
		{
			InitializeComponent();
		}

		private void LoadingScreen_Load(object sender, EventArgs e)
		{
			timer.Interval = 1000;
			timer.Tick += TimerBeforeLoad;
			timer.Start();
		}

		private void TimerBeforeLoad(object sender, EventArgs e)
		{
			timer.Stop();
			load.Interval = 10;
			load.Tick += Loading;
			load.Start();
		}

		private void Loading(object sender, EventArgs e)
		{
			if (LoadingBar.Value < LoadingBar.Maximum)
				LoadingBar.Value++;
			else EndLoading();
		}

		private void EndLoading()
		{
			load.Stop();
			if (Directory.EnumerateFiles("game/saves").Count() > 0)
			{

			}
			else
			{

			}
		}
	}
}
