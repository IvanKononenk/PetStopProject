using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PetStop
{
	/// <summary>
	/// Класс для загрузки эффектов
	/// </summary>
	public static class EffectsFactory
	{
		public static Dictionary<string, Effects> effectsDictionary;

		/// <summary>
		/// Конструктор, загружающий черты из файла
		/// </summary>
		static EffectsFactory()
		{
			LoadEffectsFromJson("effects.json");
		}

		/// <summary>
		/// Метод заполнения словаря черт из файла или грубым кодом
		/// </summary>
		/// <param name="filePath">Путь к JSON файлу</param>
		static void LoadEffectsFromJson(string filePath)
		{
			if (File.Exists(filePath))
			{
				var json = File.ReadAllBytes(filePath);
				var effectsList = JsonSerializer.Deserialize<List<Effects>>(json);
				effectsDictionary = effectsList?.ToDictionary(s => s.effectEng)
								   ?? new Dictionary<string, Effects>();
			}
			else
			{
				effectsDictionary = new Dictionary<string, Effects>
				{

				};
			}
		}

		/// <summary>
		/// Метод для получения определенной черты из словаря
		/// </summary>
		/// <param name="effectEng">Имя черты</param>
		/// <returns>Черта питомца</returns>
		/// <exception cref="ArgumentException">Возникает, если черта не была найдена в словаре</exception>
		public static Effects CreateEffects(string effectEng)
		{
			if (effectsDictionary.TryGetValue(effectEng, out Effects effects))
			{ return effects; }
			else
			{
				throw new ArgumentException($"Неизвестная черта: {effectEng}");
			}
		}
	}
	
	/// <summary>
	/// Класс для баффов и дебаффов
	/// </summary>
	public class Effects
	{
		public string effect { get; set; }
		public string effectEng { get; set; }

		public int modHappiness { get; set; }
		public int modSatiety { get; set; }
		public int modHydration { get; set; }
		public int modCommunication { get; set; }
		public int modVigor { get; set; }
		public int modCleanliness { get; set; }

		/// <summary>
		/// Простой конструктор класса эффектов
		/// </summary>
		/// <param name="effect">Название эффекта</param>
		/// <param name="effectEng">Название эффекта по-английски</param>
		/// <param name="modHappiness">Модификатор счастья</param>
		/// <param name="modSatiety">Модификатор голода</param>
		/// <param name="modHydration">Модификатор жажды</param>
		/// <param name="modCommunication">Модификатор общения</param>
		/// <param name="modVigor">Модификатор бодрости</param>
		/// <param name="modCleanliness">Модификатор чистоты</param>
		public Effects(string effect, string effectEng, int modHappiness, int modSatiety, int modHydration, int modCommunication, int modVigor, int modCleanliness)
		{
			this.effect = effect;
			this.effectEng = effectEng;
			this.modHappiness = modHappiness;
			this.modSatiety = modSatiety;
			this.modHydration = modHydration;
			this.modCommunication = modCommunication;
			this.modVigor = modVigor;
			this.modCleanliness = modCleanliness;
		}
	}
}