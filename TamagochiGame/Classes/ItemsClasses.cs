namespace PetStop
{
	/// <summary>
	/// Класс для предметов инвентаря
	/// </summary>
	public class Items
	{
		public string item { get; set; }
		public string itemEng { get; set; }
		public int count { get; set; }

		/// <summary>
		/// Простой конструктор класса
		/// </summary>
		/// <param name="item">Название предмета</param>
		/// <param name="itemEng">Название предмета по-английски</param>
		/// <param name="count">Количество предметов</param>
		public Items(string item, string itemEng, int count)
		{
			this.item = item;
			this.itemEng = itemEng;
			this.count = count;
		}

		/// <summary>
		/// Метод увеличения количества предметов
		/// </summary>
		/// <param name="c">Количество, на которое увеличичвается количество</param>
		public void AddItem(int c) => count += c;

		/// <summary>
		/// Метод уменьшения количества предметов
		/// </summary>
		/// <param name="c">Количество, на которое уменьшается количество</param>
		public void RemoveItem(int c) => count -= c;
	}
}
