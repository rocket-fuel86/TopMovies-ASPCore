using HW3.DAL.Entities;
using HW3.DAL.Interfaces;
using HW3.DAL.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HW3.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private MovieContext db;
        private MovieRepository movieRepository;
        public EFUnitOfWork(MovieContext context) 
        {
            db = context;
        }
        public IRepository<Movie> Movies
        {
            get
            {
                if (movieRepository == null)
                    movieRepository = new MovieRepository(db);
                return movieRepository;
            }
        }
        public async Task Save()
        {
            await db.SaveChangesAsync();
        }
    }
}
