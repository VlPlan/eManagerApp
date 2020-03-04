using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public virtual Client Client { get; set; } = new Client();
        public int ClientSelected { get; set; }
        public string ClientName { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public double Duration { get; set; }
        public List<ActivityEmployee> EmployeeActivities { get; set; } = new List<ActivityEmployee>();
        public List<Employee> allEmployees { get; set; } = new List<Employee>();
        public ActivityStatus ActivityStatus { get; set; }
        
    }
}
