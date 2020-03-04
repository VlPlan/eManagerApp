using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class EmployeeRepository:IRepository<Employee>
    {
        private readonly ManagerDbContext _context;
        public EmployeeRepository(ManagerDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            Employee employee = _context.Employees.SingleOrDefault(x => x.Id == id);
            if (employee != null) _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            var employee = _context.Employees.SingleOrDefault(x=>x.Id==id);
            return employee;
        }

        public int Insert(Employee entity)
        {
            _context.Employees.Add(entity);
            return _context.SaveChanges();
            
        }

        public int Update(Employee entity)

        {

           var employee = _context.Employees.SingleOrDefault(x => x.Id == entity.Id);
            if (employee != null)
            {
               employee.Id = entity.Id;
               employee.Department = entity.Department;
               employee.LastName = entity.LastName;
               employee.FirstName = entity.FirstName;
               employee.DateOfBirth = entity.DateOfBirth;
               employee.Phone = entity.Phone;
               employee.Address = entity.Address;
               employee.Salary = entity.Salary;
                employee.IdCard = entity.IdCard;
                employee.Medical = entity.Medical;
                employee.M1M2= entity.M1M2;
                employee.HSafety = entity.HSafety;
                employee.Username = entity.Username;
               employee.Password = entity.Password;
                _context.Employees.Update(employee);
            }

         
            int id = _context.SaveChanges();
            return id;

        }
    }
}
