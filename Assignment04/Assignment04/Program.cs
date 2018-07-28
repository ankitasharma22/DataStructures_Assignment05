using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----ASSIGNMENT 04----");
            Console.WriteLine("Choose the data structure you wish to use");
            Console.WriteLine(" 1. Stack 2. Queue 3. Singly Linked List");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Stack1 StackObject = new Stack1();
                    Console.WriteLine("____STACK____");
                    Console.WriteLine(" Enter the operation you want to perform on stack");
                    int stackChoice = 0;
                    do
                    {
                        Console.WriteLine(" 1. Push 2. Pop 3. Display 4. Sort 5. Exit");
                        stackChoice = Convert.ToInt32(Console.ReadLine());
                        switch (stackChoice)
                        {
                            case 1:
                                Console.WriteLine(" Enter the number you want to push onto the stack ");
                                int input = Convert.ToInt32(Console.ReadLine());
                                StackObject.Push(input);
                                break;
                            case 2:
                                StackObject.Pop();
                                break;
                            case 3:
                                StackObject.Display();
                                break;
                            case 4:
                                StackObject.Sort();
                                break;
                            default:
                                Console.WriteLine(" You have entered invalid choice. Please try again! ");
                                break;
                        }
                    } while (stackChoice!=5);
                    break;

                case 2:
                    Queue1 QueueObject = new Queue1();
                    Console.WriteLine("____QUEUE___");
                    Console.WriteLine(" Enter the operation you want to perform on queue ");
                    int queueChoice = 0;
                    do
                    {
                        Console.WriteLine(" 1. Insert 2. Delete 3. Display 4. Sort 5. Peek 6. Check if Empty 7. Check if Full 8. Exit ");
                        Console.WriteLine();
                        queueChoice = Convert.ToInt32(Console.ReadLine());
                        switch (queueChoice)
                        {
                            case 1:
                                Console.WriteLine(" Enter the number you want to insert onto the queue ");
                                int input = Convert.ToInt32(Console.ReadLine());
                                QueueObject.Push(input);
                                break;
                            case 2:
                                QueueObject.Pop();
                                break;
                            case 3:
                                QueueObject.Display();
                                break;
                            case 4:
                                QueueObject.Sort();
                                break;
                            case 5:
                                int peep = QueueObject.Peep();
                                Console.WriteLine(" Element at front of queue "+peep);
                                break;
                            case 6:
                                QueueObject.isEmpty();
                                break;
                            case 7:
                                QueueObject.isFull();
                                break;
                            default:
                                Console.WriteLine("You have entered invalid choice. Please try again! ");
                                break;
                        }
                    } while (queueChoice != 8
                    );
                    break;
                case 3:
                    LinkedList1 LinkedListObject = new LinkedList1();
                    Console.WriteLine("____SINGLY LINKED LIST____");
                    Console.WriteLine("Enter the operation you want to perform on the linked list");
                    int LLChoice = 0;
                    do
                    {
                        Console.WriteLine(" 1. Add Element At Start 2. Add Element at End 3. Remove Element from beginning 4. Display All the elements 5. Sort 6. Exit ");
                        LLChoice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                                                switch (LLChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter the number you want to add at beginning ");
                                int input1 = Convert.ToInt32(Console.ReadLine());
                                LinkedListObject.AddElementAtStart(input1);
                                break;
                            case 2:
                                Console.WriteLine("Enter the number you want to add at the end ");
                                int input2 = Convert.ToInt32(Console.ReadLine());
                                LinkedListObject.AddElementAtStart(input2);
                                break;
                            case 3:
                                LinkedListObject.RemoveElementFromStart();
                                break;
                            case 4:
                                LinkedListObject.Display();
                                break;
                            case 5:
                                LinkedListObject.Sort();
                                break;
                            default:
                                Console.WriteLine("You have entered invalid choice. Please try again! ");
                                break;
                        }
                    } while (LLChoice != 6);
                    break;
            }
            Console.ReadKey();
        }
    }




    
}
