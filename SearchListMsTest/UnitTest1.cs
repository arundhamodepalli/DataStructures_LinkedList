namespace SearchListMsTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void FindNodeWithValue30_ReturnsCorrectNode()
        {
            // Arrange
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);

            // Act
            LinkedListNode<int> nodeWith30 = linkedList.Find(30);

            // Assert
            Assert.IsNotNull(nodeWith30);
            Assert.AreEqual(30, nodeWith30.Value);
        }
    }
}
  