using PetStop.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetStop.Classes
{
	internal class CratesClasses
	{
		[Serializable]
		public class Crates
		{
			public string speciesInside { get; set; }
			public string crateName { get; set; }
			public Species[] species { get; set; }
		}
		static Random rnd = new Random();
		public static Crates[] LoadCrates()
		{
			return JsonSerializer.Deserialize<Crates[]>(Resources.Crates);
		}
		public static Species RandomSpecies(int crateNum)
		{
			return cratesArray[crateNum].species[rnd.Next(cratesArray[crateNum].species.Length)];
		}
		public static Crates[] cratesArray = LoadCrates();
	}
}
