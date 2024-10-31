using PetStop;
using PetStop.Properties;
using System;
using System.CodeDom;
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

namespace PetStop
{
	
	public partial class MainScreenForm : Form
	{
		Random chance = new Random();
		public MainScreenForm()
		{
			InitializeComponent();
		}

		private void MainScreenForm_Load(object sender, EventArgs e)
		{
			PrBarHappiness.Value = Pet.activePet.happiness;
			PrBarSatiety.Value = Pet.activePet.satiety;
			PrBarHydration.Value = Pet.activePet.hydration;
			PrBarCommunication.Value = Pet.activePet.communication;
			PrBarVigor.Value = Pet.activePet.vigor;
			PrBarCleanliness.Value = Pet.activePet.cleanliness;
			LblMoney.Text = "Не имплементировано";
			LblAge.Text = Pet.activePet.ageMinutes.ToString();
			switch (Pet.activePet.species.speciesEng)
			{
				case "germanShepherd":
					{
						PicBoxPet.Image = Resources.petGS1;
						break;
					}
				case "parrot":
					{
						break;
					}
				case "platypus":
					{
						break;
					}
				case "platypusPerry":
					{
						break;
					}
			}
		}

		private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e) => Application.OpenForms[0].Close();
	}
}