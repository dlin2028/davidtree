using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidTree
{
    class Program
    {
        static void Main(string[] args)
        {
            DavidTree<int> tree = new DavidTree<int>();

            tree.InsertRecursively(5);
            tree.InsertRecursively(7);
            tree.InsertRecursively(9);
            tree.InsertRecursively(8);
            tree.InsertRecursively(4);

            tree.SearchRecursively(8);


            while (true)
            {
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine().ToLower();
                if (operation == "preorder")
                {
                    tree.PreOrder();
                }
                else if (operation == "help")
                {
                    Console.WriteLine("Commands: \n help \n insert \n preorder \n \n");
                }
                else if (operation != "insert")
                {
                    Console.WriteLine("Type help for help");
                }
                else
                {
                    Console.WriteLine("Arguements: ");
                    int arguements = int.Parse(Console.ReadLine());
                    if (operation == "insert")
                    {
                        tree.InsertRecursively(arguements);
                    }
                }
            }
        }
    }
}
