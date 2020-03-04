using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess.Repositories
{
    public class ActivityRepository:IRepository<Activity>
    {
        private readonly ManagerDbContext _context;
        public ActivityRepository(ManagerDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            
            Activity activity = _context.Activities.FirstOrDefault(x => x.ActivityId == id);
         

            if (activity != null) _context.Activities.Remove(activity);
            _context.SaveChanges();
        }

        public List<Activity> GetAll()
        {
            return _context.Activities.Include(x=>x.allEmployees).Include(x => x.EmployeeActivities).ThenInclude(x => x.Activity).Include(x => x.EmployeeActivities).ThenInclude(x => x.Employee).Include(x => x.User).ToList();
        }

        public Activity GetById(int id)
        {
            var activity = _context.Activities.Include(x => x.EmployeeActivities).ThenInclude(x => x.Employee).Include(i => i.User).FirstOrDefault(x => x.ActivityId == id);
            return activity;
        }

        public int Insert(Activity entity)
        {
            _context.Activities.Add(entity);
            return _context.SaveChanges();

        }

        public int Update(Activity entity)

        {

            
                Activity activity = _context.Activities.Include(u=>u.User).FirstOrDefault(x => x.ActivityId == entity.ActivityId);
                if (activity != null)
                {

                activity.ActivityId = entity.ActivityId;
                activity.allEmployees = _context.Employees.ToList();
                activity.EmployeeActivities = entity.EmployeeActivities;
                activity.Date = entity.Date;
                //activity.Client = entity.Client;
                activity.ActivityStatus = entity.ActivityStatus;
                activity.ClientName = entity.ClientName;
                activity.Description = entity.Description;
                activity.ClientSelected = entity.ClientSelected;
                activity.Duration = entity.Duration;
                activity.User = entity.User;
                activity.UserId = entity.UserId;



            }
               
            _context.Activities.Update(activity);
            int id = _context.SaveChanges();
                return id;
            

        }
    }
}
