using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigments12._1
{
    public class Node
    {
        public int Data;
        public Node next;
        public Node prev;
        public Node(int data, Node next, Node prev)
        {
            this.Data = data;
            this.next = next;
            this.prev = prev;
        }
    }
    class LList
    {
        private Node head;
        private Node tail;
        private int size;
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
        public void AddFirst(int data)
        {
            Node newNode = new Node(data, null, null);
            if (IsEmpty())
            {
                this.head = this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head.prev = newNode;
                this.head = newNode;
            }
            size++;
        }
        public bool IsPalindrome()
        {
            if (IsEmpty() || this.size == 1) return true;
            Node left = this.head;
            Node right = this.tail;

            while (left != right && left.prev != right)
            {
                if (left.Data != right.Data)
                {
                    return false;
                }

                left = left.next;
                right = right.prev;
            }
            return true;
        }
    }

}
