using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Entities;
using AntraMovie.Infrastructure.Data;
namespace AntraMovie.Infrastructure.Repository
{
    public class PurchaseRepositoryAsync : BaseRepositoryAsync<Purchase>, IPurchaseRepositoryAsync
    {
        public PurchaseRepositoryAsync(CustomerCrmDbContext _context):base(_context)
        {
        }
    }
}

