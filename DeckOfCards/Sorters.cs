using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public class SortByNewDeck : IDeckSorter
	{
		public List<Card> Sort(IDeck deck)
		{
			deck.CreateNewDeck();

			return deck.Deck;
		}
	}

	public class SortBySortedOrder : IDeckSorter
	{
		public List<Card> Sort(IDeck deck)
		{
			deck.Deck = deck.Deck.OrderBy(c => c.SortedOrder).ToList();

			return deck.Deck;
		}
	}

}
