using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementationCSharp.Graph
{
    //There are two way to Represent the GRAPH
    // 1. Adjacency Matrix
    // 2. Adjacency List 
    //C# Code to demonstrate Graph Represntation Using Adjancy Matrix
    /// <summary>
    /// Adjacency Matrix Implementation
    /// </summary>
    public class AdjancyMatrixGraph
    {
        public int noOfVertices;
        int[,] adjacencyMatrix;
        public AdjancyMatrixGraph(int n)
        {
            this.noOfVertices = n;
            this.adjacencyMatrix = new int[noOfVertices, noOfVertices];
        }

        public  void addEdge(int i, int j)
        {
            this.adjacencyMatrix[i, j] = 1;
            this.adjacencyMatrix[j, i] = 1;
        }
        public  void removeEdge(int i, int j)
        {

        }
        public  void printAdjacencyMatrix()
        {
            for (int i = 0; i < this.adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.adjacencyMatrix.GetLength(1); j++)
                {
                    Console.Write(" " +this.adjacencyMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }


    }
    /// <summary>
    ///  /// <summary>
    /// Adjacency List Implementation.
    /// </summary>
    /// </summary>
    //C# Code to demonstrate Graph Represntation Using Linked list in C#
    public class AdjancyListGraph
    {
        public int noOfVertices;
        public  LinkedList<int>[] adjList;
        public AdjancyListGraph(int n)
        {
            // Adjacency List Approach
            adjList = new LinkedList<int>[n];
            for (int i = 0; i < n; i++)
            {
                adjList[i] = new LinkedList<int>();
            }
        }    
        public  void addEdge(int i, int j)
        {
            adjList[i].AddLast(j);
            adjList[j].AddLast(i);
        }
        public void printAdjacencyList()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                Console.Write("\n Adjacency List of Vertex  " + i);
                foreach (var item in adjList[i])
                {
                    Console.Write(" -> " + item);
                }
                Console.WriteLine();
            }
        }
    }
}
