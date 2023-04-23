namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LinkedListOperations obj = new LinkedListOperations();
            obj.Add(70);
            obj.Add(30);
            obj.Add(56);

            
            obj.Append(80);
            obj.Add(100);

            
            obj.InsertMiddle(95, 30, 70);
            string list = obj.ToString();
            Console.WriteLine(list);
        }
    }
}