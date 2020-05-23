using System;

namespace DataStructureImplementationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Add node in Binary Search Tree.");
            BSTNode root = null;
            root =BinaryTreeOperations.AddNode(root, 10);
            root =BinaryTreeOperations.AddNode(root, 5);
            root =BinaryTreeOperations.AddNode(root, 15);
            root = BinaryTreeOperations.AddNode(root, 12);
            root = BinaryTreeOperations.AddNode(root, 25);
            BinaryTreeOperations ops = new BinaryTreeOperations();            
            Console.WriteLine("Minimum Value is Tree is : " + ops.Min(root));
            Console.WriteLine("Maximum Value is Tree is : " + ops.Max(root));
        }
    }
}
