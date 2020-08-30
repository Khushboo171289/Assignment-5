using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStackUsing2Queues
{
    public class Stack
    {
        Queue<int> Q1;
        Queue<int> Q2;
        public int size = 0;

        public Stack()
        {
            Q1 = new Queue<int>();
            Q2 = new Queue<int>();
            size = 0;
        }

        public void Push(int data)
        {
            while (Q1.Count != 0)
            {
                int temp = Q1.Dequeue();
                Q2.Enqueue(temp);
            }

            Q1.Enqueue(data);
            Console.WriteLine($"{data} is pushed in the stack");
            size++;
            while (Q2.Count != 0)
            {
                int temp = Q2.Dequeue();
                Q1.Enqueue(temp);
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }else
            {
                int temp = Q1.Dequeue();
                size--;
                Console.WriteLine($"{temp} is poped out of the stack");
                return temp;
            }            
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int temp = Q1.Peek();                
                Console.WriteLine($"{temp} is the top item of stack");
                return temp;
            }
        }

        public bool IsEmpty()
        {
            return Q1.Count == 0 && Q2.Count == 0; 
        }

        public int Size()
        {
            return size;
        }
    }
}
