using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Server = (localdb)\MSSQLLocalDB;
            Database = MovieStore;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(connection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region EntitiesThatHaveDataAccessLayer
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        #endregion

        #region TableConnectionHolders
        public DbSet<GenreCustomer> GenresCustomers { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }
        public DbSet<MovieCustomer> MoviesCustomers { get; set; }
        public DbSet<MovieDirector> MoviesDirectors { get; set; }
        #endregion



    }
}
