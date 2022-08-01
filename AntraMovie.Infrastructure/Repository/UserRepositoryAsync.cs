using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Entities;
using AntraMovie.Infrastructure.Data;

namespace AntraMovie.Infrastructure.Repository
{
    public class UserRepositoryAsync:BaseRepositoryAsync<User>, IUserRepositoryAsync
    {
        public UserRepositoryAsync(CustomerCrmDbContext _context):base(_context)
        {
        }
    }
}

