using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void AddANewValueToSet()
        {
            //Arrange
            var set = new HashedSet<int>();

            //Act
            set.Add(2);

            //Assert
            Assert.IsNotEmpty(set);
        }

        [Test]
        public void IncreaseCount_WhenANewValueIsAdded()
        {
            //Arrange
            var set = new HashedSet<int>();
            var expectedCount = 2;
            //Act
            set.Add(2);
            set.Add(33);

            //Assert
            Assert.IsTrue(set.Count == expectedCount);
        }
    }
}