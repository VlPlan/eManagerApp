using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.WebModels
{
    public class ServiceViewModel
    {
        public ServiceViewModel(Service service)
        {
            ServiceId = service.ServiceId;
            Name = service.Name;
            Price = service.Price*service.CurrencyRate;
            Quantity = service.Quantity;
            Currency = (CurrencyView)service.Currency;
            CurrencyRate = service.CurrencyRate;
            SelectedClientId = service.ClientId;
            Client = new ClientViewModel(service.Client);
            SelectedClient = service.Client.Name;

            ClientInvoices = service.ClientInvoices.Select(x => new ClientViewModel(x.Client)).ToList();
          
     


        }

        public ServiceViewModel()
        {
            ClientInvoices = new List<ClientViewModel>();
        }

        public int ServiceId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public CurrencyView Currency { get; set; }
        public double CurrencyRate { get; set; } = 1;
        public ClientViewModel Client { get; set; }
        [Display(Name = "Select client")]
        public IEnumerable<SelectListItem> Clients { get; set; }
        [Display(Name = "Select client")]
        public int SelectedClientId { get; set; }
        public string SelectedClient { get; set; }
        public List<ClientViewModel> ClientInvoices { get; set; } = new List<ClientViewModel>();





    }
}
