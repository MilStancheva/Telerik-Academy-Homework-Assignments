namespace Poker.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Infrastructure;
    using Models;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStringShouldReturnCardFaceAceCardSuitClubsCorrectly()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);

            string cardToString = card.ToString();

            Assert.AreEqual("A♣", cardToString, "ToString(): should return card face - capital first letter and card suit - char symbol");
        }

        [TestMethod]
        public void ToStringShouldReturnCardFaceTenCardSuitDimondsCorrectly()
        {
            var card = new Card(CardFace.Ten, CardSuit.Diamonds);

            string cardToString = card.ToString();

            Assert.AreEqual("10♦", cardToString, "ToString(): should return card face - capital first letter and card suit - char symbol");
        }

        [TestMethod]
        public void ToStringShouldReturnCardFaceJackCardSuitHeartsCorrectly()
        {
            var card = new Card(CardFace.Jack, CardSuit.Hearts);

            string cardToString = card.ToString();

            Assert.AreEqual("J♥", cardToString, "ToString(): should return card face - capital first letter and card suit - char symbol");
        }

        [TestMethod]
        public void ToStringShouldReturnCardFaceTwoCardSuitSpadesCorrectly()
        {
            var card = new Card(CardFace.Two, CardSuit.Spades);

            string cardToString = card.ToString();

            Assert.AreEqual("2♠", cardToString, "ToString(): should return card face - capital first letter and card suit - char symbol");
        }
    }
}
