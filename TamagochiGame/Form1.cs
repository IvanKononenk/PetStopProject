using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TamagochiGame
{
	public partial class Form1 : Form
	{
		int feedAmount = 50;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
			aTimer.Tick += Timer_Elapsed;
			aTimer.Interval = 100;
			aTimer.Start();
		}

		private void Timer_Elapsed(object sender, EventArgs e)
		{
			int starveAmount = 1;

			if (prBarHunger.Value - starveAmount < prBarHunger.Minimum)
				prBarHunger.Value = prBarHunger.Minimum;
			else prBarHunger.Value -= starveAmount;

			if (prBarThirst.Value - starveAmount < prBarThirst.Minimum)
				prBarThirst.Value = prBarThirst.Minimum;
			else prBarThirst.Value -= starveAmount;

			if (prBarHappy.Value - starveAmount < prBarHappy.Minimum)
				prBarHappy.Value = prBarHappy.Minimum;
			else prBarHappy.Value -= starveAmount;
		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{
			if (prBarHappy.Value + feedAmount > prBarHappy.Maximum)
				prBarHappy.Value = prBarHappy.Maximum;
			else prBarHappy.Value += feedAmount;
		}

		private void BtnFeed_Click(object sender, EventArgs e)
		{
			if (prBarHunger.Value + feedAmount > prBarHunger.Maximum)
				prBarHunger.Value = prBarHunger.Maximum;
			else prBarHunger.Value += feedAmount;
		}

		private void BtnDrink_Click(object sender, EventArgs e)
		{
			if (prBarThirst.Value + feedAmount > prBarThirst.Maximum)
				prBarThirst.Value = prBarThirst.Maximum;
			else prBarThirst.Value += feedAmount;
		}
	}
}
