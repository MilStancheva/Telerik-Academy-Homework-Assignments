using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class HashTableConstructor_Should
    {
        [Test]
        public void InitializeANewInstanceOfAHashTableWithInitialCapacity16()
        {
            //Arrange & Act
            var hashTable = new HashTable<string, int>();
            var expectedCapacity = 16;

            //Assert
            Assert.That(hashTable.Capacity == expectedCapacity);
        }
    }
}