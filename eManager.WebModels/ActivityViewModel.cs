using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using eManager.Domain;
using System.Linq;

namespace eManager.WebModels
{
    public class ActivityViewModel
    {
        public ActivityViewModel(Activity activity)
        {
            ActivityId = activity.ActivityId;
            Description = activity.Description;
            User = new UserViewModel(activity.User);
            Client = new ClientViewModel(activity.Client);
            Date = activity.Date;
            Duration = activity.Duration;
            ClientSelected = activity.ClientSelected;
            ClientName = activity.Client.Name;
            EmployeeActivities = activity.EmployeeActivities.Select(x=>new EmployeeViewModel(x.Employee)).ToList();
            AllEmployees = new List<EmployeeViewModel>();
            ActivityStatusViewModel = (ActivityStatusViewModel)activity.ActivityStatus;




        }


        public ActivityViewModel()
        {

        }

        public int ActivityId { get; set; }
        public string Description { get; set; }
        public ClientViewModel Client { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Today;
        public double Duration { get; set; }
        [Display(Name = "Select Client")]
        public IEnumerable<SelectListItem> Clients { get; set; }
        public int ClientSelected { get; set; }
        public string ClientName { get; set; }
        public UserViewModel User { get; set; }
        public ActivityStatusViewModel ActivityStatusViewModel { get; set; }
        public List<EmployeeViewModel> EmployeeActivities { get; set; } = new List<EmployeeViewModel>();
        public List<EmployeeViewModel> AllEmployees { get; set; }

    }
}
