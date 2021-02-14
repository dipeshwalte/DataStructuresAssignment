using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }
        public bool Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
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

        public void AddNodeAtEnd(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
              
            }
            Console.WriteLine($"Added {value} at end of the linkedlist");
        }

        public void AddNodeAfterNode(int nodeValue,int addAfterThisValue)
        {
            Node newNode = new Node(nodeValue);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.data != addAfterThisValue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;

            }
            Console.WriteLine($"Added {nodeValue} at in between");
        }

        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }

        public void DeleteNodeAtLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing To Delete");
                return;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }

        public void DeleteNodeWithValue(int value)
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            Node prev = this.head;
            Node pointsToValue = this.head;
            while (pointsToValue.data != value)
            {
                if (pointsToValue == null)
                {
                    break;
                }
                pointsToValue = pointsToValue.next;
            }
            while (prev.next.data != value)
            {
                if (prev == null)
                {
                    break;
                }
                prev = prev.next;
            }
            prev.next = pointsToValue.next;

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
