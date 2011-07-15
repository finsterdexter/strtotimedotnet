using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using strtotimedotnet;

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

			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 7, 15, 0, DateTimeKind.Local), output1);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 6, 45, 0, DateTimeKind.Local), output2);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 19, 15, 0, DateTimeKind.Local), output3);
			Assert.AreEqual<DateTime>(new DateTime(now.Year, now.Month, now.Day, 18, 45, 0, DateTimeKind.Local), output4);
		}
	}
}
