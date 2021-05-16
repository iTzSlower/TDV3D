using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Armor : Equipment
    {
        public int AC;

        public enum Type
        {
            Light,
            Medium,
            Heavy
        }
        public Type type = Type.Light;

        public Armor(string name,int price,int AC) : base(name,price) {
            this.AC = AC;
        }
    }
}
