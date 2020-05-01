using System;

namespace Cards
{
    class Program
    {
        static void DisplayCard (NumberCard card)
        {
            Console.WriteLine(card);
            DisplayPips(card.PipLayout, card.SuitChar);
            Console.WriteLine();
        }

        static void DisplayPips((int l, int c, int r) pipLayout, char pip = '\u2666')
        {
            bool[,] edges =   { { false, false, false, false, false, false },   // 0
                                { false, false, false, false, false, false },   // 1 - never used 
                                { true,  false, false, false, true,  false },   // 2
                                { true,  false, true,  false, false, true  },   // 3
                                { true,  false, true,  true,  false, true  }};  // 4

            bool[,] middles = { { false, false, false, false, false, false },   // 0
                                { false, true,  false, false, false, false },   // 1
                                { false, true,  false, false, true,  false },   // 2
                                { false, true,  true,  false, true,  false } }; // 3 

            for (int row = 0; row < 6; ++row)
            {
                string s = $"{(edges[pipLayout.l, row] ? pip : ' ')} {(middles[pipLayout.c, row] ? pip : ' ')} {(edges[pipLayout.r, row] ? pip : ' ')}";

                if (!string.IsNullOrWhiteSpace(s))
                    Console.WriteLine(s);
            }
        }

        static void Main()
        {
            NumberCard pc1 = new NumberCard(4, Suit.Diamonds);
            PlayingCardBase pc2 = new PictureCard(PlayingCardBase.King, Suit.Clubs);
            NumberCard pc3 = new NumberCard(PlayingCardBase.Ace, Suit.Clubs);
            NumberCard pc4 = new NumberCard(7, Suit.Spades);
            NumberCard pc5 = new NumberCard(2, Suit.Hearts);

            Hand hand = new Hand { pc1, pc2, pc3, pc4, pc5 };

            Console.WriteLine($"Hand '{hand}' scores {hand.Score}.");

            DisplayCard(pc1);
            DisplayCard(pc4);
        }
    }
}
