using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _2dMap.classes;

//game name is "Madvanoxia"

namespace _2dMap
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[,] grid = new string[6, 6];
            Player player = new Player();
            player.makePlayer(5, 5, 0, 0);
            int health = player.getHealth();
            Console.WriteLine(health);
            player.setInventory();
            player.addToInventory("acorn");
            player.addToInventory("Chicken");
            string[] inventory = new string[9];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(player.getInventory(i));
            }

            string command = Console.ReadLine();
            //Regex rx = new Regex;

        }
    }
}