namespace InclusaoDiversidade.Domain.Entities
{
    public class Training
    {
        public int TrainingId { get; set; } 
        public string Title { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty; 
        public DateTime DueDate { get; set; } 

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}