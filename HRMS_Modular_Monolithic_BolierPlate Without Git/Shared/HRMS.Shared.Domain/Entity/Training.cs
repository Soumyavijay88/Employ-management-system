namespace HRMS.Shared.Domain.Entity
{
    public class Training : UserBase
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CourseUrl { get; set; }
        public int DurationHours { get; set; }
        
        // Navigation properties
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; } = new List<EmployeeTraining>();
    }
}
