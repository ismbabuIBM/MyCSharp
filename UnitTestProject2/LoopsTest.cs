using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
	[TestClass]
	public class LoopsTest
	{
		[TestMethod]
		public void NestedWhile()
		{
			int Outer = 0;

			while(Outer < 3)
			{
				int Inner = 10;
				while (Inner > 5)
				{
					Console.WriteLine("Outer: " + Outer + "\t\t" + "Inner: " + Inner + "\n");
					Inner--;
				}	
				Outer++;
			}
		}

		[TestMethod]
		public void BreakandContinue()
		{
			char letter = 'a';
			switch(letter)
			{
				case 'l':
					Console.WriteLine("Letter l received...");
					break;
				case 'a':
					string let = letter.ToString();
					int len = let.Length;
					String length = Convert.ToString(len);
					Console.Write("let is: " + let + " length is: " + length);
					break;
				default:
					Console.WriteLine("Invalid Char...");
					break;
			}
		}

		[TestMethod]
		public void PrintTriangle()
		{
			String alpha = "abcdefghijklm";
			int length = alpha.Length;
			if(length%2 != 0)
			{
				int n = length / 2;
				int m = n;
				for (int i = 0; i <= m ; i++)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write(" ");
					}
					Console.Write(alpha.Substring(0, (2 * i) + 1));
					for (int j = 0; j < n; j++)
					{
						Console.Write(" ");
					}
					n--;
					Console.Write("\n");
				}
			}
			else
			{
				Assert.Fail("Not an Odd String...");
			}
		}
	}
}
