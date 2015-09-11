using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    interface Hero
    {
        string weapon1 { set; get; }
        string weapon2 { set; get; }
        void attack();
        void speAttack();
    }
}
