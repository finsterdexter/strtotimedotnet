using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using strtotimedotnet;
using System.Globalization;

namespace StrToTimeTests
{
	[TestClass]
	public class StrToTimeTests
	{
		/// <summary>
		/// strtotime.phpt
		/// </summary>
		[TestMethod]
		public void strtotime()
		{
			DateTime output1 = StrToTimeClass.StrToTime("2005-07-14 22:30:41");
			DateTime output2 = StrToTimeClass.StrToTime("2005-07-14 22:30:41 GMT");
			DateTime output3 = StrToTimeClass.StrToTime("1121373041");
			DateTime output4 = StrToTimeClass.StrToTime("1121373041 CEST");

			Assert.AreEqual<DateTime>(new DateTime(2005, 7, 14, 22, 30, 41, DateTimeKind.Local), output1);
			Assert.AreEqual<DateTime>(new DateTime(2005, 7, 14, 16, 30, 41, DateTimeKind.Local), output2);
			Assert.AreEqual<DateTime>(new DateTime(2005, 7, 14, 22, 30, 41, DateTimeKind.Local), output3);
			Assert.AreEqual<DateTime>(new DateTime(2005, 7, 14, 22, 30, 41, DateTimeKind.Local), output4);

		}

		/// <summary>
		/// strtotime_basic.phpt
		/// </summary>
		[TestMethod]
		public void strtotime_basic()
		{
			DateTime output1 = StrToTimeClass.StrToTime("1 Monday December 2008");
			DateTime output2 = StrToTimeClass.StrToTime("2 Monday December 2008");
			DateTime output3 = StrToTimeClass.StrToTime("3 Monday December 2008");
			DateTime output4 = StrToTimeClass.StrToTime("first Monday December 2008");
			DateTime output5 = StrToTimeClass.StrToTime("second Monday December 2008");
			DateTime output6 = StrToTimeClass.StrToTime("third Monday December 2008");

			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 1), output1);
			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 8), output2);
			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 15), output3);
			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 8), output4);
			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 15), output5);
			Assert.AreEqual<DateTime>(new DateTime(2008, 12, 22), output6);
		}

		/// <summary>
		/// strtotime_basic2.phpt
		/// </summary>
		[TestMethod]
		public void strtotime_basic2()
		{
			DateTime output1 = StrToTimeClass.StrToTime("mayy 2 2009"); // misspelled month name

			Assert.IsNull(output1);
		}

		[TestMethod]
		public void strtotime_variation_scottish()
		{
			DateTime output1 = StrToTimeClass.StrToTime("back of 7");
			DateTime output2 = StrToTimeClass.StrToTime("front of 7");
			DateTime output3 = StrToTimeClass.StrToTime("back of 19");
			DateTime output4 = StrToTimeClass.StrToTime("front of 19");

			DateTime now = new DateTime();

			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 7, 15, 0), output1);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 6, 45, 0), output2);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 19, 15, 0), output3);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 18, 45, 0), output4);
		}

		[TestMethod]
		public void strtotime2()
		{
			const string DATE_ATOM = "";
			const string DATE_COOKIE = "";
			const string DATE_ISO8601 = "";
			const string DATE_RFC822 = "";
			const string DATE_RFC850 = "";
			const string DATE_RFC1036 = "";
			const string DATE_RFC1123 = "";
			const string DATE_RFC2822 = "";
			const string DATE_RFC3339 = "";
			const string DATE_RSS = "";
			const string DATE_W3C = "";
			
			DateTime time = DateTime.Now;



			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("d")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("D")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("f")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("F")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("g")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("G")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("m")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("o")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("r")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("s")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("t")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("T")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("u")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("U")));
			Assert.AreEqual<DateTime>(time, StrToTimeClass.StrToTime(time.ToString("y")));
		}
	}
}
