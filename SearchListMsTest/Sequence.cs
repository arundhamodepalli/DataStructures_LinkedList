using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMsTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void InsertNodeAfter30_InsertsNodeCorrectly()
        {
            // Arrange
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);

            // Act
            LinkedListNode<int> nodeWith30 = linkedList.Find(30);
            linkedList.AddAfter(nodeWith30, 40);

            // Assert
            Assert.AreEqual(4, linkedList.Count);
            Assert.AreEqual(56, linkedList.First.Value);
            Assert.AreEqual(30, linkedList.First.Next.Value);
            Assert.AreEqual(40, linkedList.First.Next.Next.Value);
            Assert.AreEqual(70, linkedList.Last.Value);
        }
    }
}

