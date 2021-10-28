using System;

namespace Day14_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();      //creating object of linklist class
            list.Insert(56);
            list.Insert(30);
            list.Insert(40);
            list.Insert(70);           
            list.deletePosition(3);
            list.Display();
            Console.ReadLine();

        }
    }
}
