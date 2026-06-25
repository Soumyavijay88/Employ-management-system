namespace HRMS.Shared.Domain.Entity
{
    public class Document : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public DateTime? ExpiryDate { get; set; }
        public bool IsVerified { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
    }
}
