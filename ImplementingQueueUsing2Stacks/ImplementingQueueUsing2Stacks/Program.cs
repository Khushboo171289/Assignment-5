using System;
using System.Collections.Generic;

namespace ImplementingQueueUsing2Stacks
{
    class Program
    {       
        static void Main(string[] args)
        {

            Queue MyQueue = new Queue();
            MyQueue.Enqueue(1);
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(3);
            MyQueue.Enqueue(4);
            MyQueue.Dequeue();
            MyQueue.Peek();
            MyQueue.Dequeue();
            Console.WriteLine($"Size of the queue is {MyQueue.size}");
            MyQueue.Enqueue(5);
            MyQueue.Enqueue(6);
            MyQueue.Dequeue();
            MyQueue.Enqueue(7);
            MyQueue.Peek();
            Console.WriteLine($"Size of the queue is {MyQueue.size}");
            Console.ReadLine();



        }

    }
}
