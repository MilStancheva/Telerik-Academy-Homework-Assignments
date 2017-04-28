using NUnit.Framework;
using Problem_5___HashSetImplementation;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class HashedSetConstructor_Should
    {
        [Test]
        public void InitializeWithCountZero()
        {
            //Arragne & Act
            var set = new HashedSet<int>();
            var expectedCount = 0;

            //Assert
            Assert.AreEqual(expectedCount, set.Count);
        }
    }
}