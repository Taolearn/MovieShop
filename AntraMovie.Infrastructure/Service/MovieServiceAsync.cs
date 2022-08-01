using System;
using AntraMovie.Core.Contracts.Repository;
using AntraMovie.Core.Contracts.Service;
using AntraMovie.Core.Model;

namespace AntraMovie.Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {
        IMovieRepositoryAsync movieRepositoryAsync;

        public MovieServiceAsync(IMovieRepositoryAsync _movie)
        {
            movieRepositoryAsync = _movie;
        }

        public Task<int> DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieModel>> GetAllMovieAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovieModel> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertMovieAsync(MovieModel movieModel)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateMovieAsync(MovieModel movieModel)
        {
            throw new NotImplementedException();
        }
    }
}

