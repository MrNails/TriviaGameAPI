using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGameAPI.DAL.Models;

namespace TriviaGameAPI.DAL.Configurations
{
    internal class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x=> x.Id)
                .IsClustered(false)
                .HasName("PK_NC_Answer_Id");

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Text)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(500);

            builder.HasOne(x => x.Question);
        }
    }
}
