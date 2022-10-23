using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanSerialization
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool IsBranchManager { get; set; }

        public override string ToString()
        {
            return "Name:" + Name + ", Salary:" + Salary + ", IsBranchManager:" + IsBranchManager;
        }
    }
}
