using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Announcement>());
        }

        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements");
            builder.HasKey(a => a.Id);
            
            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Category).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Priority).HasMaxLength(50);
            builder.Property(a => a.VisibilityScope).HasMaxLength(100);
            builder.Property(a => a.AttachmentUrl).HasMaxLength(500);
            
            builder.HasOne(a => a.Author)
                .WithMany()
                .HasForeignKey(a => a.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
