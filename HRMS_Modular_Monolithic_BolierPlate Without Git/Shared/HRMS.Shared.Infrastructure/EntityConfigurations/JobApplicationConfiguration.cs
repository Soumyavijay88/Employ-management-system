using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class JobApplicationConfiguration : IEntityTypeConfiguration<JobApplication>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<JobApplication>());
        }

        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.ToTable("JobApplications");
            builder.HasKey(j => j.Id);
            
            builder.Property(j => j.ApplicantName).IsRequired().HasMaxLength(200);
            builder.Property(j => j.Email).IsRequired().HasMaxLength(200);
            builder.Property(j => j.PhoneNumber).HasMaxLength(20);
            builder.Property(j => j.ResumeUrl).IsRequired().HasMaxLength(500);
            builder.Property(j => j.Status).HasMaxLength(50);
            
            builder.HasOne(j => j.JobPosting)
                .WithMany(jp => jp.Applications)
                .HasForeignKey(j => j.JobPostingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
