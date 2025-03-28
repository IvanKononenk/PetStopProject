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
		int smallerWidth = 174;
		int smallerHeight = 160;
		int smallerHeightPos = 493;
		Random movePerStep = new Random();
		public int[] Step()
		{
			int[] step = { movePerStep.Next(21), movePerStep.Next(21) };
			return step;
		}
		public int[] DoStep(int locOldX, int locOldY, int width, int height)
		{
			int[] step = Step();

			int posOldX = locOldX + (width / 2);
			int posOldY = locOldY + height;

			int posNewX = posOldX + step[0];
			int posNewY = posOldY + step[1];

			int widthNew = 0;
			int heightNew = 0;

			int locNewX = posNewX - (widthNew / 2);
			int locNewY = posNewY - heightNew;
			int[] newLoc = { locNewX, locNewY };
			return newLoc;

		}
	}
}