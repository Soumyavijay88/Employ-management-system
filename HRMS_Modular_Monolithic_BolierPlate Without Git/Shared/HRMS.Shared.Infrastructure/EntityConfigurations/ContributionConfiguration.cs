using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class ContributionConfiguration : IEntityTypeConfiguration<Contribution>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Contribution>());
        }

        public void Configure(EntityTypeBuilder<Contribution> builder)
        {
            builder.ToTable("Contributions");
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Title).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Description).HasMaxLength(1000);
            builder.Property(c => c.Category).HasMaxLength(100);
            builder.Property(c => c.ProofUrl).HasMaxLength(500);
            
            builder.HasOne(c => c.Employee)
                .WithMany(e => e.Contributions)
                .HasForeignKey(c => c.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
