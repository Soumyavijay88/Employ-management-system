namespace HRMS.Shared.Domain.Entity
{
    public class PerformanceReview : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ReviewerId { get; set; }
        public DateTime ReviewPeriodStart { get; set; }
        public DateTime ReviewPeriodEnd { get; set; }
        public int Rating { get; set; }
        public string Strengths { get; set; } = string.Empty;
        public string AreasForImprovement { get; set; } = string.Empty;
        public string Comments { get; set; } = string.Empty;
        public DateTime ReviewDate { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
        public Employee? Reviewer { get; set; }
    }
}
