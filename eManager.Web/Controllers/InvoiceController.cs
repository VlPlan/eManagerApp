using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using X.PagedList;
using X.PagedList.Mvc;

namespace eManager.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IUserService _userService;
        private readonly IInvoiceService _invoiceService;
        private readonly IClientService _clientService;
        private readonly IToastNotification _toastNotification;

        public InvoiceController(IServiceService serviceService, IUserService userService, IInvoiceService invoiceService, IClientService clientService, IToastNotification toastNotification)
        {
            _serviceService = serviceService;
            _userService = userService;
            _invoiceService = invoiceService;
            _clientService = clientService;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult AddInvoice()
        {
            var model = new InvoiceViewModel();
            var lastInvoice = _invoiceService.ShowInvoices().OrderByDescending(i => i.Id).FirstOrDefault();
            if (lastInvoice == null)
            {
                model.InvoiceNumber = "OGN2020/001";
            }
            else
            {
                model.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
            }

            return View(model);
        }


        [HttpPost]
        public IActionResult AddInvoice(InvoiceViewModel model)
        {

            int addedInvoice = _invoiceService.CreateInvoice(model);
            return RedirectToAction("Invoices", "Invoice");
        }



        public int AddDetailsToInvoice(int serviceId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice(user.Id);

            string serviceName;
            int result = _invoiceService.UploadInvoice(invoice.Id, serviceId, invoice.SelectedClient, user.Id, out serviceName);
            return result;
        }

        public int RemoveDetailsFromInvoice(int serviceId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice(user.Id);

            string serviceName;
            int result = _invoiceService.RemoveServiceFromInvoice(invoice.Id, serviceId, user.Id, out serviceName);
            return result;
        }

        public IActionResult Invoices(string sort, string search, string filter, int? page)
        {
            var invoices = _invoiceService.ShowInvoices().ToList();
           
            
            ViewBag.CurrentSort = sort;
            ViewBag.SortByClient = String.IsNullOrEmpty(sort) ? "client_desc" : "";
            ViewBag.SortByDate = sort == "Date" ? "date_desc" : "Date";
            ViewBag.SortByDueDate = sort == "DueDate" ? "duedate_desc" : "DueDate";
            ViewBag.SortByTotalPrice = sort == "TotalPrice" ? "totalprice_desc" : "TotalPrice";
            if(search !=  null)    
            {
                page = 1;
            }
            else
            {
                search = filter;
            }
            ViewBag.CurrentFilter = search;

            if (!String.IsNullOrEmpty(search))
            {
                invoices = invoices.Where(i => i.Client.Name == search || i.ClientAddress == search || i.Description == search).ToList();
                 
            }

            switch (sort)
            {
                case "client_desc":
                    invoices = invoices.OrderByDescending(c => c.ClientName).ToList();
                    break;
                case "date_desc":
                    invoices = invoices.OrderByDescending(c => c.InvoiceDate).ToList();
                    break;
                case "duedate_desc":
                    invoices = invoices.OrderByDescending(c => c.DueDate).ToList();
                    break;
                case "totalprice_desc":
                    invoices = invoices.OrderByDescending(c => c.TotalPrice).ToList();
                    break;

            }
           
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = invoices.ToPagedList(pageNumber, pageSize);
            return View(invoices.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult CurrentInvoice()
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice(user.Id);

            InvoiceViewModel invoiceModel = new InvoiceViewModel();

            invoiceModel.InvoiceDate = invoice.InvoiceDate;
            invoiceModel.PaymentPeriod = invoice.PaymentPeriod;
            invoiceModel.Price = invoice.Price;
            invoiceModel.User = invoice.User;
            invoiceModel.Description = invoice.Description;
            invoiceModel.SelectedClient = invoice.SelectedClient;
            invoiceModel.Client = invoice.Client;
            invoiceModel.ClientAddress = invoice.Client.Address;
            invoiceModel.DueDate = invoice.DueDate;
            invoiceModel.ClientName = invoice.Client.Name;
            invoiceModel.InvoiceServices = invoice.InvoiceServices;
            invoiceModel.ClientInvoices = invoice.ClientInvoices;
     
            if (invoiceModel.InvoiceServices.Any(s => s.Currency == CurrencyView.EUR && s.CurrencyRate == 1))
            {
                invoiceModel.VAT = invoiceModel.VAT * 0;
                invoiceModel.TotalPrice = invoiceModel.Price * 61.5;

            }
            if (invoiceModel.InvoiceServices.Any())
            {
                if (invoiceModel.Client.Name.ToLower().Contains("arcelor") || invoiceModel.Client.Name.ToLower().Contains("aрцелор") || invoiceModel.Client.Name.ToLower().Contains("Liberty") || invoiceModel.Client.Name.ToLower().Contains("Либерти"))
                {
                    invoiceModel.VAT = invoiceModel.VAT * 0;
                    invoiceModel.TotalPrice = invoiceModel.Price;
                }
            }
           
            return View(invoiceModel);

        }


        [HttpGet]
        public IActionResult DeleteInvoice(int invoiceId)
        {
            var invoice = _invoiceService.ShowInvoices().FirstOrDefault(x => x.Id == invoiceId);
            return View(invoice);


        }


        [HttpPost]
        public IActionResult DeleteInvoice(InvoiceViewModel invoice)
        {

            _invoiceService.RemoveInvoice(invoice.Id);
            return RedirectToAction("Invoices", "Invoice");
        }



        public IActionResult RegisterInvoice(InvoiceViewModel invoice, double price, string description, int clientId, string clientName, string userId, DateTime invoiceDate, double paymentPeriod)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel currentInvoice = _invoiceService.GetCurrentInvoice(user.Id);
            ClientViewModel client = _clientService.GetClient(currentInvoice.SelectedClient);
            var lastInvoice = _invoiceService.ShowInvoices().OrderByDescending(i => i.Id).FirstOrDefault();
            var newInvoice = new InvoiceViewModel();
            newInvoice.Id = currentInvoice.Id;
            newInvoice.InvoiceDate = invoiceDate;
            newInvoice.PaymentPeriod = paymentPeriod;
            newInvoice.DueDate = currentInvoice.InvoiceDate.AddDays(paymentPeriod);
            newInvoice.Client = client;
            newInvoice.Description = description;
            newInvoice.InvoiceServices = currentInvoice.InvoiceServices;
            newInvoice.ClientInvoices = currentInvoice.ClientInvoices;
            newInvoice.ClientName = currentInvoice.Client.Name;
            newInvoice.ClientAddress = currentInvoice.Client.Address;
            newInvoice.SelectedClient = currentInvoice.SelectedClient;
            newInvoice.Price = currentInvoice.Price;
            if (lastInvoice == null)
            {
                newInvoice.InvoiceNumber = "OGN2020/001";
            }
            else
            {
                newInvoice.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
            }
            if (newInvoice.InvoiceServices.Any(s => s.Currency == CurrencyView.EUR && s.CurrencyRate == 1))
            {
                newInvoice.VAT = newInvoice.VAT * 0;
                newInvoice.TotalPrice = newInvoice.Price * 61.5;

            }
            if (newInvoice.Client.Name.ToLower().Contains("arcelor") || newInvoice.Client.Name.ToLower().Contains("aрцелор") || newInvoice.Client.Name.ToLower().Contains("Liberty") || newInvoice.Client.Name.ToLower().Contains("Либерти"))
            {
                newInvoice.VAT = newInvoice.VAT * 0;
                newInvoice.TotalPrice = newInvoice.Price;
            }
            _invoiceService.RegisterInvoice(currentInvoice, newInvoice.Description, newInvoice.Id, user.Id, client.ClientId, newInvoice.InvoiceNumber, client.Name, invoiceDate, paymentPeriod);
            return RedirectToAction("invoices", "invoice");

        }

        public IActionResult InvoiceDetails(InvoiceViewModel invoiceModel)
        {
            var invoice = _invoiceService.ShowInvoices().Where(x => x.Id == invoiceModel.Id).FirstOrDefault();
            if (invoice == null) return View("_Error");

            InvoiceViewModel invoiceToView = new InvoiceViewModel()
            {
                Id = invoice.Id,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceNumber = invoice.InvoiceNumber,
                Client = invoice.Client,
                ClientAddress = invoice.ClientAddress,
                ClientName = invoice.ClientName,
                ClientInvoices = invoice.ClientInvoices,
                InvoiceServices = invoice.InvoiceServices,
                PaymentPeriod = invoice.PaymentPeriod,
                Price = invoice.Price,
                SelectedClient = invoice.SelectedClient,
                TotalPrice = invoice.TotalPrice,
                VAT = invoice.VAT,
                User = invoice.User,
                DueDate = invoice.DueDate,
                Description = invoice.Description

            };

            if (invoiceToView.InvoiceServices.Any(s => s.Currency == CurrencyView.EUR && s.CurrencyRate == 1))
            {
                invoiceToView.VAT = invoiceToView.VAT * 0;
                invoiceToView.TotalPrice = invoiceToView.Price * 61.5;

            }
            if (invoiceToView.Client.Name.ToLower().Contains("arcelor") || invoiceToView.Client.Name.ToLower().Contains("aрцелор") || invoiceToView.Client.Name.ToLower().Contains("Liberty") || invoiceToView.Client.Name.ToLower().Contains("Либерти"))
            {
                invoiceToView.VAT = invoiceToView.VAT * 0;
                invoiceToView.TotalPrice = invoiceToView.Price;
            }
            return View(invoiceToView);
        }

        public IActionResult SalesReport(string year, string filter)
        {
            var invoices = _invoiceService.ShowInvoices().ToList();
            var clients = _clientService.ShowClients().ToList();
            ClientInvoiceViewModel clientInvoiceModel = new ClientInvoiceViewModel();
            foreach(var i in invoices)
            {
                if(i.InvoiceServices.Any(s=>s.Currency==CurrencyView.EUR && s.CurrencyRate == 1))
                {
                    i.VAT = i.VAT * 0;
                    i.TotalPrice = i.Price*61.5;
                  
                }
                if(i.Client.Name.ToLower().Contains("arcelor") || i.Client.Name.ToLower().Contains("aрцелор")||i.Client.Name.ToLower().Contains("Liberty") || i.Client.Name.ToLower().Contains("Либерти"))
                {
                    i.VAT = i.VAT * 0;
                    i.TotalPrice = i.Price;
                }

                clientInvoiceModel.Invoices.Add(i);
            }
            foreach (var c in clients)
            {
                clientInvoiceModel.Clients.Add(c);
            }
            if (String.IsNullOrEmpty(year))
            {
                ViewBag.CurrentFilter = DateTime.Now.Year.ToString();
            }else
            {
                ViewBag.CurrentFilter = year;
            }
         

            if (!String.IsNullOrEmpty(year))
            {
                clientInvoiceModel.Invoices = clientInvoiceModel.Invoices.Where(i => i.InvoiceDate.Year.ToString()==year).ToList();

            }


            return View(clientInvoiceModel);
        }

    }
}
