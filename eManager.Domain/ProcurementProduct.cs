using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace eManager.Domain
{
    public class ProcurementProduct
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    
        public int ProcurementId { get; set; }
        public virtual Procurement Procurement { get; set; }
    }
}
