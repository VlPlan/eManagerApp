using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.WebModels
{
    public class ClientViewModel
    {

        public ClientViewModel()
        {

        }

        public ClientViewModel(Client client)
        {


            ClientId = client.Id;
            Name = client.Name;
            Description = client.Description;
            Phone = client.Phone;
            Address = client.Address;
            Email = client.Email;
            BankAccount = client.BankAccount;
            TaxNumber = client.TaxNumber;
            LogoImage = client.LogoImage;


        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        [Display(Name = "Tax Number")]
        public long TaxNumber { get; set; }
        [Display(Name = "Bank Account")]
        public long BankAccount { get; set; }
        public string LogoImage { get; set; }

    }
}
