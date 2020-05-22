using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementationCSharp
{
    class StackOperations
    {
        public class MyStack<T>
        {
            private T dataType;
            public MyStack(T value)
            {
                this.dataType = value;
            }
            public void push(T item)
            {

            }
        }


        //Linked List Stack Representation
        public class LinkedListStackOfString
        {
            Node firstNode = null;
            public class Node
            {
                public string item;
                public Node next;
                //public Node(string data)
                //{
                //    this.item = data;
                //    this.next = null;
                //}
            }

            public bool isEmpty()
            {
                return firstNode == null;
            }
            public void Push(string data)
            {
                if (isEmpty())
                {
                    firstNode = new Node();
                    firstNode.item = data;
                    firstNode.next = null;
                }
                else
                {
                    Node lastNode = firstNode;
                    firstNode = new Node();
                    firstNode.item = data;
                    firstNode.next = lastNode;
                }

            }
            public string Pop()
            {
                if (isEmpty())
                {
                    throw new Exception("Stack is already Empty");
                }
                else
                {
                    string popItem = firstNode.item;
                    firstNode.next = firstNode;
                    return popItem;
                }
            }
            public void Print()
            {
                Node currentNode = firstNode;
                Console.WriteLine("Stack Element are as below:");
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.item);
                    currentNode = currentNode.next;
                }


            }
        }
    }
}
