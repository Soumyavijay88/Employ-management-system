using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Document>());
        }

        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            builder.HasKey(d => d.Id);
            
            builder.Property(d => d.Title).IsRequired().HasMaxLength(200);
            builder.Property(d => d.Description).HasMaxLength(500);
            builder.Property(d => d.Category).IsRequired().HasMaxLength(100);
            builder.Property(d => d.FileUrl).IsRequired().HasMaxLength(500);
            builder.Property(d => d.FileType).HasMaxLength(50);
            
            builder.HasOne(d => d.Employee)
                .WithMany(e => e.Documents)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
