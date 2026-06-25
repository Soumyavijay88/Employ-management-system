namespace HRMS.Shared.Domain.Entity
{
    public class Designation
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
