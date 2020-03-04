using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;

namespace eManager.Services.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IRepository<Activity> _activityRepository;
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Client> _clientRepository;
        private readonly IUserRepository _userRepository;

        public ActivityService(IRepository<Activity> activityRepository, IRepository<Employee> employeeRepository, IRepository<Client> clientRepository, IUserRepository userRepository)
        {
            _activityRepository = activityRepository;
            _employeeRepository = employeeRepository;
            _clientRepository = clientRepository;
            _userRepository = userRepository;
        }

        public int AddActivity(ActivityViewModel entity)
        {
            var newActivity = new Activity();
          
            newActivity.ActivityId = entity.ActivityId;
            newActivity.Date =entity.Date;
            newActivity.Description = entity.Description;
            newActivity.ClientSelected = entity.ClientSelected;
            newActivity.Client = new Client() { Id = entity.ClientSelected };   
            newActivity.ClientName = entity.ClientName;
            newActivity.UserId = entity.User.Id;
            newActivity.ActivityStatus = (ActivityStatus)entity.ActivityStatusViewModel;                       
            newActivity.allEmployees = _employeeRepository.GetAll().ToList();
            newActivity.EmployeeActivities = new List<ActivityEmployee>();
            var addedActivity = _activityRepository.Insert(newActivity);
            return addedActivity;
        }

        public void RemoveActivity(int id)
        {

            _activityRepository.DeleteById(id);


        }


        public List<ActivityViewModel> ShowActivities()
        {
            var activities = _activityRepository.GetAll().ToList();
            foreach(var i in activities)
            {
                i.EmployeeActivities.GroupBy(x => x.EmployeeId).Distinct();
            }
            List<ActivityViewModel> allActivities = new List<ActivityViewModel>();
      
            foreach (var activity in activities)
            {
                
                allActivities.Add(new ActivityViewModel(activity));
              
            }
         
            
            return allActivities;
        }
        

        public int UpdateActivityInfo(ActivityViewModel activity)
        {
            var updatedActivity = new Activity();
            updatedActivity.ActivityId = activity.ActivityId;
            updatedActivity.ClientSelected = activity.ClientSelected;
            updatedActivity.Date = activity.Date;
            updatedActivity.Description = activity.Description;
            updatedActivity.Duration = activity.Duration;
            updatedActivity.UserId = activity.User.Id;
            updatedActivity.EmployeeActivities = updatedActivity.EmployeeActivities.ToList();
            updatedActivity.ActivityStatus = (ActivityStatus)activity.ActivityStatusViewModel;
            var userModel = _userRepository.GetById(updatedActivity.UserId);
            updatedActivity.User = userModel;
            new ActivityViewModel(updatedActivity);
            var updated = _activityRepository.Update(updatedActivity);
            return updated;

        }

        public int PickEmployee(int activityId, int employeeId, string userId, out string employeeFullName)
        {
            try
            {

                Employee employee = _employeeRepository.GetById(employeeId);

                Activity activity = _activityRepository.GetById(activityId);

                activity.allEmployees = _employeeRepository.GetAll().ToList();

                ActivityEmployee activityEmployee = new ActivityEmployee()
                {
                    
                    EmployeeId = employeeId,
                    ActivityId = activityId,
                    Employee = new Employee() { Id = employee.Id, Address = employee.Address, FirstName = employee.FirstName, LastName = employee.LastName, IdCard = employee.IdCard, EmployeeActivities = employee.EmployeeActivities, EmployeeNumber = employee.EmployeeNumber, DateOfBirth = employee.DateOfBirth.Date, Department = employee.Department, HSafety = employee.HSafety, Medical = employee.Medical, M1M2 = employee.M1M2, Password = employee.Password, Phone = employee.Phone, Salary = employee.Salary, Username = employee.Username },
                    Activity = activity
                };

                    activity.EmployeeActivities.Add(activityEmployee);


                User user = _userRepository.GetById(userId);
                activity.User = user;

                employeeFullName = employee.FirstName + ' ' + employee.LastName;
                new ActivityViewModel(activity);
               
               var id= _activityRepository.Update(activity);
              
                return id;

            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }


        public int RemoveEmployee(int activityId, int employeeId, string userId, out string employeeFullName)
        {
            try
            {

                Employee employee = _employeeRepository.GetById(employeeId);

                Activity activity = _activityRepository.GetById(activityId);


                employeeFullName = employee.FirstName + ' ' + employee.LastName;
               
                ActivityEmployee employeeRemove = activity.EmployeeActivities.FirstOrDefault(x => x.EmployeeId == employeeId && x.ActivityId == activityId);
                User user = _userRepository.GetById(userId);
                activity.User = user;
                activity.EmployeeActivities.Remove(employeeRemove);

                int id = _activityRepository.Update(activity);
                return id;



            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public int CompleteActivity(int activityId, string userId, ActivityStatusViewModel status)
        {
            try
            {
                Activity activity = _activityRepository.GetById(activityId);
                activity.ActivityStatus =(ActivityStatus)status;
                User user = _userRepository.GetById(userId);
                activity.User = user;
                int modified =_activityRepository.Update(activity);
                return modified;
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong changing status! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

    }
}
