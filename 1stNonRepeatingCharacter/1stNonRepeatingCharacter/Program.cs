using System;
using System.Collections.Generic;

namespace _1stNonRepeatingCharacter
{
    class Program
    {
        public static void NonRepeatingChar(char[] a)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            Queue<char> Q = new Queue<char>();

            for (int i = 0; i < a.Length; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]]++;
                }else
                {
                    map.Add(a[i], 1);
                    Q.Enqueue(a[i]);
                }

                while(Q.Count > 0)
                {
                    if (map[Q.Peek()] == 1)
                    {
                        Console.WriteLine($"{a[i]} goes to stream : 1st non repeating element {Q.Peek()}");
                        //Console.WriteLine(Q.Peek());
                        break;
                    }
                    else
                    {
                        Q.Dequeue();
                    }
                }
                
                if (Q.Count == 0)
                {
                    Console.WriteLine($"{a[i]} goes to stream : no non repeating element -1");
                    //Console.WriteLine(-1);
                }
            }
        }

        static void Main(string[] args)
        {
            char[] charStearm;
            charStearm = new char[] { 'a', 'a', 'b', 'c' };
            for (int i = 0; i < charStearm.Length; i++)
            {
                Console.Write($"{charStearm[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine("For the above given stream of characters , the first non repeating char after adding each char is as: ");
            Console.WriteLine();
            NonRepeatingChar(charStearm);
            Console.ReadLine();
        }
    }
}
