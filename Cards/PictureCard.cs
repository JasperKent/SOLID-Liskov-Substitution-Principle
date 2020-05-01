namespace Cards
{
    public enum Gender { F, M }

    public sealed class PictureCard : PlayingCardBase
    {
        public PictureCard(int rank, Suit suit)
            :base(rank, suit)
        {
            AssertRank(rank, Jack, King);
        }

        public Gender Gender => Rank == Queen ? Gender.F : Gender.M;

        public override string ToString()
        {
            return $"{base.ToString()}{Gender}";
        }
    }
}
