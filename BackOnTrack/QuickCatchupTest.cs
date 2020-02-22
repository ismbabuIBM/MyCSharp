using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BackOnTrack
{
	[TestClass]
	public class QuickCatchupTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			QuickCatchup obj = new QuickCatchup(10, 7);
			int result = obj.MathCall();
			Console.WriteLine("The result of Math Call is: " + result);
		}
	}
}
