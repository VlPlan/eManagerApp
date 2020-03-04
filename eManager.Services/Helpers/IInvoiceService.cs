using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IInvoiceService
    {      
        InvoiceViewModel GetCurrentInvoice(string userId);
        int CreateInvoice(InvoiceViewModel invoice);
        int UploadInvoice(int invoiceId, int serviceId, int clientId, string userId, out string serviceName);
        int RemoveServiceFromInvoice(int invoiceId, int serviceId, string userId, out string serviceName);
        List<InvoiceViewModel> ShowInvoices();
        void RemoveInvoice(int id);
        int RegisterInvoice(InvoiceViewModel invoice, string description, int invoiceId, string userId, int clientId, string invoiceNumber, string clientName, DateTime invoiceDate, double paymentPeriod);

    }
}
