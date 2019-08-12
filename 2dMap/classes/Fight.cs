using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;

namespace _2dMap.classes
{
    class Fight
    {
        public void initFight(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("Fight\n");
            player.setHealth();
            player.setArmor();
            player.setAttackDmg();
        }

        public void displayBattleStats(Player player, string enemyName, Enemy enemy)
        {
            Console.WriteLine("\n" + enemyName + "'s health now at " + enemy.health);
            Console.WriteLine(enemyName + "'s armor now at " + enemy.armor + "\n");
            Console.WriteLine("Player health now at " + player.health);
            Console.WriteLine("Player armor now at " + player.armor + "\n");
        }
    }
}
