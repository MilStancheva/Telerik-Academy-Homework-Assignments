using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Contains_Should
    {
        [Test]
        public void ReturnFalseIfTheSearchedValueDoesNotExistInTheHashedSet()
        {
            //Arrange
            var set = new HashedSet<int>();
            var firstValue = 1;
            var secondValue = 12;
            set.Add(firstValue);

            //Act
            var actualResult = set.Contains(secondValue);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void ReturnTrueIfTheSearchedKeyIsValid()
        {
            //Arrange
            var set = new HashedSet<int>();
            var firstValue = 1;
            var secondValue = 12;
            set.Add(firstValue);
            set.Add(secondValue);

            //Act
            var actualResult = set.Contains(secondValue);

            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}