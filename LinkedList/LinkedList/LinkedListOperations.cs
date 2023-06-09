﻿using System;
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
        public bool DeleteData(int input)
        {
            if (head == null)
                return false;
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
                {
                    if (pre == null)
                    {
                        head = t.next;
                        return true;
                    }
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
        }
        public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }
        public void DeleteFirstElement()
        {
            Node t = head;
            if (t == null)
            {
                throw new NullReferenceException("list is empty");
            }
            else
            {
                head = t.next;
            }

        }
        public int Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException("List is Empty");
            }
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            int obj = t.data;
            if (head.next == null)
            {
                head = null;
            }
            p.next = null;
            return obj;
        }

    }
}
