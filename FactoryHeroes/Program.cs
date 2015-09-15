using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Program
    {
        static void Main()
        {
            int opc = 0;
            string weapon1, weapon2;
            Asks ask = new Asks();
            Hero myHero = null;
            Console.WriteLine("Choose a Hero: ");
            Console.WriteLine("1 Warrior\n2 Wizard\n3 Agent");
            opc = Int32.Parse(Console.ReadLine());
            weapon1 = ask.askWeapon("Choose a Wepon");
            weapon2 = ask.askWeapon("Choose a second Weapon");
            switch (opc)
            {
                case 1:
                    myHero = new Warrior(weapon1, weapon2);
                    break;
                case 2:
                    myHero = new Wizard(weapon1, weapon2);
                    break;
                case 3:
                    myHero = new Agent(weapon1, weapon2);
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
            Console.WriteLine(myHero.type + " Hero created. Weapons: "+myHero.weapon1+" & "+weapon2);
            
            do
            {
                opc = ask.askAttack();
                Console.WriteLine("\n");
                if (opc == 1)
                    Console.WriteLine(myHero.type + " attack with " + weapon1 + ". Damage: " + myHero.damage1);
                else
                {
                    Console.WriteLine(myHero.type + " special attack with " + weapon2 + ". Damage: " + myHero.damage2);
                    Console.WriteLine("    -^~~~^-");
                    Console.WriteLine("  .~       ~.");
                    Console.WriteLine(" (;:       :;)");
                    Console.WriteLine("(:           :)");
                    Console.WriteLine("  ':._    _.:'");
                    Console.WriteLine("     |  |");
                    Console.WriteLine("   (======)");
                    Console.WriteLine("     |  |");
                    Console.WriteLine( "    |  |");
                    Console.WriteLine("     |  |");
                    Console.WriteLine("  ((/   \\))");
                }
                Console.WriteLine("\n");
            } while (opc != 0);
        }
    }
}
