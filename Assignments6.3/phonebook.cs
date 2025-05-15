using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6._3
{
    class PhoneNode
    {
        public string phoneNumber; //Using string since sometimes user can input -,(,).
        public PhoneNode next;
        public PhoneNode(string val, PhoneNode next) {
            this.phoneNumber = val;
            this.next = next;
        }
    }
    class Q
    {
        PhoneNode front;//Head
        PhoneNode rear; //tail
        int size;
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void Enqueu(string val)//AddLast() O(1)
        {
            PhoneNode newNode = new PhoneNode(val, null);
            if (IsEmpty())
            {
                front = newNode;
            }
            else
            {
                rear.next = newNode;
            }
            rear = newNode;
            size++;

        }
        public string? Deque()
        {   
            if (IsEmpty())
            {
                Console.WriteLine("Nothing to Deque");
                return null;
            }
            string val = front.phoneNumber;
            front = front.next;
            size--;
            if (IsEmpty())
            {
                rear = null;
            }
            return val;
        }
        public void Display()
        {
            if (IsEmpty()) { Console.WriteLine("Nothing to Display!!"); return; }
            PhoneNode temp = front;
            while(temp != null)
            {
                Console.WriteLine(temp.phoneNumber + " ");
                temp = temp.next;
            }
            Console.WriteLine("--------------");
        }
    }
}
