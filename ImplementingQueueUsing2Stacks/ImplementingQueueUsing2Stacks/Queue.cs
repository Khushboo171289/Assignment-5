using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ImplementingQueueUsing2Stacks
{
    public class Queue
    {
        Stack<int> inputStack;
        Stack<int> outputStack;
        public int size = 0;

        public Queue()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        public void Enqueue(int data)
        {
            inputStack.Push(data);
            Console.WriteLine($"{data} is added in Queue ");
            size++;
        }

        public bool IsEmpty()
        {
            return outputStack.Count == 0 && inputStack.Count == 0;            
        }

        public int Dequeue()
        {
            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }

                int t = outputStack.Pop();
                size--;
                Console.WriteLine($"An item {t} is removed from Queue");
                return t;
            }

            if (outputStack.Count!= 0)
            {
                int t = outputStack.Pop();
                size--;
                Console.WriteLine($"An item {t} is removed from Queue");
                return t;
            }

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");                
            }
            return -1;

        }

        public int Peek()
        {

            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
                Console.WriteLine($"Current first item in Queue is {outputStack.Peek()} ");
                return outputStack.Peek();
            }

            if (outputStack.Count != 0)
            {
                Console.WriteLine($"Current first item in Queue is {outputStack.Peek()} ");
                return outputStack.Peek();
            }

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            return -1;
           
        }
    }
}
