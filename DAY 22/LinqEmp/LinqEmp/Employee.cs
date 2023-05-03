using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmp
{
    internal class Employee
    {
		private string _employeeName;

		public string EmplyeeName
		{
			get { return _employeeName; }
			set { _employeeName = value; }
		}
		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}


		public Employee() { }
		public Employee(string employeeName,string city) {
			_employeeName = employeeName;
			_city = city;
		}

	}
}
