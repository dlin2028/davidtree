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
        private TreeNode<T> currentNode;
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
<<<<<<< HEAD
                currentNode = top;
=======
                return true;
            }
>>>>>>> 9c4ac863231b67ca30a2d7a15d655bbe2ada0837

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

<<<<<<< HEAD
        public TreeNode<T> InsertRecursively(T item, TreeNode<T> currentNode = null)
        {
            if (currentNode == null)
            {
                if(top == null)
                {
                    top = new TreeNode<T>(item);
                    return top;
                }
                return InsertRecursively(item, top);
            }
            else
            {
                if (item.CompareTo(currentNode.Item) > 0)
                {
                    if (currentNode.RightNode == null)
                    {
                        currentNode.RightNode = new TreeNode<T>(item);
                        return top;
                    }
                    return InsertRecursively(item, currentNode.RightNode);
                }
                else
                {
                    if(currentNode.LeftNode == null)
                    {
                        currentNode.LeftNode = new TreeNode<T>(item);
                        return top;
                    }
                    return InsertRecursively(item, currentNode.LeftNode);
                }
            }
        }
        public TreeNode<T> SearchRecursively(T item, TreeNode<T> currentNode = null)
        {
            if (currentNode == null)
            {
                return SearchRecursively(item, top);
            }
            else
            {
                if (item.CompareTo(currentNode.Item) > 0)
                {
                    if (currentNode.Item.Equals(item))
                    {
                        Console.WriteLine("found it");
                        return top;
                    }
                    return SearchRecursively(item, currentNode.RightNode);
                }
                else
                {
                    if (currentNode.Item.Equals(item))
                    {
                        Console.WriteLine("found it");
                        return top;
                    }
                    return SearchRecursively(item, currentNode.LeftNode);
                }
            }
        }




        int counter = 0;
        public void PreOrder()
=======

        public void Delete(T key)
>>>>>>> 9c4ac863231b67ca30a2d7a15d655bbe2ada0837
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
