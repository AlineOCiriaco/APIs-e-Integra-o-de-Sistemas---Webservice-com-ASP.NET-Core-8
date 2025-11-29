namespace InclusaoDiversidade.Domain.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; } 
        public DateTime EnrollmentDate { get; set; } 

        
        public int EmployeeEmployeeId { get; set; } 
        public Employee Employee { get; set; }

        public int TrainingTrainingId { get; set; } 
        public Training Training { get; set; }

        
        public ICollection<Completion> Completions { get; set; }
    }
}