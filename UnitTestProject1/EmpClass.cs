using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
	class EmpClass
	{
		//Set Private Variables
		private String empFirstName;
		private String empLastName;

		//Create Constructor
		public EmpClass(String Fname, String Lname)
		{
			EmpFirstName = Fname;
			EmpLastName = Lname;
		}

		//Create Properties of Private Variables
		public String EmpFirstName
		{
			get
			{
				return empFirstName;
			}
			set
			{
				empFirstName = value;
			}
		}
		public String EmpLastName
		{
			get
			{
				return empLastName;
			}
			set
			{
				empLastName = value;
			}
		}

		public String empFullName()
		{
			return EmpFirstName +" "+ EmpLastName;
		}

	}
}
