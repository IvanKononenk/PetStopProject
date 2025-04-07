using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStop.Classes
{
	public class WalkingClasses
	{
		int buttonLeftBorder = 377; //Крайняя левая точка панели кнопок
		int buttonRightBorder = 635; //Крайняя правая точка панели кнопок
		int buttonUpBorder = 583; //Крайняя верхняя точка панели кнопок
		int beddingLeftBorder = 410; //Крайняя левая точка лежанки
		int beddingRightBorder = 562; //Крайняя правая точка лежанки
		int smallerWidth = 174; //Ширина спрайта при минимальном размере
		int smallerHeight = 160; //Высота спрайта при минимальном размере
		int smallerHeightPos = 493; //Максимальное положение по оси Y (высоты) для "ног" спрайта питомца
		int screenRightBorder = 1030; //Ширина игрового окна
		int screenDownBorder = 694; //Высота игрового окна
		
		Random movePerStep = new Random(); //Генератор случайных чисел для "шагов" питомца
		/// <summary>
		/// Определяет, на какое расстояние сместится питомец
		/// </summary>
		/// <returns>Расстояние смещения питомца по двум осям</returns>
		public int[] Step()
		{
			int[] step = { movePerStep.Next(61) - 30, movePerStep.Next(61) - 30 };
			return step;
		}
		/// <summary>
		/// Задает новые значения позиции и размера панели со спрайтом питомца
		/// </summary>		
		/// <param name="locOldX">Местоположение панели спрайта по оси X(ширины)</param>
		/// <param name="locOldY">Местоположение панели спрайта по оси Y(высоты)</param>
		/// <param name="width">Ширина панели спрайта</param>
		/// <param name="height">Высота панели спрайта</param>
		/// <returns>Новые значения местоположения и размера панели спрайта</returns>
		public int[,] DoStep(int locOldX, int locOldY, int width, int height)
		{
			int[] step = Step(); //Присвоение смещения питомца

			int posOldX = locOldX + (width / 2); //Определение нижней центральной точки спрайта по оси X (ширины)
			int posOldY = locOldY + height; //Определение нижней центральной точки спрайта по оси Y (высоты)

			int posNewX = posOldX + step[0]; //Определение новой нижней центральной точки спрайта по оси X (ширины)
			int posNewY = posOldY + step[1]; //Определение новой нижней центральной точки спрайта по оси Y (высоты)

			int widthNew = CalculateWidth(width);
			int heightNew = CalculateHeight(height);

			if (posNewX < (widthNew / 2)) //Если спрайт заходит за левый край окна
				posNewX = (widthNew / 2) + 5; //Сместить спрайт вправо с отступом от края окна
			if (posNewX + (widthNew / 2) > screenRightBorder) //Если спрайт заходит за правый край окна
				posNewX = screenRightBorder - (widthNew / 2) - 5; //Сместить спрайт влево с отступом от края окна

			if (posNewX < buttonRightBorder - (width / 2)) //Если спрайт заходит за правый край панели кнопок
				posNewX = buttonRightBorder + (widthNew / 2) + 5; //Сместить спрайт вправо от панели кнопок с отступом
			if (posNewX + (width / 2) > buttonLeftBorder) //Если спрайт заходит за левый край панели кнопок
				posNewX = buttonLeftBorder - (widthNew / 2) - 5; //Сместить спрайт влево от панели кнопок с отступом

			if (posNewX < beddingRightBorder - (width / 2)) //Если спрайт заходит за правый край лежанки
				posNewX = beddingRightBorder + (widthNew / 2) + 5; //Сместить спрайт вправо от лежанки с отступом
			if (posNewX + (width / 2) > beddingLeftBorder) //Если спрайт заходит за левый край лежанки
				posNewX = beddingLeftBorder - (widthNew / 2) - 5; //Сместить спрайт влево от лежанки с отступом

			if (posNewY > smallerHeightPos) //Если спрайт уходит слишком высоко
			{
				posNewY = smallerHeightPos; //Сместить питомца вниз, в минимальное значение высоты
				widthNew = smallerWidth;
				heightNew = smallerHeight;
			}
			if (posNewY > screenDownBorder) //Если спрайт уходит слишком низко
			{
				posNewY = screenDownBorder; //Сместить питомца вверх, в максимальное значение высоты
				widthNew = CalculateWidth(smallerWidth);
				heightNew = CalculateHeight(smallerHeight);
			}


			int locNewX = posNewX - (widthNew / 2); //Опредление нового местопооложения спрайта по оси X (ширины)
			int locNewY = posNewY - heightNew; //Определение нового местоположения спрайта по оси Y (высоты)
			int[,] newLoc = { { locNewX, locNewY }, { widthNew, heightNew } }; //Запись новых данных в переменную на выход
			return newLoc;
		}
		/// <summary>
		/// Функция расчета новой ширины спрайта
		/// </summary>
		/// <param name="width">Минимальное значение ширины спрайта</param>
		/// <returns>Новая ширина спрайта</returns>
		public int CalculateWidth(int smallerWidth)
		{
			int widthNew = (int)(smallerWidth * (((33f / 100f) * ((posNewY - smallerHeightPos) / 150f)) + 1));
			return widthNew;
		}
		/// <summary>
		/// Функция расчета новой высоты спрайта
		/// </summary>
		/// <param name="height">Минимальное значение высоты спрайта</param>
		/// <returns>Новая высота спрайта</returns>
		public int CalculateHeight(int smallerHeight) 
		{
			int heightNew = (int)(smallerHeight * (((33f / 100f) * ((posNewY - smallerHeightPos) / 150f)) + 1));
			return heightNew;
		}
}