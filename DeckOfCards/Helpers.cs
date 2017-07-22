using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
	public class Helpers
	{
		public static class EnumUtil
		{
			public static IEnumerable<T> GetValues<T>()
			{
				IEnumerable<T> enums = ((T[])Enum.GetValues(typeof(T)));

				return enums;
			}
		}
	}
}
