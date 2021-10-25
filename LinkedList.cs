﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList
{ 
    public class LinkedList
    {
        internal Node head;                        //defined head position
        internal void Add(int data)
        {
            Node newNode = new Node(data);         //defining and creating object of node class ,pushing data to node class
            newNode.next = this.head;
            this.head = newNode;
        }
        internal void Display()                    //display the linklist data
        {
            Console.WriteLine("\ndisplay linklist element is: ");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }

        }

    }
}