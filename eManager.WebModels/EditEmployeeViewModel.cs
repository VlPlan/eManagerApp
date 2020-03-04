using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Http;

namespace eManager.WebModels
{
   public class EditEmployeeViewModel:EmployeeViewModel
    {
        public EditEmployeeViewModel(Employee employee)
        {
            Id = employee.Id;
        }

        public EditEmployeeViewModel()
        {

        }
        public int Id { get; set; }
        //[Display(Name = "Firstname")]
        //public string FirstName { get; set; }
        //[Display(Name = "Lastname")]
        //public string LastName { get; set; }
        //public long Salary { get; set; }
        //[Display(Name = "Birthdate")]
        //public DateTime DateOfBirth { get; set; }
        //public DepartmentView Department { get; set; }
        //public long Phone { get; set; }
        //public string Address { get; set; }
        //public virtual string Files { get; set; }



    }
}
