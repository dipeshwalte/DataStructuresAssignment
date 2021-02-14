using NUnit.Framework;
using DataStructuresAssignment;
namespace TestForDataStructures
{
    public class Tests
    {
        LinkedList linkedList;
        [SetUp]
        public void Setup()
        {
            linkedList = new LinkedList();
        }

        [Test]
        [TestCase(30)]
        public void SearchValue_ReturnTrue(int searchValue)
        {
           
        }
    }
}