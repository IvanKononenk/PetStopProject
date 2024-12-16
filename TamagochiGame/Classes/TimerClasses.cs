using System;
using System.Windows.Forms;

namespace PetStop.Classes
{
	public class TimerClasses
	{ 
		public void WorkTimer(int interval, string name)
		{
			Timer tmr = new Timer();
			tmr.Interval = interval;
			tmr.Tag = name;
			tmr.Tick += Timer_Tick;
			tmr.Start();
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Тик таймера " + sender.ToString());
		}
	}
}