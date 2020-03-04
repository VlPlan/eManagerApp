using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IServiceService
    {
        List<ServiceViewModel> GetServices();
        ServiceViewModel GetServiceById(int id);
        int AddService(ServiceViewModel service);
        void RemoveService(int id);
        int ChangeQuantity(int serviceId, double quantity);
        int ChangePrice(int serviceId, double currencyRate);
    }
}
