using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckOfCards;

namespace UnitTests
{
	public class TestHelper
	{
		public static List<Card> CreatedSortedStandardDeck()
		{
			List<Card> deck = new List<Card>();

			int i = 0;

			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Two,   i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Three, i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Four,  i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Five,  i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Six,   i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Seven, i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Eight, i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Spade, StandardCardValue.King,  i++);

			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Two,   i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Three, i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Four,  i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Five,  i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Six,   i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Seven, i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Eight, i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Heart, StandardCardValue.King,  i++);

			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Ace, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Two, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Three, i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Four, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Five, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Six, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Seven, i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Eight, i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Nine, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Ten, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Jack, 	i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Diamond, StandardCardValue.King, 	i++);

			AddCardToDeck(deck, Suits.Club, StandardCardValue.Ace, 	 i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Two, 	 i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Three, i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Four,  i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Five,  i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Six, 	 i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Seven, i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Eight, i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Ten, 	 i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Club, StandardCardValue.King,  i++);

			return deck;
		}

		public static List<Card> CreatedSortedPinnocleDeck()
		{
			List<Card> deck = new List<Card>();

			int i = 0;

			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.King,  i++);
			AddCardToDeck(deck, Suits.Spade, PinnocleCardValue.King,  i++);

			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Ace,   i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Ten,   i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.King,  i++);
			AddCardToDeck(deck, Suits.Heart, PinnocleCardValue.King,  i++);

			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Ace, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Ace, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Nine, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Nine, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Ten, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Ten, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Jack, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Jack, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.King, 	i++);
			AddCardToDeck(deck, Suits.Diamond, PinnocleCardValue.King, 	i++);

			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Ace, 	 i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Ace, 	 i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Nine,  i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Ten, 	 i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Ten, 	 i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Jack,  i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.Queen, i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.King,  i++);
			AddCardToDeck(deck, Suits.Club, PinnocleCardValue.King,  i++);

			return deck;
		}

		public static List<Card> CreatedShuffledStandardDeck()
		{
			List<Card> deck = CreatedSortedStandardDeck();

			for (int i = 0; i < deck.Count; i++)
			{
				deck[i].RandomOrder = randomListOf52[i];
			}

			return deck.OrderBy(o => o.RandomOrder).ToList();
		}


		public static void AddCardToDeck(List<Card> deck, Suits suit, StandardCardValue value, int sortedOrder) 
		{
			Card newCard = new Card(suit, (int)value);
			newCard.SortedOrder = sortedOrder;
			deck.Add(newCard);
		}

		public static void AddCardToDeck(List<Card> deck, Suits suit, PinnocleCardValue value, int sortedOrder)
		{
			Card newCard = new Card(suit, (int)value);
			newCard.SortedOrder = sortedOrder;
			deck.Add(newCard);
		}

		public class TestDeck : IDeck
		{
			public List<Card> Deck { get; set; }

			private List<Card> saveDeck;


			public TestDeck(List<Card> deck)
			{
				Deck = deck;
				saveDeck = deck;
			}

			public void CreateNewDeck()
			{
				Deck = saveDeck;
			}
		}


		//public class NullDeck : IDeck
		//{
		//	public List<Card> Deck { get; private set; }

		//	public void CreateNewDeck()
		//	{
		//		Deck = null;
		//	}
		//}

		//public class EmptyDeck : IDeck
		//{
		//	public List<Card> Deck { get; set; }

		//	public void CreateNewDeck()
		//	{
		//		Deck = new List<Card>();
		//	}
		//}

		//public class StandardDeck : IDeck
		//{
		//	public List<Card> Deck { get; set; }

		//	public void CreateNewDeck()
		//	{
		//		Deck = TestHelper.CreatedSortedStandardDeck();
		//	}
		//}

		private static int[] randomListOf52 =
			{
				46,
				19,
				43,
				6,
				15,
				49,
				36,
				2,
				22,
				13,
				16,
				12,
				23,
				18,
				45,
				37,
				0,
				21,
				44,
				42,
				26,
				9,
				39,
				3,
				5,
				41,
				24,
				38,
				34,
				14,
				27,
				31,
				51,
				48,
				35,
				7,
				28,
				20,
				30,
				8,
				32,
				11,
				17,
				25,
				29,
				40,
				10,
				1,
				50,
				33,
				4,
				47
			};

	}
}
