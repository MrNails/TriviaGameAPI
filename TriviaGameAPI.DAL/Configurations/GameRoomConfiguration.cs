using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Configurations
{
    internal class GameRoomConfiguration : IEntityTypeConfiguration<GameplayRoom>
    {
        public void Configure(EntityTypeBuilder<GameplayRoom> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered()
                .HasName("PK_CL_GameRoom_Id");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasMany(x => x.Players);
        }
    }
}
