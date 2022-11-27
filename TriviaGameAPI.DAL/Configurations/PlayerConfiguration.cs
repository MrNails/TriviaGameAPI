using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Configurations
{
    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered(false)
                .HasName("PL_NC_Player_Id");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(x => x.CharacterColor)
                .HasColumnType("varchar")
                .HasMaxLength(9);

            builder.Property(x => x.ConnectionId)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            var players = new Player[100];
            for (int i = 0; i < 100; i++)
            {
                players[i] = new Player
                {
                    Id = i + 1,
                    Name = $"Player{i}",
                    Score = Random.Shared.Next(0, 700),
                    IsGameOrganizer = Random.Shared.Next(0, 100) <= 25,
                    LastGameDate = DateTime.UtcNow.AddDays(-Random.Shared.Next(1, 61)),
                };
            }

            builder.HasData(players);
        }
    }
}
