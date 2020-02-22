using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsAndOthers
{
	class MathHelper
	{
		public static decimal sqrtfun(double number)
		{
			return Convert.ToDecimal(Math.Sqrt(number));
		}
		public static int NamedOptionalParam(int num1, int num2, int num3 = 50)
		{
			return num1 + num2 + num3;
		}
		public static void OutParam(out int value)
		{
			value = 20;
		}
		public static void RefParam(ref int value)
		{
			value = 80;
		}

	}
}
