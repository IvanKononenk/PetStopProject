﻿using System;
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
		public Player(string username, int money, DateTime birthday)
		{
			this.username = username;
			this.money = money;
			this.birthday = birthday;
			pets = new List<Pet>();
		}
		public bool SaveAUser(Player player)
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
				return true;
			}
			catch
			{
				MessageBox.Show("Ошибка при сохранении данных пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
		public static Player LoadAPlayer(string file)
		{
			byte[] json = File.ReadAllBytes(file);
			return JsonSerializer.Deserialize<Player>(json);
		}

		public static Player activePlayer;
	}
}
