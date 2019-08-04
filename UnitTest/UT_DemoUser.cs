using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
	[TestClass]
	public class UT_DemoUser
	{
		[TestMethod]
		public void UTest_1()
		{
			int a = 3, b = 4, exp = 7;
			int act = Lib.DemoUser.Task_1(a, b);
			Assert.AreEqual(exp, act);
		}
		[TestMethod]
		public void UTest_2()
		{
			int a = 3, b = 4, exp = 12;
			int act = Lib.DemoUser.Task_2(a, b);
			Assert.AreEqual(exp, act);
		}
	}
}
