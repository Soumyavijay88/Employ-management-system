namespace HRMS.Shared.Domain.Entity
{
    public class OnboardingTask : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Order { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string Category { get; set; } = string.Empty;
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
