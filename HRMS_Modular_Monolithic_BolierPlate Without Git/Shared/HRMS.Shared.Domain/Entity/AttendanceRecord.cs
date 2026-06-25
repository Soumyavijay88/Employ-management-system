using HRMS.Shared.Domain.Enum;

namespace HRMS.Shared.Domain.Entity
{
    public class AttendanceRecord : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public AttendanceStatus Status { get; set; }
        public string? Notes { get; set; }
        public decimal? WorkHours { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
