using InclusaoDiversidade.Application.DiversityReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusaoDiversidade.Application.Services
{
    public class DiversityReportService : IDiversityReportService
    {
        private readonly ApplicationDbContext _context;

        public DiversityReportService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DiversityReportDto> GenerateReportAsync()
        {
            var employees = await _context.Employees.ToListAsync();

            var dto = new DiversityReportDto
            {
                Department = "Todos",
                TotalEmployees = employees.Count,
                Female = employees.Count(x => x.Gender == "F"),
                Male = employees.Count(x => x.Gender == "M"),
                Other = employees.Count(x => x.Gender != "M" && x.Gender != "F"),
                CreatedAt = DateTime.UtcNow
            };

            var entity = new DiversityReport
            {
                ReportId = Guid.NewGuid().ToString(),
                TotalEmployees = dto.TotalEmployees,
                FemaleCount = dto.Female,
                MaleCount = dto.Male,
                OtherCount = dto.Other,
                CreatedAt = dto.CreatedAt,
                DepartmentId = null
            };

            _context.DiversityReports.Add(entity);
            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task<IEnumerable<DiversityReportHistoryDto>> GetHistoryAsync(int page, int pageSize)
        {
            return await _context.DiversityReports
                .OrderByDescending(x => x.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new DiversityReportHistoryDto
                {
                    ReportId = x.ReportId,
                    Department = "Todos",
                    TotalEmployees = x.TotalEmployees,
                    CreatedAt = x.CreatedAt
                })
                .ToListAsync();
        }
    }
}