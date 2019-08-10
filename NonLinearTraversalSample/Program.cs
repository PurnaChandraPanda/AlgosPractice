using NonLinearTraversalSample.Logic;
using NonLinearTraversalSample.Models;
using System;
using System.Threading.Tasks;

namespace NonLinearTraversalSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var root = await PrepareTree(null);

            Console.WriteLine("********DFS*********");
            await new TreeOps<int>().DFS(root);

            Console.WriteLine("********BFS*********");
            await new TreeOps<int>().BFS(root);

            Console.ReadLine();
        }

        static async Task<BinaryTreeNode<int>> PrepareTree(BinaryTreeNode<int> binaryTreeNode)
        {
            binaryTreeNode = new BinaryTreeNode<int>(9);
            binaryTreeNode.Left = new BinaryTreeNode<int>(7);
            binaryTreeNode.Right = new BinaryTreeNode<int>(3);
            binaryTreeNode.Left.Left = new BinaryTreeNode<int>(5);
            binaryTreeNode.Left.Right = new BinaryTreeNode<int>(1);
            binaryTreeNode.Right.Left = new BinaryTreeNode<int>(2);
            binaryTreeNode.Right.Right = new BinaryTreeNode<int>(4);

            // use Task.FromResult to convert sync code to async
            return await Task.FromResult<BinaryTreeNode<int>>(binaryTreeNode);            
        }
    }
}
