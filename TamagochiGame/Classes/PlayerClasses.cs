using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStop.Classes
{
	[Serializable]
	public class PlayerClasses
	{
		public string username { get; set; }
		public int money { get; set; }
		public List<Pet> pets { get; set; }
		public DateTime birthday { get; set; }
		ДОБАВИТЬ ДНЮХУ В КОНСТРУКТОР
		public PlayerClasses(string username, int money, List<Pet> pets)
		{
			this.username = username;
			this.money = money;
			this.pets = pets;
		}
	}
}
