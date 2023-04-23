using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListOperations
    {
        private Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        public override string ToString()
        {
            if (head == null)
            {

                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }
        public bool Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        public void InsertMiddle(int data, int key,int key2)
        {
            Node t = head;
            Node n = new Node(data);
            while (t != null)
            {
                if (t.data.Equals(key) && t.next.data.Equals(key2))
                {
                    n.next = t.next;
                    t.next = n;
                }
                t = t.next;
            }
        }
        public bool Search(int data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }

    }
}
