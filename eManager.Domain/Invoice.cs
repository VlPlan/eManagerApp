using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.Domain
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public virtual Client Client { get; set; } = new Client();
        public int ClientId { get; set; }
        public string ClientAddress { get; set; }
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date only")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }
        public double PaymentPeriod { get; set; }
        public DateTime DueDate { get; set; }
        public double Price { get; set; }
        public double VAT
        {
            get { return Price*0.18; }
        }
        public double TotalPrice
        {
            get { return Price+VAT; }
        }
        public List<ClientServiceDTO> InvoiceServices { get; set; } = new List<ClientServiceDTO>();
        public List<ClientInvoice> ClientInvoices { get; set; } = new List<ClientInvoice>();
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }



    }
}
