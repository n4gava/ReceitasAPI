using Microsoft.EntityFrameworkCore;
using Receitas.WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Receitas.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() 
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<PassoPreparo> PassosPreparo { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }

    }
}
