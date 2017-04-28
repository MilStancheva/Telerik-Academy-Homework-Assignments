using System;
using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class Find_Should
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
            Assert.Throws<ArgumentException>(() => table.Find(secondKey));
        }

        [Test]
        public void ReturnAValue_WhenTheKeyisValid()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = "good morning";
            var secondValue = 33;

            table.Add(firstKey, firstValue);
            table.Add(secondKey, secondValue);

            //Act
            var actualResult = table.Find(secondKey);

            //Assert
            Assert.AreEqual(secondValue, actualResult);
        }
    }
}