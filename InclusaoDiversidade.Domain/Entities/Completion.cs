namespace InclusaoDiversidade.Domain.Entities
{
    public class Completion
    {
        public int CompletionId { get; set; } 
        public DateTime CompletionDate { get; set; } 
        public string Result { get; set; } = string.Empty; 

        public int EnrollmentEnrollmentId { get; set; } 
        public Enrollment Enrollment { get; set; }
    }
}