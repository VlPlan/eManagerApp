using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.EntityFrameworkCore;

namespace eManager.Services.Services
{
    public class ProcurementService : IProcurementService
    {
        private readonly IRepository<Procurement> _procurementRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<ProcurementProduct> _procurementProductRepo;
        private readonly IRepository<Company> _companyRepository;
        private readonly IUserRepository _userRepository;
        public ProcurementService(IRepository<Procurement> procurementRepository, IRepository<Product> productRepository, IRepository<Company> companyRepository, IRepository<ProcurementProduct> procurementProductRepo,IUserRepository userRepository)
        {
            _procurementRepository = procurementRepository;
            _productRepository = productRepository;
            _companyRepository = companyRepository;
            _procurementProductRepo = procurementProductRepo;
            _userRepository = userRepository;
        }
   
        public int UploadProcurement(int procurementId, int productId, string userId, out string productName)
        {
            try
            {
                
                Product product = _productRepository.GetById(productId);
            
                Procurement procurement = _procurementRepository.GetById(procurementId);

                
                productName = product.Name;
                
                ProcurementProduct procurementProduct = new ProcurementProduct()
                {

                    ProductId = productId,
                    ProcurementId = procurementId
                };

                procurement.ProcurementProducts.Add(procurementProduct);

                       
                
                User user = _userRepository.GetById(userId);

                    

                procurement.User = user;


                int id= _procurementRepository.Update(procurement);
                return id;



            }
            catch(Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        

        public int CreateProcurement(ProcurementViewModel procurementModel)
        {
            try
            {
               
                var procurement = new Procurement();
                procurement.Id = procurementModel.Id;
                procurement.Issuer = procurementModel.Issuer;
                procurement.Price = procurementModel.Price;
                procurement.ProcurementStatus = (ProcurementStatus)procurementModel.ProcurementStatus;
                procurement.Date = procurement.Date;
                procurement.UserId = procurementModel.User.Id;
                var addedProcurement= _procurementRepository.Insert(procurement);
                return addedProcurement;
            }
            catch(Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }

        }

        public List<ProcurementViewModel> AllProcurements()
        {
            var procurements = _procurementRepository.GetAll().ToList();

            List<ProcurementViewModel> allProcurements = new List<ProcurementViewModel>();
            foreach (var procurement in procurements)
            {
                allProcurements.Add(new ProcurementViewModel(procurement));
            }
            return allProcurements;
        }

        public ProcurementViewModel GetProcurementById(int id)
        {
            try
            {
                var procurement = _procurementRepository.GetById(id);

                if (procurement == null)
                {
                    throw new Exception("No such procurement");
                }

                ProcurementViewModel procurementModel = new ProcurementViewModel();
                procurementModel.Id = procurement.Id;
                procurementModel.Issuer = procurement.Issuer;
                procurementModel.ProcurementStatus = (ProcurementStatusViewModel)procurement.ProcurementStatus;
                procurementModel.Date = procurement.Date;
                procurementModel.ProcurementProducts = procurement.ProcurementProducts.Select(x => new ProductViewModel(x.Product)).ToList();
                return procurementModel; 
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }
        public ProcurementViewModel GetCurrentProcurement(string userId)
        {
            try
            {
                var procurement = _procurementRepository.GetAll().LastOrDefault(x=>x.User.Id==userId);
                if(procurement == null || procurement.ProcurementStatus != ProcurementStatus.Pending)
                {
                    CreateProcurement(new ProcurementViewModel { User = new UserViewModel { Id = userId } });
                    return GetCurrentProcurement(userId);
                }
                List<Product> products = procurement.ProcurementProducts
                                                     .Select(x =>
                                                     _productRepository.GetById(x.ProductId)).ToList();
                ProcurementViewModel viewModel = new ProcurementViewModel();
                viewModel.Id = procurement.Id;
                viewModel.Issuer = procurement.Issuer;
                viewModel.Date = procurement.Date;
                viewModel.Price = procurement.ProcurementProducts.Sum(x=>x.Product.Price);
                viewModel.User = new UserViewModel(procurement.User);
                viewModel.ProcurementProducts = procurement.ProcurementProducts.Select(p => new ProductViewModel(p.Product)).ToList();
                viewModel.ProcurementStatus = (ProcurementStatusViewModel)procurement.ProcurementStatus;

                return viewModel;
            }
            catch (Exception ex)
            {
                string message = $"Procurement not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public ProcurementViewModel GetProcurementById(int procurementId,string userId)
        {
            User user = _userRepository.GetById(userId);
            Procurement procurement = _procurementRepository.GetById(procurementId);

            if(user.Id == procurement.User.Id)
            {
                ProcurementViewModel procurementModel = new ProcurementViewModel(procurement);

                return procurementModel;
            }
            else
            {
                return new ProcurementViewModel();
            }
        }

        public int ChangeStatus(int procurementId, string userId, ProcurementStatusViewModel status)
        {
            try
            {
                Procurement procurement = _procurementRepository.GetById(procurementId);
                User user = _userRepository.GetById(userId);

                procurement.ProcurementStatus = (ProcurementStatus)status;

                if (status == ProcurementStatusViewModel.Approved)
                {
                    _procurementRepository.Insert(new Procurement()
                    {
                        User = user,
                        ProcurementStatus = ProcurementStatus.Pending
                    });
                }

               int modified= _procurementRepository.Update(procurement);
               return modified;
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong changing status! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public int ChangeQuantity(int procurementId, string userId, int productId, int quantity)
        {
     
                Procurement procurement = _procurementRepository.GetById(procurementId);
                User user = _userRepository.GetById(userId);
                var product = procurement.ProcurementProducts.FirstOrDefault(p => p.Product.Id == productId);
                product.Product.Quantity = quantity;
               

                return _procurementRepository.Update(procurement);
            
        }

        public int UpdateProcurementInfo(ProcurementViewModel procurementModel)
        {
           
            Procurement procurement = new Procurement();
            procurement.Id = procurementModel.Id;
            procurement.Issuer = procurementModel.Issuer;
            procurement.Price = procurementModel.Price;
            procurement.ProcurementStatus = (ProcurementStatus)procurementModel.ProcurementStatus;
            procurement.Date = procurementModel.Date;
            
            procurement.ProcurementProducts = new List<ProcurementProduct>();
            new ProcurementViewModel(procurement);
            var updatedProcurement = _procurementRepository.Update(procurement);
            return updatedProcurement;

            
        }

        public void RemoveProcurement(int id)
        {
            _procurementRepository.DeleteById(id);
        }

        


    }


}
