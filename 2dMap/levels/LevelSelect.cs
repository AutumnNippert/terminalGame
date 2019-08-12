using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;
using _2dMap.levels;

namespace _2dMap.levels
{
    class LevelSelect
    {
        public void initLevelSelect(Player player)
        {
            bool lvlSelect = true;
            while (lvlSelect == true)
            {
                Console.Write("\n>>> ");
                string command = Console.ReadLine();
                char[] charSeparators = new char[] { ' ' };
                string[] words = command.Split(charSeparators, StringSplitOptions.None);
                if (words.Length < 2)
                {
                    if (command == "start")
                    {
                        Console.Clear();
                        Tutorial tutorial = new Tutorial();
                        tutorial.InitTutorial(player);
                    }
                }
                else if (words.Length >= 2)
                {
                    if (words[0] == "drop")
                    {
                        string itemCheck = "";
                        for (int i = 0; i <= 9; i++)
                        {
                            itemCheck = player.getInventory(i);
                            if (itemCheck == words[1])
                            {
                                Console.Write("Are you sure you want to drop " + words[1] + "?\n>>> ");
                                string dropTrue = Console.ReadLine();
                                if (dropTrue == "yes" || dropTrue == "y")
                                {
                                    player.removeFromInventory(words[1]);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (itemCheck != words[1])
                        {
                            Console.WriteLine("You do not have that item");
                        }
                    }
                    if (words[0] == "eat")
                    {
                        string itemCheck = "";
                        for (int i = 0; i <= 9; i++)
                        {
                            itemCheck = player.getInventory(i);
                            if (itemCheck == words[1])
                            {
                                player.removeFromInventory(words[1]);
                                break;
                            }
                        }
                        if (itemCheck != words[1])
                        {
                            Console.WriteLine("You do not have that item");
                        }
                    }
                    if (words[0] == "view")
                    {
                        if (words[1] == "inventory")
                        {
                            Console.WriteLine("\n");
                            for (int i = 0; i <= 9; i++)
                            {
                                Console.WriteLine("[" + i + "] " + player.getInventory(i) + "\n");
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
