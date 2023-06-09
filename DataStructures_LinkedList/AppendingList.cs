﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
        class AppendingList
        {
            public int data;
            public Node next;

            public AppendingList(int d)
            {
                data = d;
                next = null;
            }
        }

        class AList
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
        }
}

