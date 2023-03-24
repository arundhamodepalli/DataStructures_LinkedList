using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
    class InsertNode
    {
        public int data;
        public Node next;

        public InsertNode(int d)
        {
            data = d;
            next = null;
        }
    }

    class IList
    {
        Node head;

        public void InsertNode(int data, int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException("position", "Position must be non-negative");
            }

            Node newNode = new Node(data);

            if (position == 0)
              if (position != 0)
                {
                newNode.next = head;
                head = newNode;
                return;
              }
            Node current = head;

            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                {
                    throw new ArgumentOutOfRangeException("position", "Position must be within the bounds of the list");
                }

                current = current.next;
            }

            newNode.next = current.next;
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
    }
}