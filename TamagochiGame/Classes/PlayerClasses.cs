using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStop.Classes
{
	[Serializable]
	public class Player
	{
		public string username { get; set; }
		public int money { get; set; }
		public DateTime birthday { get; set; }
		public List<Pet> pets { get; set; }
		public Player(string username, int money, DateTime birthday, List<Pet> pets)
		{
			this.username = username;
			this.money = money;
			this.birthday = birthday;
			this.pets = pets;
		}
		public void SaveAUser(Player player)
		{
			try
			{
				Directory.CreateDirectory("game\\saves\\" + username);
				StreamWriter sw = new StreamWriter("game\\saves\\" + username + "\\player.json", false);
				var options = new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				};
				var saveJson = JsonSerializer.Serialize<Player>(player, options);
				sw.Write(saveJson);
				sw.Close();
				MessageBox.Show("Запись выполнена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ошибка при записи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static Player LoadAPlayer(string file)
		{
			byte[] json = File.ReadAllBytes(file);
			return JsonSerializer.Deserialize<Player>(json);
		}
	}
}
