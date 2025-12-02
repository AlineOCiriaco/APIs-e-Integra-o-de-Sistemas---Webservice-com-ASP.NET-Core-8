using InclusaoDiversidade.Application.DTO;
using InclusaoDiversidade.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InclusaoDiversidade.Infrastructure.Services
{
    public class DiversidadeReportService : IDiversidadeReportService
    {
        public Task<RelatorioDiversidadeDTO> GerarRelatorioAsync()
        {
            return Task.FromResult(new RelatorioDiversidadeDTO());
        }

        public Task<IEnumerable<RelatorioDiversidadeDTO>> ObterHistoricoAsync()
        {
            IEnumerable<RelatorioDiversidadeDTO> lista = new List<RelatorioDiversidadeDTO>();
            return Task.FromResult(lista);
        }
    }
}