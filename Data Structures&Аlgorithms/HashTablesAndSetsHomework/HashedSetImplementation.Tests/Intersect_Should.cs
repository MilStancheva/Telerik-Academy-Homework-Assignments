using NUnit.Framework;
using Problem_5___HashSetImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashedSetImplementation.Tests
{
    [TestFixture]
    public class Intersect_Should
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
            var intersect = firstSet.Intersect(secondSet);

            //Assert
            Assert.IsNotEmpty(intersect);
        }

        [Test]
        public void ReturnANewHashedSetWithTheUniqueValuesPresentInBothSets()
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
            var intersect = firstSet.Intersect(secondSet);
            var actualValueResult = intersect.First();

            //Assert
            Assert.AreEqual(commonValue, actualValueResult);
        }
    }
}
