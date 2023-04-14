using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "nnnnbn", 66777m);
            Console.WriteLine(e1.ToString());
        }

        class Employee
        {
            int Id;
            string Name;
            decimal Salary;
            public Employee(int id,
            string name, decimal salary)
            {
                Id = id;
                Name = name;
                Salary = salary;
            }
            public override string ToString()
            {
                string str = "";
                str += "Id: " + Id;
                str += "\nName: " + Name;
                str += "\nSalary: " + Salary;
                return str;
            }
        }
    }
}





