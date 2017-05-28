using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace SortingHomework.Tests.SearchingAlgorythmsTests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearch_ShouldReturnFalse_IfThePassedValueIsNotContainedInTheCollection()
        {
            IList<int> numbers = new List<int>()
            {
                2482, 446 , -967, 3489, 3596,
                1140, 3706, 3299, 5796, 5003,
                5594, 6407, 865 , 3137, 3740,
                3235, 3460, 6919, 3785, 3301,
                -259, 5730, -751, 3934, 6275
            };

            SortableCollection<int> collection = new SortableCollection<int>(numbers);

            bool isFound = collection.BinarySearch(1);

            Assert.IsFalse(isFound);
        }

        [Test]
        public void BinarySearch_ShouldReturnTrue_IfThePassedValueIsContainedInTheCollection()
        {
            IList<int> numbers = new List<int>()
            {
                732, 542, 8835, 1771, 753,
                6440, 3736, 7331, 9268, 6661,
                6038, 3563, 939 , 130 , 6712,
                4094, 7289, 7485, 8853, 1752,
                6425, 645, 8348 , 6248, 5663
            };

            SortableCollection<int> collection = new SortableCollection<int>(numbers);

            bool isFound = collection.BinarySearch(130);

            Assert.IsTrue(isFound);
        }

        [Test]
        public void BinarySearch_ShouldThrowArgumentNullException_IfThePassedValueIsNull()
        {
            IList<string> words = new List<string>
            {
                "WcZhoSDRnb",
                "BywmFaVaLD",
                "nbRghRKDjQ",
                "tFfyJAuKhj",
                "znxwHUfdml",
                "NFpGdsIEAG",
                "ufDIrFLWmX",
                "kSpnfNIIxn",
                "TvCYLuCQDv",
                "oxjOxYdLVp"
            };

            SortableCollection<string> collection = new SortableCollection<string>(words);

            Assert.Throws<ArgumentNullException>(() =>
            {
                bool isFound = collection.BinarySearch(null);
            });
        }
    }
}