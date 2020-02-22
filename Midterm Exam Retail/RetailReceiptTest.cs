using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Midterm_Exam_Retail
{
	[TestClass]
	public class TestRetailReceipt
	{
		[TestMethod]
		public void TestMethod1()
		{
			DateTime now = DateTime.Now;
			RetailReceiptClass obj = new RetailReceiptClass(4466, now, "C6947", 0.01M);
			Console.WriteLine(obj);
		}

		[TestMethod]
		public void MyTest()
		{
			String name = "Peter";
			int lengthofName = name.Length;
			char nameStartsWith = Convert.ToChar(name.Substring(0, 1));

			Console.WriteLine("The length of name: " + name + " is: " + 
				lengthofName + ". and it starts with char: '" + nameStartsWith +
				"' Printed on: " + DateTime.Now);
		}
	}
}
