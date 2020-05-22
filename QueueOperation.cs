using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementationCSharp
{
    class QueueOperation
    {
        public class LinkedListQueueAPI
        {
            Node FirstNode = null;
            Node LastNode = null;
            class Node
            {
                public string item;
                public Node next;
            }
            public bool isEmpty()
            {
                return (FirstNode == null);
            }
            public void enQueue(string data)
            {
                Node oldLastNode = LastNode;
                LastNode = new Node();
                LastNode.item = data;
                LastNode.next = null;

                if (isEmpty())
                {
                    FirstNode = LastNode;
                }
                else
                {
                    oldLastNode.next = LastNode;
                }
            }
            public void deQueue()
            {
                if (isEmpty())
                    throw new Exception("No element in Queue.");
                else
                {
                    string deletedItem = FirstNode.item;
                    FirstNode = FirstNode.next;
                    if (isEmpty())
                    {
                        LastNode = null;
                    }

                }
            }

        }
        public void myMethod()
        {
            //Queue queue = new Queue();
            //queue.Enqueue("ddds");
            //queue.TrimToSize();
            //Stack s = new Stack();
            //s.Push("vvv");
            //s.Pop();
            //s.Clear();
            //s.Peek();


        }
    }
}
