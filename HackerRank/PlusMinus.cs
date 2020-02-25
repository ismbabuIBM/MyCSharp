using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank
{
	[TestClass]
	public class PlusMinus
	{
		public static int zeroCounter = 0;
		public static int posCounter = 0;
		public static int negCounter = 0;
		[TestMethod]
		public void PlusMinusTest()
		{
			int[] arr = { -4, 3, -9, 0, 4, 1};
			double len = arr.Length;
		
			foreach(int element in arr)
			{
				if(element == 0)
				{
					zeroCounter += 1;
				}
				else if(element > 0)
				{
					posCounter += 1;
				}
				else if(element < 0)
				{
					negCounter += 1;
				}
				else
				{
					Console.WriteLine("Invalid Element Passed");
				}
			}

			//double zero = posCounter/len;
			Console.WriteLine(Convert.ToDouble(posCounter/len).ToString("0.000000")+"\n"+Convert.ToDouble(negCounter/len).ToString("0.000000")+"\n"+Convert.ToDouble(zeroCounter/len).ToString("0.000000"));


		}
	}
}
