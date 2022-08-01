using System;
using AntraMovie.Core.Model;

namespace AntraMovie.Core.Contracts.Service
{
    public interface IMovieServiceAsync
    {
        Task<int> InsertMovieAsync(MovieModel movieModel);
        Task<int> UpdateMovieAsync(MovieModel movieModel);
        Task<int> DeleteMovieAsync(int id);
        Task<MovieModel> GetMovieByIdAsync(int id);
        Task<IEnumerable<MovieModel>> GetAllMovieAsync();
    }
}

