namespace PatternsFramework.Interfaces
{
    public interface IPatternsFramework<T>
    {
        Task<T> CanRemoveAsync(string uniqueId);
        Task<T> CanSaveAsync(T entity);
        Task<T> GetValidAsync(T entity);
        Task<T> RemoveAsync(string uniqueId);
        Task<T> SaveAsync(T entity);
    }
}