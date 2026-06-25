using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class DesignationConfiguration : IEntityTypeConfiguration<Designation>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Designation>());
        }

        public void Configure(EntityTypeBuilder<Designation> builder)
        {
            builder.ToTable("Designations");
            builder.HasKey(d => d.Id);
            
            builder.Property(d => d.Title).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Level).HasMaxLength(50);
            builder.Property(d => d.Description).HasMaxLength(500);
        }
    }
}
