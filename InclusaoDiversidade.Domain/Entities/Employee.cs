namespace InclusaoDiversidade.Domain.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string Name { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public int TrainingId { get; set; }
        public DateTime? LastNotificationDate { get; set; }

        public int DepartmentDepartmentId { get; set; } 

        
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}