using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidTree
{
    class TreeNode <T> where T : IComparable<T>
    {
        public T Item;
        public TreeNode<T> LeftNode;
        public TreeNode<T> RightNode;

        public TreeNode(T item, TreeNode<T> leftNode = null, TreeNode<T> rightNode = null)
        {
            Item = item;
            LeftNode = leftNode;
            RightNode = rightNode;
        }

        public bool hasChildren()
        {
            if(LeftNode == null && RightNode == null)
            {
                return false;
            }
            return true;
        }
    }
}
