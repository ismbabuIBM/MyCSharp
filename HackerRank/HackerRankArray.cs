using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
	[TestClass]
	public class HackerRankArray
	{
		[TestMethod]
		public void TestMethod1()
		{
			int n = 4;
			int[] arr = { 1, 4, 3, 2 };
			//Console.WriteLine(arr.Length);
			for(int i=n-1; i>=0; i--)
			{
				Console.Write(arr[i]);
				if(i==0)
				{
					break;
				}
				else
				{
					Console.Write(" ");
				}
			}
		}
	}
}
