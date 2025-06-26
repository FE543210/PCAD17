using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._2
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public Node(int data, Node next = null, Node prev = null)
        {
            this.Data = data;
            this.Next = next;
            this.Prev = prev;
        }
    }
    public class LList
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
                newNode.Next = this.head;
                this.head = newNode;
            }
            size++;
        }
        public Node GetHead()
        {
            return this.head;
        }
        public void Display(Node node)
        {
            Node temp = head;
            if (IsEmpty()) { Console.WriteLine("List is empty!!"); }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }
        public Node RemoveELements(Node head, int val)
        {
            Node placeholder = new Node(0);
            placeholder.Next = head;

            Node prev = placeholder;
            Node current = head;
            while (current != null)
            {
                if (current.Data == val)
                {
                    prev.Next = current.Next;
                }
                else
                {
                    prev = current;
                }
                current = current.Next;
            }
            return placeholder.Next;
        }
    }
}