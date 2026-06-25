using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class PerformanceReviewConfiguration : IEntityTypeConfiguration<PerformanceReview>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<PerformanceReview>());
        }

        public void Configure(EntityTypeBuilder<PerformanceReview> builder)
        {
            builder.ToTable("PerformanceReviews");
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Strengths).HasMaxLength(1000);
            builder.Property(p => p.AreasForImprovement).HasMaxLength(1000);
            builder.Property(p => p.Comments).HasMaxLength(1000);
            
            builder.HasOne(p => p.Employee)
                .WithMany(e => e.PerformanceReviews)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasOne(p => p.Reviewer)
                .WithMany()
                .HasForeignKey(p => p.ReviewerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
