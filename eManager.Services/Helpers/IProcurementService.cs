using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
   public interface IProcurementService
    {

        int UploadProcurement(int procurementId, int productId, string userId, out string productName);
        int CreateProcurement(ProcurementViewModel procurementModel);
        List<ProcurementViewModel> AllProcurements();
        ProcurementViewModel GetProcurementById(int id);
        ProcurementViewModel GetProcurementById(int procurementId, string userId);
        ProcurementViewModel GetCurrentProcurement(string userId);
        int ChangeStatus(int procurementId, string userId, ProcurementStatusViewModel status);
        int UpdateProcurementInfo(ProcurementViewModel procurementModel);
        void RemoveProcurement(int id);
        int ChangeQuantity(int procurementId, string userId, int productId, int quantity);
    }
}
