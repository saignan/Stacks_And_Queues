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
            string list= obj.ToString();
            Console.WriteLine(list);

           
        }
    }
}