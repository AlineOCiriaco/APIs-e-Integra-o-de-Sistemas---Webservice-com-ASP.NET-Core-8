namespace InclusaoDiversidade.Domain.Entities
{
    public class EmailOutbox
    {
        public int Id { get; set; } 
        public string Recipient { get; set; } = string.Empty; 
        public string Subject { get; set; } = string.Empty; 
        public string Body { get; set; } = string.Empty; 
        public string Status { get; set; } = "Pending"; 
        public DateTime CreatedAt { get; set; } 
        public DateTime? SentAt { get; set; } 
    }
}