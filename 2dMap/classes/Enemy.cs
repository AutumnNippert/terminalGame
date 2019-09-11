using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;
using _2dMap.levels;

namespace _2dMap.classes
{
    public class Enemy
    {
        public int lvl;
        public int health;
        public int armor;
        public int atk;
        public string name;

        static MyUtil util = new MyUtil();

        public void spawnEnemy(int Health, int Armor, int Atk, int Lvl, string Name)
        {
            lvl = Lvl;
            health = Health;
            armor = Armor;
            atk = Atk;
            name = Name;
        }
        public void attack(Player player)
        {
            if(player.armor > 0)
            {
                player.armor = player.armor - util.RandomNumber(atk - (5 * lvl), atk + (5 * lvl));
            }
            else if(player.health > 0)
            {
                player.armor = 0;
                player.health = player.health - util.RandomNumber(atk - (2 * lvl), atk + (2 * lvl));
            }
            else
            {
                player.health = 0;
            }
        }
    }
}
