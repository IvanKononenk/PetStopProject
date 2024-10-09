using PetStop;
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
	
	public partial class FrmMainScreen : Form
	{
		int feedAmount = 500;
		float timeAge;
		int money;
		int hunger, thrist, happiness, dirty;
		Random chance = new Random();
		public FrmMainScreen()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				StreamReader saveData = new StreamReader("game/save.txt");
				TimeSpan timeDiff = DateTime.Now - DateTime.Parse(saveData.ReadLine());
				timeAge = float.Parse(saveData.ReadLine());
				hunger = int.Parse(saveData.ReadLine()) - (int.Parse(timeDiff.TotalMinutes.ToString("F0")) * 10);
				thrist = int.Parse(saveData.ReadLine()) - (int.Parse(timeDiff.TotalMinutes.ToString("F0")) * 20);
				happiness = int.Parse(saveData.ReadLine()) - (int.Parse(timeDiff.TotalMinutes.ToString("F0")) * 5);
				dirty = int.Parse(saveData.ReadLine());
				money = int.Parse(saveData.ReadLine());
				MessageBox.Show(timeDiff.TotalMinutes.ToString("F2"));
				saveData.Close();
			}
			catch 
			{
				MessageBox.Show("Ошибка при прочтении файла сохранения! Игра начнется заново!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (hunger < 500)
				PrBarHunger.Value = 500;
			else
				PrBarHunger.Value = hunger;
			
			if (thrist < 500) 
				PrBarThirst.Value = 500;
			else
				PrBarThirst.Value = thrist;
			
			if (happiness < 500)
				PrBarHappy.Value = 500; 
			else
				PrBarHappy.Value = happiness;

			PrBarDirty.Value = dirty;
			System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
			aTimer.Tick += Timer_Elapsed;
			aTimer.Interval = 100;
			aTimer.Start();
		}

		private void Timer_Elapsed(object sender, EventArgs e)
		{
			int starveAmount = 10;

			if (PrBarHunger.Value - starveAmount < PrBarHunger.Minimum)
				PrBarHunger.Value = PrBarHunger.Minimum;
			else PrBarHunger.Value -= starveAmount;

			if (PrBarThirst.Value - starveAmount < PrBarThirst.Minimum)
				PrBarThirst.Value = PrBarThirst.Minimum;
			else PrBarThirst.Value -= starveAmount;

			if (PrBarHappy.Value - starveAmount < PrBarHappy.Minimum)
				PrBarHappy.Value = PrBarHappy.Minimum;
			else PrBarHappy.Value -= starveAmount;

			if ((PrBarThirst.Value + PrBarHappy.Value + PrBarThirst.Value) > 10000)
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
					if (!(PrBarDirty.Value + 10 >= 100))
						PrBarDirty.Value += 10;
					else PrBarDirty.Value = 100;
			}
		}

		private void BtnFeed_Click(object sender, EventArgs e)
		{
			CMSFeed.Show(this, BtnFeed.Location);
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

		private void FoodOne_Click(object sender, EventArgs e)
		{
			if (money >= 1)
			{
				money -= 1;
				if (PrBarHunger.Value + 1000 > PrBarHunger.Maximum)
					PrBarHunger.Value = PrBarHunger.Maximum;
				else
				{
					PrBarHunger.Value += 1000;
					if (chance.Next(0, 10) == 9)
						if (!(PrBarDirty.Value + 1 >= 100))
							PrBarDirty.Value += 1;
						else PrBarDirty.Value = 100;
				}
			}
			else MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void FoodTwo_Click(object sender, EventArgs e)
		{
			if (money >= 2)
			{
				money -= 2;
				if (PrBarHunger.Value + 2500 > PrBarHunger.Maximum)
					PrBarHunger.Value = PrBarHunger.Maximum;
				else
				{
					PrBarHunger.Value += 2500;
					if (chance.Next(0, 10) == 9)
						if (!(PrBarDirty.Value + 1 >= 100))
							PrBarDirty.Value += 1;
						else PrBarDirty.Value = 100;
				}
			}
			else MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void FoodThree_Click(object sender, EventArgs e)
		{
			if (money >= 3)
			{
				money -= 3;
				if (PrBarHunger.Value + 5000 > PrBarHunger.Maximum)
					PrBarHunger.Value = PrBarHunger.Maximum;
				else
				{
					PrBarHunger.Value += 5000;
					if (chance.Next(0, 10) == 9)
						if (!(PrBarDirty.Value + 1 >= 100))
							PrBarDirty.Value += 1;
						else PrBarDirty.Value = 100;
				}
			}
			else MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void TSMIPromocode_Click(object sender, EventArgs e)
		{
			EnterPromocodeForm EPForm = new EnterPromocodeForm();
			EPForm.ShowDialog();
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
				saveData.WriteLine(DateTime.Now.ToString());
				saveData.WriteLine(timeAge.ToString("F0"));
				saveData.WriteLine(PrBarHunger.Value.ToString());
				saveData.WriteLine(PrBarThirst.Value.ToString());
				saveData.WriteLine(PrBarHappy.Value.ToString());
				saveData.WriteLine(PrBarDirty.Value.ToString());
				saveData.WriteLine(money.ToString());
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