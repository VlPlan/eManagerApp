using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace eManager.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } = 1;
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<ProcurementProduct> ProcurementProducts { get; set; } = new List<ProcurementProduct>();
        public virtual Company Company { get; set; } = new Company();
        public int CompanyId { get; set; }

    }
}
