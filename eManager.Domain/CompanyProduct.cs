using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eManager.Domain
{
    public class CompanyProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
