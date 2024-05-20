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
	public partial class FrmGame : Form
	{
		int feedAmount = 50;
		public FrmGame()
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

			if (PrBarHunger.Value - starveAmount < PrBarHunger.Minimum)
				PrBarHunger.Value = PrBarHunger.Minimum;
			else PrBarHunger.Value -= starveAmount;

			if (PrBarThirst.Value - starveAmount < PrBarThirst.Minimum)
				PrBarThirst.Value = PrBarThirst.Minimum;
			else PrBarThirst.Value -= starveAmount;

			if (PrBarHappy.Value - starveAmount < PrBarHappy.Minimum)
				PrBarHappy.Value = PrBarHappy.Minimum;
			else PrBarHappy.Value -= starveAmount;
		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{
			if (PrBarHappy.Value + feedAmount > PrBarHappy.Maximum)
				PrBarHappy.Value = PrBarHappy.Maximum;
			else PrBarHappy.Value += feedAmount;
		}

		private void BtnFeed_Click(object sender, EventArgs e)
		{
			if (PrBarHunger.Value + feedAmount > PrBarHunger.Maximum)
				PrBarHunger.Value = PrBarHunger.Maximum;
			else PrBarHunger.Value += feedAmount;
		}

		private void BtnDrink_Click(object sender, EventArgs e)
		{
			if (PrBarThirst.Value + feedAmount > PrBarThirst.Maximum)
				PrBarThirst.Value = PrBarThirst.Maximum;
			else PrBarThirst.Value += feedAmount;
		}

		private void tsmiChangeBG_Click(object sender, EventArgs e)
		{
			BGChangeForm bgChange = new BGChangeForm();
			if(bgChange.ShowDialog() == DialogResult.OK) 
			{
				PicBoxPet.BackgroundImage = Image.FromFile(bgChange.bgFileName);
			}
		}

		private void TSMIChangePet_Click(object sender, EventArgs e)
		{
			PetChangeForm ptChange = new PetChangeForm();
			if(ptChange.ShowDialog() == DialogResult.OK)
			{
				PicBoxPet.Image = Image.FromFile(ptChange.petFileName);
			}
		}
	}
}
