using System;

namespace DataStructuresAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            LinkedList staticlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            staticlinkedList.head = node56;
            staticlinkedList.Display();


        }
    }
}
