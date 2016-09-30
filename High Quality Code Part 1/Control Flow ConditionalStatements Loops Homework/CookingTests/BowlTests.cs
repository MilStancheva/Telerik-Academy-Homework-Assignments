using System;
using NUnit.Framework;
using Cooking.Contacts;
using Moq;
using Cooking.Models;

namespace CookingTests
{
    [TestFixture]
    public class BowlTests
    {
        [Test]
        public void AddVegetables_ShouldAddANewVegetableToTheVegetablesList_WhenAValidVegetableIsPassed()
        {
            var vegetable = new Mock<IVegetable>();
            var bowl = new Bowl();

            bowl.AddVegetables(vegetable.Object);

            Assert.IsTrue(bowl.Vegetables.Count == 1);
        }

        [Test]
        public void AddVegetables_ShouldThrowArgumentException_WhenAnUnvalidVegetableIsPassed()
        {
            var bowl = new Bowl();

            Assert.Throws<ArgumentException>(() => bowl.AddVegetables(null));
        }
    }
}
