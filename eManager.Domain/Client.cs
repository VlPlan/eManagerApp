using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class Client
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long TaxNumber { get; set; }
        public long BankAccount { get; set; }
        public string LogoImage { get; set; }
        public virtual List<ClientInvoice> ClientInvoices { get; set; } 
        public int InvoiceId { get; set; }

    }
}
