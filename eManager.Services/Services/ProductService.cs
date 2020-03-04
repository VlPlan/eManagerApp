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
   public class ProductService:IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Company> _companyRepository;
        public ProductService(IRepository<Product> productRepository, IRepository<Company> companyRepository)
        {
            _productRepository = productRepository;
            _companyRepository = companyRepository;
        }

        public int UploadProduct(ProductViewModel product)
        {
            Product someProduct = new Product();
            someProduct.Id = product.Id;
            someProduct.Name = product.Name;
            someProduct.ImageUrl = product.ImageUrl;
            someProduct.Quantity = product.Quantity;
            someProduct.Price = product.Price;
            someProduct.CompanyId = product.SelectedCompanyId;

            Company company = _companyRepository.GetById(product.SelectedCompanyId);
     
            someProduct.Company = company;
           

            var addedProduct = _productRepository.Insert(someProduct);
            return addedProduct;
        }

        public ProductViewModel GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                throw new Exception("No such product");
            }

            var company = _companyRepository.GetAll().FirstOrDefault(c => c.Id == product.CompanyId);
            CompanyViewModel companyModel = new CompanyViewModel(company);
            ProductViewModel productModel = new ProductViewModel();
            productModel.Id = product.Id;
            productModel.Name = product.Name;
            productModel.Price = product.Price;
            productModel.ImageUrl = product.ImageUrl;
            productModel.SelectedCompanyId = company.Id;
            productModel.Company = new CompanyViewModel(company);
            productModel.SelectedCompany = company.Name;
            return productModel;

        }

        public List<ProductViewModel> GetProducts()
        {
            var products = _productRepository.GetAll().ToList();

            List<ProductViewModel> allProducts = new List<ProductViewModel>();
            foreach (var product in products)
            {
                allProducts.Add(new ProductViewModel(product));
            }
            return allProducts;
        }

        public void RemoveProduct(int id)
        {
            _productRepository.DeleteById(id);

        }

        public int UpdateProduct(ProductViewModel product)
        {
            var someProduct = new Product();
            someProduct.Id = product.Id;
            someProduct.Name = product.Name;
            someProduct.Price = product.Price;
            someProduct.ImageUrl = product.ImageUrl;
            someProduct.Quantity = product.Quantity;
            new ProductViewModel(someProduct);
            var addedProduct = _productRepository.Update(someProduct);
            return addedProduct;
        }
    }
}
