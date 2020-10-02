using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHRUserInterface.Extensions;
using SystemHRUserInterface.Forms.Employees.Base;

namespace SystemHRUserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
            new GenderModel("kobieta"),
            new GenderModel("mężczyzna"),
            new GenderModel(string.Empty)
            };
            bsGender.DataSource = genders;
            cbGender.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        protected override void Save()
        {
            MessageBox.Show("Zapisano");
            Close();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano");
            Close();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DatePickerValueChanged();

        }
    }
}
 