using System;
using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void ThrowAnArgumentExceptionIfTheGivenKeyAlreadyExists()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = firstKey;
            var secondValue = 33;

            table.Add(firstKey, firstValue);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => table.Add(secondKey, secondValue));
        }

        [Test]
        public void AddSuccessfully_WhenTheGivenKeyAndvalueAreValid()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = "good evening";
            var secondValue = 33;

            //Act
            table.Add(firstKey, firstValue);
            table.Add(secondKey, secondValue);

            //Assert
            Assert.IsTrue(table.Count == 2);
        }

        [Test]
        public void CallResizeAndReAddValues_WhenCapacityIsAtIts75Pecents()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var count = 0.75 * table.Capacity;
            var expectedCapacity = 32;

            //Act
            for (int i = 0; i <= count; i++)
            {
                table.Add(i.ToString(), i);
            }

            //Assert
            Assert.IsTrue(table.Capacity == expectedCapacity);
        }
    }
}