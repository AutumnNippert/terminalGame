using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2dMap.classes;

namespace _2dMap.levels
{
    class Tutorial
    {
        static MyUtil util = new MyUtil();
        static Fight fight = new Fight();
        
        public void InitTutorial(Player player)
        {
            string text = (
                "   Hey player, im your personal AI named Ai, so convenient right?\n" +
                "Yeah, my programmer wasn't exactly very goo-- OH SHIT, THERE'S\n" +
                "A DUMMY THAT JUST APPEARED RIGHT IN FRONT OF YOU oh shit\n" +
                "it was just me haha XD. Don't worry, it's just a simulated entity\n" +
                "so he can't hurt you.\n\n" +
                "   This is a test so you can get grips with the fighting mechanics of \n" +
                "this game. Give it a shot! Trust me, murdering is easier than you think!\n" + 
                "(also, usually, there will be some dialouge like now that you\n" +
                "will respond to, so just press enter lol)\n");
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Write(">>> oh ok");
            Console.ReadLine();
            Console.WriteLine("You have pissed off the dummy! He wanna fight!");
            Enemy dummy = new Enemy();
            dummy.spawnEnemy(5, 5, 0, 0, "dummy");
            //Console.WriteLine("\ndummy health is " + dummy.health);
            //Console.WriteLine("dummy armor is " + dummy.armor + "\n");
            //Console.WriteLine("player health is " + player.health);
            //Console.WriteLine("player armor is " + player.armor + "\n");
            Console.Write(">>> ok");
            fight.initFight(player, dummy);
            Console.ReadLine();
            while (player.health > 0 && dummy.health > 0)
            {
                player.attack(dummy);
                dummy.attack(player);
                fight.displayBattleStats(player,"The Dummy",  dummy);
                Console.WriteLine("Press enter to continue...\n");
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Pretty easy right?");
            Console.Write(">>> Yeah!");
            Console.ReadLine();
            Console.Write("Now i'll tell you about lo--");
            string lessDashes = "-------------";
            string dashes = (util.repeatForLoop("!2qS4es5eXDX6tcYGyv9hub)J)Bijnok)OjioimOKOplpkijOITCCbvxfdAREWQroiuIKJV,nbBVDSYTE2433YUTOIU69764$%@treryu(&6oiyYFgxNBvmnkhDTReytOIUGKJddSVCxcJKTO^oipyIUTu6345!@wqerEYUitoLKjnmCNSHRety", 50));
            foreach (char c in lessDashes)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(util.RandomNumber(50, 500));
            }
            foreach (char c in dashes)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(util.RandomNumber(0, 1));
            }
          
            Console.Clear();
            Console.WriteLine("You have pissed off the wrong dummy! He gonna kill you!");
            Console.Write(">>> shit!");
            Console.ReadLine();
            Enemy wrongDummy = new Enemy();
            wrongDummy.spawnEnemy(99999999, 99999999, 1, 1, "wrong Dummy");
            Console.WriteLine("dummy health now at " + wrongDummy.health);
            Console.WriteLine("dummy armor now at " + wrongDummy.armor + "\n");
            Console.WriteLine("player health now at 1");
            Console.WriteLine("player armor now at -99999999");
            Console.Write("Press enter to-o-ooo-o----");
            Console.ReadLine();
            Console.Clear();
            string ting = (
                "--oting.\n" +
                "The dummy you killed dropped you some loot you can\n" +
                "use for the next levels Lets see what he dropped!\n"
                );
            foreach (char c in ting)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            Console.Write(">>> What just happened?");
            Console.ReadLine();
            string item = util.generateSmallLootItem();
            string dialogue = (
                "\nlooks like he dropped a " + item + "!\n" +
                "Each time you complete a level, you have the chance\n" +
                "to take the item, but only if your inventory has space.\n\n" +
                "Now you're back at the level selection where you can view\n" +
                "your inventory and other things.\n"
                );
            foreach (char c in dialogue)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(10);
            }
            player.addToInventory(item);
            Console.Write(">>> Welp, ok then");
            Console.ReadLine();
        }
    }
}
