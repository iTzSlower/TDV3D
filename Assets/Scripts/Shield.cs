using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shield : Equipment
    {
        public int AC;

        public Shield(string name, int price, int AC) : base(name,price)
        {
            this.AC = AC;
        }
    }
}
