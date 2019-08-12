using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _2dMap.levels;
using _2dMap.classes;

namespace _2dMap.classes
{
    public class Player
    {
        public int health = 10;
        public int armor = 0;
        public int attackDmgRange1;
        public int attackDmgRange2;

        public string[] inventory = new string[10];

        static MyUtil util = new MyUtil();
        public void clearInventory()
        {
            inventory[0] = "empty";
            inventory[1] = "empty";
            inventory[2] = "empty";
            inventory[3] = "empty";
            inventory[4] = "empty";
            inventory[5] = "empty";
            inventory[6] = "empty";
            inventory[7] = "empty";
            inventory[8] = "empty";
            inventory[9] = "empty";
        }
        public void spawnPlayer()
        {
            setHealth();
            setArmor();
        }
        public string addToInventory(string item)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (inventory[i] == "empty")
                {
                    inventory[i] = item;
                    return item + " successfully added to inventory";
                }
            }
            return "your inventory is full";
        }
        public string removeFromInventory(string item)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (inventory[i] == item)
                {
                    inventory[i] = "empty";
                    return item + " successfully removed from inventory";
                }
            }
            return "you do not have this item";
        }
        public string getInventory(int index)
        {
            return inventory[index];
        }
        public int getHealth()
        {
            return health;
        }
        public void setHealth()
        {
            health = 10;
        }
        public void setAttackDmg()
        {
            string item;
            for (int i = 0; i <= 9; i++)
            {
                item = inventory[i];
                Regex r = new Regex(@"^(?=.*(?:^|(?:[.!?]\S))(\w+))(?:\S+ ){1}(\S+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);//use regex to get first word
                Match m = r.Match(item);
                string Item = m.Groups[2].ToString();
                //Console.WriteLine(Item);
                if (Item == "sword")
                {
                    if (item == "master sword")
                    {
                        attackDmgRange1 = 20;
                        attackDmgRange2 = 100;
                        break;
                    }
                    String sword = m.Groups[1].ToString();
                    Regex firstWord = new Regex(@"((?<= lvl ).*$)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    Match match = firstWord.Match(item);
                    string level = match.Groups[1].ToString();
                    //Console.WriteLine(level);

                    if (sword == "beginner")
                    {
                        if (level == "1")
                        {
                            attackDmgRange1 = 1;
                            attackDmgRange2 = 3;
                        }
                        if (level == "2")
                        {
                            attackDmgRange1 = 3;
                            attackDmgRange2 = 5;
                        }
                        if (level == "3")
                        {
                            attackDmgRange1 = 5;
                            attackDmgRange2 = 8;
                        }
                    }
                    else if (sword == "wooden")
                    {
                        if (level == "1")
                        {
                            attackDmgRange1 = 8;
                            attackDmgRange2 = 12;
                        }
                        if (level == "2")
                        {
                            attackDmgRange1 = 12;
                            attackDmgRange2 = 16;
                        }
                        if (level == "3")
                        {
                            attackDmgRange1 = 16;
                            attackDmgRange2 = 20;
                        }
                    }
                    else if (sword == "iron")
                    {
                        if (level == "1")
                        {
                            attackDmgRange1 = 20;
                            attackDmgRange2 = 25;
                        }
                        if (level == "2")
                        {
                            attackDmgRange1 = 25;
                            attackDmgRange2 = 30;
                        }
                        if (level == "3")
                        {
                            attackDmgRange1 = 30;
                            attackDmgRange2 = 40;
                        }
                    }
                    else if (sword == "ancient")
                    {
                        if (level == "1")
                        {
                            attackDmgRange1 = 40;
                            attackDmgRange2 = 50;
                        }
                        if (level == "2")
                        {
                            attackDmgRange1 = 50;
                            attackDmgRange2 = 60;
                        }
                        if (level == "3")
                        {
                            attackDmgRange1 = 60;
                            attackDmgRange2 = 70;
                        }
                    }
                    else
                    {
                    }
                }
            }
        }
        public void setArmor()
        {
            string item;
            for (int i = 0; i <= 9; i++)
            {
                item = inventory[i];
                //Regex r = new Regex(@"^(?=.*(?:^|(?:[.!?]\S))(\w+))(?:\S+ ){1}(\S+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);//use regex to get first word
                //Match m = r.Match(item);
                //string Item = m.Groups[2].ToString();
                char[] charSeparators = new char[] { ' ' };
                string[] Item = item.Split(charSeparators, StringSplitOptions.None);
                if (Item.Length > 1)
                {
                    //Console.WriteLine(Item);
                    if (Item[1] == "shield")
                    {
                        String shield = Item[0];
                        //Regex firstWord = new Regex(@"((?<= lvl ).*$)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        //Match match = firstWord.Match(item);
                        string level = Item [3];
                        //Console.WriteLine(level);

                        if (shield == "beginner")
                        {
                            if (level == "1")
                            {
                                armor = 1;
                            }
                            if (level == "2")
                            {
                                armor = 3;
                            }
                            if (level == "3")
                            {
                                armor = 5;
                            }
                        }
                        else if (shield == "wooden")
                        {
                            if (level == "1")
                            {
                                armor = 8;
                            }
                            if (level == "2")
                            {
                                armor = 12;
                            }
                            if (level == "3")
                            {
                                armor = 16;
                            }
                        }
                        else if (shield == "iron")
                        {
                            if (level == "1")
                            {
                                armor = 20;
                            }
                            if (level == "2")
                            {
                                armor = 25;
                            }
                            if (level == "3")
                            {
                                armor = 30;
                            }
                        }
                        else if (shield == "ancient")
                        {
                            if (level == "1")
                            {
                                armor = 40;
                            }
                            if (level == "2")
                            {
                                armor = 50;
                            }
                            if (level == "3")
                            {
                                armor = 60;
                            }
                        }
                        else
                        {
                        }
                    }
                }

            }
        }
        public int getArmor()
        {
            return armor;
        }
        public void attack(Enemy enemy)
        {
            if (enemy.armor > 0)
            {
                enemy.armor = enemy.armor - util.RandomNumber(attackDmgRange1, attackDmgRange2);
            }
            else
            {
                enemy.health = enemy.health - util.RandomNumber(attackDmgRange1, attackDmgRange2);
            }
        }
    }
}
