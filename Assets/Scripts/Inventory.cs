using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inventory
    {
        private List<Item> _slots;

        public List<Item> slots
        {
            get
            {
                return _slots;
            }
        }
        public Inventory()
        {
            _slots = new List<Item>();
        }
        public void Add(Item item)
        {
            _slots.Add(item);
        }
        public void Remove(int index)
        {
            _slots.RemoveAt(index);
        }
        public void Print()
        {
            Console.WriteLine("Inventory");

            //for (int i = 0; i < _slots.Count; i++)
            //{
            //    Console.WriteLine(_slots[i].name);
            //}

            foreach (Item item in _slots)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
