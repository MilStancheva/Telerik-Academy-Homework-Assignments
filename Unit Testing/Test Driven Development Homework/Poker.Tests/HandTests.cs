namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Contracts;
    using Infrastructure;
    using Models;

    [TestClass]
    public class HandTests
    {
        Hand testHand = new Hand(new List<ICard>
        {
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Five, CardSuit.Hearts),
            new Card(CardFace.King, CardSuit.Spades),
            new Card(CardFace.Four, CardSuit.Clubs),
            new Card(CardFace.Two, CardSuit.Hearts)
        });

        [TestMethod]
        public void HandShouldHaveExactlyFiveCards()
        {
            Assert.IsTrue(this.testHand.Cards.Count == 5);
        }

        [TestMethod]
        public void ToStringShouldReturnCardsSeparatedByComma()
        {
            Assert.AreEqual("A♦, 5♥, K♠, 4♣, 2♥", this.testHand.ToString());
        }
    }
}
