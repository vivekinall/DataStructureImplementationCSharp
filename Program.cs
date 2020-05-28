using System;
using DataStructureImplementationCSharp.Graph;

namespace DataStructureImplementationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Add node in Binary Search Tree.");
            //BSTNode root = null;
            //root =BinaryTreeOperations.AddNode(root, 10);
            //root =BinaryTreeOperations.AddNode(root, 5);
            //root =BinaryTreeOperations.AddNode(root, 15);
            //root = BinaryTreeOperations.AddNode(root, 12);
            //root = BinaryTreeOperations.AddNode(root, 25);
            //BinaryTreeOperations ops = new BinaryTreeOperations();            
            //Console.WriteLine("Minimum Value is Tree is : " + ops.Min(root));
            //Console.WriteLine("Maximum Value is Tree is : " + ops.Max(root));

            Console.WriteLine("*********************Adjacency List Graph Representation************************************");
            Console.WriteLine();
            AdjancyListGraph graph = new AdjancyListGraph(5);
            graph.addEdge(0, 1);
            graph.addEdge(0, 4);
            graph.addEdge(1,2);
            graph.addEdge(1,3);
            graph.addEdge(1,4);
            graph.addEdge(2,3);
            graph.addEdge(3,4);
            graph.printAdjacencyList();


            Console.WriteLine();
           
            Console.WriteLine("*********************Adjacency Matrix Graph Representation********************************");
            Console.WriteLine();
            AdjancyMatrixGraph graphMatrix = new AdjancyMatrixGraph(5);
            graphMatrix.addEdge(0, 1);
            graphMatrix.addEdge(0, 4);
            graphMatrix.addEdge(1, 2);
            graphMatrix.addEdge(1, 3);
            graphMatrix.addEdge(1, 4);
            graphMatrix.addEdge(2, 3);
            graphMatrix.addEdge(3, 4);
            graphMatrix.printAdjacencyMatrix();
            Console.ReadKey();



        }
    }
}
