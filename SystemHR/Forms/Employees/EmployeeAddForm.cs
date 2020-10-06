using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHRUserInterface.Extensions;
using SystemHRUserInterface.Forms.Employees.Base;
using SystemHRUserInterface.Helpers;
using SystemHRUserInterface.Helpers.Classes;

namespace SystemHRUserInterface.Forms.Employees
{
    

    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EventHandler ReloadEmployees;
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))

            {
                epLastName.SetError(txtLastName, "Pole Nazwisko jest wymagane. ");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))

            {
                epFirstName.SetError(txtFirstName, "Pole Imię jest wymagane. ");
            }
            else
            {
                epFirstName.Clear();
            }
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
            if (ValidateForm())
            {

            }
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano");
            Close();
        }
        protected override void Save()
        {
            if (ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DataBirth = dtpDateBirth.Value,
                    PESEL = txtPESEL.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EmailAddress = txtEmailAddress.Text,
                    IdentityCardNumber = txtIdentityCard.Text,
                    IssueDateIdentytyCard = dtpIssueDateIdentityCard.Value,
                    ExpirationDateIdentytyCard = dtpExpirationIdentityCard.Value,
                    PassportNumber = txtPassport.Text,
                    IssueDatePassport = dtpExpirationPassport.Value,
                    ExpirationDatePassport = dtpExpirationPassport.Value,
                    Status = new StatusModel("Wprowadzony")
                };
                // employee = CreateEmployee(employee);
                employee.Id = 4;
                employee.Code = 4;

                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));

                Close();
            }
        }


        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string lastNameErrorMessage = epLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }
            if (sbErrorMessage.Length>0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie pracownika...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            string peselWarningMessage = epPESEL.GetError(txtPESEL);
            if (!string.IsNullOrEmpty(peselWarningMessage))
            {
                DialogResult answer =
                    MessageBox.Show(
                        peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika? ",
                        "Dodawanie pracownika...",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (answer== DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }



        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DatePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPESEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPESEL_Validated(object sender, EventArgs e)
        {
            string PESEL = txtPESEL.Text;
            if (!string.IsNullOrWhiteSpace(PESEL) && !ValidatorHelper.IsValidPESEL(PESEL))
            {
                epPESEL.SetError(txtPESEL,"Cyfra kontrolna nr PESEL jest nieprawwidłowa");
            }
            else
            {
                epPESEL.Clear();
            }
        }
    }
}
 