using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Entities;
using AntraMovie.Infrastructure.Data;
namespace AntraMovie.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
    {
        public CastRepositoryAsync(CustomerCrmDbContext _context):base(_context)
        {
        }
    }
}

