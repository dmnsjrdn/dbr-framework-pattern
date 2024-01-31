namespace PatternsFramework.Models
{
    public class Pagination
    {
        public int Take { get; set; } = 0;
        public int Skip { get; set; } = 0;
        public int Total { get; set; } = 0;
        public string SortDirection { get; set; }
        public string SortBy { get; set; }
    }
}