﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class GoldEmployee : IEmployee
    {
        public decimal GetSalary()
        {
            return 1000;
        }
    }
}
