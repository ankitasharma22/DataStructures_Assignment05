using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class LinkedList1
    {

        class Node
        {
            public int Value;
            public Node Next;
        }
        Node Head, Tail; //Head=First Node, Tail = Recent Node
        int NumberOfNodes;

        public LinkedList1()
        {
            //Points to empty node initially
            Head = new Node();
            Tail = Head;
        }

        public void AddElementAtLast(int newNodeValue)
        {
            Node node = new Node();
            node.Value = newNodeValue;
            Tail.Next = node;
            Tail = node;
            NumberOfNodes++;
        }
        public void AddElementAtStart(int newNodeValue)
        {
            Node node = new Node();
            node.Next = this.Head.Next;  //node created
            node.Value = newNodeValue;
            this.Head.Next = node;
            NumberOfNodes++;
        }

        public void RemoveElementFromStart()
        {
            if (NumberOfNodes == 0)
                Console.WriteLine("Linked List is empty \n");
            else
            {
                Head = Head.Next;
                NumberOfNodes--;
            }
        }

        public void Display()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node present = this.Head;
            while (present.Next != null)
            {
                present = present.Next;
                Console.Write(present.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }


        public void Sort()
        {
            Node present = Head;
            int tempValue = 0;
            while (present.Next != null)
            {
                if (present.Value < present.Next.Value)
                {
                    tempValue = present.Value;
                    present.Value = present.Next.Value;
                    present.Next.Value = tempValue;
                }
                present = present.Next;
            }
        }
    }
}
