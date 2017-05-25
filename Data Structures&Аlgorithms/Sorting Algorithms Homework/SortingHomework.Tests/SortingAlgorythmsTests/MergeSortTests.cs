using System;
using NUnit.Framework;

namespace SortingHomework.Tests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void MergeSort_ShouldThrwoArgumentNullException_WhenCollectionIsNull()
        {
            var mergeSorter = new MergeSorter<int>();

            Assert.Throws<ArgumentNullException>(() => { mergeSorter.Sort(null); });
        }

        [Test]
        public void MergeSort_ShouldSortACollection_WhenValidCollectionIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(10);
            var mergeSorter = new MergeSorter<int>();

            mergeSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void MergeSort_ShouldSortACollection_WhenCollectionWithTwoElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(2);
            var mergeSorter = new MergeSorter<int>();

            mergeSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void MergeSort_ShouldReturnTheElement_WhenCollectionWithOneElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1);
            var mergeSorter = new MergeSorter<int>();

            mergeSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void MergeSort_ShouldSortCollection_WhenCollectionWithAGreatNumberOfElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1000000);
            var mergeSorter = new MergeSorter<int>();

            mergeSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }
    }
}
