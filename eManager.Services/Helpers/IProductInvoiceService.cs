using System;
using System.Collections.Generic;
using System.Text;
using eManager.Domain;

namespace eManager.Services.Helpers
{
    public interface IProductInvoiceService
    {
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int id);
        void MakeNewInvoice(Invoice invoice);
        IEnumerable<Product> GetProductsList();
        Invoice GetLastInvoice();
        Product GetProductFromProductsList(string name);
    }
}
