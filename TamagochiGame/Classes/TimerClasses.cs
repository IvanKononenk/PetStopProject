using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetStop.Classes
{
	public class TimerClasses
	{
		static Timer tmr = new Timer();
		/// <summary>
		/// Таймер, срабатывающий каждую минуту
		/// </summary>
		public static void WorkTimer()
		{
			tmr.Interval = 1000;
			tmr.Tick += Timer_Tick;
			tmr.Start();
		}
		public static void StopTimer()
		{
			tmr.Stop();
		}
		/// <summary>
		/// Вызывается при каждом тике таймера
		/// </summary>
		private static void Timer_Tick(object sender, EventArgs e)
		{
			DoTicks();
		}
		/// <summary>
		/// Проверяет, сколько тиков голода прошло
		/// </summary>
		/// <returns>Количество тиков</returns>
		public static long CheckPeriods()
		{
			TimeSpan period = TimeSpan.FromMinutes(6);
			TimeSpan difference = DateTime.Now - Pet.activePet.lastTick;
			long ticksAmount = difference.Ticks / period.Ticks;
			return ticksAmount;
		}
		/// <summary>
		/// Действия при срабатывании тика: вызвать команду голода, переместить питомца
		/// </summary>
		public static void DoTicks()
		{
			Panel petWalking = GameScreenForm.petPic;
			WalkingClasses wlkCls = new WalkingClasses();
			long ticksAmount = CheckPeriods();
			if (ticksAmount > 0)
			{
				for (int i = 0; i < ticksAmount; i++)
				{
					Pet.activePet.StarveTick();
				}
				Pet.activePet.lastTick += TimeSpan.FromTicks(TimeSpan.FromMinutes(6).Ticks * ticksAmount);
			}
			if (petWalking != null)
			{
				int[,] newPos = wlkCls.DoStep(petWalking.Location.X, petWalking.Location.Y, petWalking.Width, petWalking.Height);
				petWalking.Location = new Point(newPos[0, 0], newPos[0, 1]);
				petWalking.Width = newPos[1, 0];
				petWalking.Height = newPos[1, 1];
			}
		}
	}
}