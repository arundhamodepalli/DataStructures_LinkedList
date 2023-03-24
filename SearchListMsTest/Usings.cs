global using Microsoft.VisualStudio.TestTools.UnitTesting;
LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(56);
linkedList.AddLast(30);
linkedList.AddLast(70);

LinkedListNode<int> currentNode = linkedList.First;

while (currentNode != null)
{
    if (currentNode.Value == 30)
    {
        // Found the node with key value 30, insert 40 after it
        linkedList.AddAfter(currentNode, 40);
        break;
    }
    currentNode = currentNode.Next;
}

// Output the final sequence
currentNode = linkedList.First;
while (currentNode != null)
{
    Console.Write(currentNode.Value + "->");
    currentNode = currentNode.Next;
}