using HW3.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HW3.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Movie> Movies { get; }
        Task Save();
    }
}
