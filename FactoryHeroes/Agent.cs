using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Agent : Hero
    {
        public Agent(string a, string b)
        {
            type = "Agent";
            weapon1 = a;
            weapon2 = b;
            Asks ask = new Asks();
            if (weapon1.Equals("Gun") || weapon1.Equals("Explosive"))
                damage1 = ask.askPower(weapon1) * 2;
            else
                damage2 = ask.askPower(weapon1);
            if (weapon2.Equals("Gun") || weapon2.Equals("Explosive"))
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
