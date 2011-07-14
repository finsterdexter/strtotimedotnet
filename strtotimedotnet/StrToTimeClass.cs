using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strtotimedotnet
{
	public static class StrToTimeClass
	{

		public static DateTime StrToTime(string input) 
		{

			DateTime output = DateTime.MinValue;

			DateTime.TryParse(input, out output);
			if (output != DateTime.MinValue)
			{
				// parsed successfully
				return output;
			}

			if (int.Parse(input) > 0)
			{
			}

			return output;

		}

	}
}
