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

		public static String TimeZoneName(DateTime dt)
		{
			String sName = TimeZone.CurrentTimeZone.IsDaylightSavingTime(dt)
				? TimeZone.CurrentTimeZone.DaylightName
				: TimeZone.CurrentTimeZone.StandardName;

			String sNewName = "";
			String[] sSplit = sName.Split(new char[] { ' ' });
			foreach (String s in sSplit)
				if (s.Length >= 1)
					sNewName += s.Substring(0, 1);

			return sNewName;
		}

	}
}
