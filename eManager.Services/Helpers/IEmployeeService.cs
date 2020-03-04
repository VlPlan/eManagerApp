using System;
using System.Collections.Generic;
using System.Text;
using eManager.Domain;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IEmployeeService
    {
        EmployeeViewModel GetEmployee(int id);
        int AddNewEmployee(EmployeeViewModel entity);
        List<EmployeeViewModel> ShowEmployees();
        int UpdateEmployeeInfo(EmployeeViewModel employee);
        void RemoveEmployee(int id);

    }
}
