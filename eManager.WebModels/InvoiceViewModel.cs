using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.WebModels
{
    public class InvoiceViewModel
    {
        public InvoiceViewModel()
        {
   
        }

        public InvoiceViewModel(Invoice invoice)
        {
            Id = invoice.InvoiceId;
            InvoiceNumber = invoice.InvoiceNumber;
            User = new UserViewModel(invoice.User);
            Client = new ClientViewModel(invoice.Client);
            ClientAddress = invoice.ClientAddress;
            PaymentPeriod = invoice.PaymentPeriod;
            InvoiceDate = invoice.InvoiceDate;
            DueDate = invoice.InvoiceDate.AddDays(invoice.PaymentPeriod);
            InvoiceServices = invoice.InvoiceServices.Select(x=>new ServiceViewModel(x.Service)).ToList();
            ClientInvoices = invoice.ClientInvoices.Select(x => new ClientViewModel(x.Client)).ToList();
            Price = invoice.InvoiceServices.Sum(x=>x.Service.Price*x.Service.Quantity*x.Service.CurrencyRate);
            VAT = Price*0.18;
            TotalPrice = Price+VAT;
            SelectedClient= invoice.Client.Id;
            ClientName = invoice.Client.Name;
            Description = invoice.Description;




        }
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public UserViewModel User { get; set; }
        public ClientViewModel Client { get; set; }
        public string ClientAddress { get; set; }
        public double PaymentPeriod { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        public List<ServiceViewModel> InvoiceServices { get; set; } = new List<ServiceViewModel>();
        public List<ClientViewModel> ClientInvoices { get; set; } = new List<ClientViewModel>();
        public double Price { get; set; }
        public double VAT { get; set; }
        public double TotalPrice { get; set; }
        [Display(Name = "Select client")]
        public IEnumerable<SelectListItem> Clients { get; set; }
        public int SelectedClient { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }




    }
}
