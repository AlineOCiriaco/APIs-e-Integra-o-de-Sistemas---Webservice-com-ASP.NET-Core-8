namespace InclusaoDiversidade.Application.DTO
{
    public class RelatorioDiversidadeDTO
    {
        public string ReportId { get; set; }
        public int TotalEmployees { get; set; }
        public int FemaleCount { get; set; }
        public int MaleCount { get; set; }
        public int OtherCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DepartmentId { get; set; }

    }
}
