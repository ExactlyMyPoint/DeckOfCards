﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
	public interface IShuffler
	{
		List<Card> Shuffle(List<Card> cards);
	}
}
