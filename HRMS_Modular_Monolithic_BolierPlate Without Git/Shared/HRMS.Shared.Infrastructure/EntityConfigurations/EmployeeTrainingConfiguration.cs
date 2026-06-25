using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class EmployeeTrainingConfiguration : IEntityTypeConfiguration<EmployeeTraining>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<EmployeeTraining>());
        }

        public void Configure(EntityTypeBuilder<EmployeeTraining> builder)
        {
            builder.ToTable("EmployeeTrainings");
            builder.HasKey(et => et.Id);
            
            builder.Property(et => et.Status).HasMaxLength(50);
            builder.Property(et => et.CertificateUrl).HasMaxLength(500);
            
            builder.HasOne(et => et.Employee)
                .WithMany(e => e.EmployeeTrainings)
                .HasForeignKey(et => et.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasOne(et => et.Training)
                .WithMany(t => t.EmployeeTrainings)
                .HasForeignKey(et => et.TrainingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
