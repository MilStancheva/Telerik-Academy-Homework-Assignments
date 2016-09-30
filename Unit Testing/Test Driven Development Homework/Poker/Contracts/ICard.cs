namespace Poker.Contracts
{
    using Infrastructure;

    public interface ICard
    {
        CardFace Face { get; }

        CardSuit Suit { get; }

        string ToString();
    }
}
