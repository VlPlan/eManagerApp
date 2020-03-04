using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.WebModels
{
    public class ProcurementViewModel
    {
        public ProcurementViewModel()
        {
            ProcurementProducts = new List<ProductViewModel>();
        }

        public ProcurementViewModel(Procurement procurement)
        {
            Id = procurement.Id;
            ProcurementProducts = procurement.ProcurementProducts.Select(x => new ProductViewModel(x.Product)).ToList();
            Date = DateTime.UtcNow;
            Issuer = procurement.Issuer;
            ProcurementStatus = (ProcurementStatusViewModel)procurement.ProcurementStatus;
            User = new UserViewModel(procurement.User);
        }

        public int Id { get; set; }
        [Display(Name = "Products")]
        public List<ProductViewModel> ProcurementProducts { get; set; } = new List<ProductViewModel>();
        public DateTime Date { get; set; }
        public string Issuer { get; set; }
        [Display(Name = "Status")]
        public ProcurementStatusViewModel ProcurementStatus { get; set; }
        public double Price { get; set; }
        public UserViewModel User{ get; set; }
    }
}
