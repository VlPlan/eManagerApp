using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess.Repositories
{
    public class InvoiceRepository:IRepository<Invoice>
    {
        private ManagerDbContext _context;
        public InvoiceRepository(ManagerDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            ClientInvoice invoiceClient = _context.ClientInvoices.FirstOrDefault(x => x.Invoice_Id == id);
            ClientServiceDTO invoiceService = _context.InvoiceServices.FirstOrDefault(x => x.InvoiceId == id);
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.InvoiceId == id);
            
            if (invoice != null)
                _context.Invoices.Remove(invoice);
            if (invoiceClient != null)
                _context.ClientInvoices.Remove(invoiceClient);
            if (invoiceService != null)
                _context.InvoiceServices.Remove(invoiceService);


            _context.SaveChanges();
        }

        public List<Invoice> GetAll()
        {
            return _context.Invoices
              .Include(x => x.InvoiceServices)
              .ThenInclude(x => x.Service)
              .Include(i => i.ClientInvoices)
              .ThenInclude(i => i.Client)
              .Include(x => x.User)
              .ToList();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices
              .Include(i => i.InvoiceServices)
              .ThenInclude(i => i.Service).Include(i => i.ClientInvoices).ThenInclude(i => i.Client)
              .Include(i => i.User)
              .FirstOrDefault(x => x.InvoiceId == id);
        }

        public int Insert(Invoice entity)
        {
            
            _context.Invoices.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public int Update(Invoice entity)
        {
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.InvoiceId == entity.InvoiceId);
            if (invoice != null)
            {
                entity.InvoiceId = invoice.InvoiceId;
                entity.InvoiceNumber = invoice.InvoiceNumber;
                entity.ClientId = invoice.ClientId;
                entity.Price = invoice.Price;
                entity.InvoiceDate = invoice.InvoiceDate;
                entity.PaymentPeriod = invoice.PaymentPeriod;
                entity.Client = invoice.Client;
                entity.ClientAddress = invoice.Client.Address;
                entity.Description = invoice.Description;
                
                

                
                _context.Invoices.Update(entity);
            }
           
            int id = _context.SaveChanges();
            return id;
        }
    }
}

