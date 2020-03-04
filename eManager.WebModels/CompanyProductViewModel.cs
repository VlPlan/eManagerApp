using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.WebModels
{
    public class CompanyProductViewModel
    {
        public CompanyProductViewModel()
        {

        }

        public CompanyProductViewModel(Company company, Product product)
        {
            Company.Id = company.Id;
            Company.Name = company.Name;
            Company.Phone = company.Phone;
            Company.Email = company.Email;
            Company.ContactPerson = company.ContactPerson;
            Company.Description = company.Description;
            Company.BankAccount = company.BankAccount;
            Company.TaxNumber = company.TaxNumber;
            Company.CompanyProducts = company.CompanyProducts.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price

            }).ToList();

            Product.Id = product.Id;
            Product.Name = product.Name;
            Product.Price = product.Price;

            Company.CompanyProducts.Add(Product);
        }
     
        public CompanyViewModel Company { get; set; }
        public ProductViewModel Product { get; set; }

    }
}
