using BlazorCrudDotnet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotnet8.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options){ }

        public DbSet<Game> Games { get; set; }
    }
}


