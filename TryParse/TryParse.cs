using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
	class TryParse
	{
		static void Main(string[] args)
		{
			string[] arr = new string[10];
			Console.Clear();
			Console.Write("Please Enter input values.");
			Console.WriteLine();
			for(int i=0; i<arr.Length; i++)
			{
				arr[i] = Console.ReadLine();
			}
			Console.Write("The inputs given by the user is : {");
			for(int j=0; j<arr.Length; j++)
			{
				Console.Write(arr[j]);
				if(j != arr.Length -1)
				{
					Console.Write(", ");
				}
				else
				{
					break;
				}
			}
			Console.WriteLine("}");
			Console.WriteLine("<--------------------------------------------------------->");
			
			//calling static method without object
			TryParse.TryParseMethod(arr);
			Console.Write("Press any key to exit");
			//ReadKey to avoid console to close automatically
			Console.ReadKey();
		}//main method
		public static void TryParseMethod(String[] arr)
		{ 
			foreach(string arrValue in arr)
			{	
				/*
				TryParse tries to convert integer value on String to Equivalent Int. If success, returns true. Else, returns false.
				arrValue contains String integer, Eg. 12
				12 can be parsed from Sting to Int32 in strEquInt. So, it is a Success case.
				*/
				bool convSuccess = Int32.TryParse(arrValue, out int strEquInt);

				if(convSuccess)
				{
					Console.WriteLine("The successful conversion of String to Int32 is: {0}", arrValue);
				}
				else
				{
					Console.WriteLine("String to Int32 conversion failure for: {0}", arrValue ?? "<null>");
				}
			}
		}//static method
	}//class
}//namespace
