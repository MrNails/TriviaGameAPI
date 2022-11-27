using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered()
                .HasName("PK_CL_Category_Id");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            builder.HasMany(x => x.Questions);

            builder.HasData(new[] {
                new Category { Id = 1, Name = "Actor" },
                new Category { Id = 2, Name = "Art" },
                new Category { Id = 3, Name = "Animal" },
                new Category { Id = 4, Name = "City" },
                new Category { Id = 5, Name = "Country" },
                new Category { Id = 6, Name = "Clothing" },
                new Category { Id = 7, Name = "Drink" },
                new Category { Id = 8, Name = "Science" },
                new Category { Id = 9, Name = "Sport" },
                new Category { Id = 10, Name = "Vehicle" },
            });
        }
    }
}
