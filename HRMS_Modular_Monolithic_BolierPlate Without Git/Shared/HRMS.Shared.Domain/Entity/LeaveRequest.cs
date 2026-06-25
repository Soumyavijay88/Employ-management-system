using HRMS.Shared.Domain.Enum;

namespace HRMS.Shared.Domain.Entity
{
    public class LeaveRequest : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public string Reason { get; set; } = string.Empty;
        public LeaveStatus Status { get; set; }
        public Guid? ApproverId { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string? ApproverComments { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
        public Employee? Approver { get; set; }
    }
}
