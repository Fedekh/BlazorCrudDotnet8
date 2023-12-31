using BlazorCrudDotnet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotnet8.Data
{
    public class IGameService : DbContext 
    {
        public IGameService(DbContextOptions<IGameService> options) :base(options){ }

        public DbSet<Game> Games { get; set; }
    }
}


