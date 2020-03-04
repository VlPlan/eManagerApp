using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class ClientRepository:IRepository<Client>
    {
        private readonly ManagerDbContext _context;
        public ClientRepository(ManagerDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {

            ClientInvoice client1 = _context.ClientInvoices.FirstOrDefault(x => x.ClientId == id);
            Client client = _context.Clients.FirstOrDefault(x => x.Id == id);
            
           
            if (client != null)
                _context.Clients.Remove(client);
            if (client1 != null)
                _context.ClientInvoices.Remove(client1);
            
           
        
            _context.SaveChanges();
        }

        public List<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(int id)
        {
            var client = _context.Clients.SingleOrDefault(x => x.Id == id);
            return client;
        }

        public int Insert(Client entity)
        {
            _context.Clients.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Client entity)
        {
            var client = _context.Clients.SingleOrDefault(x => x.Id == entity.Id);
            if (client != null)
            {
               client.Id = entity.Id;
               client.Address = entity.Address;
               client.Name = entity.Name;
               client.Email = entity.Email;
               client.Phone = entity.Phone;
               client.Description = entity.Description;
               client.BankAccount = entity.BankAccount;
               client.TaxNumber = entity.TaxNumber;
                client.LogoImage = entity.LogoImage;
              

                _context.Clients.Update(client);
            }


            int id = _context.SaveChanges();
            return id;
        }
    }
}
