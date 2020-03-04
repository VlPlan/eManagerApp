using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class CompanyRepository:IRepository<Company>
    {
        private readonly ManagerDbContext _context;
        public CompanyRepository(ManagerDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            Company company = _context.Companies.SingleOrDefault(x => x.Id == id);
            if (company != null) _context.Companies.Remove(company);
            _context.SaveChanges();
        }

        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            var company = _context.Companies.SingleOrDefault(x => x.Id == id);
            return company;
        }

        public int Insert(Company entity)
        {
            _context.Companies.Add(entity);
            return _context.SaveChanges();

        }

        public int Update(Company entity)

        {

            var company = _context.Companies.SingleOrDefault(x => x.Id == entity.Id);
            if (company != null)
            {
                company.Id = entity.Id;
                company.Address = entity.Address;
                company.Name = entity.Name;
                company.Email = entity.Email;
                company.Phone = entity.Phone;
                company.Description = entity.Description;
                company.ContactPerson = entity.ContactPerson;
                company.BankAccount = entity.BankAccount;
                company.TaxNumber = entity.TaxNumber;
                company.CompanyProducts = entity.CompanyProducts;

                _context.Companies.Update(company);
            }


            int id = _context.SaveChanges();
            return id;

        }
    }
}
