using InclusaoDiversidade.Application.DiversityReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusaoDiversidade.Application.Services
{
    public interface IDiversityReportService
    {
        Task<DiversityReportDto> GenerateReportAsync();
        Task<IEnumerable<DiversityReportHistoryDto>> GetHistoryAsync(int page, int pageSize);
    }
}