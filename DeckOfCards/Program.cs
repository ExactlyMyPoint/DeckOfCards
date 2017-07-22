using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	class Program
	{
		static void Main(string[] args)
		{
			ICards cards = new Cards();

			cards.CreateNewDeck();
			cards.ShuffleDeck();
		}
	}
}
