using System;

namespace Assignment04
{
    class Queue1: IBasicFunctionality
    {
        int Front = -1, Rear = -1;
        static int Max = 5;
        int[] MyQueue = new int[5];
        public void Push(int NewEntry) //Insert into Queue
        {
            if (Rear == -1 && Front == -1)
                Front++;

            if (Rear != Max - 1)
            {
                if (Rear == -1 && Front == -1)
                    Front++;

                MyQueue[++Rear] = NewEntry;
            }
            else
                Console.WriteLine("Queue is full \n");
        }
        public void Pop() //Remove from queue
        {
            if (Front > Rear)
                Console.WriteLine("Queue Overflow \n");
            else if (Front == -1)
                Console.WriteLine("Queue empty");
            else
            {
                int removedElement = MyQueue[Front];
                Front++;
            }
        }
        public void Display()
        {
            for (int i = Front; i < Rear+1; i++)
                Console.Write("{0} ", MyQueue[i]);
        }
        public void Sort()
        {
            int tempValue;
            for (int i = Front; i <= Rear ; i++)
            {
                for (int j = Front+1; j <= Rear; j++)
                {
                    if (MyQueue[j - 1] > MyQueue[j])
                    {
                        tempValue = MyQueue[j-1];
                        MyQueue[j - 1] = MyQueue[j];
                        MyQueue[j] = tempValue;
                    }
                }
            }
        }

        public int Peep()
        {
            return MyQueue[Front];
        }
        public void isEmpty()
        {
            if (Front == -1 && Rear == -1) Console.WriteLine("Queue Underflow \n");

            else if (Front > Rear) Console.WriteLine("Queue Overflow \n");
            else Console.WriteLine("Queue is not empty \n");
        }
        public void isFull()
        {
            if (Rear == Max - 1) Console.WriteLine("Queue is full \n");
            else Console.WriteLine("Queue is not full \n");
        }
    }
}
