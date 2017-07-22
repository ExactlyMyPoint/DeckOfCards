using DeckOfCards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using System.Collections.Generic;
using UnitTests;
using System;

namespace DeckOfCards.Tests
{
	[TestClass()]
	public class CardsTests
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
		public void CreateNewDeckTest_ShouldCreateNewSortedDeck()
		{
			List<Card> actualDeck = null;
			List<Card> expectedDeck = TestHelper.CreatedSortedStandardDeck();

			Cards actualCards = new Cards(_deck, null, null);
			A.CallTo(() => _deck.CreateNewDeck()).Invokes(() => { actualDeck = TestHelper.CreatedSortedStandardDeck(); });

			actualCards.CreateNewDeck();
			A.CallTo(() => _deck.CreateNewDeck()).MustHaveHappened();

			Assert.AreEqual(expectedDeck.Count, actualDeck.Count);

			for (int i = 0; i < expectedDeck.Count; i++)
			{
				Assert.AreEqual(expectedDeck[i].Suit, actualDeck[i].Suit);
				Assert.AreEqual(expectedDeck[i].Value, actualDeck[i].Value);
			}
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void ShuffleDeckTest_ShouldFailIfDeckOfCardsNull()
		{
			Cards actualCards = new Cards(null, null, null);
			actualCards.ShuffleDeck();
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void ShuffleDeckTest_ShouldFailIfDeckNull()
		{
			IDeck deck = new TestHelper.TestDeck(null);
			Cards actualCards = new Cards(deck, null, null);
			actualCards.ShuffleDeck();
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void ShuffleDeckTest_ShouldFailIfDeckEmpty()
		{
			IDeck deck = new TestHelper.TestDeck(new List<Card>());
			Cards actualCards = new Cards(deck, null, null);
			actualCards.ShuffleDeck();
		}

		[TestMethod()]
		public void ShuffleDeckTest_ShuffleDeckShouldSucceed()
		{
			List<Card> expectedDeck = TestHelper.CreatedShuffledStandardDeck();

			IDeck deck = new TestHelper.TestDeck(TestHelper.CreatedSortedStandardDeck());
			Cards actualCards = new Cards(deck, null, null);

			A.CallTo(() => _cards.ShuffleDeck()).Invokes(() => { deck.Deck = TestHelper.CreatedShuffledStandardDeck(); });

			_cards.ShuffleDeck();

			A.CallTo(() => _cards.ShuffleDeck()).MustHaveHappened();
			Assert.AreEqual(expectedDeck.Count, actualCards.DeckOfCards.Deck.Count);

			for (int i = 0; i < expectedDeck.Count; i++)
			{
				Assert.AreEqual(expectedDeck[i].Suit, actualCards.DeckOfCards.Deck[i].Suit);
				Assert.AreEqual(expectedDeck[i].Value, actualCards.DeckOfCards.Deck[i].Value);
			}
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void SortDeckTest_ShouldFailIfDeckOfCardsNull()
		{
			Cards actualCards = new Cards(null, null, null);
			actualCards.SortDeck();
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void SortDeckTest_ShouldFailIfDeckNull()
		{
			IDeck deck = new TestHelper.TestDeck(null);
			Cards actualCards = new Cards(deck, null, null);
			actualCards.SortDeck();
		}

		[TestMethod()]
		[ExpectedException(typeof(Exception))]
		public void SortDeckTest_ShouldFailIfDeckEmpty()
		{
			IDeck deck = new TestHelper.TestDeck(new List<Card>());
			Cards actualCards = new Cards(deck, null, null);
			actualCards.SortDeck();
		}

		[TestMethod()]
		public void SortDeckTest_SortedDeckShouldSucceed()
		{
			List<Card> expectedDeck = TestHelper.CreatedSortedStandardDeck();

			IDeck deck = new TestHelper.TestDeck(TestHelper.CreatedShuffledStandardDeck());
			Cards actualCards = new Cards(deck, null, null);

			A.CallTo(() => _cards.SortDeck()).Invokes(() => { deck.Deck = TestHelper.CreatedSortedStandardDeck(); });

			_cards.SortDeck();
			A.CallTo(() => _cards.SortDeck()).MustHaveHappened();

			Assert.AreEqual(expectedDeck.Count, actualCards.DeckOfCards.Deck.Count);

			for (int i = 0; i < expectedDeck.Count; i++)
			{
				Assert.AreEqual(expectedDeck[i].Suit, actualCards.DeckOfCards.Deck[i].Suit);
				Assert.AreEqual(expectedDeck[i].Value, actualCards.DeckOfCards.Deck[i].Value);
			}
		}

		[TestMethod()]
		public void WriteLineTest()
		{
			Cards cards = new Cards(null, null, null);
			Card expectedCard = new Card(Suits.Heart, (int)StandardCardValue.Five, 7);
			string expectedLine = "Card: 5 of Heart - order: 7";
			string actualLine = cards.WriteLine(expectedCard);

			Assert.AreEqual(expectedLine, actualLine);
		}
	}
}