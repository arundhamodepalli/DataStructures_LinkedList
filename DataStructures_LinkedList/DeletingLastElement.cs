using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
    public class DeletingLastElement
    {
            public class Node
            {
                public int Value;
                public Node Next;

                public Node(int value)
                {
                    Value = value;
                    Next = null;
                }
            }

            public class LinkedList
            {
                private Node head;

                public LinkedList()
                {
                    head = null;
                }

                public void Add(int value)
                {
                    Node newNode = new Node(value);

                    if (head == null)
                    {
                        head = newNode;
                    }
                    else
                    {
                        Node current = head;
                        while (current.Next != null)
                        {
                            current = current.Next;
                        }
                        current.Next = newNode;
                    }
                }

                public void popLast()
                {
                    if (head == null)
                    {
                        return; // the list is empty
                    }

                    if (head.Next == null)
                    {
                        head = null; // there is only one node in the list
                        return;
                    }

                    Node current = head;
                    while (current.Next.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null; // remove the last node
                }

                public override string ToString()
                {
                    Node current = head;
                    string result = "";
                    while (current != null)
                    {
                        result += current.Value + "->";
                        current = current.Next;
                    }
                    return result.TrimEnd('-', '>');
                }
            }

        }
}



