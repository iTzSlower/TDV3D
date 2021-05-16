using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Equipment : Item
    {
        protected Equipment(string name, int price) : base(name, price){
        }
    }
}
