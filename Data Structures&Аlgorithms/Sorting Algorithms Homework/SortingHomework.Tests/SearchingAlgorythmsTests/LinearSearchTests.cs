using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace SortingHomework.Tests.SearchingAlgorythmsTests
{
    [TestFixture]
    public class LinearSearchTests
    {
        [Test]
        public void LinearSearch_ShouldReturnFalse_IfThePassedValueIsNotContainedInTheCollection()
        {
            int[] numbers = new int[]
            {
                2482, 446 , -967, 3489, 3596,
                1140, 3706, 3299, 5796, 5003,
                5594, 6407, 865 , 3137, 3740,
                3235, 3460, 6919, 3785, 3301,
                -259, 5730, -751, 3934, 6275
            };

            SortableCollection<int> collection = new SortableCollection<int>(numbers);

            bool isFound = collection.LinearSearch(1);

            Assert.IsFalse(isFound);
        }

        [Test]
        public void LinearSearch_ShouldReturnTrue_IfThePassedValueIsContainedInTheCollection()
        {
            int[] numbers = new int[]
            {
                2482, 446 , -967, 3489, 3596,
                1140, 3706, 3299, 5796, 5003,
                5594, 6407, 865 , 3137, 3740,
                3235, 3460, 6919, 3785, 3301,
                -259, 5730, -751, 3934, 6275
            };

            SortableCollection<int> collection = new SortableCollection<int>(numbers);

            bool isFound = collection.LinearSearch(5796);

            Assert.IsTrue(isFound);
        }

        [Test]
        public void LinearSearch_ShouldThrowArgumentNullException_IfThePassedValueIsNull()
        {
            IList<string> words = new List<string>()
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
                bool isFound = collection.LinearSearch(null);
            });
        }
    }
}
