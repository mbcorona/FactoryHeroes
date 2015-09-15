using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Wizard : Hero
    {
        public Wizard(string a, string b)
        {
            type = "Wizard";
            weapon1 = a;
            weapon2 = b;
            Asks ask = new Asks();
            if (weapon1.Equals("Spell") || weapon1.Equals("Stick"))
                damage1 = ask.askPower(weapon1) * 2;
            else
                damage1 = ask.askPower(weapon1);
            if (weapon2.Equals("Spell") || weapon2.Equals("Stick"))
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
