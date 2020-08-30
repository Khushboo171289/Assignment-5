using System;
using System.Collections.Generic;

namespace GetMinimunElementFromStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinElementStack MyStack = new MinElementStack();
            MyStack.Push(5);
            MyStack.Push(7);

            MyStack.getMin();

            MyStack.Push(2);
            MyStack.Push(1);

            MyStack.getMin();
            MyStack.Pop();

            MyStack.getMin();
            MyStack.Pop();
            //Console.WriteLine($"Stack size is : {MyStack.getSize()}");
            //MyStack.getMin();
            //MyStack.Pop();
            // 5, 7, 2, 1
            //MyStack.getMin();
            //MyStack.Pop();

            //MyStack.getMin();
            //Console.WriteLine($"Stack size is : {MyStack.getSize()}");
            Console.ReadLine();

            
        }
    }
}
