using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employeelist = new List<Employee>();
            Employeelist.Add(new Employee("Dhaha","MPM"));
            Employeelist.Add(new Employee("Waha","KKD"));
            Employeelist.Add(new Employee("Rehana","KTM"));
            Employeelist.Add(new Employee("Anu","TVM"));
            Employeelist.Add(new Employee("Geetha","KTM"));
            Employeelist.Add(new Employee("Jeena","EKM"));
            Employeelist.Add(new Employee("Thaha","KKD"));
            Employeelist.Add(new Employee("Dhanya","MPM"));
            Employeelist.Add(new Employee("Jifil","TVM"));

            var EQuery = from Employee employee in Employeelist
                         orderby employee.City
                         group employee by employee.City;
            foreach(var emp in EQuery)
            {
                Console.WriteLine("Employee with "+emp.Key+" city name : "); 
                
                foreach(var empCity in emp)
                {
                    Console.WriteLine(empCity.EmplyeeName);
                }
            }
        }
    }
}
