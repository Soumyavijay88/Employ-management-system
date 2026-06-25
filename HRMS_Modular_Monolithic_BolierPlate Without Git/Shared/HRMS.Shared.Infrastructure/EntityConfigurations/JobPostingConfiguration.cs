using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class JobPostingConfiguration : IEntityTypeConfiguration<JobPosting>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<JobPosting>());
        }

        public void Configure(EntityTypeBuilder<JobPosting> builder)
        {
            builder.ToTable("JobPostings");
            builder.HasKey(j => j.Id);
            
            builder.Property(j => j.Title).IsRequired().HasMaxLength(200);
            builder.Property(j => j.Description).IsRequired();
            builder.Property(j => j.Requirements).IsRequired();
            builder.Property(j => j.Location).HasMaxLength(100);
            builder.Property(j => j.EmploymentType).HasMaxLength(50);
            builder.Property(j => j.Status).HasMaxLength(50);
            
            builder.HasOne(j => j.Department)
                .WithMany()
                .HasForeignKey(j => j.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
