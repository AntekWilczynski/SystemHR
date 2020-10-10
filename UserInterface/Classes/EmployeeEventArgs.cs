using System;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.UserInterface.Classes
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
