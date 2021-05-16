using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Item
    {
        public string name;
        public int price;

        public Item(string name,int price)
        {
            this.name = name;
            this.price = price;
        }
        public Item()
        {
            Console.WriteLine(">Item -> constructor");
        }

        public void Use() { }
    }
}
