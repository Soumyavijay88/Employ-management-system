namespace HRMS.Shared.Domain.Entity
{
    public class Contribution : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ContributionDate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string? ProofUrl { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
