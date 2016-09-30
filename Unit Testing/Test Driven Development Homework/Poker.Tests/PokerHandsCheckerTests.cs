namespace Poker.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Contracts;
    using Infrastructure;
    using Models;

    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidHandShouldThrowExceptionIfNumberOfCardsInTheHandIsNotFive()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isValidCountOfCards = poker.IsValidHand(testHand);
                Assert.Fail();
            }
            catch(ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsValidShouldReturnTrueIfNumberOfCardsInTheHandIsFifeAndAllCardsAreDifferent()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isValid = poker.IsValidHand(testHand);

            Assert.AreEqual(true, isValid, "IsValid(): The hand is not valid.");
        }

        [TestMethod]
        public void IsValidShouldThrowExceptionIfTheNumberOfCardsInTheHandIsLessThanFive()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isValidCardsCount = poker.IsValidHand(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsValidShouldThrowExceptionIfTheNumberOfCardsInTheHandIsMoreThanFive()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isValidCardsCount = poker.IsValidHand(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsValidShouldThrowExceptionIfTheHandHasNoCardsInIt()
        {
            Hand testHand = new Hand(new List<ICard> { });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isValidCardsCount = poker.IsValidHand(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsValidShouldThrowExceptionIfNullHandIsPassed()
        {
            Hand testHand = new Hand(null);

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isValidCardsCount = poker.IsValidHand(testHand);
                Assert.Fail();
            }
            catch (NullReferenceException)
            {

            }
        }

        [TestMethod]
        public void IsValidShouldReurnFalseIfThereAreAtLeastTwoEqualCardsInTheHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            bool areDifferent = poker.IsValidHand(testHand);

            Assert.AreEqual(false, areDifferent, "IsValid(): some of the cards in the hand are the same");
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseIfTheHandIsNotAValidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(testHand);

            Assert.AreEqual(false, isFlush, "IsFlush(): The hand is not valid.");
        }

        [TestMethod]
        public void IsFlushShouldReturnTrueIfTheSuitOfAllCardsIsEqualAndTheyAreNotConsecutiveCards()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(testHand);

            Assert.AreEqual(true, isFlush, "IsFlush(): The hand is not flush.");
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseIfTheSuitOfAllCardsIsNotEqualAndTheyAreNotConsecutiveCards()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(testHand);

            Assert.AreEqual(false, isFlush, "IsFlush(): The hand is a flush but it should not be.");
        }

        [TestMethod]
        public void IsFlushShouldReturnFalseIfTheSuitOfAllCardsIsEqualButTheyAreConsecutiveCards()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFlush = poker.IsFlush(testHand);

            Assert.AreEqual(false, isFlush, "IsFlush(): The hand is not flush.");
        }

        [TestMethod]
        public void IsFourOfAKindShouldThrowExceptionIfTheHandIsNotAvalidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            try
            {
                bool isFourOfAKind = poker.IsFourOfAKind(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnTrueIfFourOfTheCardsAreWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFourOfAKind = poker.IsFourOfAKind(testHand);

            Assert.AreEqual(true, isFourOfAKind, "IsFourOfAKind(): The hand is not Four-Of-A-Kind.");
        }

        [TestMethod]
        public void IsFourOfAKindShouldReturnFalseIfFourOfTheCardsAreNotWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFourOfAKind = poker.IsFourOfAKind(testHand);

            Assert.AreEqual(false, isFourOfAKind, "IsFourOfAKind(): The hand is not Four-Of-A-Kind.");
        }

        [TestMethod]
        public void IsOnePairShouldThrowExceptionIfItIsNotAValidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isOnePair = poker.IsOnePair(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsOnePairShouldReturnTrueIfTwoOfTheCardsAreWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isOnePair = poker.IsOnePair(testHand);

            Assert.AreEqual(true, isOnePair, "IsOnePair(): The hand is not One Pair.");
        }

        [TestMethod]
        public void IsOnePairShouldReturnFalseIfTwoOfTheCardsAreNotWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isOnePair = poker.IsOnePair(testHand);

            Assert.AreEqual(false, isOnePair, "IsOnePair(): The hand is not One Pair.");
        }

        [TestMethod]
        public void IsTwoPairShouldReturnTrueIfTwoPairsOfTheCardsAreWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(testHand);

            Assert.AreEqual(true, isTwoPair, "IsTwoPair(): The hand is not Two Pair.");
        }

        [TestMethod]
        public void IsTwoPairShouldReturnFalseIfTwoPairsOfTheCardsAreNotWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isTwoPair = poker.IsTwoPair(testHand);

            Assert.AreEqual(false, isTwoPair, "IsTwoPair(): The hand is not Two Pair.");
        }

        [TestMethod]
        public void IsThreeOfAKindShouldThrowExceptionIfTheHandIsNotAvalidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isThreeOfAKind = poker.IsThreeOfAKind(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnTrueIfThreeOfTheCardsAreWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isThreeOfAKind = poker.IsThreeOfAKind(testHand);

            Assert.AreEqual(true, isThreeOfAKind, "IsThreeOfAKind(): The hand is not Three-Of-A-Kind.");
        }

        [TestMethod]
        public void IsThreeOfAKindShouldReturnFalseIfThreeOfTheCardsAreNotWithEqualFacesAndDifferentSuits()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isThreeOfAKind = poker.IsThreeOfAKind(testHand);

            Assert.AreEqual(false, isThreeOfAKind, "IsThreeOfAKind(): The hand is not Three-Of-A-Kind.");
        }

        [TestMethod]
        public void IsFullHouseShouldThrowExceptionIfTheHandIsNotAvalidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isFullHouse = poker.IsFullHouse(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsFullHouseShouldReturnTrueIfThreeOfTheCardsAreWithEqualFacesAndDifferentSuitsAndTheOtherTwoAreOnePair()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFullHouse = poker.IsFullHouse(testHand);

            Assert.AreEqual(true, isFullHouse, "IsFullHouse(): The hand is not a Full House.");
        }

        [TestMethod]
        public void IsFullHouseShouldReturnFalseIfThreeOfTheCardsAreNotWithEqualFacesAndDifferentSuitsOrTheOtherTwoAreNotOnePair()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isFullHouse = poker.IsFullHouse(testHand);

            Assert.AreEqual(false, isFullHouse, "IsFullHouse(): The hand is not a Full House.");
        }

        [TestMethod]
        public void IsStraightShouldThrowExceptionIfTheHandIsNotAValidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isStaight = poker.IsStraight(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsStraightShouldReturnTrueIfAllOfTheCardsAreSequentAndTheirSuitIsDifferent()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraight = poker.IsStraight(testHand);

            Assert.AreEqual(true, isStraight, "IsStraight(): The hand is not a Straight.");
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseIfIfNotAllOfTheCardsAreSequentAndTheirSuitIsDifferent()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStaight = poker.IsStraight(testHand);

            Assert.AreEqual(false, isStaight, "IsStraight(): The hand is not a Straight.");
        }

        [TestMethod]
        public void IsStraightShouldReturnFalseIfIfAllOfTheCardsAreSequentButTheirSuitIsNotDifferent()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStaight = poker.IsStraight(testHand);

            Assert.AreEqual(false, isStaight, "IsStraigtht(): The hand is not a Straight.");
        }

        [TestMethod]
        public void IsStraightFlushShouldThrowExceptionIfTheHandIsNotAValidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isStaightFlush = poker.IsStraightFlush(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnTrueIfAllOfTheCardsAreSequentAndTheirSuitIsEqual()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStraightFlush = poker.IsStraightFlush(testHand);

            Assert.AreEqual(true, isStraightFlush, "IsStraightFlush(): The hand is not a Straight Flush.");
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseIfIfNotAllOfTheCardsAreSequentAndTheirSuitIsEqual()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStaightFlush = poker.IsStraightFlush(testHand);

            Assert.AreEqual(false, isStaightFlush, "IsStraightFlush(): The hand is not a Straight Flush.");
        }

        [TestMethod]
        public void IsStraightFlushShouldReturnFalseIfIfAllOfTheCardsAreSequentButTheirSuitIsDifferent()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isStaightFlush = poker.IsStraightFlush(testHand);

            Assert.AreEqual(false, isStaightFlush, "IsStraigthtFlush(): The hand is not a Straight Flush.");
        }

        [TestMethod]
        public void IsHighCardShouldThrowExceptionIfTheHandIsNotAValidHand()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();

            try
            {
                bool isHighCard = poker.IsHighCard(testHand);
                Assert.Fail();
            }
            catch (ArgumentException)
            {

            }
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseIfIsStraightFlush()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighcard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighcard, "IsHighCard(): The hand is not a High card.)");
        }

        [TestMethod]
        public void IsHighCardShouldReturnFaseIfIsFlush()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseIfIsFourOfAKind()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighCardShouldReturnfalseIfIsOnePair()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseIfIsTwoPair()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighcardShouldReturnFalseIfIsThreeOfAKind()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighCardShouldReturnFalseIfIsFullHouse()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighcardShouldReturnFalseIfIsStraight()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }

        [TestMethod]
        public void IsHighCardShouldReturnTrueIfIsStraightFlush()
        {
            Hand testHand = new Hand(new List<ICard>
            {
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            PokerHandsChecker poker = new PokerHandsChecker();
            bool isHighCard = poker.IsHighCard(testHand);

            Assert.AreEqual(false, isHighCard, "IsHighCard(): The hand is not a High Card.");
        }
    }
}
