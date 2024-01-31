using OrderModule.Database;
using OrderModule.Entities;
using PatternsFramework.Interfaces;

namespace OrderModule
{
    public class OrderItemPatternsFramework : IPatternsFramework<OrderItem>
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderItemPatternsFramework(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<OrderItem> CanRemoveAsync(string uniqueId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> CanSaveAsync(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetValidAsync(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> RemoveAsync(string uniqueId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> SaveAsync(OrderItem entity)
        {
            throw new NotImplementedException();
        }
    }
}