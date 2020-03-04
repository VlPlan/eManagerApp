using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace eManager.Domain
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public Department Department { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public string IdCard { get; set; }
        public string Medical { get; set; }
        public string M1M2 { get; set; }
        public string HSafety { get; set; }
        public virtual List<ActivityEmployee> EmployeeActivities { get; set; } = new List<ActivityEmployee>();

    }
}
