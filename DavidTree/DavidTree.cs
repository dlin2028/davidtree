using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidTree
{
    class DavidTree <T> where T : IComparable<T>
    {
        static TreeNode<T> top;
        int count;

        public DavidTree ()
        {
            top = null;
            count = 0;
        }

        public void Insert(T item)
        {
            count++;
            if (top == null)
            {
                top = new TreeNode<T>(item);
            }
            else
            {
                TreeNode<T> currentNode = top;

                while(true)
                {
                    if (currentNode.Item.CompareTo(item) > 0)
                    {
                        if (currentNode.LeftNode == null)
                        {
                            currentNode.LeftNode = new TreeNode<T>(item);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                    }
                    else
                    {
                        if (currentNode.RightNode == null)
                        {
                            currentNode.RightNode = new TreeNode<T>(item);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightNode;
                        }
                    }
                }
            }
        }

        TreeNode<T> currentNode;
        int counter = 0;
        public void PreOrder()
        {
            if(currentNode == null)
            {
                currentNode = top;
            }
            if(currentNode.LeftNode == null || currentNode.LeftNode.LeftNode != null)
            {
                Console.WriteLine(currentNode.Item);
                counter++;
                currentNode = currentNode.LeftNode;
            }
            else if(currentNode.RightNode == null)
            {
                Console.WriteLine(currentNode.Item);
                counter++;
                currentNode = top.RightNode;
            }
            else
            {
                Console.WriteLine(currentNode.Item);
                counter++;
                if (currentNode.LeftNode != null)
                {
                    Console.WriteLine(currentNode.LeftNode.Item);
                    counter++;
                }
                currentNode = currentNode.RightNode;
            }
            
            if(count >= counter)
            {
                PreOrder();
            }
            else
            {
                counter = 0;
            }
        }

    }
}
