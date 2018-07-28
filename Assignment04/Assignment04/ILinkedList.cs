using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    interface ILinkedList
    {
        void AddElementAtLast(int newNodeValue);
        void AddElementAtStart(int newNodeValue);
        void RemoveElementFromStart();
        void Display();
        void Sort();
    }
}
