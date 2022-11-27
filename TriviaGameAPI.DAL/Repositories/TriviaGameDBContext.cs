using Microsoft.EntityFrameworkCore;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Repositories
{
    public class TriviaGameDBContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameplayRoom> GameplayRooms { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Question> Question { get; set; }

        public TriviaGameDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TriviaGameDBContext).Assembly);
        }
    }
}
