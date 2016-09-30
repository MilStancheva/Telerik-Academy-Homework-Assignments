namespace Poker.Models
{
    using Contracts;
    using Infrastructure;

    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string face = string.Empty;
            
            switch (this.Face)
            {
                case CardFace.Jack:
                    face = "J";
                    break;
                case CardFace.Queen:
                    face = "Q";
                    break;
                case CardFace.King:
                    face = "K";
                    break;
                case CardFace.Ace:
                    face = "A";
                    break;
                default:
                    face = ((int)this.Face).ToString();
                    break;
            }

            char suit = new char();
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣';
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥';
                    break;
                case CardSuit.Spades:
                    suit = '♠';
                    break;
            }

            string cardToString = string.Format("{0}{1}", face, suit);

            return cardToString;
        }
    }
}
