using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;

namespace _2dMap.classes
{
    public class Player
    {
        public int health;
        public int armor;
        public int attackDmg;

        public int xPos;
        public int yPos;

        public string[] inventory = new string[10];
        public void setInventory()
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

        public void makePlayer(int health, int armor, int xPos, int yPos)
        {
            Player player = new Player();
            player.setHealth(health);
            player.setArmor(armor);
            player.setPos(xPos, yPos);

        }
        public void setPos(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
        public int getXPos()
        {
            return xPos;
        }
        public int getYPos()
        {
            return yPos;
        }
        public void moveUp()
        {
            yPos = yPos - 1;
        }
        public void moveDown()
        {
            yPos = yPos + 1;
        }
        public void moveRight()
        {
            xPos = xPos + 1;
        }
        public void moveLeft()
        {
            xPos = xPos - 1;
        }
        public void takeDamage(int damage)
        {
            health = health - damage;
        }
        public string addToInventory(string item)
        {
            for(int i = 0; i <= 9; i++)
            {
                if(inventory[i] == "empty"){
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
            return "your inventory is full";
        }
        public string getInventory(int index)
        {
            return inventory[index];
        }
        public int getHealth()
        {
            return health;
        }
        public void setHealth(int Health)
        {
            health = Health;
        }
        public void setArmor(int Armor)
        {
            armor = Armor;
        }
        public int getArmor()
        {
            return armor;
        }
    }
}
