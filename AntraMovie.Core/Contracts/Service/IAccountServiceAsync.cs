using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface IAccountServiceAsync
    {
        Task<int> InsertAccountAsync(AccountModel accountModel);
        Task<int> UpdateAccountAsync(AccountModel accountModel);
        Task<int> DeleteAccountAsync(int id);
        Task<AccountModel> GetAccountByIdAsync(int id);
        Task<IEnumerable<AccountModel>> GetAllAccountAsync();
    }
}

