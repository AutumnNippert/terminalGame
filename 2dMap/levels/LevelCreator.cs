using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;
using _2dMap.levels;

namespace _2dMap.levels
{
    class LevelCreator
    {

        static MyUtil util = new MyUtil();
        static Fight fight = new Fight();
        public void initLevel(int numberOfEnemies, Player player)
        {
            int playerLevel = player.lvl;

            for (int x = 0; x <= numberOfEnemies; x++)
            {
                string monsterName = util.randName();
                Enemy enemy = new Enemy();
                enemy.spawnEnemy(
                    Convert.ToInt32(Math.Pow(5, playerLevel)),
                    Convert.ToInt32(Math.Pow(2, playerLevel)),
                    Convert.ToInt32(Math.Pow(5, playerLevel)),
                    playerLevel,
                    monsterName);
                fight.initFight(player, enemy);





                //dummy.spwanEnemy(5, 5, 0, 0);
                //fight.initFight(player, dummy);
                //Console.WriteLine("\ndummy health is " + dummy.health);
                //Console.WriteLine("dummy armor is " + dummy.armor + "\n");
                //Console.WriteLine("player health is " + player.health);
                //Console.WriteLine("player armor is " + player.armor + "\n");
                //Console.Write(">>> ok");
                //Console.ReadLine();
            }
        }
    }
}
