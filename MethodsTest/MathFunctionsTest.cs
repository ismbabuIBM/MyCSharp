using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsTest
{
	[TestClass]
	public class TestStaticOverloadMethods
	{
		[TestMethod]
		public void TestMethod1()
		{
			double resultofSqrt = MathFunctions.SquareRoot(707.18319);
			int resultofIntSum = MathFunctions.Sum(10, 20);
			double resultofDoubleSum = MathFunctions.Sum(613831.7981, 163816383.77991);
			decimal resultofDecimalSum = MathFunctions.Sum(686.890M, 586878.668M);

			Console.WriteLine("ResultofSqrt: {0}, ResultofIntSum: {1}, " +
				"ResultofDoubleSum: {2}, ResultofDecimalSum: {3}", 
				resultofSqrt, resultofIntSum, resultofDoubleSum, resultofDecimalSum);
		}
	}
}
