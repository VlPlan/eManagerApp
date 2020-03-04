using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;

namespace eManager.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Activity> _activityRepository;
        private readonly IRepository<Client> _clientRepository;


        public EmployeeService(IRepository<Employee> employeeRepository, IRepository<Client> clientRepository, IRepository<Activity> activityRepository)
        {
            _employeeRepository = employeeRepository;
            _clientRepository = clientRepository;
            _activityRepository = activityRepository;

        }

        public int AddNewEmployee(EmployeeViewModel entity)
        {
            var newEmployee = new Employee();
            newEmployee.Id = entity.Id;
            newEmployee.EmployeeNumber = entity.EmployeeNumber;
            newEmployee.FirstName = entity.FirstName;
            newEmployee.LastName = entity.LastName;
            newEmployee.Username = entity.Username;
            newEmployee.Password = entity.Password;
            newEmployee.Salary = entity.Salary;
            newEmployee.DateOfBirth = entity.DateOfBirth;
            newEmployee.Department = (Department)entity.Department;
            newEmployee.Phone = entity.Phone;
            newEmployee.Address = entity.Address;
            newEmployee.IdCard = entity.IdCard;
            newEmployee.Medical = entity.Medical;
            newEmployee.M1M2 = entity.M1M2;
            newEmployee.HSafety = entity.HSafety;

            var addedEmployee = _employeeRepository.Insert(newEmployee);
            return addedEmployee;
        }

        public List<EmployeeViewModel> ShowEmployees()
        {
            var employees = _employeeRepository.GetAll().ToList();

            List<EmployeeViewModel> allEmployees = new List<EmployeeViewModel>();
            foreach (var employee in employees)
            {
                allEmployees.Add(new EmployeeViewModel(employee));
            }
            return allEmployees;
        }

        public EmployeeViewModel GetEmployee(int id)
        {


            var employee = _employeeRepository.GetById(id);

            if (employee == null)
            {
                throw new Exception("No such employee");
            }


            EmployeeViewModel employeeView = new EmployeeViewModel();
            employeeView.Id = employee.Id;
            employeeView.EmployeeNumber = employee.EmployeeNumber;
            employeeView.DateOfBirth = employee.DateOfBirth;
            employeeView.FirstName = employee.FirstName;
            employeeView.LastName = employee.LastName;
            employeeView.Username = employee.Username;
            employeeView.Password = employee.Password;
            employeeView.Salary = employee.Salary;
            employeeView.Phone = employee.Phone;
            employeeView.Department = (DepartmentView)employee.Department;
            employeeView.Address = employee.Address;
            employeeView.IdCard = employee.IdCard;
            employeeView.Medical = employee.Medical;
            employeeView.M1M2 = employee.M1M2;
            employeeView.HSafety = employee.HSafety;


            return employeeView;
        }

        public int UpdateEmployeeInfo(EmployeeViewModel employee)
        {
            var updatedEmployee = new Employee();
            updatedEmployee.Id = employee.Id;
            updatedEmployee.EmployeeNumber = employee.EmployeeNumber;
            updatedEmployee.FirstName = employee.FirstName;
            updatedEmployee.LastName = employee.LastName;
            updatedEmployee.DateOfBirth = employee.DateOfBirth;
            updatedEmployee.Department = (Department)employee.Department;
            updatedEmployee.Phone = employee.Phone;
            updatedEmployee.Address = employee.Address;
            updatedEmployee.Salary = employee.Salary;
            updatedEmployee.IdCard = employee.IdCard;
            updatedEmployee.Medical = employee.Medical;
            updatedEmployee.M1M2 = employee.M1M2;
            updatedEmployee.HSafety = employee.HSafety;
            new EmployeeViewModel(updatedEmployee);
            var updated = _employeeRepository.Update(updatedEmployee);
            return updated;

        }


        public void RemoveEmployee(int id)
        {

            _employeeRepository.DeleteById(id);


        }


    }
}
