using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Asks
    {
        public string askWeapon(string mess)
        {
            string message = mess + "\n1 Blade\n2 Axe\n3 Stick\n4 Spell\n5 Gun\n6 Explosive";
            Console.WriteLine(message);
            switch (Console.ReadLine())
            {
                case "1":
                    return "Blade";
                case "2":
                    return "Axe";
                case "3":
                    return "Stick";
                case "4":
                    return "Spell";
                case "5":
                    return "Gun";
                case "6":
                    return "Explosive";
                default:
                    Console.WriteLine("Invalid input. Try again");
                    return askWeapon(mess);
            }
        }
        public int askAttack()
        {
            string message = "1 Attack\n2 Special Attck\n0 Exit";
            Console.WriteLine(message);
            switch (Console.ReadLine())
            {
                case "0":
                    return 0;
                case "1":
                    return 1;
                case "2":
                    return 2;
                default:
                    Console.WriteLine("Invalid input. Try again");
                    return askAttack();
            }
        }

        public int askPower(string weapon)
        {
            switch(weapon)
            {
                case "Blade":
                    return 3;
                case "Axe":
                    return 2;
                case "Stick":
                    return 3;
                case "Spell":
                    return 2;
                case "Gun":
                    return 3;
                case "Explosive":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
