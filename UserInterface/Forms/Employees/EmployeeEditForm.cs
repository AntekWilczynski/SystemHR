﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields
        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        #endregion
        #region Constructor
        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            InitializeData();
            employee = GetFakeEmployee(employeeId);
            PrepareEmployeeData(employee);
            ValidateControls(); 
        }

        private void PrepareEmployeeData(EmployeeModel employee)
        {
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.FirstName;
            cbGender.Text = employee.Gender !=null? employee.Gender.Value :null;
            dtpDateBirth.SetDateTimePickerValue(employee.DateBirth);
            txtPESEL.Text = employee.PESEL;
            txtPhoneNumber.Text = employee.PhoneNumber;
            txtEmailAddress.Text = employee.EmailAddress;
            txtIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueDateIdentityCard.SetDateTimePickerValue(employee.IssueDateIdentityCard);
            dtpExpirationIdentityCard.SetDateTimePickerValue(employee.ExpirationDateIdentityCard);
            txtPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDatePassport);
            dtpExpirationPassport.SetDateTimePickerValue(employee.ExpirationDatePassport);
            lblEmployee.Text = $"{employee.FirstName}{employee.LastName}({employee.Code.ToString().PadLeft(4, '0')}) - {employee.Status.ToString()}";
        }
        #endregion

        #region Private Methods
        private EmployeeModel GetFakeEmployee(int employeeId)
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Andrzejewski",
                    FirstName = "Paweł",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1994,9,1),
                    PESEL = "94090142830",
                    PhoneNumber = "665988254",
                    EmailAddress = "p.andrzejewski@gmail.com",
                    IdentityCardNumber = "AWR204120",
                    IssueDateIdentityCard = new DateTime(2012,9,15),
                    ExpirationDateIdentityCard = new DateTime(2032,9,15),
                    PassportNumber = "ER8984510",
                    IssueDatePassport = new DateTime(2015,5,23),
                    ExpirationDatePassport = new DateTime(2025,5,23),
                    Status = new StatusModel("Wprowadzony")
                },

                 new EmployeeModel()
                {
                    Id = 2,
                    LastName = "Bedanerek",
                    FirstName = "Damian",
                    Code = 2,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1990,9,14),
                    PESEL = "90091444249",
                    PhoneNumber = "754952134",
                    EmailAddress = "d.bednarek@gmail.com",
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 3,
                    LastName = "Szczepaniak",
                    FirstName = "Katarzyna",
                    Code = 3,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995,10,13),
                    PESEL = "95101361886",
                    PhoneNumber = "852745984",
                    EmailAddress = "k.szczepaniak@gmail.com",
                    Status = new StatusModel("Wprowadzony")
                },
                new EmployeeModel()
                {
                    Id = 4,
                    LastName = "Iksiński",
                    FirstName = "Paweł",
                    Code = 4,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1985,1,12),
                    PESEL = "85061212345",
                    PhoneNumber = "555 666 777",
                    EmailAddress = "abc@gmail.com",
                    IdentityCardNumber = "AWR 12347",
                    IssueDateIdentityCard = new DateTime(2000,2,12),
                    ExpirationDateIdentityCard = new DateTime(2050,11,11),
                    PassportNumber = "RGB9875",
                    IssueDatePassport = new DateTime(2020,10,3),
                    ExpirationDatePassport = new DateTime(2021,12,13),
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 5,
                    LastName = "Romanov",
                    FirstName = "Jurij",
                    Code = 5,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1935,6,2),
                    PESEL = "35061212345",
                    PhoneNumber = "525 636 757",
                    EmailAddress = "123abc@gmail.com",
                    IdentityCardNumber = "AWH 23547",
                    IssueDateIdentityCard = new DateTime(2010,12,12),
                    ExpirationDateIdentityCard = new DateTime(2050,10,11),
                    PassportNumber = "GPU346346",
                    IssueDatePassport = new DateTime(2021,11,3),
                    ExpirationDatePassport = new DateTime(2026,06,3),
                    Status = new StatusModel("Wprowadzony")
                },
                new EmployeeModel()
                {
                    Id = 6,
                    LastName = "CzingCzong",
                    FirstName = "Zdzisława",
                    Code = 6,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995,5,15),
                    PESEL = "95051516675",
                    PhoneNumber = "555 777 444",
                    EmailAddress = "def@gmail.com",
                    IdentityCardNumber = "ABW 72344",
                    IssueDateIdentityCard = new DateTime(2000,2,12),
                    ExpirationDateIdentityCard = new DateTime(2050,9,12),
                    PassportNumber = "KGB9875",
                    IssueDatePassport = new DateTime(2020,5,13),
                    ExpirationDatePassport = new DateTime(2021,11,3),
                    Status = new StatusModel("Wprowadzony")
                }
            };
            EmployeeModel fakeEmployeeModel = fakeEmployeesModel.Where(x => x.Id == employeeId).FirstOrDefault();
            return fakeEmployeeModel;
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
            //dtp.DatePickerValueChanged();
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
                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.Gender = new GenderModel(cbGender.Text);
                employee.DateBirth = dtpDateBirth.Value;
                employee.PESEL = txtPESEL.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.EmailAddress = txtEmailAddress.Text;
                employee.IdentityCardNumber = txtIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueDateIdentityCard.Value;
                employee.ExpirationDateIdentityCard = dtpExpirationIdentityCard.Value;
                employee.PassportNumber = txtPassportNumber.Text;
                employee.IssueDatePassport = dtpExpirationPassport.Value;
                employee.ExpirationDatePassport = dtpExpirationPassport.Value;
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
