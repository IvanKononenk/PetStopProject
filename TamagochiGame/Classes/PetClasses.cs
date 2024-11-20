using PetStop.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;

namespace PetStop
{
	/// <summary>
	/// Класс питомца
	/// </summary>
	[Serializable]
	public class Pet
	{
		public string name { get; set; }
		public Species species { get; set; }
		public string petPic { get; set; }
		public string gender { get; set; }

		public int happiness { get; set; }
		public int satiety { get; set; }
		public int hydration { get; set; }
		public int communication { get; set; }
		public int vigor { get; set; }
		public int cleanliness { get; set; }

		public Traits trait { get; set; }
		public int ageMinutes { get; set; }
		public List<Items> inventory { get; set; }
		public List<Effects> effects { get; set; }
		
		/// <summary>
		/// Конструктор нового питомца
		/// </summary>
		/// <param name="name">Имя питомца</param>
		/// <param name="species">Вид питомца</param>
		/// <param name="gender">Пол питомца</param>
		/// <param name="trait">Черта питомца</param>
		public Pet(string name, Species species, string petPic, string gender, Traits trait)
		{
			this.name = name;
			this.species = species;
			this.petPic = petPic;
			this.gender = gender;
			happiness = 500000;
			satiety = 10000;
			hydration = 10000;
			communication = 10000;
			vigor = 10000;
			cleanliness = 10000;
			ageMinutes = 0;
			this.trait = trait;
			inventory = new List<Items>();
			effects = new List<Effects>();
		}
		
		/// <summary>
		/// Метод загрузки питомца из файла сохранения
		/// </summary>
		/// <param name="file">Путь к JSON-файлу сохранения</param>
		/// <returns>Объект класса, представляющий питомца</returns>
		public static Pet LoadAPet(string file)
		{
			byte[] json = File.ReadAllBytes(file);
			return JsonSerializer.Deserialize<Pet>(json);
		}
		
		/// <summary>
		/// Пустой конструктор питомца (для сериализации)
		/// </summary>
		public Pet() { }
		
		/// <summary>
		/// Метод записи нового \ перезаписи существующего файла сохранения питомца
		/// </summary>
		/// <returns>Удалось ли сохранить данные</returns>
		public bool SaveAPet(Pet saveTarget)
		{
			try
			{
				StreamWriter sw = new StreamWriter("game\\saves\\" + Player.activePlayer.username + "\\" + name + ".json", false);
				var options = new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				};
				var saveJson = JsonSerializer.Serialize<Pet>(saveTarget, options);
				sw.Write(saveJson);
				sw.Close();
				MessageBox.Show("Сохранение данных питомца выполнено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			catch
			{
				MessageBox.Show("Ошибка при сохранении данных питомца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
		}
		
		/// <summary>
		/// Метод добавления в инвентарь питомца предмета
		/// </summary>
		/// <param name="item">Объект предмета</param>
		public void AssignItem(Items item) => inventory.Add(item);
		
		/// <summary>
		/// Метод назначения питомца эффекта
		/// </summary>
		/// <param name="effect">Название эффекта</param>
		public void AssignEffect(Effects effect)
		{
			effects.Add(effect);
			happiness += effect.modHappiness;
			satiety += effect.modSatiety;
			hydration += effect.modHydration;
			communication += effect.modCommunication;
			vigor += effect.modVigor;
			cleanliness += effect.modCleanliness;
		}

		/// <summary>
		/// Метод снятия эффекта с питомца
		/// </summary>
		/// <param name="effect">Название удаляемого эффекта</param>
		public void RemoveEffect(Effects effect)
		{
			effects.Remove(effect);
			happiness -= effect.modHappiness;
			satiety -= effect.modSatiety;
			hydration -= effect.modHydration;
			communication -= effect.modCommunication;
			vigor -= effect.modVigor;
			cleanliness -= effect.modCleanliness;
		}

		/// <summary>
		/// Метод уменьшения показателей питомца с каждым тиком
		/// </summary>
		public void StarveTick()
		{
			int effectModHappinessSum = 0;
			int effectModSatietySum = 0;
			int effectModHydrationSum = 0;
			int effectModCommunicationSum = 0;
			int effectModVigorSum = 0;
			int effectModCleanlinessSum = 0;
			foreach (Effects effect in effects)
			{
				effectModHappinessSum += effect.modHappiness;
				effectModSatietySum += effect.modSatiety;
				effectModHydrationSum += effect.modHydration;
				effectModCommunicationSum += effect.modCommunication;
				effectModVigorSum += effect.modVigor;
				effectModCleanlinessSum += effect.modCleanliness;
			}
			satiety -= species.modSatiety - trait.modSatiety - effectModSatietySum;
			hydration -= species.modHydration - trait.modHydration - effectModHydrationSum;
			communication -= species.modCommunication - trait.modCommunication - effectModCommunicationSum;
			vigor -= species.modVigor - trait.modVigor - effectModVigorSum;
			cleanliness -= species.modCleanliness - trait.modCleanliness - effectModCleanlinessSum;
			happiness = (satiety + hydration + communication + vigor + cleanliness) - species.modHappiness - effectModHappinessSum;
		}

		public static TimeSpan lastPlay;
		public static Pet activePet;
		public static Pet newPet;
	}
}