using PatternsFramework.Models.Enumerators;

namespace PatternsFramework.Models
{
    public class Result<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public ResultType ResultType { get; set; }
    }
}