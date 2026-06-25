namespace HRMS.Shared.Domain.Entity
{
    public class Payroll : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime PayPeriodStart { get; set; }
        public DateTime PayPeriodEnd { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }
        public string Currency { get; set; } = "USD";
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } = string.Empty;
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
