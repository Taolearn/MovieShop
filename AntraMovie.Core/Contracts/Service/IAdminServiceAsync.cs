using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface IAdminServiceAsync
    {
        Task<int> InsertAdminAsync(AdminModel adminModel);
        Task<int> UpdateAdminAsync(AdminModel adminModel);
        Task<int> DeleteAdminAsync(int id);
        Task<AdminModel> GetAdminByIdAsync(int id);
        Task<IEnumerable<AdminModel>> GetAllAdminAsync();
    }
}

