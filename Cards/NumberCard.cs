using System;

namespace Cards
{
    public sealed class NumberCard : PlayingCardBase
    {
        public NumberCard(int rank, Suit suit)
            : base(rank, suit)
        {
            AssertRank(rank, Ace, 10);
        }

        public (int, int, int) PipLayout
        {
            get
            {
                return Rank switch
                {
                    Ace => (0, 1, 0),
                    2 => (0, 2, 0),
                    3 => (0, 3, 0),
                    4 => (2, 0, 2),
                    5 => (2, 1, 2),
                    6 => (3, 0, 3),
                    7 => (3, 1, 3),
                    8 => (3, 2, 3),
                    9 => (4, 1, 4),
                    10 => (4, 2, 4),
                    _ => throw new InvalidOperationException("Rank out of range.")
                };
            }
        }
    }
}
