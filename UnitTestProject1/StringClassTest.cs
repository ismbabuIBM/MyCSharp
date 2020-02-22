using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class StringClassTest
	{
		[TestMethod]
		public void StringTestMethod()
		{
			String mystr = "This is Mindtree";
			Console.WriteLine(mystr + "\n");
			String upletter = mystr.ToUpper();
			Console.WriteLine(upletter);
			Console.WriteLine("The length of String is: " + upletter.Length);
		}
	}
}
