using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Mvc;
using NToastNotify;

namespace eManager.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IToastNotification _toastNotification;
        public CompanyController(ICompanyService companyService, IToastNotification toastNotification)
        {
            _companyService = companyService;
            _toastNotification = toastNotification;
        }

        public ActionResult ShowCompanies(int? page)
        {
            var companies = _companyService.ShowCompanies().ToList();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = companies.ToPagedList(pageNumber, pageSize);
            return View(companies.ToPagedList(pageNumber, pageSize));

        }

        [HttpGet]
        public ActionResult AddProductToCompany(int id)
        {
            var company = _companyService.ShowCompanies().Find(x => x.Id == id);
            if (company == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }
            List<ProductViewModel> Products = new List<ProductViewModel>();
           
            ProductViewModel product = new ProductViewModel();
            CompanyViewModel companyToView = new CompanyViewModel()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Phone = company.Phone,
                Description = company.Description,
                BankAccount = company.BankAccount,
                ContactPerson = company.ContactPerson,
                Email = company.Email,
                TaxNumber = company.TaxNumber,
                CompanyProducts = Products

            };

            companyToView.CompanyProducts.Add(product);
 


            return View(product);
        }


        [HttpPost]
        public ActionResult AddProductToCompany(ProductViewModel product)
        {

           
           
            _companyService.AddProduct(product);

            return RedirectToAction("ShowCompanies", "Company");
        }



        public ActionResult CompanyInfo(int id)
        {

            var company = _companyService.ShowCompanies().Find(x => x.Id == id);
            
            if (company == null) return View("_Error");
            
            List<ProductViewModel> companyProducts = new List<ProductViewModel>();
            foreach(ProductViewModel companyProduct in company.CompanyProducts)
            {
                companyProducts.Add(new ProductViewModel()
                {
                    Id = companyProduct.Id,
                    Name=companyProduct.Name,
                    Price=companyProduct.Price

                });
            }
            
            if (company == null) return View("_Error");
            CompanyViewModel companyToView = new CompanyViewModel()
            {
                Id = company.Id,
                Name = company.Name,
                Description = company.Description,
                Address = company.Address,
                BankAccount = company.BankAccount,
                ContactPerson = company.ContactPerson,
                Email = company.Email,
                Phone = company.Phone,
                TaxNumber = company.TaxNumber,
                CompanyProducts = company.CompanyProducts

            };

            return View(companyToView);
        }




        [HttpGet]
        public ActionResult AddCompany()
        {

            return View(new CompanyViewModel());
        }

        [HttpPost]
        public ActionResult AddCompany(CompanyViewModel company)
        {

            int addedCompany = _companyService.AddNewCompany(company);
            string message = String.Format("New company {0} is successfully created!", addedCompany);
            _toastNotification.AddSuccessToastMessage(message);
            return RedirectToAction("ShowCompanies", "Company");
        }

        [HttpGet]
        public IActionResult UpdateCompanyInfo(int id)
        {

            var company = _companyService.ShowCompanies().Find(x => x.Id == id);
            if (company == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }

            CompanyViewModel companyToView = new CompanyViewModel()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Phone = company.Phone,
                Description = company.Description,
                BankAccount = company.BankAccount,
                ContactPerson=company.ContactPerson,
                Email=company.Email,
                TaxNumber=company.TaxNumber,
                CompanyProducts=company.CompanyProducts

            };

            return View(companyToView);
        }

        [HttpPost]
        public IActionResult UpdateCompanyInfo(CompanyViewModel companyToView)
        {

            var modified = _companyService.UpdateCompanyInfo(companyToView);
            return RedirectToAction("ShowCompanies");


        }


        [HttpGet]
        public IActionResult RemoveCompany(int id)
        {
            var company = _companyService.ShowCompanies().SingleOrDefault(x => x.Id == id);

            return View(company);
        }

        [HttpPost]
        public IActionResult RemoveCompany(CompanyViewModel viewModel)
        {
            _companyService.RemoveCompany(viewModel.Id);
            string message = String.Format("Company {0} is successfully removed!", viewModel.Name);
            _toastNotification.AddWarningToastMessage(message);
            return RedirectToAction("ShowCompanies", "Company");
        }


    }
}