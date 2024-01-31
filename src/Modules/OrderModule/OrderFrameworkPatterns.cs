using OrderModule.Database;
using OrderModule.Entities;
using PatternsFramework.Interfaces;

namespace OrderModule
{
    public class OrderPatternsFramework : IPatternsFramework<Order>
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderPatternsFramework(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Order> CanRemoveAsync(string uniqueId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> CanSaveAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetValidAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<Order> RemoveAsync(string uniqueId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> SaveAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}