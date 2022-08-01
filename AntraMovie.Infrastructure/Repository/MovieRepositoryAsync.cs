using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Entities;
using AntraMovie.Infrastructure.Data;

namespace AntraMovie.Infrastructure.Repository
{
    public class MovieRepositoryAsync: BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        public MovieRepositoryAsync(CustomerCrmDbContext _context) : base(_context)
        {
        }
    }
}

