using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments6._2
{
    class ArrayStack
    {
        private int[] data;
        private int top;
        public ArrayStack(int size)
        {
            this.data = new int[size];
            this.top = -1;
        }
        public ArrayStack(int size, int[] arrayIntake)
        {
            this.data = new int[size];
            this.top = -1;
            int arrayLen = arrayIntake.Length;
            for (int i = 0; i <= arrayLen - 1; i++)
            {
                Push(arrayIntake[i]);
            } 
        }
        public bool isEmpty()
        {
            return this.top == -1;
        }
        public bool isFull()
        {
            if(this.top == data.Length - 1)
            {
                Console.WriteLine("Stack is already full!!");
                return true;
            }
            return false;
        }
        public void Push(int val)
        {
            if (isFull()) {
                return;
            }
            else
            {
                top++;
                data[top] = val;
            }
        }
        public int Pop()
        {
            if (isEmpty())
            {
                return -1;
            }
            int val = data[top];
            top--;
            return val;
        }
        public void Display()
        {
            if (!isEmpty())
            {
                for(int i=top; i>=0; i--)
                {
                    Console.WriteLine(data[i]);
                }
            }
            else {
                Console.WriteLine("There ios nothing to Display!!");
            }
        }
        public int Peek()
        {
            if (!isEmpty()){ Console.WriteLine(data[top]); return data[top]; }
            return -1;
        }
    }
}


