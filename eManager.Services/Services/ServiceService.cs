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
    public class ServiceService : IServiceService
    {
        private readonly IRepository<Service> _serviceRepository;
        private readonly IRepository<Client> _clientRepository;
        public ServiceService(IRepository<Service> serviceRepository, IRepository<Client> clientRepository)
        {
            _serviceRepository = serviceRepository;
            _clientRepository = clientRepository;
        }
        public int AddService(ServiceViewModel service)
        {
            Service newService = new Service();
            
            newService.ServiceId = service.ServiceId;
            newService.Name = service.Name;
            newService.Quantity = service.Quantity;
            newService.Price = service.Price;
            newService.Currency = (Currency)service.Currency;
            newService.CurrencyRate = service.CurrencyRate;
            newService.ClientId = service.SelectedClientId;

            Client client = _clientRepository.GetById(service.SelectedClientId);
            newService.Client = client;

            var addedService = _serviceRepository.Insert(newService);
            return addedService;
        }

        public ServiceViewModel GetServiceById(int id)
        {
            var service = _serviceRepository.GetById(id);
            if (service == null)
            {
                throw new Exception("No such service registered for this client, please add service");
            }


            var client = _clientRepository.GetAll().FirstOrDefault(x => x.Id == service.ClientId);
            ClientViewModel clientModel = new ClientViewModel(client);
            ServiceViewModel serviceModel = new ServiceViewModel();

            serviceModel.ServiceId = service.ServiceId;
            serviceModel.Name = service.Name;
            serviceModel.Price = service.Price;
            serviceModel.Quantity = service.Quantity;
            serviceModel.Currency = (CurrencyView)service.Currency;
            serviceModel.CurrencyRate = service.CurrencyRate;
            serviceModel.SelectedClientId = service.ClientId;
            serviceModel.Client = new ClientViewModel(client);
            serviceModel.SelectedClient = clientModel.Name;


            return serviceModel;
        }

        public List<ServiceViewModel> GetServices()
        {
            var services = _serviceRepository.GetAll().ToList();
           
            List<ServiceViewModel> allServices = new List<ServiceViewModel>();
            foreach (var service in services)
            {
                
                
                allServices.Add(new ServiceViewModel(service));
            }
            return allServices;
        }

        public void RemoveService(int id)
        {
            _serviceRepository.DeleteById(id);
        }


        public int ChangeQuantity(int serviceId, double quantity)
        {

            
            var currentService = _serviceRepository.GetById(serviceId);
            currentService.Quantity = quantity;


            return _serviceRepository.Update(currentService);

        }

        public int ChangePrice(int serviceId, double currencyRate)
        {


            var currentService = _serviceRepository.GetById(serviceId);
            currentService.CurrencyRate = currencyRate;


            return _serviceRepository.Update(currentService);

        }

    }
}
