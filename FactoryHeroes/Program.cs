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
            Hero myHero;
            Console.WriteLine("Choose a Hero: ");
            Console.WriteLine("1 Warrior\n2 Wizard\n3 Agent");
            opc = Int32.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    myHero = Crear("warrior");
                    break;
                case 2:
                    myHero = Crear("wizard");
                    break;
                case 3:
                    myHero = Crear("agent");
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    Main();
                    break;
            }
        }
        public static Hero Crear(string tipo)
        {
            switch (tipo)
            {
                case "warrior":
                    return new Warrior();
                case "wizard":
                    return new Wizard();
                case "agent":
                    return new Agent();
                default:
                    Console.WriteLine("Hero Unknow");
                    return null;
            }
        }
    }
}
