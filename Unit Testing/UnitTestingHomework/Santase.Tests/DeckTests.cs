namespace Santase.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using Logic;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void NewDeckShouldContain24cards()
        {
            IDeck testDeck = new Deck();

            Assert.AreEqual(24, testDeck.CardsLeft);
        }

        [Test]
        [TestCase(25)]
        public void GetNextCardShouldThrowInternalGameExceptionIfDeckIsEmpty(int cardsToBeDrawn)
        {
            IDeck testDeck = new Deck();

            try
            {
                for (int i = 0; i < cardsToBeDrawn; i++)
                {
                    testDeck.GetNextCard();
                }

                Assert.Fail();
            }
            catch(InternalGameException)
            {

            }
        }

        [Test]
        public void GetNextCardShouldReturnAValidCardSuit()
        {
            IDeck testDeck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.GetNextCard().Suit));
        }

        [Test]
        public void GetNextCardShouldReturnAValidCardType()
        {
            IDeck testDeck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.GetNextCard().Type));
        }

        [Test]
        public void GetNextCardShouldRemoveACardFromTheDeck()
        {
            IDeck testDeck = new Deck();
            int initialCardsCount = testDeck.CardsLeft;

            testDeck.GetNextCard();

            Assert.AreEqual(initialCardsCount - 1, testDeck.CardsLeft);
        }

        [Test]
        [TestCase(5)]
        [TestCase(12)]
        [TestCase(17)]
        [TestCase(21)]
        [TestCase(23)]
        public void GetNextCardShouldGenerateCardAndAddintItToAListShouldReturnTheCorrectCount(int count)
        {
            IDeck testDeck = new Deck();
            var cards = new List<Card>();

            for (int i = 0; i < count; i++)
            {
                cards.Add(testDeck.GetNextCard());
            }

            Assert.AreEqual(count, cards.Count);
        }

        [Test]
        public void ChangeTrumpCardShouldReturnAValidCardSuit()
        {
            IDeck testDeck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), testDeck.TrumpCard.Suit));
        }

        [Test]
        public void ChangeTrumpCardShouldReturnAValidCardType()
        {
            IDeck testDeck = new Deck();

            Assert.IsTrue(Enum.IsDefined(typeof(CardType), testDeck.TrumpCard.Type));
        }

        [Test]
        public void ChangeTrumpCardShouldChangeTheTrumpCardInTheDeckIfThereAreLeftCards()
        {
            IDeck testDeck = new Deck();
            Card initialTrumpcard = testDeck.TrumpCard;
            Card newcard = testDeck.GetNextCard();
            testDeck.ChangeTrumpCard(newcard);

            Assert.AreNotSame(initialTrumpcard, testDeck.TrumpCard);
        }
    }
}
