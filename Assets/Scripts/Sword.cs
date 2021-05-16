using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sword : Item
    {
        public int dmg;

        public Sword(string name, int price, int dmg) : base(name, price)
        {
            this.dmg = dmg;
        }
        public void Attack() { }
    }
}
