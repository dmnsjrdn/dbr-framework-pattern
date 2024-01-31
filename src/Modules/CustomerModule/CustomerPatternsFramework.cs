using CustomerModule.Database;
using CustomerModule.Entities;
using PatternsFramework.Interfaces;

namespace CustomerModule;

public class CustomerPatternsFramework : IPatternsFramework<Customer>
{
    private readonly ApplicationDbContext _dbContext;

    public CustomerPatternsFramework(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Customer> CanRemoveAsync(string uniqueId)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> CanSaveAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetValidAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> RemoveAsync(string uniqueId)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> SaveAsync(Customer entity)
    {
        throw new NotImplementedException();
    }
}