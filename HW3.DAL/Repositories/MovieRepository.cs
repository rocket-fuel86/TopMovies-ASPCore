using HW3.DAL.Entities;
using HW3.DAL.Interfaces;
using HW3.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW3.DAL.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private MovieContext db;

        public MovieRepository(MovieContext context)
        {
            this.db = context;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await db.Movies.ToListAsync();
        }

        public async Task<Movie?> Get(int id)
        {
            Movie? movie = await db.Movies.FindAsync(id);
            return movie;
        }

        public async Task<Movie?> Get(string name)
        {
            var movies = await db.Movies.Where(a => a.Title == name).ToListAsync();
            Movie? movie = movies?.FirstOrDefault();
            return movie;
        }

        public async Task Create(Movie movie)
        {
            await db.Movies.AddAsync(movie);
        }

        public void Update(Movie team)
        {
            db.Entry(team).State = EntityState.Modified;
        }

        public async Task Delete(int id)
        {
            Movie? movie = await db.Movies.FindAsync(id);
            if (movie != null)
                db.Movies.Remove(movie);
        }
    }
}
