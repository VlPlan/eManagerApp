using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.WebModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Product product)
        {

            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Quantity = product.Quantity;
            ImageUrl = product.ImageUrl;
            Company = new CompanyViewModel(product.Company);
            SelectedCompany = product.Company.Name;
            SelectedCompanyId = product.CompanyId;

            
        }

        public ProductViewModel()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } 
        public string ImageUrl { get; set; }
        [Display(Name = "Select Vendor")]
        public IEnumerable<SelectListItem> Vendors { get; set; }
        [Display(Name = "Select Vendor")]
        public int SelectedCompanyId { get; set; }
        public string SelectedCompany { get; set; }
        public CompanyViewModel Company { get; set; }

    }
}
