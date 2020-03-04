using System;
using System.Collections.Generic;
using System.Text;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IProductService
    {
        List<ProductViewModel> GetProducts();
        ProductViewModel GetProductById(int id);
        int UploadProduct(ProductViewModel product);
        int UpdateProduct(ProductViewModel product);
        void RemoveProduct(int id);
    }
}
