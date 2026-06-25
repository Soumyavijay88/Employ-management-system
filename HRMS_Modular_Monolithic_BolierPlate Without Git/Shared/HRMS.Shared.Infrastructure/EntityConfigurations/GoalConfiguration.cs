using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Goal>());
        }

        public void Configure(EntityTypeBuilder<Goal> builder)
        {
            builder.ToTable("Goals");
            builder.HasKey(g => g.Id);
            
            builder.Property(g => g.Title).IsRequired().HasMaxLength(200);
            builder.Property(g => g.Description).HasMaxLength(1000);
            builder.Property(g => g.Status).HasMaxLength(50);
            
            builder.HasOne(g => g.Employee)
                .WithMany(e => e.Goals)
                .HasForeignKey(g => g.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
