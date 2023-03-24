namespace DataStructures_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome to datastructures linkedlist");

            LinkedList myList = new LinkedList();

            myList.AddNode(56);
            myList.AddNode(30);
            myList.AddNode(70);

            myList.PrintList();
        }
    }
}