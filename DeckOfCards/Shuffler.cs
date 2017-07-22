using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public class ShufflerInt : IShuffler
	{
		public List<Card> Shuffle(List<Card> deck)
		{
			Random rnd = new Random();

			foreach (Card card in deck)
			{
				card.RandomOrder = rnd.Next(int.MaxValue);
			}

			return deck.OrderBy(c => c.RandomOrder).ToList();
		}
	}

	public class ShufflerGuid : IShuffler
	{
		public List<Card> Shuffle(List<Card> deck)
		{
			foreach (Card card in deck)
			{
				card.RandomOrderGuid = Guid.NewGuid();
			}

			return deck.OrderBy(c => c.RandomOrderGuid).ToList();
		}
	}

}
