using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Inventory inventory;
        static void Main(string[] args)
        {
            inventory = new Inventory();

            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Inventory");
            Console.WriteLine("=========");
            Console.WriteLine("1- List");
            Console.WriteLine("2- Add");
            Console.WriteLine("3- Remove");
            Console.WriteLine("0- Exit");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    inventory.Print();
                    Console.ReadLine();
                    MainMenu();
                    break;

                case "2":
                    AddItem();
                    break;

                case "3":
                    RemoveItem();
                    break;

                case "0":
                    break;
            }
        }
        static void AddItem()
        {
            Sword longsword = new Sword("Longsword", 15, 3);
            Sword greatsword = new Sword("Greatsword", 50, 5);

            Shield buckler = new Shield("Buckler", 5, 1);
            Armor chainmail = new Armor("Chainmail", 15, 3);

            Item item = null;

            Console.Clear();
            Console.WriteLine("Add Item");
            Console.WriteLine("===========");
            Console.WriteLine("1- Longsword");
            Console.WriteLine("2- Greatsword");
            Console.WriteLine("3- Buckler");
            Console.WriteLine("4- Chainmail");
            Console.WriteLine("0- Exit");

            string itemId = Console.ReadLine();
            switch (itemId)
            {
                case "1":
                    item = longsword;
                    break;

                case "2":
                    item = greatsword;

                    break;

                case "3":
                    item = buckler;
                    break;

                case "4":
                    item = chainmail;
                    break;

                case "0":
                    break;
            }

            if (item != null)
                inventory.Add(item);

            MainMenu();
        }
        static void RemoveItem()
        {
            Console.Clear();
            Console.WriteLine("Remove Item");
            Console.WriteLine("===========");

            Console.WriteLine("Item id: ");

            int itemId = int.Parse(Console.ReadLine());

            inventory.Remove(itemId);
            MainMenu();
        }
    }
}
