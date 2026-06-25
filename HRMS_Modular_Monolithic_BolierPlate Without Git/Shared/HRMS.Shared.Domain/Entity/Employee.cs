using HRMS.Shared.Domain.Enum;

namespace HRMS.Shared.Domain.Entity
{
    public class Employee : UserBase
    {
        public Guid Id { get; set; }
        public string EmployeeId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime JoiningDate { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid DesignationId { get; set; }
        public Guid? ManagerId { get; set; }
        public Guid? ReportingManagerId { get; set; }
        public Role Role { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public string Location { get; set; } = string.Empty;
        public Address? Address { get; set; }
        
        // Navigation properties
        public Department? Department { get; set; }
        public Designation? Designation { get; set; }
        public Employee? Manager { get; set; }
        public Employee? ReportingManager { get; set; }
        public ICollection<Employee> DirectReports { get; set; } = new List<Employee>();
        public ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
        public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        public ICollection<Document> Documents { get; set; } = new List<Document>();
        public ICollection<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();
        public ICollection<Goal> Goals { get; set; } = new List<Goal>();
        public ICollection<Contribution> Contributions { get; set; } = new List<Contribution>();
        public ICollection<EmployeeTraining> EmployeeTrainings { get; set; } = new List<EmployeeTraining>();
        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
        public ICollection<Recognition> SentRecognitions { get; set; } = new List<Recognition>();
        public ICollection<Recognition> ReceivedRecognitions { get; set; } = new List<Recognition>();
        public ICollection<OnboardingTask> OnboardingTasks { get; set; } = new List<OnboardingTask>();
        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
    }
}
