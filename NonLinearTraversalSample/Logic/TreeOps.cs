using NonLinearTraversalSample.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearTraversalSample.Logic
{
    class TreeOps<T>
    {
        // following pre-order technique to read items [root-left-right]
        public async Task DFS(BinaryTreeNode<T> root)
        {
            await Task.Run(() =>
            {
                var stack = new Stack<BinaryTreeNode<T>>();
                stack.Push(root);

                while (stack.Count != 0)
                {
                    var node = stack.Pop();
                    Console.WriteLine(node.Data);

                    if (node.Right != null)
                    {
                        stack.Push(node.Right);
                    }
                    if (node.Left != null)
                    {
                        stack.Push(node.Left);
                    }
                }
            }).ConfigureAwait(false);

            return;
        }

        public async Task BFS(BinaryTreeNode<T> root)
        {
            await Task.Run(() =>
            {
                var queue = new Queue<BinaryTreeNode<T>>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    var node = queue.Dequeue();
                    Console.WriteLine(node.Data);

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
            }).ConfigureAwait(false);

            return;
        }
    }
}
