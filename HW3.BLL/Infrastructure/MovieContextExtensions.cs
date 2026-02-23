using HW3.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW3.BLL.Infrastructure
{
    public static class MovieContextExtensions
    {
        public static void AddMovieContext(this IServiceCollection services, string? connection)
        {
            services.AddDbContext<MovieContext>(options => options.UseSqlServer(connection));
        }
    }
}
