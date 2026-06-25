using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class PayrollConfiguration : IEntityTypeConfiguration<Payroll>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Payroll>());
        }

        public void Configure(EntityTypeBuilder<Payroll> builder)
        {
            builder.ToTable("Payrolls");
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Currency).HasMaxLength(3);
            builder.Property(p => p.Status).HasMaxLength(50);
            
            builder.HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
