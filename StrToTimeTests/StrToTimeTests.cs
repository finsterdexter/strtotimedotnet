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
		[TestMethod]
		public void TestMethod1()
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

		[TestMethod]
		public void TestMethod2()
		{
		}
	}
}
