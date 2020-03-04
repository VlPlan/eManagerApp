using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using X.PagedList.Mvc.Core;
using X.PagedList;


namespace eManager.Controllers
{
    [Authorize]
    public class ProcurementController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly IProcurementService _procurementService;
        private readonly ICompanyService _companyService;
        private readonly IRepository<Product> _productRepository;
        private readonly IToastNotification _toastNotification;

        public ProcurementController(IProcurementService procurementService, IProductService productService, ICompanyService companyService, IRepository<Product> productRepo,IUserService userService, IToastNotification toastNotification)
        {
            _procurementService = procurementService;
            _companyService = companyService;
            _productService = productService;
            _productRepository = productRepo;
            _userService = userService;
            _toastNotification = toastNotification;
                
        }



        [HttpGet]
        public IActionResult AddProcurement()
        {
            return View(new ProcurementViewModel());
        }

    
        [HttpPost]
        public IActionResult AddProcurement(ProcurementViewModel model)
        {
            
            int addedProcurement = _procurementService.CreateProcurement(model);
            return RedirectToAction("AllProcurements", "Procurement");
        }

    
        public IActionResult ProcurementDetails(int procurementId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ProcurementViewModel procurement = _procurementService.AllProcurements().Where(x=>x.Id==procurementId).FirstOrDefault();

            if (procurement.Id > 0)
            {
                return View("Procurement", procurement);
        }
            else
            {
                return View("Error", new ErrorViewModel());
            }
}

        public int AddProduct(int productId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ProcurementViewModel procurement = _procurementService.GetCurrentProcurement(user.Id);

            string productName;
   

            int result = _procurementService.UploadProcurement(procurement.Id, productId, user.Id, out productName);
            if (result >= 0)
            {
                _toastNotification.AddSuccessToastMessage("Product added!");
                return result;
            }
            else
            {
                _toastNotification.AddSuccessToastMessage($"Something went wrong while adding product!");
                return result;
            }

        }



        public IActionResult AllProcurements(int? page)
        {
            var procurements = _procurementService.AllProcurements().ToList();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = procurements.ToPagedList(pageNumber, pageSize);
            return View(procurements.ToPagedList(pageNumber, pageSize));
        }
 
        public IActionResult ConfirmProcurement(int procurementId)
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ProcurementViewModel procurement = _procurementService.GetProcurementById(procurementId);
            _procurementService.ChangeStatus(procurementId, user.Id, ProcurementStatusViewModel.Approved);
            return RedirectToAction("AllProcurements");
        }

      
        public IActionResult DeclineProcurement(int procurementId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ProcurementViewModel procurement = _procurementService.GetProcurementById(procurementId);
            _procurementService.ChangeStatus(procurementId, user.Id, ProcurementStatusViewModel.Declined);
            return RedirectToAction("AllProcurements");
        }

        public IActionResult UpdateQuantity(int productId, int quantity)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            ProcurementViewModel procurement = _procurementService.GetCurrentProcurement(user.Id);
            ProductViewModel product = procurement.ProcurementProducts.FirstOrDefault(x => x.Id == productId);
            product.Quantity = quantity;
           
            _procurementService.ChangeQuantity(procurement.Id,user.Id,productId,quantity);
            return RedirectToAction("Procurement");
            
            
        }


        [HttpGet]
        public IActionResult UpdateProcurement(int procurementId)
        {
            var procurement = _procurementService.AllProcurements().Find(x => x.Id == procurementId);

            if (procurement == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = procurementId.ToString()
                };
                return View("Error", error);
            }


            ProcurementViewModel procurementModel = new ProcurementViewModel()
            {
                Id = procurement.Id,
                Date = procurement.Date,
                Issuer = procurement.Issuer,
                ProcurementStatus = (ProcurementStatusViewModel)procurement.ProcurementStatus,
                ProcurementProducts = procurement.ProcurementProducts

            };

            return View(procurementModel);


        }

    
        [HttpPost]
        public IActionResult UpdateProcurement(ProcurementViewModel procurementModel, int productId, int quantity)
        {
            var product = procurementModel.ProcurementProducts.FirstOrDefault(p => p.Id == productId);
            product.Quantity = quantity;
            var modified = _procurementService.UpdateProcurementInfo(procurementModel);
            

            return RedirectToAction("AllProcurements", "Procurement");
        }



        public IActionResult Procurement()
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var procurement = _procurementService.GetCurrentProcurement(user.Id);
            if (procurement == null)
            {
                string message = String.Format("No current procurements!Please add products from CHECK PRODUCTS menu!");
                _toastNotification.AddErrorToastMessage(message);
            }

            return View(procurement);
        }


       
        [HttpGet]
        public IActionResult DeleteProcurement(int procurementId)
        {
            var procurement = _procurementService.AllProcurements().SingleOrDefault(x => x.Id == procurementId);
            return View(procurement);


        }

  
        [HttpPost]
        public IActionResult DeleteProcurement(ProcurementViewModel procurement)
        {
            _procurementService.RemoveProcurement(procurement.Id);
            return RedirectToAction("AllProcurements", "Procurement");
        }


   
        public IActionResult ChangeStatus(int procurementId, int statusId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
           
            _procurementService.ChangeStatus(procurementId, user.Id, (ProcurementStatusViewModel)statusId);

            return RedirectToAction("products", "product");

        }
    }



}