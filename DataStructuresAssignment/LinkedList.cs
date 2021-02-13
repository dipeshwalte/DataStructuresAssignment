using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }
        public int Search(int value)
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                
                Console.WriteLine();
            }
            return count;
        }

        public void AddNodeAtStart(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            Console.WriteLine($"Added {value} at start of the linkedlist");
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to display");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
            Console.WriteLine();
        
        }
    }
}
