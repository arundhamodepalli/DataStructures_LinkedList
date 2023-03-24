using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    class LinkedList
    {
        Node head;

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
        }

        public void PrintList()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }

            Console.WriteLine();
        }

        internal void Add(int v)
        {
            throw new NotImplementedException();
        }

        internal void popLast()
        {
            throw new NotImplementedException();
        }
    }
}

