using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Union_Should
    {
        [Test]
        public void ReturnANewHashedSet()
        {
            //Arrange
            var firstSet = new HashedSet<int>();
            var secondSet = new HashedSet<int>();

            var commonValue = 1;
            var firstSetValue = 13;
            var secondSetValue = 42;

            firstSet.Add(commonValue);
            secondSet.Add(commonValue);
            firstSet.Add(firstSetValue);
            secondSet.Add(secondSetValue);

            //Act
            var union = firstSet.Union(secondSet);

            //Assert
            Assert.IsNotEmpty(union);
        }

        [Test]
        public void ReturnANewHashedSetWithTheUniqueValuesPresentInBothSets()
        {
            //Arrange
            var firstSet = new HashedSet<int>();
            var secondSet = new HashedSet<int>();

            var firstCommonValue = 1;
            var secondCommonValue = 1;

            var firstSetValue = 13;
            var secondSetValue = 42;

            firstSet.Add(firstCommonValue);
            secondSet.Add(secondCommonValue);
            firstSet.Add(firstSetValue);
            secondSet.Add(secondSetValue);
            var expectedCount = 3;
            //Act
            var union = firstSet.Union(secondSet);
            var actualCountResult = union.Count;

            //Assert
            Assert.AreEqual(expectedCount, actualCountResult);
        }
    }
}