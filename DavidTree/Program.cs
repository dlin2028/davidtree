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
            DavidTree<string> tree = new DavidTree<string>();
            while(true)
            {
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine().ToLower();
                if(operation == "preorder")
                {
                    tree.PreOrder();
                }
                else if(operation != "insert")
                {
                    Console.WriteLine("Type help for help");
                }
                else
                {
                    Console.WriteLine("Arguements: ");
                    string arguements = Console.ReadLine();
                    if(operation == "insert")
                    {
                        tree.Insert(arguements);
                    }
                }
            }
        }
    }
}
