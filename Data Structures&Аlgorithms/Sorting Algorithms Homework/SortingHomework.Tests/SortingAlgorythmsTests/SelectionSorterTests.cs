using System;
using NUnit.Framework;

namespace SortingHomework.Tests
{
    [TestFixture]
    public class SelectionSorterTests
    {
        [Test]
        public void SelectionSort_ShouldThrwoArgumentNullException_WhenCollectionIsNull()
        {
            var selectionSorter = new SelectionSorter<int>();

            Assert.Throws<ArgumentNullException>(() => { selectionSorter.Sort(null); });      
        }

        [Test]
        public void SelectionSort_ShouldSortACollection_WhenValidCollectionIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(10);
            var selectionSorter = new SelectionSorter<int>();

            selectionSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));           
        }

        [Test]
        public void SelectionSort_ShouldSortACollection_WhenCollectionWithTwoElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(2);
            var selectionSorter = new SelectionSorter<int>();

            selectionSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void SelectionSort_ShouldReturnTheElement_WhenCollectionWithOneElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1);
            var selectionSorter = new SelectionSorter<int>();

            selectionSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }

        [Test]
        public void SelectionSort_ShouldSortCollection_WhenCollectionWithAGreatNumberOfElementsIsPassed()
        {
            var collection = CollectionsUtils.GenerateCollection(1000000);
            var selectionSorter = new SelectionSorter<int>();

            selectionSorter.Sort(collection);

            Assert.IsTrue(CollectionsUtils.IsSorted(collection));
        }
    }
}