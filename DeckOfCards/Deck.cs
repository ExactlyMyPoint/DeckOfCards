using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeckOfCards.Helpers;

namespace DeckOfCards
{
	public class StandardDeck : IDeck
	{
		public List<Card> Deck { get; set; }

		public void CreateNewDeck()
		{
			Deck = new List<Card>();
			int sortOrder = 0;

			foreach (Suits suit in EnumUtil.GetValues<Suits>())
			{
				foreach (StandardCardValue value in EnumUtil.GetValues<StandardCardValue>())
				{
					Card newCard = new Card(suit, (int)value);
					newCard.SortedOrder = sortOrder++;
					Deck.Add(newCard);
				}
			}
		}
	}

	public class PinochleDeck : IDeck
	{
		public List<Card> Deck { get; set; }

		public void CreateNewDeck()
		{
			Deck = new List<Card>();
			int sortOrder = 0;

			foreach (Suits suit in EnumUtil.GetValues<Suits>())
			{
				foreach (PinnocleCardValue value in EnumUtil.GetValues<PinnocleCardValue>())
				{
					for (int i = 0; i < 2; i++)
					{
						Card newCard = new Card(suit, (int)value);
						newCard.SortedOrder = sortOrder++;
						Deck.Add(newCard);
					}
				}
			}
		}
	}
}
