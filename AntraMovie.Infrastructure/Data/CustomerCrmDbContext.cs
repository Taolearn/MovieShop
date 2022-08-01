using System;
using AntraMovie.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AntraMovie.Infrastructure.Data
{
    public class CustomerCrmDbContext: DbContext
    {
        public CustomerCrmDbContext(DbContextOptions<CustomerCrmDbContext> options):base(options)
        {

        }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<User> User { get; set; }

    }
}

