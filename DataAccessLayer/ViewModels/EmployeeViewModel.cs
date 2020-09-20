using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        private string lastName;
        public string LastName 
        {
            get; 
            set; 
        }
        private string firstName;
        public string FirstName 
        { 
            get;
            set; 
        }
        public string Psition { get; set; }
        public string Status { get; set; }
    }
}
