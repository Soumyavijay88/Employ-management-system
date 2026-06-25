namespace HRMS.Shared.Domain.Entity
{
    public class Recognition : UserBase
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime RecognitionDate { get; set; }
        public bool IsPublic { get; set; }
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
        
        // Navigation properties
        public Employee? Sender { get; set; }
        public Employee? Recipient { get; set; }
    }
}
