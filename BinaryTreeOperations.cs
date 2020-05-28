using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataStructureImplementationCSharp
{
   public  class BinaryTreeOperations
    {
      public  BSTNode root = null;

        /// <summary>
        /// Adding a Node in BST.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public  static BSTNode AddNode(BSTNode root, int n)
        {
            BSTNode newNode = new BSTNode(n);
            if(root == null)
            {
                root = newNode;
                return root;
            }
            else if(n <= root.data)
            { 
             root.leftNode= AddNode(root.leftNode, n);
            }
            else
            {
              root.rightNode =  AddNode(root.rightNode, n);
            }
            return root;
        }
        /// <summary>
        /// Traverse the root Left 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public  int Min(BSTNode root)
        {
            if(root == null)
            {
                return -1;
            }
            while(root.leftNode != null)
                {
                root = root.leftNode;
             
                }
            return root.data;
        }
        public int Max(BSTNode root)
        {
            if (root == null)
            {
                return -1;
            }
            while (root.rightNode != null)
            {
                root = root.rightNode;

            }
            return root.data;
        }
    }

    public class BSTNode
    {
      public  int data;
      public  BSTNode leftNode;
      public  BSTNode rightNode;

        public BSTNode(int data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
