using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureImplementationCSharp
{
    class LinkedListOperation
    {
        public static Node head = null;
        public Node tail = null;
        public static void AddAtBegin(int n)
        {
            Node newNode = new Node(n);
            newNode.next = head;
            head = newNode;

            //if(head == null)
            //{
            //    head = newNode;
            //    head.next = null;
            //}
            //else
            //{
            //    newNode.next = head;
            //    head = newNode;
            //}
        }

        public static void DeleteAtBegin()
        {
            if (head != null)
            {
                head = head.next;
            }

        }

        public static void DeleteAtEnd()
        {
            while (head.next != null)
            {
                head = head.next;
            }


        }

        public static void AddAtEnd(int n)
        {
            Node newNode = new Node(n);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;

        }
        public static void AddAtIndex(int index, int n)
        {
            Node newNode = new Node(n);
            int i = 1;
            Node temp = head;
            while (temp.next != null)
            {
                if (i == index - 1)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                temp = temp.next;
                i++;
            }

        }
        public static void Insert(int index, int data)
        {
            Node newNode = new Node(data);
            if (index == 1)
            {
                newNode.next = head;
                head = newNode;
                return;

            }
            Node temp = head;
            for (int i = 0; i < index - 2; i++)
            {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;


        }
        public static void Print()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.Write(temp.data);
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
