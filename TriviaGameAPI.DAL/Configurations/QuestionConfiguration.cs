using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Configurations
{
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered()
                .HasName("PK_CL_Question_Id");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Text)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(200);

            builder.HasOne(x => x.Category);
        }
    }
}
