using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class Clear_Should
    {
        [Test]
        public void DeleteAllElementsOfTheHasTable()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var initialCount = 5;
            for (int i = 0; i < initialCount; i++)
            {
                table.Add(i.ToString(), i);
            }

            //Act
            table.Clear();

            //Assert
            Assert.AreEqual(0, table.Count);
        }
    }
}