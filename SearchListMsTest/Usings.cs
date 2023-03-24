global using Microsoft.VisualStudio.TestTools.UnitTesting;
LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddLast(40);

LinkedListNode<int> currentNode = linkedList.First;

while (currentNode != null)
{
    if (currentNode.Value == 30)
    {
        // Found the node with key 30
        break;
    }
    currentNode = currentNode.Next;
}

if (currentNode != null)
{
    Console.WriteLine("Found node with key 30: " + currentNode.Value);
}
else
{
    Console.WriteLine("Node with key 30 not found.");
}