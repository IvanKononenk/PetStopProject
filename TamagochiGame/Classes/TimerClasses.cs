using System;
using System.Windows.Forms;

namespace PetStop.Classes
{
	public class TimerClasses
	{ 
		public static void WorkTimer()
		{
			Timer tmr = new Timer();
			tmr.Interval = 60000;
			tmr.Tick += Timer_Tick;
			tmr.Start();
		}
		private static void Timer_Tick(object sender, EventArgs e)
		{
			DoTicks();
		}
		public static long CheckPeriods()
		{
			TimeSpan period = TimeSpan.FromMinutes(6);
			TimeSpan difference = DateTime.Now - Pet.activePet.lastTick;
			long ticksAmount = difference.Ticks / period.Ticks;
			return ticksAmount;
		}
		public static void DoTicks()
		{
			long ticksAmount = CheckPeriods();
			if (ticksAmount > 0)
			{
				for (int i = 0; i < ticksAmount; i++)
				{
					Pet.activePet.StarveTick();
				}
				Pet.activePet.lastTick += TimeSpan.FromTicks(TimeSpan.FromMinutes(6).Ticks * ticksAmount);
			}
		}
	}
}