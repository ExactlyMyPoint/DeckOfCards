using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public interface IDeck
	{
		List<Card> Deck { get; set; }
		void CreateNewDeck();
	}
}
