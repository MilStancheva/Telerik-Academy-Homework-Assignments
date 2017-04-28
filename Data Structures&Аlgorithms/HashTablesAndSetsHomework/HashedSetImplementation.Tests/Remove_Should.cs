using System;
using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Remove_Should
    {
        [Test]
        public void CallMehtodRemoveOfHashTableAndThrowArgumentException_WhenTheValueisNotFound()
        {
            //Arrange
            var set = new HashedSet<int>();
            var firstValue = 1;
            var secondValue = 22;
            set.Add(firstValue);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => set.Remove(secondValue));
        }

        [Test]
        public void RemoveTheValueSuccessfully_WhenTheValueisFound()
        {
            //Arrange
            var set = new HashedSet<int>();
            var firstValue = 1;
            set.Add(firstValue);

            //Act
            set.Remove(firstValue);

            //Assert
            Assert.IsEmpty(set);
        }

        [Test]
        public void DecreasesTheCount_WhenTheKeyisFoundAndTheIteIsSuccessfullyRemoved()
        {
            //Arrange
            var set = new HashedSet<int>();
            var firstValue = 1;
            var secondValue = 23;
            var expectedCountResult = 1;
            set.Add(firstValue);
            set.Add(secondValue);

            //Act
            set.Remove(firstValue);

            //Assert
            Assert.AreEqual(expectedCountResult, set.Count);
        }
    }
}