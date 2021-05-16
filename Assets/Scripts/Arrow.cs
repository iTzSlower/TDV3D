using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arrow : Item
    {
        public int maxStacks = 20;

        public Arrow(string name, int price) : base(name, price)
        {

        }
    }
}
