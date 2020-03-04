using System;
using System.Collections.Generic;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
   public interface ICompanyService
    {
        CompanyViewModel GetCompany(int id);
        int AddNewCompany(CompanyViewModel entity);
        List<CompanyViewModel> ShowCompanies();
        int UpdateCompanyInfo(CompanyViewModel company);
        List<ProductViewModel> GetCompanyProducts();
        ProductViewModel GetProductFromCompany(string name);
        void AddProduct(ProductViewModel productView);
        void RemoveCompany(int id);
    }
}
