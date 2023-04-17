using System;

namespace collectDemo1
{

    public class Emp : IComparable

    {

        private int _empid;

        public int EmpId

        {

            get { return _empid; }

            set { _empid = value; }

        }

        private string _empname;

        public string EmpName

        {

            get { return _empname; }

            set { _empname = value; }

        }

        private decimal _salary;

        public decimal Salary

        {

            get { return _salary; }

            set { _salary = value; }

        }

        public Emp()

        {

        }

        public Emp(int empid, string empname, decimal salary)

        {

            this.EmpId = empid;

            EmpName = empname;

            Salary = salary;

        }

        public override string ToString()

        {

            return $"Emp ID:{EmpId} Emp Name:{EmpName} Emp Salary:{Salary}";

        }

        public override bool Equals(object obj)

        {

            Emp temp = obj as Emp;

            return temp.EmpId == this.EmpId;

        }

        public override int GetHashCode()

        {

            return base.GetHashCode();

        }

        public int CompareTo(object obj)

        {

            Emp temp = obj as Emp;

            return Salary.CompareTo(temp.Salary);

        }

    }
}