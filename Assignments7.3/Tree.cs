using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments7._3
{
    class Node
    {
        public int data;
        public Node rightPointer;
        public Node leftPointer;

        public Node(int data, Node right, Node left)
        {
            this.data = data;
            this.rightPointer = right;
            this.leftPointer = left;
        }
    }
    class BST
    {
        public Node root;
        public BST()
        {
            root = null;
        }
        public void InsertNode(Node temptRoot, int val)
        {
            Node newNode = new Node(val, null, null);
            Node temp = null;
            if(root != null)
            {
                while (temptRoot!= null)
                {
                    temp = temptRoot;
                    if(temptRoot.data == val)
                    {
                        return;
                    }else if(val < temptRoot.data)
                    {
                        temptRoot = temptRoot.leftPointer;
                    }
                    else if(val >temptRoot.data)
                    {
                        temptRoot = temptRoot.rightPointer;
                    }
                   
                }
                if (val < temp.data)
                {
                    temp.leftPointer = newNode;
                }
                else if(val > temp.data)
                {
                    temp.rightPointer = newNode;
                }
            }
            else
            {
                root = newNode;
            }
        }
        public void Inorder(Node temptroot)
        {
            if(temptroot!= null)
            {
                Inorder(temptroot.leftPointer);
                Console.WriteLine(temptroot.data);
                Inorder(temptroot.rightPointer);
            }
        }
        public Node Search(Node temptRoot, int val)
        {
            while (temptRoot != null)
            {

                if (temptRoot.data == val)
                {
                    return temptRoot;
                }
                else if (val < temptRoot.data)
                {
                    temptRoot = temptRoot.leftPointer;
                }
                else if (val > temptRoot.data)
                {
                    temptRoot = temptRoot.rightPointer;
                }
            }
            return null;
        }
    }
}
