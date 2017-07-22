using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeckOfCards.Helpers;

namespace DeckOfCards
{
	public class Cards : ICards
	{
		private IShuffler shuffler;
		private IDeckSorter deckSorter;

		public IDeck DeckOfCards { get; private set; }

		public Cards()
		{
			DeckOfCards = new StandardDeck();
			shuffler 	= new ShufflerInt();
			deckSorter 	= new SortByNewDeck();
		}

		public Cards(IDeck deck, IShuffler shuffler, IDeckSorter deckSorter)
		{
			this.DeckOfCards = deck;
			this.shuffler 	 = shuffler;
			this.deckSorter  = deckSorter;
		}

		public void CreateNewDeck()
		{
			DeckOfCards.CreateNewDeck();
		}

		public void SortDeck()
		{
			ValidateNonEmptyDeck();

			DeckOfCards.Deck = deckSorter.Sort(DeckOfCards);
		}

		public void ShuffleDeck()
		{
			ValidateNonEmptyDeck();

			DeckOfCards.Deck = shuffler.Shuffle(DeckOfCards.Deck);
		}

		private void ValidateNonEmptyDeck()
		{
			if (DeckOfCards == null)
				throw new Exception("No deck of cards");

			if (DeckOfCards.Deck == null)
				throw new Exception("Null deck");

			if (DeckOfCards.Deck.Count == 0)
				throw new Exception("Empty deck");
		}

		public string WriteLine(Card card)
		{
			string lineFormat = "Card: {0} of {1} - order: {2}";
			string writeLine = string.Format(lineFormat, card.Value, card.Suit, card.RandomOrder);

			return writeLine;
		}

		public void OutputToConsole()
		{
			foreach (Card card in DeckOfCards.Deck)
			{
				Console.WriteLine(WriteLine(card));
			}
		}
	}
}
