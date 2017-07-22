using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using static UnitTests.TestHelper;
using FakeItEasy;

namespace DeckOfCards.Tests
{
	[TestClass()]
	public class SortTests
	{
		private ICards _cards;
		private IDeck _deck;

		[TestInitialize]
		public void Initialize()
		{
			_cards = A.Fake<ICards>();
			_deck = A.Fake<IDeck>();
		}

		[TestMethod()]
		public void SortByNewDeckTest_SortShouldSucceed()
		{
			List<Card> expectedCards = TestHelper.CreatedSortedStandardDeck();

			_deck.Deck = CreatedShuffledStandardDeck();
			Cards actualCards = new Cards(_deck, null, new SortByNewDeck());
			A.CallTo(() => _deck.CreateNewDeck()).Invokes(() => { _deck.Deck = TestHelper.CreatedSortedStandardDeck(); });

			actualCards.SortDeck();

			Assert.AreEqual(expectedCards.Count, actualCards.DeckOfCards.Deck.Count);

			for (int i = 0; i < expectedCards.Count; i++)
			{
				Assert.AreEqual(expectedCards[i].Suit, actualCards.DeckOfCards.Deck[i].Suit);
				Assert.AreEqual(expectedCards[i].Value, actualCards.DeckOfCards.Deck[i].Value);
			}
		}

		[TestMethod()]
		public void SortBySortedOrderTest_SortShouldSucceed()
		{
			List<Card> expectedCards = TestHelper.CreatedSortedStandardDeck();

			_deck.Deck = CreatedShuffledStandardDeck();
			Cards actualCards = new Cards(_deck, null, new SortBySortedOrder());

			actualCards.SortDeck();

			Assert.AreEqual(expectedCards.Count, actualCards.DeckOfCards.Deck.Count);

			for (int i = 0; i < expectedCards.Count; i++)
			{
				Assert.AreEqual(expectedCards[i].Suit, actualCards.DeckOfCards.Deck[i].Suit);
				Assert.AreEqual(expectedCards[i].Value, actualCards.DeckOfCards.Deck[i].Value);
			}
		}
	}
}