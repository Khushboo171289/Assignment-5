using System;

namespace ImplementStackUsing2Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack = new Stack();

            MyStack.Push(1);
            MyStack.Push(2);
            MyStack.Push(3);
            MyStack.Peek();
            Console.WriteLine($"Stack size is {MyStack.Size()}");
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Push(4);
            Console.WriteLine($"Stack size is {MyStack.Size()}");
            MyStack.Peek();
            Console.ReadLine();

        }
    }
}
