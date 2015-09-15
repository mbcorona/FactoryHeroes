using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Warrior : Hero
    {
        public Warrior(string a, string b)
        {
            type = "Warrior";
            weapon1 = a;
            weapon2 = b;
            Asks ask = new Asks();
            if (weapon1.Equals("Blade") || weapon1.Equals("Axe"))
                damage1 = ask.askPower(weapon1) * 2;
            else
                damage1 = ask.askPower(weapon1);
            if (weapon2.Equals("Blade") || weapon2.Equals("Axe"))
                damage2 = ask.askPower(weapon2) * 4;
            else
                damage2 = ask.askPower(weapon2) * 2;
        }
        public string type { set; get; }

        public string weapon1 { set; get; }

        public string weapon2 { set; get; }

        public int damage1 { set; get; }

        public int damage2 { set; get; }
    }
}
