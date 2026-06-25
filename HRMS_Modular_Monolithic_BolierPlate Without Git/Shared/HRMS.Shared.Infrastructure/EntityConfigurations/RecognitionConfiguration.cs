using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class RecognitionConfiguration : IEntityTypeConfiguration<Recognition>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<Recognition>());
        }

        public void Configure(EntityTypeBuilder<Recognition> builder)
        {
            builder.ToTable("Recognitions");
            builder.HasKey(r => r.Id);
            
            builder.Property(r => r.Category).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Message).IsRequired().HasMaxLength(1000);
            
            builder.HasOne(r => r.Sender)
                .WithMany(e => e.SentRecognitions)
                .HasForeignKey(r => r.SenderId)
                .OnDelete(DeleteBehavior.Restrict);
                
            builder.HasOne(r => r.Recipient)
                .WithMany(e => e.ReceivedRecognitions)
                .HasForeignKey(r => r.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
