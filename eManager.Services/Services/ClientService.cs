using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;

namespace eManager.Services.Services
{
    public class ClientService:IClientService
    {
        private readonly IRepository<Client> _clientRepository;
        public ClientService(IRepository<Client> clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public int AddClient(ClientViewModel entity)
        {
            Client client= new Client();
            client.Id = entity.ClientId;
            client.Name = entity.Name;
            client.Description = entity.Description;
            client.Address = entity.Address;
            client.Email = entity.Email;
            client.BankAccount = entity.BankAccount;
            client.TaxNumber = entity.TaxNumber;
            client.LogoImage = entity.LogoImage;
            client.Phone = entity.Phone;
           

            var addedClient = _clientRepository.Insert(client);
            return addedClient;
        }


        public ClientViewModel GetClient(int id)
        {
            var client = _clientRepository.GetById(id);
            if (client == null)
            {
                throw new Exception("No such client, please add it in registry!");
            }

            ClientViewModel viewClient = new ClientViewModel();
            viewClient.ClientId = client.Id;
            viewClient.Name = client.Name;
            viewClient.Description = client.Description;
            viewClient.Email = client.Email;
            viewClient.Address = client.Address;
            viewClient.Phone = client.Phone;
            viewClient.BankAccount = client.BankAccount;
            viewClient.TaxNumber = client.TaxNumber;
            viewClient.LogoImage = client.LogoImage;
            
            return viewClient;

        }

  
        public void RemoveClient(int id)
        {
            
            _clientRepository.DeleteById(id);
        }

        public List<ClientViewModel> ShowClients()
        {
            var clients = _clientRepository.GetAll().ToList();

            List<ClientViewModel> allClients = new List<ClientViewModel>();
            foreach (var client in clients)
            {
                allClients.Add(new ClientViewModel(client));
            }
            return allClients;
        }

        public int UpdateClientInfo(ClientViewModel client)
        {
            Client modelClient = new Client();
            modelClient.Id = client.ClientId;
            modelClient.Name = client.Name;
            modelClient.Description = client.Description;
            modelClient.Email = client.Email;
            modelClient.Address = client.Address;
            modelClient.Phone = client.Phone;
            modelClient.BankAccount = client.BankAccount;
            modelClient.TaxNumber = client.TaxNumber;
            modelClient.LogoImage = client.LogoImage;



            new ClientViewModel(modelClient);
            var updated = _clientRepository.Update(modelClient);
            return updated;
        }
    }
}
