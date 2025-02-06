using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStop.Classes
{
	internal class WalkingClasses
	{
		int buttonLeftBorder = 344;
		int buttonRightBorder = 602;
		int buttonUpBorder = 518;
		int beddingLeftBorder = 410;
		int beddingRightBorder = 562;
		Random movePerStep = new Random();
		public int[] Step()
		{
			int[] step = { movePerStep.Next(21), movePerStep.Next(21) };
			return step;
		}
		public int[] DoStep(int locationUL, int width, int height)
		{

		}
	}
}