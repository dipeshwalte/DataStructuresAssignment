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

            //UC4
            Console.WriteLine("Add Node In Between End Demo ");
            LinkedList linkedListForBetweenDemo = new LinkedList();
            linkedListForBetweenDemo.AddNodeAtEnd(56);
            linkedListForBetweenDemo.AddNodeAtEnd(70);
            linkedListForBetweenDemo.AddNodeAfterNode(30,56);
            linkedListForBetweenDemo.Display();

            //UC5
            Console.WriteLine("Delete First element demo");
            linkedListForBetweenDemo.Display();
            linkedListForBetweenDemo.DeleteNodeAtFirst();
            linkedListForBetweenDemo.Display();

            //UC6
            Console.WriteLine("Delete Last element demo");
            linkedListForEndDemo.Display();
            linkedListForEndDemo.DeleteNodeAtLast();
            linkedListForEndDemo.Display();

            //UC7
            Console.WriteLine("Search for Node 30");
            staticlinkedList.Display();
            if (staticlinkedList.Search(30))
            {
                Console.WriteLine("Node found");
            }

            //UC8
            Console.WriteLine("Add Node After Node ");
            LinkedList linkedListForNodeAfterNode = new LinkedList();
            linkedListForNodeAfterNode.AddNodeAtEnd(56);
            linkedListForNodeAfterNode.AddNodeAtEnd(30);
            linkedListForNodeAfterNode.AddNodeAtEnd(70);
            linkedListForNodeAfterNode.AddNodeAfterNode(40, 30);
            linkedListForNodeAfterNode.Display();

            //UC9
            Console.WriteLine("Delete From Middle");
            linkedListForNodeAfterNode.Display();
            linkedListForNodeAfterNode.DeleteNodeWithValue(40);
            linkedListForNodeAfterNode.Display();

            //UC10
            Console.WriteLine("Sorted linked list");
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.AddNode(56);
            sortedLinkedList.AddNode(30); 
            sortedLinkedList.AddNode(40);
            sortedLinkedList.AddNode(70);
            sortedLinkedList.Display();
        }
    }
}
