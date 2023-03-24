using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_LinkedList
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList<T>
    {
        private LinkedListNode<T> head;

        public void Add(T value)
        {
            var node = new LinkedListNode<T> { Value = value };
            if (head == null)
            {
                head = node;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public T Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }

            var value = head.Value;
            head = head.Next;
            return value;
        }
    }
}
