using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IActivityService
    {
       
        int AddActivity(ActivityViewModel entity);
        List<ActivityViewModel> ShowActivities();
        int UpdateActivityInfo(ActivityViewModel activity);
        void RemoveActivity(int id);
        int PickEmployee(int activityId, int employeeId, string userId, out string employeeFullName);
        int RemoveEmployee(int activityId, int employeeId, string userId, out string employeeFullName);
        int CompleteActivity(int activityId, string userId, ActivityStatusViewModel status);

    }
}
