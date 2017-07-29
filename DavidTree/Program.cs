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
<<<<<<< HEAD

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
=======
            while(true)
            {
                Console.WriteLine("Operation: ");
                string operation = Console.ReadLine().ToLower();

                if (operation == "lazy")
                {
                    tree.Insert(5);
                    tree.Insert(3);
                    tree.Insert(4);
                    tree.Insert(7);
                    tree.Insert(6);
                }
                else if(operation == "inorder")
                {
                    tree.InOrder();
                }
                else if (operation == "preorder")
                {
                    tree.PreOrder();
                }
                else if(operation == "postorder")
                {
                    tree.PostOrder();
                }
                else if(operation != "insert" && operation != "search")
>>>>>>> 9c4ac863231b67ca30a2d7a15d655bbe2ada0837
                {
                    Console.WriteLine("Type help for help");
                }
                else
                {
                    Console.WriteLine("Arguements: ");
                    int arguements = int.Parse(Console.ReadLine());
                    if (operation == "insert")
                    {
<<<<<<< HEAD
                        tree.InsertRecursively(arguements);
=======
                        tree.Insert(int.Parse(arguements));
                    }
                    else if (operation == "search")
                    {
                        Console.WriteLine(tree.Search(int.Parse(arguements)).ToString());
>>>>>>> 9c4ac863231b67ca30a2d7a15d655bbe2ada0837
                    }
                }
            }
        }
    }
}
