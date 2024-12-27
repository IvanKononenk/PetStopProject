using System;
using System.Windows.Forms;

namespace PetStop.Classes
{
	public class TimerClasses
	{ 
		public void WorkTimer(int interval, string name)
		{
			Timer tmr = new Timer();
			tmr.Interval = 1000;
			tmr.Tick += Timer_Tick;
			tmr.Start();
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (DateTime.Now.Subtract(Pet.activePet.lastTick) <= TimeSpan.FromMinutes(6))
			{

			}
		}
	}
}