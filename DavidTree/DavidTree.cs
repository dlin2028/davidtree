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

        public void PreOrder()
        {
            preOrder(top);
        }
        private void preOrder(TreeNode<T> currentNode)
        {
            if(currentNode == null)
            {
                return;
            }
            Console.WriteLine(currentNode.Item);
            preOrder(currentNode.LeftNode);
            preOrder(currentNode.RightNode);
        }

        public void PostOrder()
        {
            postOrder(top);
        }
        private void postOrder(TreeNode<T> currentNode)
        {
            if(currentNode == null)
            {
                return;
            }
            postOrder(currentNode.LeftNode);
            postOrder(currentNode.RightNode);

            Console.WriteLine(currentNode.Item);
        }

        public void InOrder()
        {
            inOrder(top);
        }
        private void inOrder(TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            inOrder(currentNode.LeftNode);
            Console.WriteLine(currentNode.Item);
            inOrder(currentNode.RightNode);
        }
    }
}
