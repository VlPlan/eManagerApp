using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.WebModels
{
    public class CompanyViewModel
    {

        public CompanyViewModel()
        {
            CompanyProducts = new List<ProductViewModel>();
        }

        public CompanyViewModel(Company company)
        {
            Id = company.Id;
            Name = company.Name;
            Description = company.Description;
            Phone = company.Phone;
            Address = company.Address;
            Email = company.Email;
            BankAccount = company.BankAccount;
            TaxNumber = company.TaxNumber;
            ContactPerson = company.ContactPerson;
            CompanyProducts = company.CompanyProducts.Select(x=>new ProductViewModel()
            {
                Id=x.Id,
                Name=x.Name,
                Price=x.Price
                
            }).ToList();



        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Contact person")]
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        [Display(Name = "Tax Number")]
        public long TaxNumber { get; set; }
        [Display(Name = "Bank Account")]
        public long BankAccount { get; set; }
        public List<ProductViewModel> CompanyProducts { get; set; } = new List<ProductViewModel>();


    }
}
