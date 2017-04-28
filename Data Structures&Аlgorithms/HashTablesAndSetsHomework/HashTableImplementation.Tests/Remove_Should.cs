using System;
using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class Remove_Should
    {
        [Test]
        public void ThrowArgumentException_WhenTheKeyisNotFound()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = "good morning";

            table.Add(firstKey, firstValue);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => table.Remove(secondKey));
        }

        [Test]
        public void RemoveThePairSuccessfully_WhenTheKeyisFound()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;

            table.Add(firstKey, firstValue);

            //Act
            table.Remove(firstKey);

            //Assert
            Assert.IsEmpty(table);
        }

        [Test]
        public void DecreasesTheCount_WhenTheKeyisFoundAndTheIteIsSuccessfullyRemoved()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = "good morning";
            var secondValue = 33;
            var expectedCountResult = 1;

            table.Add(firstKey, firstValue);
            table.Add(secondKey, secondValue);

            //Act
            table.Remove(firstKey);

            //Assert
            Assert.AreEqual(expectedCountResult, table.Count);
        }
    }
}