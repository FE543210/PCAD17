using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6._1
{
    class Node
    {
        public int HouseNumber { get; set; }//data
        public string HouseAdress { get; set; }//data
        public string HouseType { get; set; }//data
        public Node next;// adress /ref / link of next node
        // Node newnode = new Node(num, adress, type, null)
        public Node(int num, string adress, string type, Node next)
        {
            this.HouseNumber = num;
            this.HouseAdress = adress;
            this.HouseType = type;
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
        public void AddFirst(int num, string adress, string type)
        {
            Node newNode = new Node(num, adress, type, null);
            if (this.IsEmpty())//Only executes if the list is empty, so new node ius the only one in the list, so head and tail both will point to the same node!
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else//List is not empty
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
                    Console.WriteLine(temp.HouseNumber);
                    Console.WriteLine(temp.HouseAdress);
                    Console.WriteLine(temp.HouseType + "\n");
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
                if (temp.HouseNumber == val)
                {
                    Console.WriteLine($"House found at index {i}");
                    return;
                }
                temp = temp.next;
                i++;
            }
            Console.WriteLine("House Not Found");
        }
    }
}
    


