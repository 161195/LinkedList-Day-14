using System;

namespace Day14_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();      //creating object of linklist class
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            list.Display();
            Console.ReadLine();

        }
    }
}
