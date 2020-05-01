using System;

namespace Cards
{
    public enum Suit { Clubs, Diamonds, Hearts, Spades }

    public abstract class PlayingCardBase
    {
        public const int Ace = 1;
        public const int Jack = 11;
        public const int Queen = 12;
        public const int King = 13;

        public PlayingCardBase(int rank, Suit suit)
        {
            AssertRank(rank, Ace, King);

            Rank = rank;
            Suit = suit;
        }

        protected static void AssertRank(int rank, int min, int max)
        {
            if (rank < min || rank > max)
                throw new ArgumentOutOfRangeException($"Invalid rank {rank}");
        }

        public char SuitChar => "\u2663\u2666\u2665\u2660"[(int)Suit];
        public char RankChar => " A23456789TJQK"[Rank];

        public int Rank { get; }
        public Suit Suit { get; }

        public virtual int Score => Rank;

        public override string ToString() => $"{RankChar}{SuitChar}";
    }
}

