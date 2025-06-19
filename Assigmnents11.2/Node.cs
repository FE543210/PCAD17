using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment11._2
{
    class Node
    {
        public int number { get; set; }//data
        public Node next;
        
        public Node(int num, Node next)
        {
            this.number = num;
            this.next = next;
        }
    }
    class LList
    {
        private Node head;
        private Node tail;
        private int size;//Devs choice
        public int Size
        {
            get { return this.size; }
        }
        public LList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;

        }
        public void AddFirst(int num)
        {
            Node newNode = new Node(num, null);
            if (this.IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
            size++;
        }
        public void Display()
        {
            Node temp = head;
            if (IsEmpty()) { Console.WriteLine("List is empty!!"); }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.number);
                    temp = temp.next;
                }
            }
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!!");
            }
            else
            {
                head = head.next;
                this.size--;
                if (IsEmpty()) { tail = null; }
            }
        }
        public void Search(int val)
        {
            Node temp = head;
            int i = 1;
            while (temp != null)
            {
                if (temp.number == val)
                {
                    Console.WriteLine($"Number found at index {i}");
                    return;
                }
                temp = temp.next;
                i++;
            }
            Console.WriteLine("Number Not Found");
        }
        public void Reverse()
        {
            Node prev = null;
            Node current = this.head;
            Node next = null;
            this.tail = head;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            this.head = prev;
        }

    }
}
