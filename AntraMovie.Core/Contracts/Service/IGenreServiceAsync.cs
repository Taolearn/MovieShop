using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface IGenreServiceAsync
    {
        Task<int> InsertGenreAsync(GenreModel genreModel);
        Task<int> UpdateGenreAsync(GenreModel genreModel);
        Task<int> DeleteGenreAsync(int id);
        Task<GenreModel> GetGenreByIdAsync(int id);
        Task<IEnumerable<GenreModel>> GetAllGenreAsync();
    }
}

