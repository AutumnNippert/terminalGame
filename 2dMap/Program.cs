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
        static Player player = new Player();
        static void initGame()
        {
            player.spawnPlayer(5, 5, 0, 0);
            player.clearInventory();
            string[,] grid = new string[6, 6];
        }
        static void Main(string[] args)
        {
            initGame();
            player.addToInventory("acorn");
            player.addToInventory("Chicken");
            bool game = true;
            while (game == true)
            {
                string command = Console.ReadLine();
                Regex r = new Regex(@"(.*?(?= ))", RegexOptions.IgnoreCase | RegexOptions.Singleline);//use regex to get first word
                Match m = r.Match(command);
                if (m.Success)
                {
                    String word1 = m.Groups[1].ToString();
                    Console.WriteLine("Word 1 = " + word1);
                    if (word1 == "drop")
                    {
                        Regex r2 = new Regex(@"((?<= )\w+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        Match m2 = r2.Match(command);
                        String word2 = m2.Groups[1].ToString();
                        Console.Write(word2.ToString() + "\n");
                        if (m.Success)
                        {
                            player.removeFromInventory(word2);
                            for (int i = 0; i <= 9; i++)
                            {
                                Console.WriteLine(player.getInventory(i));
                            }

                        }
                        else
                        {
                            Console.WriteLine("You do not have that item");
                        }
                    }
                    if (word1 == "view")
                    {
                        Regex r2 = new Regex(@"((?<= )\w+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        Match m2 = r2.Match(command);
                        String word2 = m2.Groups[1].ToString();
                        Console.Write(word2.ToString() + "\n");
                        if (m.Success)
                        {
                            if (word2 == "inventory")
                            {
                                for (int i = 0; i <= 9; i++)
                                {
                                    Console.WriteLine("[" + i + "] " + player.getInventory(i) + "\n");
                                }
                            }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }
        }
    }
}