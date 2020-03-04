using System;
using System.Collections.Generic;
using System.Text;

namespace eManager.WebModels
{

    public class ClientInvoiceViewModel
    {

        public ClientInvoiceViewModel()
        {
            Clients = new List<ClientViewModel>();
            Invoices = new List<InvoiceViewModel>();
        }

     
        public List<ClientViewModel> Clients { get; set; } 
        public List<InvoiceViewModel> Invoices { get; set; }
    }


}
