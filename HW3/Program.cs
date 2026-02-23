using HW3.BLL.DTO;
using HW3.BLL.Infrastructure;
using HW3.BLL.Interfaces;
using HW3.BLL.Services;
using HW3.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddMovieContext(connection);
            builder.Services.AddUnitOfWorkService();
            builder.Services.AddTransient<IEntityService<MovieDTO>, MovieService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseStatusCodePagesWithReExecute("/Error/404");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=Index}/{id?}");
            
            app.Run();
        }
    }
}