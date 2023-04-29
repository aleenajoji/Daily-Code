using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    internal partial class Emp
    {
        public void Display()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(Name);
        }
    }
}
