namespace Poker.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Poker.Contracts;
    using Infrastructure;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool areDifferent = true;
            bool isValidCountOfCards = true;

            if (hand.Cards.Count != 5)
            {
                isValidCountOfCards = false;
                throw new ArgumentException("A hand is valid when it consists of exactly 5 different cards.");
            }

            if (hand.Cards.Count == 0)
            {
                throw new ArgumentException("The hand is empty and has no cards.");
            }

            if (hand.Cards == null)
            {
                throw new NullReferenceException("The hand is null.");
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                ICard currentCard = hand.Cards[i];

                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    ICard nextCard = hand.Cards[j];
                    if (currentCard.Face == nextCard.Face && currentCard.Suit == nextCard.Suit)
                    {
                        areDifferent = false;
                        break;
                    }
                }
            }

            bool isValid = isValidCountOfCards && areDifferent;

            return isValid;
        }

        public bool IsStraightFlush(IHand hand)
        {

            if (!this.IsValidHand(hand))
            {
                return false;
            }

            CardSuit firstCardSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            var sortedHand = hand.Cards.Select(card => (int)card.Face).OrderBy(value => value).ToArray();

            for (int i = 0; i < sortedHand.Length - 1; i++)
            {
                if (sortedHand[i] + 1 != sortedHand[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFourOfAKind(IHand hand) // ToDo: Check all cases
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int result = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard card = hand.Cards[i];
                int numberOfTheSameFaceOfCardInHand = hand.Cards.Where(x => x.Face == card.Face).Count();
                if (numberOfTheSameFaceOfCardInHand > result)
                {
                    result = numberOfTheSameFaceOfCardInHand;
                }
            }

            if (result != 4)
            {
                return false;
            }

            return true;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Any(gr => gr.Count() == 3) && group.Any(gr => gr.Count() == 2);
        }

        public bool IsFlush(IHand hand) //Follow the official poker rules from Wikipedia: http://en.wikipedia.org/wiki/List_of_poker_hands
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            CardSuit firstCardSuit = hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            if (this.IsStraightFlush(hand))
            {
                return false;
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
                       
            if (hand.Cards.GroupBy(card => card.Suit).Count() == 1)
            {
                return false;
            }

            var sortedHand = hand.Cards.Select(card => (int)card.Face).OrderBy(value => value).ToArray();

            for (int i = 0; i < sortedHand.Length - 1; i++)
            {
                if (sortedHand[i] + 1 != sortedHand[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int result = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard card = hand.Cards[i];
                int numberOfTheSameFaceOfCardInHand = hand.Cards.Where(x => x.Face == card.Face).Count();
                if (numberOfTheSameFaceOfCardInHand > result)
                {
                    result = numberOfTheSameFaceOfCardInHand;
                }
            }

            if (result != 3)
            {
                return false;
            }

            return true;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            return hand.Cards.GroupBy(card => card.Face).Count(group => group.Count() == 2) == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            int result = 1;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard card = hand.Cards[i];
                int numberOfTheSameFaceOfCardInHand = hand.Cards.Where(x => x.Face == card.Face).Count();
                if (numberOfTheSameFaceOfCardInHand > result)
                {
                    result = numberOfTheSameFaceOfCardInHand;
                }
            }

            if (result != 2)
            {
                return false;
            }

            return true;
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (this.IsFlush(hand))
            {
                return false;
            }

            if (this.IsFourOfAKind(hand))
            {
                return false;
            }

            if (this.IsFullHouse(hand))
            {
                return false;
            }

            if (this.IsOnePair(hand))
            {
                return false;
            }

            if (this.IsTwoPair(hand))
            {
                return false;
            }

            if (this.IsStraight(hand))
            {
                return false;
            }

            if (this.IsStraightFlush(hand))
            {
                return false;
            }

            if (this.IsThreeOfAKind(hand))
            {
                return false;
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
