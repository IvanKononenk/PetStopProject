using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PetStop
{
	/// <summary>
	/// Класс для загрузки видов питомцев и случайного выбора из созданного справочника
	/// </summary>
	public static class SpeciesFactory
	{
		private static Dictionary<string, Species> speciesDictionary;

		/// <summary>
		/// Конструктор класса непонятного назначения
		/// </summary>
		static SpeciesFactory()
		{
			// Initialize the species from JSON or hardcoded values
			LoadSpeciesFromJson("species.json"); // Optional JSON loading
		}
		
		/// <summary>
		/// Метод загрузки объектов класса из файла JSON
		/// </summary>
		/// <param name="filePath">Путь к файлу JSON</param>
		private static void LoadSpeciesFromJson(string filePath)
		{
			if (File.Exists(filePath))
			{
				var json = File.ReadAllBytes(filePath);
				var speciesList = JsonSerializer.Deserialize<List<Species>>(json);

				speciesDictionary = speciesList?.ToDictionary(s => s.speciesEng)
									?? new Dictionary<string, Species>();
			}
			else
			{
				// Fallback to hardcoded values if JSON file is missing
				speciesDictionary = new Dictionary<string, Species>
				{
					{ "germanShepherd", new Species("Немецкая овчарка", "germanShepherd", 0, 0, 0, 0, 0, 0) },
					{ "species2", new Species("Специес 2", "species2", 1, 1, 1, 1, 1, 1) }
					// Add more species here...
				};
			}
		}
		
		/// <summary>
		/// Метод выбора случайного вида питомца
		/// </summary>
		/// <returns>Случайная порода\вид питомца</returns>
		public static Species RandomSpecies()
		{
			LoadSpeciesFromJson("species.json");
			Random rnd = new Random();
			return speciesDictionary.ElementAt(rnd.Next(speciesDictionary.Count)).Value;
		}
		
		/// <summary>
		/// Метод для получения породы питомца по его английскому названию
		/// </summary>
		/// <param name="speciesEng">Имя породы по-английски</param>
		/// <returns>Порода\вид питомца</returns>
		/// <exception cref="ArgumentException">Возникает, если не обнаружена порода с таким названием</exception>
		public static Species CreateSpecies(string speciesEng)
		{
			if (speciesDictionary.TryGetValue(speciesEng, out Species species))
			{ return species; }
			else
			{ throw new ArgumentException($"Unknown species: {speciesEng}"); }
		}
	}
	
	/// <summary>
	/// Класс породы питомца
	/// </summary>
	public class Species
	{
		public string speciesName { get; set; }
		public string speciesEng { get; set; }

		public int modHappiness { get; set; }
		public int modSatiety { get; set; }
		public int modHydration { get; set; }
		public int modCommunication { get; set; }
		public int modVigor { get; set; }
		public int modCleanliness { get; set; }

		/// <summary>
		/// Простой конструктор класса
		/// </summary>
		/// <param name="speciesName">Название породы</param>
		/// <param name="speciesEng">Название породы по-английски</param>
		/// <param name="modHappiness"></param>
		/// <param name="modSatiety"></param>
		/// <param name="modHydration"></param>
		/// <param name="modCommunication"></param>
		/// <param name="modVigor"></param>
		/// <param name="modCleanliness"></param>
		public Species(string speciesName, string speciesEng, int modHappiness, int modSatiety, int modHydration, int modCommunication, int modVigor, int modCleanliness)
		{
			this.speciesName = speciesName;
			this.speciesEng = speciesEng;
			this.modHappiness = modHappiness;
			this.modSatiety = modSatiety;
			this.modHydration = modHydration;
			this.modCommunication = modCommunication;
			this.modVigor = modVigor;
			this.modCleanliness = modCleanliness;
		}
	}
}