namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-1,2
            LinkedListOperations obj = new LinkedListOperations();
            obj.Add(70);
            obj.Add(30);
            obj.Add(56);

            //UC-3
            obj.Append(80);
            obj.Add(100);
            string list = obj.ToString();
            Console.WriteLine(list);
        }
    }
}