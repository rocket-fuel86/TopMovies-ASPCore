using HW3.BLL.DTO;
using HW3.BLL.Interfaces;
using HW3.DAL.Entities;
using HW3.DAL.Interfaces;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AutoMapper;

namespace HW3.BLL.Services
{
    public class MovieService : IEntityService<MovieDTO>
    {
        IUnitOfWork Database { get; set; }

        public MovieService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public async Task Create(MovieDTO movieDto)
        {
            var movie = new Movie
            {
                Id = movieDto.Id,
                Title = movieDto.Title,
                Director = movieDto.Director,
                Genre = movieDto.Genre,
                Year = movieDto.Year,
                Poster = movieDto.Poster,
                Description = movieDto.Description,
                Trailer = movieDto.Trailer,
            };

            await Database.Movies.Create(movie);
            await Database.Save();
        }

        public async Task Update(MovieDTO movieDto)
        {
            var movie = new Movie
            {
                Id = movieDto.Id,
                Title = movieDto.Title,
                Director = movieDto.Director,
                Genre = movieDto.Genre,
                Year = movieDto.Year,
                Poster = movieDto.Poster,
                Description = movieDto.Description,
                Trailer = movieDto.Trailer,
            };

            Database.Movies.Update(movie);
            await Database.Save();
        }

        public async Task Delete(int id)
        {
            await Database.Movies.Delete(id);
            await Database.Save();
        }

        public async Task<MovieDTO> Get(int id)
        {
            var movie = await Database.Movies.Get(id);
            if (movie == null)
                throw new ValidationException("Немає такого клуба!");

            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Genre = movie.Genre,
                Year = movie.Year,
                Poster = movie.Poster,
                Description = movie.Description,
                Trailer = movie.Trailer,
            };
        }

        public async Task<IEnumerable<MovieDTO>> GetAll()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<Movie, MovieDTO>(), NullLoggerFactory.Instance);
            return config.CreateMapper()
                         .Map<IEnumerable<MovieDTO>>(await Database.Movies.GetAll());
        }
    }
}
