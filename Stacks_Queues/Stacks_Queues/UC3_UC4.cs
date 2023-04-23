﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stacks_Queues.Program;

namespace Stacks_Queues
{
    internal class UC3
    {
        private Node front;
        private Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }
        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            int data = front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }

    }
}
