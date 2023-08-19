using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class SilverEmployee : IEmployee
    {
        public decimal GetSalary()
        {
            return 800;
        }
    }
}
