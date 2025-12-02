using InclusaoDiversidade.Application.DTO;

namespace InclusaoDiversidade.Application.Services
{
    public interface IDiversidadeReportService
    {
        Task<RelatorioDiversidadeDTO> GerarRelatorioAsync();
        Task<IEnumerable<RelatorioDiversidadeDTO>> ObterHistoricoAsync();
    }
}