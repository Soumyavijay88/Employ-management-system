using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnboardingFeature.Infrastructure
{
    public class OnboardingTaskConfiguration : IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<OnboardingTask>());
        }

        public void Configure(EntityTypeBuilder<OnboardingTask> builder)
        {
            builder.ToTable("OnboardingTasks");
            builder.HasKey(o => o.Id);
            
            builder.Property(o => o.Title).IsRequired().HasMaxLength(200);
            builder.Property(o => o.Description).HasMaxLength(1000);
            builder.Property(o => o.Category).HasMaxLength(100);
            
            builder.HasOne(o => o.Employee)
                .WithMany(e => e.OnboardingTasks)
                .HasForeignKey(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
