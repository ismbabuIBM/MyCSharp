using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays
{
	[TestClass]
	public class ArrayTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string S = "Iphone 10 X";

			foreach(char C in S)
			{
				Console.Write(C);
			}

		}
	}
}
