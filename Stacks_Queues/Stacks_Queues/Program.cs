namespace Stacks_Queues
{
    internal class Program
    {
        //creating a node of LinkedList
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        static void Main(string[] args)
        {
           //UseCase 1
            Stack1 obj = new Stack1();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);


            //UseCase 2
            while (!obj.IsEmpty())
            {
                Console.WriteLine(obj.Pop());
            }

        }
    }
}