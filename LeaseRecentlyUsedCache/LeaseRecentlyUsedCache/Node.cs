using System;
using System.Collections.Generic;
using System.Text;

namespace LeaseRecentlyUsedCache
{
    public class Node
    {
        public int key;
        public int value;
        public Node prev;
        public Node next;
    }
}
