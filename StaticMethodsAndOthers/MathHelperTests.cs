using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaticMethodsAndOthers
{
	[TestClass]
	public class MathHelperTests
	{
		[TestMethod]
		public void StaticMethodTest()
		{
			//calling static method in MathHelper class without need of creating object
			Console.WriteLine(Math.Round(MathHelper.sqrtfun(57.45), 2, MidpointRounding.ToEven));
		}

		[TestMethod]
		public void NamedOptionalParamTest()
		{
			/*
			 * named and optional params
			 * num1 - named, num2 - named but num3 is optional param in NamedOptionalParam method
			 * passing value for num3 is optional because value for num3 is already set in method itself
			 * still we can pass value of num3(--priority given for this value)
			 */
			Console.WriteLine(MathHelper.NamedOptionalParam(num1: 10, num2: 20));
		}
		[TestMethod]
		public void OutAndRefKeywordTest()
		{
			/*
			 * OUT & REF keywords actually & almost does the same job
			 * It returns the constant value set inside the method (even though value is changed as part of test method
			 * For Ref param, initializing value is manadatory whereas for Out param it is not
			 */ 
			int someNumber;
			int someOtherNumber = 10;
			MathHelper.OutParam(out someNumber);
			MathHelper.RefParam(ref someOtherNumber);

			Console.WriteLine("Output of OUT: "+someNumber + "\nOutput of REF: "+ someOtherNumber);
		}
		[TestMethod]
		public void TupleTest()
		{
			Tuple<int, string, double, bool> obj = new 
				Tuple<int, string, double, bool>(10, "hello", 47646.575, true);

			if(obj.Item1 == 10)
			{
				Console.WriteLine("Tuple Item1: " + obj.Item1);
			}

			if (obj.Item4)
			{
				Console.WriteLine("Printed only if Item4 of Tuple is True");
			}
		}

	}
}
