﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHRUserInterface.Helpers.Classes
{
     public class EmployeeEventArgs: EventArgs

    {
        public EmployeeModel Employee { private set; get; }
        public EmployeeEventArgs(EmployeeModel employee)

        {
            Employee = employee;
        }
    }
}
