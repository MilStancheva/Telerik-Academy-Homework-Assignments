using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Clear_Should
    {
        [Test]
        public void DeleteTheValuesInTheSet()
        {
            //Arrange
            var set = new HashedSet<int>();
            set.Add(3);

            //Act
            set.Clear();

            //Assert
            Assert.IsEmpty(set);
        }

        [Test]
        public void SetCountToZero()
        {
            //Arrange
            var set = new HashedSet<int>();
            var expectedCount = 0;
            set.Add(3);

            //Act
            set.Clear();

            //Assert
            Assert.AreEqual(expectedCount, set.Count);
        }
    }
}