using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
    public class ProcurementProductRepo : IRepository<ProcurementProduct>
    {
        private readonly ManagerDbContext _context;
        public ProcurementProductRepo(ManagerDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            ProcurementProduct procurement = _context.ProcurementProducts.FirstOrDefault(x => x.Id == id);
            if (procurement != null)
                _context.ProcurementProducts.Remove(procurement);
            _context.SaveChanges();
        }

        public List<ProcurementProduct> GetAll()
        {
            return _context.ProcurementProducts.ToList();
        }

        public ProcurementProduct GetById(int id)
        {
            var product = _context.ProcurementProducts.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public int Insert(ProcurementProduct entity)
        {
            _context.ProcurementProducts.Add(entity);
            return _context.SaveChanges();

        }

        public int Update(ProcurementProduct entity)

        {

            _context.ProcurementProducts.Update(entity);
            int id = _context.SaveChanges();
            return id;

        }
    }
}

