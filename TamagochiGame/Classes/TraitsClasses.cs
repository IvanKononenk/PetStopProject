using PetStop.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PetStop
{
	/// <summary>
	/// Класс для загрузки черт питомца из JSON файла
	/// </summary>
	public static class TraitsFactory
	{
		private static Dictionary<string, Traits> traitsDictionary;

		/// <summary>
		/// Конструктор, загружающий черты из файла
		/// </summary>
		static TraitsFactory()
		{
			LoadTraitsFromJson();
		}
		
		/// <summary>
		/// Метод заполнения словаря черт из файла или грубым кодом
		/// </summary>
		private static void LoadTraitsFromJson()
		{
			var traitsList = JsonSerializer.Deserialize<List<Traits>>(Resources.Traits);
			traitsDictionary = traitsList?.ToDictionary(s => s.traitEng)
								?? new Dictionary<string, Traits>();
		}
		
		/// <summary>
		/// Метод выбора случайной черты питомца из списка
		/// </summary>
		/// <returns>Случайная черта питомца</returns>
		public static Traits RandomTrait()
		{
			LoadTraitsFromJson();
			Random rnd = new Random();
			return traitsDictionary.ElementAt(rnd.Next(traitsDictionary.Count)).Value;
		}
		
		/// <summary>
		/// Метод для получения определенной черты из словаря
		/// </summary>
		/// <param name="traitEng">Имя черты</param>
		/// <returns>Черта питомца</returns>
		/// <exception cref="ArgumentException">Возникает, если черта не была найдена в словаре</exception>
		public static Traits CreateTraits(string traitEng)
		{
			if (traitsDictionary.TryGetValue(traitEng, out Traits traits))
			{ return traits; }
			else
			{
				throw new ArgumentException($"Неизвестная черта: {traitEng}");
			}
		}
	}
	
	/// <summary>
	/// Класс для черт питомца
	/// </summary>
	public class Traits
	{
		public string trait { get; set; }
		public string traitEng { get; set; }

		public int modSatiety { get; set; }
		public int modHydration { get; set; }
		public int modCommunication { get; set; }
		public int modVigor { get; set; }
		public int modCleanliness { get; set; }
		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="trait">Название черты</param>
		/// <param name="traitEng">Название черты по-английски(для сохранения)</param>
		/// <param name="modSatiety">Размер убывания голода</param>
		/// <param name="modHydration">Размер убывания жажды</param>
		/// <param name="modCommunication">Размер убывания общения</param>
		/// <param name="modVigor">Размер убывания бодрости</param>
		/// <param name="modCleanliness">Размер убывания чистоты</param>
		public Traits(string trait, string traitEng, int modSatiety, int modHydration, int modCommunication, int modVigor, int modCleanliness)
		{
			this.trait = trait;
			this.traitEng = traitEng;
			this.modSatiety = modSatiety;
			this.modHydration = modHydration;
			this.modCommunication = modCommunication;
			this.modVigor = modVigor;
			this.modCleanliness = modCleanliness;
		}
		public static Traits newTrait;
	}
}
