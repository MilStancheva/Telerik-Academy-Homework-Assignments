using System;
using NUnit.Framework;
using SortingHomework;

namespace SortingHomework.Tests
{
    [TestFixture]
    public class QuickSorterTests
    {

        [Test]
        public void QuickSort_ShouldThrwoArgumentNullException_WhenCollectionIsNull()
        {
            var quickSorter = new QuickSorter<int>();

            Assert.Throws<ArgumentNullException>(() => { quickSorter.Sort(null); });
        }

        [Test]
        public void QuickSort_ShouldSortACollection_WhenValidCollectionIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(10);
            var quickSorter = new QuickSorter<int>();

            quickSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void QuickSort_ShouldSortACollection_WhenCollectionWithTwoElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(2);
            var quickSorter = new QuickSorter<int>();

            quickSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void QuickSort_ShouldReturnTheElement_WhenCollectionWithOneElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1);
            var quickSorter = new QuickSorter<int>();

            quickSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void QuickSort_ShouldSortCollection_WhenCollectionWithAGreatNumberOfElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1000000);
            var quickSorter = new QuickSorter<int>();

            quickSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }
    }
}
