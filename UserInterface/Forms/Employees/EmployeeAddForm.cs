﻿ using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;
using SystemHR.UserInterface.Classes;




namespace SystemHR.UserInterface.Forms.Employees
{
    

    public partial class EmployeeAddForm : BaseAddEditForm
    { 
        #region Fields
        public EventHandler ReloadEmployees;
        #endregion
        #region Constructor
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }
        #endregion
        #region Private Methods

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
            if (sbErrorMessage.Length > 0)
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
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
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
        #endregion
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
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
                epPESEL.SetError(txtPESEL, "Cyfra kontrolna nr PESEL jest nieprawwidłowa");
            }
            else
            {
                epPESEL.Clear();
            }
        }
    
        #endregion
        #region Override
        protected override void Save()
        {
            if (ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cbGender.Text),
                    DateBirth = dtpDateBirth.Value,
                    PESEL = txtPESEL.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EmailAddress = txtEmailAddress.Text,
                    IdentityCardNumber = txtIdentityCard.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentityCard.Value,
                    ExpirationDateIdentityCard = dtpExpirationIdentityCard.Value,
                    PassportNumber = txtPassport.Text,
                    IssueDatePassport = dtpExpirationPassport.Value,
                    ExpirationDatePassport = dtpExpirationPassport.Value,
                    Status = new StatusModel("Wprowadzony")
                };
                employee.Id = 4;
                employee.Code = 4;
                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));
                Close();
            }
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano");
            Close();
        }
        #endregion
    }
}
 