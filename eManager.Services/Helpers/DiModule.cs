using System;
using System.Collections.Generic;
using System.Text;
using eManager.DataAccess;
using eManager.DataAccess.Repositories;
using eManager.Domain;
using eManager.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace eManager.Services.Helpers
{
    public class DiModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services,
            string connectionString)
        {
           
            services.AddDbContext<ManagerDbContext>
                (x => x.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {

                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                        .AddRoleManager<RoleManager<IdentityRole>>()
                        .AddEntityFrameworkStores<ManagerDbContext>()
                        .AddDefaultTokenProviders();

            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IRepository<Procurement>, ProcurementRepository>();
            services.AddTransient<IRepository<ProcurementProduct>, ProcurementProductRepo>();
            services.AddTransient<IRepository<Activity>, ActivityRepository>();
            services.AddTransient<IRepository<Service>, ServiceRepository>();
            services.AddTransient<IRepository<Client>, ClientRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Employee>, EmployeeRepository>();
            services.AddTransient<IRepository<Invoice>, InvoiceRepository>();
            services.AddTransient<IRepository<Company>, CompanyRepository>();



            return services;
        }
    }
}
