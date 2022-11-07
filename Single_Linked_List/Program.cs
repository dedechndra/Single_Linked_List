using System;

namespace Single_Linked_List
{
    // each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;

    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() //add a node in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll name of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
