namespace HRMS.Shared.Domain.Entity
{
    public class Announcement : UserBase
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid? AuthorId { get; set; }
        public string VisibilityScope { get; set; } = string.Empty;
        public string? Targeting { get; set; }
        public string? AttachmentUrl { get; set; }
        public int ViewsCount { get; set; }
        public int LikesCount { get; set; }
        public int AcknowledgmentsCount { get; set; }
        public int CommentsCount { get; set; }
        
        // Navigation properties
        public Employee? Author { get; set; }
    }
}
