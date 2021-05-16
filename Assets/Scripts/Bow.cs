using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bow : Item
    {
        public int dmg;
        public int range;

        public Bow(string name, int price, int dmg, int range) : base(name, price)
        {
            this.dmg = dmg;
            this.range = range;

        }
        public void Attack() { }
    }
}

