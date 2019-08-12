using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _2dMap.levels;
using _2dMap.classes;

//game name is "Madvanoxia"

namespace _2dMap
{
    class Program
    {
        static Player player = new Player();
        static LevelSelect levelSelect = new LevelSelect();
        static void initGame()
        {
            player.clearInventory();
            player.spawnPlayer();
        }
        static void Main(string[] args)
        {
            initGame();
            player.addToInventory("acorn");
            player.addToInventory("acorn");
            player.addToInventory("Chicken");
            player.addToInventory("beginner shield lvl 1");
            player.addToInventory("beginner sword lvl 1");
            player.setArmor();
            Console.WriteLine(player.getArmor());
            levelSelect.initLevelSelect(player);
        }
    }
}