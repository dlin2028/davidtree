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
            insert(item, top);
        }
        private bool insert(T item, TreeNode<T> currentNode)
        {
            if (top == null)
            {
                top = new TreeNode<T>(item);
                return true;
            }
            else if (currentNode == null)
            {
                return true;
            }

            if(currentNode.Item.CompareTo(item) > 0)
            {
                if(insert(item, currentNode.LeftNode))
                {
                    currentNode.LeftNode = new TreeNode<T>(item);
                    return false;
                }
            }
            else
            {
                if (insert(item, currentNode.RightNode))
                {
                    currentNode.RightNode = new TreeNode<T>(item);
                    return false;
                }
            }
            return true;
        }


        public void Delete(T key)
        {
            TreeNode<T> nodeToDelete = Search(key);

        }


        public TreeNode<T> Maximum()
        {
            return maximum(top);
        }
        private TreeNode<T> maximum(TreeNode<T> currentNode)
        {
            if(maximum(currentNode) == null)
            {
                return currentNode;
            }

            return currentNode.RightNode;
        }


        public TreeNode<T> Minimum()
        {
            return minimum(top);
        }
        private TreeNode<T> minimum(TreeNode<T> currentNode)
        {
            if(minimum(currentNode) == null)
            {
                return currentNode;
            }

            return currentNode.LeftNode;
        }


        public TreeNode<T> Search(T key)
        {
            return search(key, top);
        }
        private TreeNode<T> search(T key, TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                throw new Exception("node with key not found");
            }
            
            if (currentNode.Item.CompareTo(key) > 0)
            {
                return search(key, currentNode.LeftNode);
            }
            else if(currentNode.Item.CompareTo(key) != 0)
            {
                return search(key, currentNode.RightNode);
            }
            else
            {
                return currentNode;
            }
            throw new Exception("How can you see this error? You should be dead by now!");
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
