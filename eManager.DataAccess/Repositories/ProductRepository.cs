using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess.Repositories
{
    public class ProductRepository : IRepository<Product>
    {

        private readonly ManagerDbContext _context;
        public ProductRepository(ManagerDbContext context)
        {
            _context = context;
        }

        
        public void DeleteById(int id)
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null) _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            _context.Products.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public int Update(Product entity)
        {
            Product product = _context.Products.FirstOrDefault(x => x.Id == entity.Id);
            if (product != null)
            {
                entity.Id = product.Id;
                entity.Quantity = product.Quantity;
                _context.Products.Update(entity);
            }
           
            int id = _context.SaveChanges();
            return id;
        }
    }
}

