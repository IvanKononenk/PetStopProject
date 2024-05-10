using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TamagochiGame
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			progressBar1.Value += 50;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			System.Timers.Timer aTimer = new System.Timers.Timer();
			aTimer.Elapsed += Timer_Elapsed;
			aTimer.Interval = 100;
			aTimer.AutoReset = true;
			aTimer.Start();
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			progressBar1.Value -= 1;
			progressBar2.Value -= 1;
			progressBar3.Value -= 1;
		}
	}
}
