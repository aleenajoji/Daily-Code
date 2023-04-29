using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    internal partial class Emp
    {
        private int _empId;

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
