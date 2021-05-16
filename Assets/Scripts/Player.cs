using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public string name;

        private int maxLevel = 20;

        private int _exp;
        //public int GetExp()
        //{
        //    return exp;
        //}
        //
        //public void SetExp(int value)
        //{
        //    exp += value;
        //
        //    if (exp < 0)
        //        exp = 0;
        //}
        public int exp
        {
            get
            {
                return _exp;
            }
            set
            {
                _exp = value;
            }
        }
        public int Level
        {
            get
            {
                return exp / 750;
            }
        }

        public Player()
        {
            Console.WriteLine("Constructor");
            _exp = 0;
            name = "New Player";
        }

        public void Attack()
        {

        }

        public void Attack(int lvl)
        {

        }

        public int Damage()
        {
            int result = 0;
            //...
            return result;
        }
        
    }
}
