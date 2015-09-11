using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    class Warrior : Hero
    {
        int damage;
        Asks ask = new Asks();
        public Warrior()
        {
            weapon1 = ask.askWeapon();
            Console.WriteLine("Choose a weapon for special attack");
            weapon2 = ask.askWeapon();
            Console.WriteLine("Warrior hero created. Weapons: "+weapon1+" & "+weapon2);
            Console.WriteLine("Press any key to continue: ");
            int opc=0;
            do
            {
                opc = ask.askAttack();
                if (opc == 1)
                {
                    attack();
                }
                else
                {
                    speAttack();
                }
            } while (opc != 0);
        }

        public void attack()
        {
            if (weapon1.Equals("Blade") || weapon1.Equals("Axe"))
                damage = ask.askPower(weapon1) * 2;
            else
                damage = ask.askPower(weapon1);
            Console.WriteLine("Your warrior give a hit with " + weapon1 +
                "\nDamage: " + damage);
        }

        public void speAttack()
        {
            if (weapon1.Equals("Blade") || weapon1.Equals("Axe"))
                damage = ask.askPower(weapon1) * 4;
            else
                damage = ask.askPower(weapon1) * 2;
            Console.WriteLine("Your warrior give a special hit with " + weapon1 +
                "\nDamage: " + damage);
        }

        public string weapon1 { set; get; }

        public string weapon2 { set; get; }
    }
}
