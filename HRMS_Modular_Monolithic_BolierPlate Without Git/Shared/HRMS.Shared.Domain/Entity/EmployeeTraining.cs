namespace HRMS.Shared.Domain.Entity
{
    public class EmployeeTraining : UserBase
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid TrainingId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? CertificateUrl { get; set; }
        
        // Navigation properties
        public Employee? Employee { get; set; }
        public Training? Training { get; set; }
    }
}
