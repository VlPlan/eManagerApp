using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess
{
    public class ManagerDbContext: IdentityDbContext<User>
    {

        public ManagerDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Procurement> Procurements { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityEmployee> EmployeeActivities { get; set; }
        public DbSet<ProcurementProduct> ProcurementProducts { get; set; }
        public DbSet<ClientServiceDTO> InvoiceServices { get; set; }
        public DbSet<ClientInvoice> ClientInvoices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            
            base.OnModelCreating(builder);
           


           
            builder.Entity<ProcurementProduct>().HasIndex(p => new { p.ProductId, p.ProcurementId });
            builder.Entity<ClientServiceDTO>().HasIndex(p => new { p.InvoiceId, p.ServiceId });
            builder.Entity<ActivityEmployee>().HasIndex(p => new { p.ActivityId, p.EmployeeId });
            builder.Entity<ClientInvoice>().HasIndex(p => new { p.Invoice_Id, p.ClientId });
            builder.Entity<User>().HasMany(u => u.Procurements).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            builder.Entity<Invoice>().HasMany(x => x.InvoiceServices).WithOne(x => x.Invoice).HasForeignKey(x => x.InvoiceId);
            builder.Entity<Service>().HasMany(x => x.InvoiceServices).WithOne(x => x.Service).HasForeignKey(x => x.ServiceId);
            builder.Entity<Client>().HasMany(x => x.ClientInvoices).WithOne(x => x.Client).HasForeignKey(x => x.ClientId);  
            builder.Entity<Invoice>().HasMany(x => x.ClientInvoices).WithOne(x => x.Invoice).HasForeignKey(x => x.Invoice_Id);
            builder.Entity<User>().HasMany(x => x.Invoices).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.Entity<Activity>().HasMany(a => a.EmployeeActivities).WithOne(e => e.Activity).HasForeignKey(e => e.ActivityId);
            builder.Entity<Employee>().HasMany(a => a.EmployeeActivities).WithOne(e => e.Employee).HasForeignKey(e => e.EmployeeId);
            builder.Entity<Product>().HasMany(p => p.ProcurementProducts).WithOne(p => p.Product).HasForeignKey(p => p.ProductId);
            builder.Entity<Procurement>().HasMany(pp => pp.ProcurementProducts).WithOne(p => p.Procurement).HasForeignKey(p => p.ProcurementId);
            

            


            // SEED THE SUPPLIER ACCOUNT AND ROLES
            // NEW SUPPLIER ID ( ADMIN USER )
            string supplierId = Guid.NewGuid().ToString();
            // ADMIN ROLE ID
            string roleId = Guid.NewGuid().ToString();
            // USER ROLE ID
            string userRoleId = Guid.NewGuid().ToString();
            // SEEDING ROLES ONLY IN DB
            builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = userRoleId,
                Name = "user",
                NormalizedName = "USER"
            });

            var hasher = new PasswordHasher<User>();
            // SEEDING ADMIN USER WITHOUT ROLE
            builder.Entity<User>().HasData(new User
            {
                Id = supplierId,
                UserName = "supplier",
                NormalizedUserName = "SUPPLIER",
                Email = "supplier@mail.com",
                NormalizedEmail = "supplier@mail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Admin#"),
                SecurityStamp = string.Empty
            });
            // ADD CONNECTION BETWEEN SUPPLIER ROLE AND SUPPLIER USER TO HAVE ADMIN RIGHTS
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = supplierId
            });


        }
    }
}
