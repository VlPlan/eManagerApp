using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace eManager.Domain
{
   public class User:IdentityUser
    {
        public string FullName { get; set; }
        
        public virtual List<Procurement> Procurements { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
    }
}
