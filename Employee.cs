using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class Employee : IEmployee
    {
        private readonly IEmployee _employeeType;
        public Employee(IEmployee employeeType)
        {
            _employeeType = employeeType;
        }
        public decimal GetSalary()
        {
            return _employeeType.GetSalary();
        }
    }
}
