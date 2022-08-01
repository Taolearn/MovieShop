using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface ICastServiceAsync
    {
        Task<int> InsertCastAsync(CastModel castModel);
        Task<int> UpdateCastAsync(CastModel castModel);
        Task<int> DeleteCastAsync(int id);
        Task<CastModel> GetCastByIdAsync(int id);
        Task<IEnumerable<CastModel>> GetAllCastsAsync();
    }
}

