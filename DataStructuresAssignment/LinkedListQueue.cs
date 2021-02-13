using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class LinkedListQueue
    {
        Node head;
        public void Enqueue(int item) 
        {
            Node newNode = new Node(item);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("Inserted into List :"+ newNode.data);
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("Removed from queue :" +temp.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data);
                    temp = temp.next;
                }
            }
        
        }
    }
}
