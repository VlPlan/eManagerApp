using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IClientService
    {
            ClientViewModel GetClient(int id);
            int AddClient(ClientViewModel entity);
            List<ClientViewModel> ShowClients();
            int UpdateClientInfo(ClientViewModel company);
            void RemoveClient(int id);
    }
}
