using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Entities;
using AntraMovie.Infrastructure.Data;
namespace AntraMovie.Infrastructure.Repository
{
    public class ReportRepositoryAsync : BaseRepositoryAsync<Report>, IReportRepositoryAsync
    {
        public ReportRepositoryAsync(CustomerCrmDbContext _context):base(_context)
        {
        }
    }
}

