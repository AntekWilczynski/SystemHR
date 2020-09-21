using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.ViewModels;

namespace SystemHRUserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;
        public static EmployeesForm Instance
        {
            get
            { if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

private EmployeesForm()
        { 
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            throw new NotImplementedException();
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
