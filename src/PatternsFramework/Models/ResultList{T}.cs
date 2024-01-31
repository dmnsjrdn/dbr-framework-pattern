using PatternsFramework.Models.Enumerators;

namespace PatternsFramework.Models
{
    public class ResultList<T> : Pagination
    {
        public IEnumerable<T> Data { get; set; }
        public string Message { get; set; }
        public ResultType ResultType { get; set; }
    }
}