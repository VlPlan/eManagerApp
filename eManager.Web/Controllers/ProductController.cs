using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace eManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ICompanyService _companyService;
        private readonly IToastNotification _toastNotification;

        public ProductController(IProductService productService, IToastNotification toastNotification, IHostingEnvironment hostingEnvironment, ICompanyService companyService)
        {
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
            _companyService = companyService;
            _toastNotification = toastNotification;
        }

        public IActionResult Products()
        {

            var products = _productService.GetProducts().ToList();
            var vendorList = _companyService.ShowCompanies().Select(x => new SelectListItem
            {
                Value = x.Name,
                Text = x.Name,
                Selected = false

            });
            ViewBag.vendorSelect = vendorList;


            foreach (var p in products)
            {
                var currentVendor = _companyService.ShowCompanies().FirstOrDefault(c=>c.Id == p.SelectedCompanyId);
                if (p.SelectedCompanyId == currentVendor.Id)
                {
                    p.SelectedCompany = currentVendor.Name;

                }

            }

            return View(products);
        }

     
        [HttpGet]
        public IActionResult UploadProduct()
        {

            return View(new ProductViewModel() {Vendors = GetVendorList() });
        }
        
        [HttpPost]
        public IActionResult UploadProduct(ProductViewModel product,IFormFile ImageUrl)
        {
            if (ImageUrl != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", ImageUrl.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    ImageUrl.CopyToAsync(stream);
                }
                product.ImageUrl = ImageUrl.FileName;


                ViewBag.Message = "Image for product is successfully uploaded!";
                var obj = _productService.GetProducts().Where(x => x.ImageUrl == product.ImageUrl).FirstOrDefault();
                if (obj != null)
                {
                    product.ImageUrl = obj.ImageUrl;
                }
            }
           

            product.Vendors = GetVendorList();


            var selectedVendorId = product.Vendors.SingleOrDefault(x => x.Value == product.Id.ToString());


            if (selectedVendorId != null)
            {

                selectedVendorId.Selected = true;
                ViewBag.Message = "Product from vendor: " + selectedVendorId.Text;

            }

            CompanyViewModel vendorModel = _companyService.GetCompany(product.SelectedCompanyId);

            product.Company = vendorModel;
            product.SelectedCompany = vendorModel.Name;
            int addedProduct = _productService.UploadProduct(product);
            string message = String.Format("Product {0} is successfully created and added to Catalog!", addedProduct);
            _toastNotification.AddSuccessToastMessage(message);
            return RedirectToAction("Products");
        }




        [HttpGet]
        public IActionResult RemoveProduct(int id)
        {
            var product = _productService.GetProducts().SingleOrDefault(x => x.Id == id);

            return View(product);
        }

        [HttpPost]
        public IActionResult RemoveProduct(ProductViewModel viewModel)
        {
            _productService.RemoveProduct(viewModel.Id);
            return RedirectToAction("Products", "Product");
        }


        public IEnumerable<SelectListItem> GetVendorList()
        {
            var vendorList = _companyService.ShowCompanies().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,
                Selected = false

            });
            return new SelectList(vendorList, "Value", "Text");
        }
    }
}