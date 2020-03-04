using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;

namespace eManager.Services.Services
{
    public class ProductInvoiceService : IProductInvoiceService
    {
        private IRepository<Employee> _employeesRepository;
        private IRepository<Invoice> _invoicesRepository;
        private IRepository<Product> _productsRepository;
        public ProductInvoiceService(IRepository<Employee> employeesRepository, IRepository<Invoice> invoicesRepository, IRepository<Product> productsRepository)
        {
            _employeesRepository = employeesRepository;
            _productsRepository = productsRepository;
            _invoicesRepository = invoicesRepository;
        }
        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _invoicesRepository.GetAll();
        }

        public Invoice GetInvoiceById(int id)
        {
            var someEmployee = new Employee()
            {
                Id = 1,
                FirstName = "Vladimir",
                LastName = "Planojevic",
                Department = Department.Procurements,
                Username = "VladP",
                Password = "123VP"

            };
            _employeesRepository.Update(someEmployee);
            return _invoicesRepository.GetById(id);
        }

        public Invoice GetLastInvoice()
        {
            List<Invoice> invoices = _invoicesRepository.GetAll().ToList();
            return invoices[invoices.Count-1];
        }

        public Product GetProductFromProductsList(string name)
        {
            IEnumerable<Product> products = _productsRepository.GetAll();
            return products.Where(x => x.Name == name).FirstOrDefault();
        }

        public IEnumerable<Product> GetProductsList()
        {
            IEnumerable<Product> products = _productsRepository.GetAll()
               .GroupBy(x => x.Name)
               .Select(x => x.First());
               
            return products;
        }

        public void MakeNewInvoice(Invoice invoice)
        {
            _invoicesRepository.Insert(invoice);
        }
    }
}
