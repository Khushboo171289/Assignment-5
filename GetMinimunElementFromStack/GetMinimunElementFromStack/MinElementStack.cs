using System;
using System.Collections.Generic;
using System.Text;

namespace GetMinimunElementFromStack
{
    public class MinElementStack
    {
        Stack<int> S1;
        int size = 0;
        int minElement = 0;
        public MinElementStack()
        {
            S1 = new Stack<int>();
        }

        public void Push(int data)
        {
            if (S1.Count == 0)
            {
                S1.Push(data);
                size++;
                minElement = data;
                Console.WriteLine($"Element pushed in the stack : {data}");
                return;
            }
            
            if (data < minElement)
            {
                S1.Push(2 * data - minElement);
                minElement = data;
                size++;
                Console.WriteLine($"Element pushed in the stack : {data}");
            }
            else
            {
                S1.Push(data);
                size++;
                Console.WriteLine($"Element pushed in the stack : {data}");
            }
           
        }

        public void Pop()
        {
            if (S1.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine($"Top Element popped");
            int temp = S1.Pop();
            size--;
            if (temp < minElement)
            {
                Console.WriteLine(minElement);
                minElement = minElement * 2 - temp;
            }
            else
            {
                Console.WriteLine(temp);
            }
            
        }

        public void getMin()
        {
            if (S1.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Console.WriteLine($"Minimum element in the stack is {minElement}");
            }
        }

        public int getSize()
        {
            return size;
        }

    }
}
