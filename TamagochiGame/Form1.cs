using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		float timeAge = 0;
		int money = 0;
		Random chance = new Random();
		public FrmGame()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				StreamReader saveData = new StreamReader("game/save.txt");
				timeAge = float.Parse(saveData.ReadLine());
				PrBarHunger.Value = int.Parse(saveData.ReadLine());
				PrBarThirst.Value = int.Parse(saveData.ReadLine());
				PrBarHappy.Value = int.Parse(saveData.ReadLine());
				PrBarDirty.Value = int.Parse(saveData.ReadLine());
				money = int.Parse(saveData.ReadLine());
				TimeSpan timeDiff = DateTime.Now - DateTime.Parse(saveData.ReadLine());
				MessageBox.Show(timeDiff.TotalMinutes.ToString("F2"));
				saveData.Close();
			}
			catch 
			{
				MessageBox.Show("Ошибка при прочтении файла сохранения! Игра начнется заново!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

			if ((PrBarThirst.Value + PrBarHappy.Value + PrBarThirst.Value) > 1000)
			{
				timeAge += 1f/10f;
				LblAge.Text = timeAge.ToString("F0");
			}
			
			LblMoney.Text = money.ToString() + " $";
		}

		private void BtnPlay_Click(object sender, EventArgs e)
		{
			if (PrBarHappy.Value + feedAmount > PrBarHappy.Maximum)
				PrBarHappy.Value = PrBarHappy.Maximum;
			else
			{
				PrBarHappy.Value += feedAmount;
				if (chance.Next(0, 10) == 9)
					money += 1;
				if (chance.Next(0, 5) == 4)
					PrBarDirty.Value += 10;
			}
		}

		private void BtnFeed_Click(object sender, EventArgs e)
		{
			if (PrBarHunger.Value + feedAmount > PrBarHunger.Maximum)
				PrBarHunger.Value = PrBarHunger.Maximum;
			else
			{
				PrBarHunger.Value += feedAmount;
				if (chance.Next(0, 10) == 9)
					PrBarDirty.Value += 1;
			}
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

		private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				StreamWriter saveData = new StreamWriter("game/save.txt", false, Encoding.Unicode);
				saveData.WriteLine(timeAge.ToString("F0"));
				saveData.WriteLine(PrBarHunger.Value.ToString());
				saveData.WriteLine(PrBarThirst.Value.ToString());
				saveData.WriteLine(PrBarHappy.Value.ToString());
				saveData.WriteLine(PrBarDirty.Value.ToString());
				saveData.WriteLine(money.ToString());
				saveData.WriteLine(DateTime.Now.ToString());
				saveData.Close();
			}
			catch 
			{
				MessageBox.Show("Возникла ошибка при сохранении файла! Прогресс не был сохранен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnClean_Click(object sender, EventArgs e)
		{
			if (PrBarDirty.Value != 0)
			{
				if (money >= 10)
				{
					PrBarDirty.Value = 0;
					money -= 10;
				}
				else
				{
					MessageBox.Show("Недостаточно денег для покупки шампуня!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else MessageBox.Show("Питомцу не требуется помывка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
