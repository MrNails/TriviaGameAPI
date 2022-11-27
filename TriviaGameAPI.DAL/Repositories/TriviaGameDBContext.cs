using Microsoft.EntityFrameworkCore;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Repositories
{
    public class TriviaGameDBContext : DbContext
    {
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<GameplayRoom> GameplayRooms { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Question> Question { get; set; }

        public TriviaGameDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TriviaGameDBContext).Assembly);
        }
    }
}
