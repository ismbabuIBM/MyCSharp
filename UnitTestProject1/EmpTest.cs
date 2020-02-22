using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class EmpTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			//Create Object instance for class EmpClass
			EmpClass obj1 = new EmpClass("Peter", "Harry");
			EmpClass obj2 = new EmpClass("John", "Parker");
			String obj1fullName = obj1.empFullName();
			String obj2fullName = obj2.empFullName();
			Console.WriteLine("The Employee obj 1 Full Name is: " + obj1fullName+"\n");
			Console.WriteLine("The Employee obj 2 Full Name is: " + obj2fullName + "\n");
			StringAssert.Equals(obj1fullName, obj2fullName);
			StringAssert.ReferenceEquals(obj1fullName, obj2fullName);
		}
	}
}
