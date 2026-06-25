namespace HRMS.Shared.Domain.Entity
{
    public class Goal : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime TargetDate { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; } = string.Empty;
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
