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
    public class CompanyService : ICompanyService
    {
        private readonly IRepository<Company> _companyService;
        private readonly IRepository<Product> _productService;
        public CompanyService(IRepository<Company> companyService, IRepository<Product> productService)
        {
            _companyService = companyService;
            _productService = productService;
        }

        public int AddNewCompany(CompanyViewModel entity)
        {
            Company company = new Company();
            company.Id = entity.Id;
            company.Name = entity.Name;
            company.Description = entity.Description;
            company.Address = entity.Address;
            company.ContactPerson = entity.ContactPerson;
            company.Email = entity.Email;
            company.BankAccount = entity.BankAccount;
            company.TaxNumber = entity.TaxNumber;
            company.Phone = entity.Phone;
   

            var addedCompany = _companyService.Insert(company);
            return addedCompany;
        }


        public CompanyViewModel GetCompany(int id)
        {
            var company = _companyService.GetById(id);
            if (company == null)
            {
                throw new Exception("No such employee");
            }

            CompanyViewModel viewCompany = new CompanyViewModel();
            viewCompany.Id = company.Id;
            viewCompany.Name = company.Name;
            viewCompany.Description = company.Description;
            viewCompany.Email = company.Email;
            viewCompany.ContactPerson = company.ContactPerson;
            viewCompany.Address = company.Address;
            viewCompany.Phone = company.Phone;
            viewCompany.BankAccount = company.BankAccount;
            viewCompany.TaxNumber = company.TaxNumber;
            viewCompany.CompanyProducts = company.CompanyProducts.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price

            }).ToList();
            return viewCompany;
        }

        public void RemoveCompany(int id)
        {
            _companyService.DeleteById(id);
        }

        public List<CompanyViewModel> ShowCompanies()
        {
            var companies = _companyService.GetAll().ToList();
            var products = _productService.GetAll().ToList();

            List<CompanyViewModel> allCompanies = new List<CompanyViewModel>();
            

            foreach (var company in companies)
            {
    
                    allCompanies.Add(new CompanyViewModel(company));
                

            }
            return allCompanies;
        }

        public int UpdateCompanyInfo(CompanyViewModel company)
        {
            Company domainCompany = new Company();
            domainCompany.Id = company.Id;
            domainCompany.Name = company.Name;
            domainCompany.Description = company.Description;
            domainCompany.Email = company.Email;
            domainCompany.ContactPerson = company.ContactPerson;
            domainCompany.Address = company.Address;
            domainCompany.Phone = company.Phone;
            domainCompany.BankAccount = company.BankAccount;
            domainCompany.TaxNumber = company.TaxNumber;
            


            new CompanyViewModel(domainCompany);
            var updated = _companyService.Update(domainCompany);
            return updated;
        }

        public List<ProductViewModel> GetCompanyProducts()
        {
            var products = _productService.GetAll();

            List<ProductViewModel> allCompanyProducts = new List<ProductViewModel>();
            foreach (var product in products)
            {
                allCompanyProducts.Add(new ProductViewModel(product));
            }
            return allCompanyProducts;

        }

        public ProductViewModel GetProductFromCompany(string name)
        {
            var products = _productService.GetAll();

            List<ProductViewModel> allCompanyProducts = new List<ProductViewModel>();
            foreach (var product in products)
            {
                allCompanyProducts.Add(new ProductViewModel(product));
            }
            return allCompanyProducts.Where(x => x.Name == name).FirstOrDefault();
        }

        public void AddProduct(ProductViewModel productView)
        {
            var products = _productService.GetAll();
            var Product = new Product()
            {
                Id = productView.Id,
                Name = productView.Name,
                Price = productView.Price


            };
            var addedProduct = new ProductViewModel(Product);
            List<ProductViewModel> allCompanyProducts = new List<ProductViewModel>();
            foreach (var product in products)
            {
                allCompanyProducts.Add(addedProduct);
            }

            var added = allCompanyProducts.Where(x => x.Name == addedProduct.Name).FirstOrDefault();

        }
    }
}
