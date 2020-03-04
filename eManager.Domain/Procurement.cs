using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class Procurement
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Issuer { get; set; }
        public ProcurementStatus ProcurementStatus { get; set; }
        public double Price { get; set; }
        public virtual List<ProcurementProduct> ProcurementProducts { get; set; } = new List<ProcurementProduct>();
        public virtual User User { get; set; }
        [Required]
        public string UserId { get; set; }



    }
}
