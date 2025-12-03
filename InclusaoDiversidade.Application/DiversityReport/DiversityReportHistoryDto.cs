using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DiversityReportHistoryDto
{
    public string ReportId { get; set; }
    public string Department { get; set; }
    public int TotalEmployees { get; set; }
    public DateTime CreatedAt { get; set; }
}
