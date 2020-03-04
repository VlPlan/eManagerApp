using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Http;

namespace eManager.WebModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(Employee employee)
        {
            Id = employee.Id;
            EmployeeNumber = employee.EmployeeNumber;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Username = employee.Username;
            Password = employee.Password;
            Salary = employee.Salary;
            DateOfBirth = employee.DateOfBirth;
            Department = (DepartmentView)employee.Department;
            Phone = employee.Phone;
            Address = employee.Address;
            IdCard = employee.IdCard;
            Medical = employee.Medical;
            M1M2 = employee.M1M2;
            HSafety = employee.HSafety;

         
        }

        public EmployeeViewModel()
        {

        }

        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        [Display(Name ="Firstname")]
        public string FirstName { get; set; }
        [Display(Name = "Lastname")]
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long Salary { get; set; }
        [Display(Name = "Birthdate")]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; } = DateTime.Today;
        public DepartmentView Department { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string IdCard { get; set; }
        public string Medical { get; set; }
        public string M1M2 { get; set; }
        public string HSafety { get; set; }
      
   




    }


    
}
