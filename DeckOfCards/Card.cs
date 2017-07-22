using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public class Card
	{
		public Suits Suit { get; set; }
		public int Value { get; set; }
		public int RandomOrder { get; set; }
		public Guid RandomOrderGuid { get; set; }
		public int SortedOrder { get; set; }

		public Card(Suits suit, int value)
		{
			Suit = suit;
			Value = value;
		}

		public Card(Suits suit, int value, int randomOrder) : this(suit, value)
		{
			RandomOrder = randomOrder;
		}

		public Card(Suits suit, int value, Guid order) : this(suit, value)
		{
			RandomOrderGuid = order;
		}
	}
}
