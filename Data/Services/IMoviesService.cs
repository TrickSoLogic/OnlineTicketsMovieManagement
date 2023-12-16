﻿using OnlineTicketsMovieManagement.Data.Base;
using OnlineTicketsMovieManagement.Data.ViewModels;
using OnlineTicketsMovieManagement.Models;
using System.Threading.Tasks;

namespace OnlineTicketsMovieManagement.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}