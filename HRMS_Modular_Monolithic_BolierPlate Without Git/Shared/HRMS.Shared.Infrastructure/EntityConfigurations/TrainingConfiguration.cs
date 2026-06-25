using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class TrainingConfiguration : IEntityTypeConfiguration<Training>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Training>());
        }

        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("Trainings");
            builder.HasKey(t => t.Id);
            
            builder.Property(t => t.Title).IsRequired().HasMaxLength(200);
            builder.Property(t => t.Description).HasMaxLength(1000);
            builder.Property(t => t.Category).HasMaxLength(100);
            builder.Property(t => t.CourseUrl).HasMaxLength(500);
        }
    }
}
