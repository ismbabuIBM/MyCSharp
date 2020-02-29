using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ArrayListNameSpace
{
	[TestClass]
	public class ArrayListTest
	{
		public static int sum = 0;
		[TestMethod]
		public void TestMethod1()
		{
			//ArrayList Object
			ArrayList dataList = new ArrayList();
			
			//Add collections to ArrayList
			dataList.Add("Someday");

			dataList.Add(2);

			dataList.Add("app");

			dataList.Add("13.5");

			dataList.Add("red");

			dataList.Add(8);

			dataList.Add(99);

			dataList.Add("6");

			dataList.Add("Meatball soup");

			dataList.Add(18M);

			dataList.Add("pieces");

			dataList.Add("14");

			for(int i = 0; i<dataList.Count;)
			{
				if(dataList[i].GetType().FullName == "System.Int32" || Int32.TryParse(dataList[i].ToString(), out int result))
				{
					Console.Write(dataList[i] + " ");
					i++;
				}
				else
				{
					dataList.RemoveAt(i);
				}
			}
			Console.WriteLine("\nThe updated count of cleaned ArrayList(Only Int32) is: "+ dataList.Count);
			//The sum of integers in ArrayList
			for (int i = 0; i < dataList.Count;i++)
			{
					sum = sum + Convert.ToInt32(dataList[i]);
			}
			Console.WriteLine("The sum of int32 elements in ArrayList is " + sum);
		}
	}
}
