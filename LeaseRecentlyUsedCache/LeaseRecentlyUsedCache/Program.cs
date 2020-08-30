using System;

namespace LeaseRecentlyUsedCache
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache MyCache = new LRUCache(2);
            MyCache.set(1, 1);
            MyCache.set(2, 2);            
            Console.WriteLine(MyCache.get(1));
            MyCache.set(3, 3);
            Console.WriteLine(MyCache.get(3));
            MyCache.set(4, 4);
            Console.WriteLine(MyCache.get(2));
            MyCache.set(5, 5);
            Console.WriteLine(MyCache.get(1));
            Console.ReadLine();

        }
    }
}
