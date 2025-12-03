using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InclusaoDiversidade.Domain.Entities
{
    public class DiversityReport
    {

        public string ReportId { get; set; }

        public int TotalEmployees { get; set; }
        public int FemaleCount { get; set; }
        public int MaleCount { get; set; }
        public int OtherCount { get; set; }
        public DateTime CreatedAt { get; set; }

        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}