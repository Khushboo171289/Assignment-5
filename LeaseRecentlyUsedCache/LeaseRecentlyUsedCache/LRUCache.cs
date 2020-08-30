using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace LeaseRecentlyUsedCache
{
    public class LRUCache
    {
        int cache_Capacity = 0;
        Node head = new Node();
        Node tail = new Node();
        Dictionary<int, Node> Map_Node;

        public LRUCache(int capacity)
        {
            Map_Node = new Dictionary<int, Node>();
            this.cache_Capacity = capacity;
            head.next = tail;
            tail.prev = head;
        }

        public int get(int x)
        {
            int result = -1;
           // Node node = Map_Node[x];
            if (Map_Node.ContainsKey(x))
            {
                Node node = Map_Node[x];
                result = node.value;
                RemoveNode(node);
                AddNode(node);
            }
            return result;
        }

        public void set(int x, int y)
        {
            //Node node = Map_Node[x];
            if (Map_Node.ContainsKey(x))
            {
                Node node = Map_Node[x];
                node.value = y;
                RemoveNode(node);
                AddNode(node);
            }
            else
            {
                if (Map_Node.Count == cache_Capacity)
                {
                    Map_Node.Remove(tail.prev.key);
                    RemoveNode(tail.prev);
                }

                Node new_node = new Node();
                new_node.key = x;
                new_node.value = y;
                Map_Node.Add(x, new_node);
                AddNode(new_node);

            }
        }

        private void AddNode(Node node)
        {
            Node temp = head.next;
            node.next = head.next;
            temp.prev = node;
            head.next = node;
            node.prev = head;
        }

        private void RemoveNode(Node node)
        {
            Node toRemove_next = node.next;
            Node toRemove_prev = node.prev;
            toRemove_next.prev = toRemove_prev;
            toRemove_prev.next = toRemove_next;
        }
    }
}
