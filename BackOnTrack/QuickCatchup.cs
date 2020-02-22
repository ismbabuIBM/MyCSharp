using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOnTrack
{
	class QuickCatchup
	{
		private int num1;
		private int num2;

		//Constructor with Args
		public QuickCatchup(int a, int b)
		{
			Num1 = a;
			Num2 = b;
		}
		//Properties
		public int Num1
		{
			get
			{
				return num1;
			}
			set
			{
				if(value >= 0)
				{
					num1 = value;
				}
				else
				{
					Assert.Fail("You have entered -ve number");
				}
			}
		}
		public int Num2
		{
			get
			{
				return num2;
			}
			set
			{
				if(value >= 5)
				{
					num2 = value;
				}
				else
				{
					Assert.Fail("You have entered number less than 5");
				}
			}
		}

		public int MathCall()
		{
			return Num1 * Num2;
		}

	}
}
