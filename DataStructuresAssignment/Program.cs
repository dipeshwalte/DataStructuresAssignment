using System;

namespace DataStructuresAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            Console.WriteLine("Static Linked List:");
            LinkedList staticlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            staticlinkedList.head = node56;
            staticlinkedList.Display();

            //UC2
            Console.WriteLine("Add Node At Start Demo");
            LinkedList linkedListForStartDemo = new LinkedList();
            linkedListForStartDemo.AddNodeAtStart(70);
            linkedListForStartDemo.AddNodeAtStart(30);
            linkedListForStartDemo.AddNodeAtStart(56);
            linkedListForStartDemo.Display();

            //UC3
            Console.WriteLine("Add Node At End Demo");
            LinkedList linkedListForEndDemo = new LinkedList();
            linkedListForEndDemo.AddNodeAtEnd(56);
            linkedListForEndDemo.AddNodeAtEnd(30);
            linkedListForEndDemo.AddNodeAtEnd(70);
            linkedListForEndDemo.Display();


        }
    }
}
