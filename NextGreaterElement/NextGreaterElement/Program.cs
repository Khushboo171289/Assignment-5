using System;
using System.Collections.Generic;

namespace NextGreaterElement
{
    class Program
    {
        public static void FindNextGreaterElement(int[] a, int n)
        {
            Stack<int> s = new Stack<int>();
            s.Push(a[0]);
            for (int i = 1; i < n; i++)
            {
                while (s.Count != 0 && s.Peek() < a[i])
                {
                    Console.WriteLine($"{s.Peek()} ==> {a[i]}");
                    s.Pop();
                }

                if (s.Count != 0)
                {
                    if (s.Peek() > a[i])
                    {
                        s.Push(a[i]);
                    }
                    if (i == n - 1)
                    {
                        while (s.Count > 0)
                        {
                            Console.WriteLine($"{s.Peek()} ==> -1");
                            s.Pop();
                        }
                    }

                }
                else
                    s.Push(a[i]);
            }    
        }
        static void Main(string[] args)
        {
            int[] a;
            a = new int[] { 13, 7, 6, 12 };
            int n = a.Length;
            FindNextGreaterElement(a, n);            
        }
    }
}
