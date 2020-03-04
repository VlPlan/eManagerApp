using System;
using System.Collections.Generic;
using System.Linq;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;

namespace eManager.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Client> _clientRepository;
        private readonly IRepository<Service> _serviceRepository;
        private readonly IRepository<Invoice> _invoiceRepository;
        private readonly IUserRepository _userRepository;
        public InvoiceService(IRepository<Client> clientRepository, IRepository<Service> serviceRepository, IUserRepository userRepository, IRepository<Invoice> invoiceRepository)
        {
            _clientRepository = clientRepository;
            _serviceRepository = serviceRepository;
            _userRepository = userRepository;
            _invoiceRepository = invoiceRepository;
        }

        public int UploadInvoice(int invoiceId, int serviceId, int clientId, string userId, out string serviceName)
        {
            try
            {

                Service service = _serviceRepository.GetById(serviceId);
                Invoice invoice = _invoiceRepository.GetById(invoiceId);
                
                Client client = _clientRepository.GetById(service.ClientId);

                serviceName = service.Name;

                
                ClientServiceDTO productInvoice = new ClientServiceDTO()
                {
                    ServiceId = serviceId,
                    InvoiceId = invoiceId
                };

                ClientInvoice clientInvoice = new ClientInvoice()
                {
                    ClientId = service.ClientId,
                    Invoice_Id = invoice.InvoiceId
                };


                invoice.InvoiceServices.Add(productInvoice);
                invoice.ClientInvoices.Add(clientInvoice);
                invoice.Client = client;

                invoice.ClientId = client.Id;
                invoice.ClientAddress = client.Address;

                User user = _userRepository.GetById(userId);
                invoice.User = user;

                int id = _invoiceRepository.Update(invoice);
                return id;

            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }


        public int RemoveServiceFromInvoice(int invoiceId, int serviceId, string userId, out string serviceName)
        {
            try
            {

                Service service = _serviceRepository.GetById(serviceId);

                Invoice invoice = _invoiceRepository.GetById(invoiceId);
                serviceName = service.Name;
                ClientServiceDTO productInvoice = invoice.InvoiceServices.FirstOrDefault(x => x.ServiceId == serviceId && x.InvoiceId == invoiceId);

                invoice.InvoiceServices.Remove(productInvoice);

                User user = _userRepository.GetById(userId);
                invoice.User = user;

                int id = _invoiceRepository.Update(invoice);

                return id;

            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }


        public int CreateInvoice(InvoiceViewModel Invoice)
        {
            try
            {

                Invoice newInvoice = new Invoice();
                var lastInvoice = _invoiceRepository.GetAll().OrderByDescending(i => i.InvoiceId).FirstOrDefault();
               
                if (lastInvoice == null)
                {

                    newInvoice.InvoiceNumber = "OGN2020/001";
                }
                else
                {

                    newInvoice.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
                }
                
              
                
                newInvoice.InvoiceServices = new List<ClientServiceDTO>();
                foreach(var i in Invoice.InvoiceServices)
                {
                    newInvoice.InvoiceServices.Add(new ClientServiceDTO {InvoiceId = Invoice.Id, ServiceId = i.ServiceId });
                }
                newInvoice.ClientInvoices = new List<ClientInvoice>();
                foreach (var c in Invoice.ClientInvoices)
                {
                    newInvoice.ClientInvoices.Add(new ClientInvoice { ClientId = c.ClientId, Invoice_Id = Invoice.Id });
                }
                newInvoice.InvoiceId = Invoice.Id;
                newInvoice.InvoiceDate = Invoice.InvoiceDate;
                newInvoice.PaymentPeriod = Invoice.PaymentPeriod;
                newInvoice.Price = Invoice.Price;
                newInvoice.UserId = Invoice.User.Id;
                newInvoice.ClientId = Invoice.SelectedClient;
                newInvoice.ClientAddress = Invoice.ClientAddress;
                newInvoice.DueDate = Invoice.DueDate;
                newInvoice.Description = Invoice.Description;
               

                var addInvoice = _invoiceRepository.Insert(newInvoice);
                return addInvoice;
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }



        public InvoiceViewModel GetCurrentInvoice(string UserId)
        {
            try
            {
                var invoice = _invoiceRepository.GetAll().LastOrDefault(x => x.User.Id == UserId);
                if (invoice == null)
                {

                    CreateInvoice(new InvoiceViewModel { User = new UserViewModel { Id = UserId } });
                    return GetCurrentInvoice(UserId);
                }
                List<Service> services = invoice.InvoiceServices
                                                     .Select(x =>
                                                     _serviceRepository.GetById(x.ServiceId)).ToList();

                
                InvoiceViewModel invoiceModel = new InvoiceViewModel();
                invoiceModel.Id = invoice.InvoiceId;
                invoiceModel.InvoiceNumber = invoice.InvoiceNumber;
                invoiceModel.InvoiceDate = invoice.InvoiceDate;
                invoiceModel.PaymentPeriod = invoice.PaymentPeriod;
                invoiceModel.Price = invoice.Price;
                invoiceModel.User = new UserViewModel(invoice.User);
                invoiceModel.SelectedClient = invoice.ClientId;
                invoiceModel.Client = new ClientViewModel(invoice.Client);
                invoiceModel.ClientAddress = invoice.Client.Address;
                invoiceModel.DueDate = invoice.DueDate;
                invoiceModel.ClientName = invoice.Client.Name;
                invoiceModel.InvoiceServices = invoice.InvoiceServices.Select(x => new ServiceViewModel(x.Service)).ToList();
                invoiceModel.ClientInvoices = invoice.ClientInvoices.Select(c => new ClientViewModel(c.Client)).ToList();
                invoiceModel.Description = invoice.Description;
                return invoiceModel;
            }
            catch (Exception ex)
            {
                string message = $"Invoice not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public void RemoveInvoice(int id)
        {
            _invoiceRepository.DeleteById(id);
        }

        public List<InvoiceViewModel> ShowInvoices()
        {
            var invoices = _invoiceRepository.GetAll().ToList();

            List<InvoiceViewModel> allInvoices = new List<InvoiceViewModel>();
            foreach (var invoice in invoices)
            {
                allInvoices.Add(new InvoiceViewModel(invoice));
            }
            return allInvoices;
        }

    


        public int RegisterInvoice(InvoiceViewModel invoice, string description, int invoiceId, string userId, int clientId, string invoiceNumber, string clientName, DateTime invoiceDate, double paymentPeriod)
        {
            try
            {
                Invoice currentInvoice = _invoiceRepository.GetById(invoiceId);
           
                currentInvoice.InvoiceDate = invoiceDate;
                currentInvoice.PaymentPeriod = paymentPeriod;
                currentInvoice.DueDate = invoiceDate.AddDays(paymentPeriod);
                currentInvoice.Description = description;
            
                User user = _userRepository.GetById(userId);
                Client client = _clientRepository.GetById(clientId);
                _invoiceRepository.Insert(new Invoice() { User = user, Client = client, ClientId = clientId, ClientName = clientName, InvoiceDate = invoiceDate, PaymentPeriod = paymentPeriod, InvoiceNumber = invoiceNumber, ClientAddress = currentInvoice.Client.Address, Price = currentInvoice.Price, DueDate = invoiceDate.AddDays(paymentPeriod) });

                return _invoiceRepository.Update(currentInvoice);
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong registering Invoice! {ex.InnerException}";
                throw new Exception(message, ex);
            }

        }
    }


    }


