namespace HRMS.Shared.Domain.Entity
{
    public class JobApplication : UserBase
    {
        public Guid Id { get; set; }
        public Guid JobPostingId { get; set; }
        public string ApplicantName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ResumeUrl { get; set; } = string.Empty;
        public DateTime AppliedDate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? CoverLetter { get; set; }
        
        // Navigation properties
        public JobPosting? JobPosting { get; set; }
    }
}
