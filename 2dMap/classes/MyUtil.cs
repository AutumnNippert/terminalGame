using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;
using Newtonsoft.Json;

namespace _2dMap.classes
{
    class MyUtil
    {
        
        static Random random = new Random();
        public string generateSmallLootItem()
        {
            string[] items = new string[20];
            items[0] = "acorn";
            items[1] = "acorn";
            items[2] = "acorn";
            items[3] = "acorn";
            items[4] = "acorn";
            items[5] = "acorn";
            items[6] = "acorn";
            items[7] = "acorn";
            items[8] = "acorn";
            items[9] = "beginner sword lvl 2";
            items[10] = "beginner shield lvl 2";
            items[11] = "beginner shield lvl 2";
            items[12] = "beginner shield lvl 2";
            items[13] = "baguette";
            items[14] = "baguette";
            items[15] = "baguette";
            items[16] = "baguette";
            items[17] = "baguette";
            items[18] = "baguette";
            items[19] = "baguette";

            int number = RandomNumber(0, 19);
            string item = items[number];
            return item;

        }
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
        public string repeatForLoop(string s, int n)
        {
            var result = s;

            for (var i = 0; i < n - 1; i++)
            {
                result += s;
            }

            return result;
        }
        public string randName()
        {
            string[] names = new string[10] { "Jankster", "Borgoth", "Grayhound", "Grandorth", "Trogorth", "Nangrome", "Gormund", "Zormud", "Scrafe", "Progrint" };
            int num = RandomNumber(0, names.Length);
            return names[num];
        }
        public void saveGame(Player player)
        {
            int lvl;
            int health;
            int armor;
            int atk;
            int xp;
            string[] inventory;
            try
            {
                Save save = new Save()
                {
                    lvl = player.lvl,
                    health = player.health,
                    armor = player.armor,
                    atk = player.atk,
                    xp = player.xp,
                    inventory = player.inventory
                };
                String strResultJSON = JsonConvert.SerializeObject(save);
                File.WriteAllText(@"save.json", strResultJSON);
            }
            catch
            {

            }
        }
        public void load(Player player)
        {
            StreamReader file = File.OpenText("save.json");
            Save o1 = JsonConvert.DeserializeObject<Save>(file.ReadToEnd());
            player.lvl = o1.lvl;
            player.health = o1.health;
            player.armor = o1.armor;
            player.atk = o1.atk;
            player.xp = o1.xp;
            for(int x = 0; x < player.inventory.Length; x++){

                player.inventory[x] = o1.inventory[x];
            }
        }
    }
}