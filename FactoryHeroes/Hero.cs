using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHeroes
{
    interface Hero
    {
        string type { set; get; }
        string weapon1 { set; get; }
        string weapon2 { set; get; }
        int damage1 { set; get; }
        int damage2 { set; get; }
    }
}
