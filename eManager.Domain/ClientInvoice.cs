using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class ClientInvoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int Invoice_Id { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<Client> Clients { get; set; } = new List<Client>();
        public virtual List<Invoice>Invoices { get; set; } = new List<Invoice>();
    }
}
