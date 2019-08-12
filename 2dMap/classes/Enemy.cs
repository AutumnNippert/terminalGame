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
        public int health;
        public int armor;
        public int attackDmgRange1;
        public int attackDmgRange2;

        static MyUtil util = new MyUtil();

        public void spwanEnemy(int Health, int Armor, int AtkRng1, int AtkRng2)
        {
            health = Health;
            armor = Armor;
            attackDmgRange1 = AtkRng1;
            attackDmgRange2 = AtkRng2;
        }
        public void attack(Player player)
        {
            if(player.armor > 0)
            {
                player.armor = player.armor - util.RandomNumber(attackDmgRange1, attackDmgRange2);
            }
            else
            {
                player.health = player.health - util.RandomNumber(attackDmgRange1, attackDmgRange2);
            }
            
        }
    }
}
