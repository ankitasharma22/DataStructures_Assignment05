using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Stack1: IBasicFunctionality
    {
        int Top = -1;
        static int Max = 5;
        int[] MyStack = new int[5];
        public void Push(int newEntry)
        {
            if (Top == Max - 1) //Stack reached limit
                Console.WriteLine("Stack overflow \n");
            else
            {
                Top++; //point to the next position and put value in there
                MyStack[Top] = newEntry;
            }

        }
        public void Pop()
        {
            int deleteEntry = 0;
            if (Top == -1)
                Console.WriteLine("Stack underflow \n");
            else
            {
                deleteEntry = MyStack[Top];
                MyStack[Top] = 0;
                Top--;
            }
        }

        public void Display()
        {
            for(int i = Top;i>=0;i--)
                Console.Write(" "+MyStack[i]);
        }

        public void Sort()
        {
            int tempValue;
            for (int i = 0; i <= Top ; i++)
            {
                for (int j = 1; j <= Top; j++)
                {
                    if (MyStack[j - 1] > MyStack[j])
                    {
                        tempValue = MyStack[j - 1];
                        MyStack[j - 1] = MyStack[j];
                        MyStack[j] = tempValue;
                    }
                }
            }
        }
    }
}
