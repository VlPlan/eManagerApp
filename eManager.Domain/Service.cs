using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.Domain
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Currency Currency { get; set; }
        public virtual List<ClientServiceDTO> InvoiceServices { get; set; } = new List<ClientServiceDTO>();
        public virtual List<ClientInvoice> ClientInvoices { get; set; } = new List<ClientInvoice>();
        public int InvoiceId { get; set; }
        public virtual Client Client { get; set; } = new Client();
        public int ClientId { get; set; }
        public virtual double CurrencyRate { get; set; }


    }
}
