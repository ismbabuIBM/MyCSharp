using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
	[TestClass]
	public class HackerRankTest
	{
		[TestMethod]
		public void DataTypeTest()
		{
			/*
			double d = 4.0;
			double e = 8.0;
			double f = d + e;

			Console.WriteLine(f.ToString("0.0"));
			
			double meal = 12.00;
			double tip = (20/(double)100) * meal;
			double tax = (8 / (double)100) * meal;

			double bill = tip + tax + meal;
			
			Console.WriteLine("Tip: "+tip);
			Console.WriteLine("Tax: " +tax);
			Console.WriteLine(Convert.ToInt16(bill));
			
			int n = 4;
			for(int i=1; i<=10; i++)
			{
				Console.WriteLine(n + " x " + i + " = " + n * i);
			}
			*/

			int T = 1;

			for(int i=0; i<=T-1; i++)
			{
				string S = "Hacker";
				for(int j=0; j<S.Length; j++)
				{
					if(j%2 == 0)
					{
						Console.Write(S[j]);
					}
				}
				Console.Write("  ");
				for (int k = 0; k < S.Length; k++)
				{
					if (k % 2 != 0)
					{
						Console.Write(S[k]);
					}
				}

			}


		}
	}
}
