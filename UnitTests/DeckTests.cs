using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;

namespace DeckOfCards.Tests
{
	[TestClass()]
	public class DeckTests
	{
		[TestMethod()]
		public void StandardDeckTest_CreateNewDeckShouldSucceed()
		{
			StandardDeck actualCards = new StandardDeck();
			List<Card> expectedCards = TestHelper.CreatedSortedStandardDeck();

			actualCards.CreateNewDeck();

			Assert.AreEqual(expectedCards.Count, actualCards.Deck.Count);

			for (int i = 0; i < expectedCards.Count; i++)
			{
				Assert.AreEqual(expectedCards[i].Suit, actualCards.Deck[i].Suit);
				Assert.AreEqual(expectedCards[i].Value, actualCards.Deck[i].Value);
				Assert.AreEqual(expectedCards[i].SortedOrder, actualCards.Deck[i].SortedOrder);
			}
		}

		[TestMethod()]
		public void PinnocleDeckTest_CreateNewDeckShouldSucceed()
		{
			PinochleDeck actualCards = new PinochleDeck();
			List<Card> expectedCard = TestHelper.CreatedSortedPinnocleDeck();

			actualCards.CreateNewDeck();

			Assert.AreEqual(expectedCard.Count, actualCards.Deck.Count);

			for (int i = 0; i < expectedCard.Count; i++)
			{
				Assert.AreEqual(expectedCard[i].Suit, actualCards.Deck[i].Suit);
				Assert.AreEqual(expectedCard[i].Value, actualCards.Deck[i].Value);
				Assert.AreEqual(expectedCard[i].SortedOrder, actualCards.Deck[i].SortedOrder);
			}
		}
	}
}