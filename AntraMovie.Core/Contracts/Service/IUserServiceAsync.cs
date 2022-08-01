using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface IUserServiceAsync
    {
        Task<int> InsertUserAsync(UserModel userModel);
        Task<int> UpdateUserAsync(UserModel userModel);
        Task<int> DeleteUserAsync(int id);
        Task<UserModel> GetUserByIdAsync(int id);
        Task<IEnumerable<UserModel>> GetAllUserAsync();
    }
}

