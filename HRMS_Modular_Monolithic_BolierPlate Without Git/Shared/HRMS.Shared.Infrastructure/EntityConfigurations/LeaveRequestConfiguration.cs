using HRMS.Core.Postgres.Interfaces;
using HRMS.Shared.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRMS.Shared.Infrastructure.EntityConfigurations
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>, IPostgresEntityConfigurator
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            Configure(modelBuilder.Entity<LeaveRequest>());
        }

        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.ToTable("LeaveRequests");
            builder.HasKey(l => l.Id);
            
            builder.Property(l => l.Reason).IsRequired().HasMaxLength(1000);
            builder.Property(l => l.ApproverComments).HasMaxLength(500);
            
            builder.HasOne(l => l.Employee)
                .WithMany(e => e.LeaveRequests)
                .HasForeignKey(l => l.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasOne(l => l.Approver)
                .WithMany()
                .HasForeignKey(l => l.ApproverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
