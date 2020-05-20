using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VezhbaIT.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Client> Clients { get; set; }
        public MoviesDbContext() : base("Connection")
        {
        }
        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }
    }
}