using DatingApp.API.Models;
using DatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

         public DbSet<Value> Values { get; set; }

        public DbSet<AppUser> Users { get; set; }
    }
}