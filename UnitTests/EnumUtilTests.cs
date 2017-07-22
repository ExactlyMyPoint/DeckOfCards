using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeckOfCards.Helpers;

namespace DeckOfCards.Tests.Helpers
{
	[TestClass()]
	public class EnumUtilTests
	{
		[TestMethod()]
		public void GetValuesTest()
		{
			// setup
			List<Suits> nextSuit = EnumUtil.GetValues<Suits>().ToList();
			int i = 0;

			Assert.AreEqual(Suits.Spade,   nextSuit[i++]);
			Assert.AreEqual(Suits.Heart,   nextSuit[i++]);
			Assert.AreEqual(Suits.Diamond, nextSuit[i++]);
			Assert.AreEqual(Suits.Club,    nextSuit[i++]);
		}
	}
}