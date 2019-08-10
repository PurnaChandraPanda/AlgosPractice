using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearTraversalSample.Models
{
    class BinaryTreeNode<T>
    {
        public T Data;
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T _data)
        {
            Data = _data;
        }        
    }
}
