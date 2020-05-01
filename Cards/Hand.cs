using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    public class Hand : IEnumerable<PlayingCardBase>
    {
        private List<PlayingCardBase> _cards = new List<PlayingCardBase>();

        public void Add(params PlayingCardBase[] cards) => _cards.AddRange(cards);

        public int Score => _cards.Sum(c => c.Score);

        public override string ToString()
        {
            var builder = new StringBuilder();

            foreach (var c in _cards)
                builder.Append($"{c} ");

            return builder.ToString().Trim();
        }

        public IEnumerator<PlayingCardBase> GetEnumerator() => _cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _cards.GetEnumerator();
    }
}
