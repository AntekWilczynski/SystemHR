using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer
{
    public class TextConnector
    {
        IList<EmployeeModel> fakeTextEmployeesModel = new List<EmployeeModel>()
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
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return fakeSqlEmployeesModel;
        }
        public EmployeeModel GetEmployee(int id)
        {
            return fakeSqlEmployeesModel.Single(x => x.Id == id);
        } 


    }
}
