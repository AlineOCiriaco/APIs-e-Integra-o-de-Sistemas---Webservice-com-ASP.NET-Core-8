using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusaoDiversidade.Application.DiversityReport
{
    public class DiversityReportDto
    {
        public string Department { get; set; }
        public int TotalEmployees { get; set; }
        public int Female { get; set; }
        public int Male { get; set; }
        public int Other { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}