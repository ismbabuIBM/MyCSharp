using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTest
{
	class MathFunctions
	{
		public static double SquareRoot(double num)
		{
			return Math.Sqrt(num);
		}

		public static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}

		public static double Sum(double num1, double num2)
		{
			return num1 + num2;
		}

		public static decimal Sum(decimal num1, decimal num2)
		{
			return num1 + num2;
		}
	}
}
