using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;

namespace eManager.DataAccess.Repositories
{
   public class ServiceRepository:IRepository<Service>
    {
        private readonly ManagerDbContext _context;
        public ServiceRepository(ManagerDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Service service = _context.Services.FirstOrDefault(x => x.ServiceId == id);
            if (service != null) _context.Services.Remove(service);
            _context.SaveChanges();
        }

        public List<Service> GetAll()
        {
            return _context.Services.ToList();
        }

        public Service GetById(int id)
        {
            return _context.Services.FirstOrDefault(x => x.ServiceId == id);
        }

        public int Insert(Service entity)
        {
            _context.Services.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public int Update(Service entity)
        {
            Service service = _context.Services.FirstOrDefault(x => x.ServiceId == entity.ServiceId);
            if (service != null)
            {
                entity.ServiceId = service.ServiceId;
                _context.Services.Update(entity);
            }

            int id = _context.SaveChanges();
            return id;
        }
    }
}
