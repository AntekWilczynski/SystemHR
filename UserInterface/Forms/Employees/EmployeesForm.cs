﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.DataAccessLayer.ViewModels;
using SystemHR.UserInterface.Helpers;
using SystemHR.UserInterface.Classes;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        #region Fields
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployees;
        #endregion
        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
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
        #endregion
        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }
        #endregion
        #region Private Methods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Iksiński",
                    FirstName = "Paweł",
                    Code = 1,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1985,1,12),
                    PESEL = "85061212345",
                    PhoneNumber = "555 666 777",
                    EmailAddress = "abc@gmail.com",
                    IdentityCardNumber = "AWR 12347",
                    IssueDateIdentytyCard = new DateTime(2000,2,12),
                    ExpirationDateIdentytyCard = new DateTime(2050,11,11),
                    PassportNumber = "RGB9875",
                    IssueDatePassport = new DateTime(2020,10,3),
                    ExpirationDatePassport = new DateTime(2021,12,13),
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 2,
                    LastName = "Romanov",
                    FirstName = "Jurij",
                    Code = 2,
                    Gender = new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1935,6,2),
                    PESEL = "35061212345",
                    PhoneNumber = "525 636 757",
                    EmailAddress = "123abc@gmail.com",
                    IdentityCardNumber = "AWH 23547",
                    IssueDateIdentytyCard = new DateTime(2010,12,12),
                    ExpirationDateIdentytyCard = new DateTime(2050,10,11),
                    PassportNumber = "GPU346346",
                    IssueDatePassport = new DateTime(2021,11,3),
                    ExpirationDatePassport = new DateTime(2026,06,3),
                    Status = new StatusModel("Wprowadzony")
                },

                new EmployeeModel()
                {
                    Id = 3,
                    LastName = "CzingCzong",
                    FirstName = "Zdzisława",
                    Code = 3,
                    Gender = new GenderModel("kobieta"),
                    DateBirth = new DateTime(1995,5,15),
                    PESEL = "95051516675",
                    PhoneNumber = "555 777 444",
                    EmailAddress = "def@gmail.com",
                    IdentityCardNumber = "ABW 72344",
                    IssueDateIdentytyCard = new DateTime(2000,2,12),
                    ExpirationDateIdentytyCard = new DateTime(2050,9,12),
                    PassportNumber = "KGB9875",
                    IssueDatePassport = new DateTime(2020,5,13),
                    ExpirationDatePassport = new DateTime(2021,11,3),
                    Status = new StatusModel("Wprowadzony")
                }
            };
            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployeesModel);
        }
        #endregion
        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee
                    = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    bsEmployees.Add(employee);
                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };
            frm.ShowDialog();
        }
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion

        private void btnModify_Click(object sender, EventArgs e)
        {
            EmployeeEditForm frm = new EmployeeEditForm();
                frm.ShowDialog();
        }
    }
}
