using HRMS.Shared.Domain.Enum;

namespace HRMS.Shared.Domain.Entity
{
    public class Expense : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Currency { get; set; } = "USD";
        public string? ReceiptUrl { get; set; }
        public Status ReimbursementStatus { get; set; }
        public Guid? ApproverId { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string? ApproverComments { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
        public Employee? Approver { get; set; }
    }
}
